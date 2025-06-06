using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Eterea_Parfums_Desktop.Helpers;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario
{
    public partial class Facturar_UC : UserControl
    {



        Cliente clientefactura = new Cliente();
        public string numeroCaja;

        public int IdHistorialCaja { get; set; }

        private StringBuilder codigoBarrasBuffer = new StringBuilder();
        private DateTime ultimaLectura = DateTime.Now;
        private const int TIEMPO_ENTRE_LECTURAS_MS = 100;

        private bool yaMostroAdvertenciaCaja = false;  // lo ponés como campo en la clase


        public Facturar_UC()
        {
            InitializeComponent();

          

            txt_nombre_empleado.Text = Program.logueado.nombre + " " + Program.logueado.apellido;

            this.Load += FormFacturacion_Load;
            txt_scan_factura.Leave += Txt_scan_factura_Leave;
            txt_scan_factura.TextChanged += Txt_scan_factura_TextChanged;
            Factura.CellContentClick += DataGridViewFactura_CellContentClick;
            btn_pago.Visible = false;

           

            combo_forma_pago.SelectedIndexChanged -= combo_forma_pago_SelectedIndexChanged;

            txt_nombre_cliente.Text = "Consumidor Final";
            txt_condicion_iva.Text = "Consumidor Final";

            combo_forma_pago.Items.Clear();
            combo_forma_pago.Items.Add("Efectivo");
            combo_forma_pago.Items.Add("Visa Débito");
            combo_forma_pago.Items.Add("Visa Crédito");
            combo_forma_pago.Items.Add("Mastercard");
            combo_forma_pago.Items.Add("Amex");
            combo_forma_pago.Items.Add("Mercado Pago");
            combo_forma_pago.SelectedIndex = 0;


            combo_descuento.Items.Clear();
            combo_descuento.Items.AddRange(new object[] { 0, 10, 20, 30 });
            combo_descuento.SelectedIndex = 0;

            combo_cuotas.Items.Clear();
            combo_cuotas.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6 });
            combo_cuotas.SelectedIndex = 0;

            //txt_recargo.Hide();

            txt_total.Text = "0,00";
            txt_subtotal.Text = "0,00";
            txt_monto_recargo.Text = "0,00";
            txt_monto_descuento.Text = "0,00";
            txt_iva.Text = "0,00";

            combo_forma_pago.SelectedIndexChanged += combo_forma_pago_SelectedIndexChanged;
            ActualizarDescuentosYCuotas();

            lbl_dniE.Hide();
            txt_scan_factura.Hide();

            this.Cursor = Cursors.Default;
            this.UseWaitCursor = false;

            ActualizarEstadoCaja();

            //Diseño del combo box
            combo_forma_pago.DrawMode = DrawMode.OwnerDrawFixed;
            combo_forma_pago.DrawItem += comboBoxdiseño_DrawItem;
            combo_forma_pago.DropDownStyle = ComboBoxStyle.DropDownList;

            combo_cuotas.DrawMode = DrawMode.OwnerDrawFixed;
            combo_cuotas.DrawItem += comboBoxdiseño_DrawItem;
            combo_cuotas.DropDownStyle = ComboBoxStyle.DropDownList;

            combo_descuento.DrawMode = DrawMode.OwnerDrawFixed;
            combo_descuento.DrawItem += comboBoxdiseño_DrawItem;
            combo_descuento.DropDownStyle = ComboBoxStyle.DropDownList;

            this.VisibleChanged += Facturar_UC_VisibleChanged;
        }

        private void Facturar_UC_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                BarcodeReceiver.OnCodigoLeido -= ProcesarCodigoLeido;
                BarcodeReceiver.OnCodigoLeido += ProcesarCodigoLeido;
            }
            else
            {
                BarcodeReceiver.OnCodigoLeido -= ProcesarCodigoLeido;
            }
        }

        private void ProcesarCodigoLeido(string codigo)
        {
            if (!this.Visible || string.IsNullOrEmpty(numeroCaja) || numeroCaja == "Caja sin asignar")
            {
                if (!yaMostroAdvertenciaCaja)
                {
                    yaMostroAdvertenciaCaja = true;
                    MessageBox.Show("No se puede escanear productos sin una caja abierta.", "Caja no asignada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            if (InvokeRequired)
            {
                Invoke(new Action(() => ProcesarCodigoLeido(codigo)));
                return;
            }

            if (codigo.Length == 12)
            {
                codigo = "0" + codigo;
            }


            txt_scan_factura.Text = codigo;
            ProcesarCodigoBarras(codigo);
            txt_scan_factura.Clear();
        }

    
        public void DesactivarEscaner()
        {
            BarcodeReceiver.OnCodigoLeido -= ProcesarCodigoLeido;
        }

        public void ActivarEscaner()
        {
            BarcodeReceiver.OnCodigoLeido -= ProcesarCodigoLeido;
            BarcodeReceiver.OnCodigoLeido += ProcesarCodigoLeido;
        }



        private void FormFacturacion_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Program.NumeroCajaActual) || Program.NumeroCajaActual == "Caja sin asignar")
            {
                FormNumeroDeCaja formNumero = new FormNumeroDeCaja();
                formNumero.AutoTomarCaja = true;

                formNumero.ConfirmarNumeroCaja += (s, cajaElegida) =>
                {
                    numeroCaja = cajaElegida;
                    IdHistorialCaja = Program.IdHistorialCajaActual;
                    txt_numero_caja.Text = numeroCaja;
                    ActualizarEstadoCaja();


                    // 👉 Reiniciamos el flag aquí
                    yaMostroAdvertenciaCaja = false;


                    // 🔥 ACTIVAR EL ESCANER AQUÍ EXPLÍCITAMENTE
                    BarcodeReceiver.OnCodigoLeido -= ProcesarCodigoLeido;
                    BarcodeReceiver.OnCodigoLeido += ProcesarCodigoLeido;
                };

                ModalHelper.MostrarModalConFondoOscuro(formNumero);
            }
            else
            {
                numeroCaja = Program.NumeroCajaActual;
                IdHistorialCaja = Program.IdHistorialCajaActual;
                txt_numero_caja.Text = numeroCaja;
            }


            txt_numero_factura.Text = Num_factura_máximo();
            txt_scan_factura.Focus();
            ActualizarEstadoCaja();
        }


        private string Num_factura_máximo()
        {
            int puntoDeVenta = Program.sucursal;
            string puntoDeVentaString = puntoDeVenta.ToString("D4");
            string numeroDeFacturaString = FacturaControlador.ObtenerProximoNumFactura(tipo_de_factura(), puntoDeVentaString);
            txt_numero_factura.Text = numeroDeFacturaString;
            return numeroDeFacturaString;
        }

        private void ProcesarCodigoBarras(string codigo)
        {
            if (string.IsNullOrEmpty(codigo)) return;

            Perfume perfume = PerfumeControlador.getByCodigo(codigo);

            if (perfume == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Ocultas la primera columna de la tabla (es una columna de seleccion de fila)
            Factura.RowHeadersVisible = false;

            foreach (DataGridViewRow fila in Factura.Rows)
            {
                if (fila.Cells[0].Value.ToString() == perfume.id.ToString()) // Columna ID
                {
                    if (int.TryParse(fila.Cells[1].Value.ToString(), out int cantidadActual))
                    {
                        fila.Cells[1].Value = cantidadActual + 1;
                        PerfumeEnPromoControlador promoController = new PerfumeEnPromoControlador();
                        int descuentoPorcentaje = promoController.obtenerMayorDescuentoPorPerfume(perfume.id) ?? 0; //CAMBIE ALGO ACAAAAAA MAXI
                        decimal precioUnitario = Convert.ToDecimal(perfume.precio_en_pesos);
                        decimal descuentoMonto = ((precioUnitario * descuentoPorcentaje) / 100);
                        fila.Cells[6].Value = descuentoMonto;
                        //facturacionForm.GetFacturaDataGrid().Rows[rowIndex].Cells["Tot"].Value = perfume.precio_en_pesos.ToString();
                        fila.Cells[7].Value = (cantidadActual + 1) * perfume.precio_en_pesos;
                        descuentoUnitario();
                        ActualizarTotales();
                    }
                    return;
                }
            }

            Factura.CellPainting += Factura_CellPainting;

            int rowIndex = Factura.Rows.Add(perfume.id, 1, "", "", perfume.nombre, perfume.precio_en_pesos, "", "", ""); ;

            // Asignar botones a las celdas de la nueva fila
            Factura.Rows[rowIndex].Cells[2] = new DataGridViewButtonCell() { Value = "➕" };
            Factura.Rows[rowIndex].Cells[3] = new DataGridViewButtonCell() { Value = "➖" };
            Factura.Rows[rowIndex].Cells[8] = new DataGridViewButtonCell() { Value = "Eliminar" };// "🗑" 

            descuentoUnitario();
            ActualizarTotales();
        }

        private void Txt_scan_factura_Leave(object sender, EventArgs e)
        {
            txt_scan_factura.Focus(); // Si pierde el foco, volver a asignárselo automáticamente
        }

        private void Txt_scan_factura_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            CajaManager.IntentarAbrirCajaDesdeBoton(this, (numeroCajaAsignada) =>
            {
                numeroCaja = numeroCajaAsignada;
                IdHistorialCaja = Program.IdHistorialCajaActual;
                txt_numero_caja.Text = numeroCaja;
                txt_estadoCaja.Text = "Abierta";
                txt_estadoCaja.ForeColor = Color.Green;
                ReiniciarFormulario();
            });



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CajaManager.HayCajaAsignada())
            {
                MessageBox.Show("No hay ninguna caja en uso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Cerrar la caja correctamente y registrar en la base
            CajaManager.CerrarCaja();

            // Mostrar mensaje de confirmación
            MessageBox.Show("Caja cerrada correctamente.", "Cierre de Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Actualizar interfaz
            txt_numero_caja.Text = "Caja no asignada";
            txt_estadoCaja.Text = "Cerrada";
            txt_estadoCaja.ForeColor = Color.Red;

            // Reset variables locales del UC también
            numeroCaja = "Caja sin asignar";
            IdHistorialCaja = 0;

            ReiniciarFormulario();

            //Limpiar consumidor y num factura
            txt_nombre_cliente.Text = "";
            txt_condicion_iva.Text = "";
            txt_numero_factura.Text = "";

            // Limpiar perfumes de la factura si hay alguno cargado
            if (Factura.Rows.Count > 0)
            {
                Factura.Rows.Clear();
            }




        }



        private void ActualizarEstadoCaja()
        {
            string numero = Program.NumeroCajaActual;


            if (!string.IsNullOrEmpty(numero) && numero != "Caja sin asignar")
            {
                txt_estadoCaja.Text = "Abierta";
                txt_estadoCaja.ForeColor = Color.Green;
            }
            else
            {
                txt_estadoCaja.Text = "Cerrada";
                txt_estadoCaja.ForeColor = Color.Red;
            }
        }

        private void MostrarCajaSinAsignar()
        {
            numeroCaja = null;

            txt_numero_caja.Text = "Caja sin asignar";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string numero = Program.NumeroCajaActual;


            if (numero != null && numero != "Caja sin asignar")
            {
                // Si hay caja asignada
                if (string.IsNullOrWhiteSpace(txt_dni.Text))
                {
                    MessageBox.Show("Ingrese un número de DNI o CUIT antes de buscar un cliente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_dni.Text = "";
                    return;
                }
                // Validar la longitud del DNI
                if (txt_dni.Text.Length != 8 && txt_dni.Text.Length != 11)
                {
                    MessageBox.Show("El número ingresado debe tener 8 u 11 dígitos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_dni.Text = "";
                    return;
                }
                if (!txt_dni.Text.All(char.IsDigit))
                {
                    MessageBox.Show("El DNI o CUIT solo puede contener números, sin guiones.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_dni.Text = "";
                    return;
                }


                long dni = long.Parse(txt_dni.Text);
                Cliente cliente = ClienteControlador.obtenerPorDni(dni);
                if (cliente != null)
                {
                    clientefactura = cliente;
                    //}
                    //if (cliente != null)
                    //{
                    // Si se encuentra el cliente, llenar los campos en el formulario actual
                    txt_nombre_cliente.Text = cliente.nombre + " " + cliente.apellido;
                    txt_condicion_iva.Text = cliente.condicion_frente_al_iva;
                    txt_email.Text = cliente.e_mail;

                }
                else
                {
                    long dniIngresado = long.Parse(txt_dni.Text);
                    // Si no se encuentra el cliente, abrir el formulario para agregar un nuevo cliente
                    FormCrearClienteFactura formCrearClienteFactura = new FormCrearClienteFactura(dni);


                    // ✅ Mostrar con fondo oscuro sin preocuparte por el form padre
                    DialogResult dr = ModalHelper.MostrarModalConFondoOscuro(formCrearClienteFactura);



                    // Luego de cerrar el formulario de clientes, verifica si se creó un nuevo cliente
                    Cliente nuevoCliente = ClienteControlador.obtenerPorDni(dniIngresado);
                    if (nuevoCliente != null)
                    {
                        // Asigna los datos del nuevo cliente al formulario actual
                        txt_nombre_cliente.Text = nuevoCliente.nombre + " " + nuevoCliente.apellido;
                        txt_condicion_iva.Text = nuevoCliente.condicion_frente_al_iva;
                        txt_email.Text = nuevoCliente.e_mail;
                        
                    }
                }


                Num_factura_máximo();
                ActualizarTotales();
            }
            else
            {
                // No hay caja asignada, mostrar FormNumeroDeCaja para elegirla
                MessageBox.Show("Debes ingresar un número de caja.\n Haz click en 'Abrir Caja' ", "Número de Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txt_dni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // evita el sonido 'ding'
                btn_buscar.PerformClick(); // llama al botón como si hicieras clic
            }
        }



        private void btn_consultas_Click(object sender, EventArgs e)
        {
            string numero = Program.NumeroCajaActual;

            if (numero != null && numero != "Caja sin asignar")
            {
                FormConsultasPerfumeEmpleado consultasPerfumeEmpleado = new FormConsultasPerfumeEmpleado(this);
                ModalHelper.MostrarModalConFondoOscuro(consultasPerfumeEmpleado);


            }
            else
            {
                // No hay caja asignada, mostrar FormNumeroDeCaja para elegirla
                MessageBox.Show("Debes ingresar un número de caja.\n Haz click en 'Abrir Caja' ", "Número de Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void DataGridViewFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 8)
            {
                if (Factura.Rows.Count > 0 && e.RowIndex < Factura.Rows.Count)
                {
                    Factura.Rows.RemoveAt(e.RowIndex);
                    ActualizarTotales();
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                int cant = int.Parse(Factura.Rows[e.RowIndex].Cells[1].Value.ToString());
                Factura.Rows[e.RowIndex].Cells[1].Value = cant + 1;

                int rowIndex = e.RowIndex;

                int valorMultiplicador = Convert.ToInt32(Factura.Rows[rowIndex].Cells[1].Value);
                double precio = Convert.ToDouble(Factura.Rows[rowIndex].Cells[5].Value);


                Factura.Rows[e.RowIndex].Cells[7].Value = (precio * valorMultiplicador).ToString();
                descuentoUnitario();
                ActualizarTotales();

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                int cant = int.Parse(Factura.Rows[e.RowIndex].Cells[1].Value.ToString());
                if (int.Parse(Factura.Rows[e.RowIndex].Cells[1].Value.ToString()) > 1)
                {
                    Factura.Rows[e.RowIndex].Cells[1].Value = cant - 1;

                    int rowIndex = e.RowIndex;

                    int valorMultiplicador = Convert.ToInt32(Factura.Rows[rowIndex].Cells[1].Value);
                    double precio = Convert.ToDouble(Factura.Rows[rowIndex].Cells[5].Value);

                    Factura.Rows[e.RowIndex].Cells[7].Value = (precio * valorMultiplicador).ToString();
                    descuentoUnitario();
                    ActualizarTotales();

                }
                else if (Factura.Rows.Count > 0 && e.RowIndex < Factura.Rows.Count)
                {
                    Factura.Rows.RemoveAt(e.RowIndex);
                    descuentoUnitario();
                    ActualizarTotales();

                }

            }
        }

        public void descuentoUnitario()
        {
            DataGridView dgv = this.GetFacturaDataGrid();
            PerfumeEnPromoControlador promoController = new PerfumeEnPromoControlador();
            int descuentoPorcentaje = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["Nombre_Perfume"].Value != null) // Verifica que la fila no esté vacía
                {
                    int perfumeId = Convert.ToInt32(row.Cells[0].Value); // ID del perfume
                    int descuentoUnitario = 2;
                    decimal descuentoMonto = 0;
                    decimal totalConDescuento = 0;
                    // Obtener precio unitario
                    decimal precioUnitario = Convert.ToDecimal(row.Cells["Precio_Unitario"].Value);

                    if (row.Cells["Cantidad"].Value != null && int.TryParse(row.Cells["Cantidad"].Value.ToString(), out int cantidad))
                    {
                        if (cantidad % 2 == 0)
                        {
                            descuentoUnitario = 0; //Cambiamos el valor para que no se aplique el descuento unitario porque la cantidad es par

                            // Obtener el descuento del perfume (en porcentaje)
                            descuentoPorcentaje = promoController.obtenerMayorDescuentoPorPerfume(perfumeId) ?? 0; // CAMBIAR METODO TIENE QUE SER MAYOR A 20%

                            if (descuentoPorcentaje > 20)
                            {
                                Console.WriteLine($"Perfume ID: {perfumeId}, Descuento Porcentaje Obtenido: {descuentoPorcentaje}%");


                                // Obtener cantidad
                                cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                                // Calcular el monto de descuento
                                descuentoMonto = ((precioUnitario * descuentoPorcentaje) / 100) * cantidad;

                                // Mostrar el monto de descuento en la celda "Descuento" (valor nominal)
                                row.Cells["Descuento"].Value = descuentoMonto;

                                // Calcular el total con descuento
                                totalConDescuento = ((precioUnitario * cantidad) - descuentoMonto);

                                // Actualizar el total en el DataGridView
                                row.Cells["Tot"].Value = totalConDescuento;

                                // Mostrar en consola para depuración
                                Console.WriteLine($"Perfume ID: {perfumeId}, Descuento Aplicado: {descuentoMonto} (Monto), Total con Descuento: {totalConDescuento}");
                            }
                            else
                            {
                                descuentoUnitario = 2;
                            }
                        }
                        else
                        {
                            // Obtener el descuento del perfume (en porcentaje) solo si es mayor a 20%
                            descuentoPorcentaje = promoController.obtenerMayorDescuentoPorPerfume(perfumeId) ?? 0;

                            // Solo aplicar el descuento si es mayor a 20%
                            if (descuentoPorcentaje > 20)
                            {
                                Console.WriteLine($"Perfume ID: {perfumeId}, Descuento Porcentaje Obtenido: {descuentoPorcentaje}%");

                                // Obtener cantidad
                                cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                                // Verificar si la cantidad es mayor que 1 antes de aplicar descuento
                                if (cantidad > 1)
                                {
                                    // Calcular cuántas veces se aplicará el descuento (por cada par de unidades)
                                    int cantidadDescuentos = cantidad / 2;  // Dividir entre 2 para saber cuántos pares de unidades hay

                                    cantidadDescuentos = cantidadDescuentos * 2;  // multiplicar por 2 para saber cuantos descuentos aplicar

                                    // Calcular el monto de descuento por cada par de unidades
                                    decimal descuentoMontoPorPar = (precioUnitario * descuentoPorcentaje) / 100;

                                    // Calcular el descuento total
                                    descuentoMonto = descuentoMontoPorPar * cantidadDescuentos;
                                    Console.WriteLine($"descuentoMonto : {descuentoMonto}, cantidadDescuentos: {cantidadDescuentos} , descuentoMontoPorPar: {descuentoMontoPorPar}");

                                    // Mostrar el monto de descuento en la celda "Descuento" (valor nominal)
                                    row.Cells["Descuento"].Value = descuentoMonto;

                                    // Calcular el total con descuento
                                    totalConDescuento = ((precioUnitario * cantidad) - descuentoMonto);

                                    // Actualizar el total en el DataGridView
                                    row.Cells["Tot"].Value = totalConDescuento;

                                    descuentoUnitario = 1; //Se utiliza para verificar si se debe aplicar algun descuento unitario ya que la cantidad es impar y mayor a 3

                                    // Mostrar en consola para depuración
                                    Console.WriteLine($"Perfume ID: {perfumeId}, Descuento Aplicado: {descuentoMonto} (Monto), Total con Descuento: {totalConDescuento}");
                                }

                            }
                            if (descuentoUnitario == 1) //Descuento del 10% cuando es impar mayor a 1
                            {
                                // Obtener el descuento del perfume (en porcentaje)
                                descuentoPorcentaje = promoController.obtenerPromocionPorPerfumeConDescuento10(perfumeId) ?? 0;


                                Console.WriteLine($"Perfume ID: {perfumeId}, Descuento Porcentaje Obtenido: {descuentoPorcentaje}%");


                                // Obtener cantidad
                                cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                                // Calcular el monto de descuento
                                descuentoMonto += (((precioUnitario * descuentoPorcentaje) / 100));

                                // Mostrar el monto de descuento en la celda "Descuento" (valor nominal)
                                row.Cells["Descuento"].Value = descuentoMonto;

                                // Calcular el total con descuento
                                totalConDescuento = ((precioUnitario * cantidad) - descuentoMonto);

                                // Actualizar el total en el DataGridView
                                row.Cells["Tot"].Value = totalConDescuento;

                                // Mostrar en consola para depuración
                                Console.WriteLine($"Perfume ID: {perfumeId}, Descuento Aplicado: {descuentoMonto} (Monto), Total con Descuento: {totalConDescuento}");
                            }
                            if (descuentoUnitario == 2) //Descuento cuando no tiene descuento mayor a 20%
                            {
                                // Obtener el descuento del perfume (en porcentaje)
                                descuentoPorcentaje = promoController.obtenerPromocionPorPerfumeConDescuento10(perfumeId) ?? 0;


                                Console.WriteLine($"Perfume ID: {perfumeId}, Descuento Porcentaje Obtenido: {descuentoPorcentaje}%");

                                // Obtener cantidad
                                cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                                // Calcular el monto de descuento
                                descuentoMonto = (((precioUnitario * descuentoPorcentaje) / 100) * cantidad);

                                // Mostrar el monto de descuento en la celda "Descuento" (valor nominal)
                                row.Cells["Descuento"].Value = descuentoMonto;

                                // Calcular el total con descuento
                                totalConDescuento = ((precioUnitario * cantidad) - descuentoMonto);

                                // Actualizar el total en el DataGridView
                                row.Cells["Tot"].Value = totalConDescuento;

                                // Mostrar en consola para depuración
                                Console.WriteLine($"Perfume ID: {perfumeId}, Descuento Aplicado: {descuentoMonto} (Monto), Total con Descuento: {totalConDescuento}");
                            }
                        }

                    }
                }
            }
        }

        private void totalFactura()
        {
            double sumaPrecios = 0; // Usar decimal para los precios

            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow fila in Factura.Rows)
            {
                if (fila.Cells[4].Value != null)
                {
                    double precioFila = 0;
                    // Comprobar si el valor se puede convertir a decimal
                    if (double.TryParse(fila.Cells[7].Value.ToString(), out precioFila))
                    {
                        sumaPrecios += precioFila; // Sumar el valor al total
                    }
                }
            }
            // Mostrar la suma en un TextBox
            txt_subtotal.Text = sumaPrecios.ToString("N2");
        }

        private void CalcularImporteRecargo(float recargo, float subtotal)
        {
            txt_monto_recargo.Text = (subtotal * recargo / 100).ToString("N2");
        }

        private void desc()
        {
            string descuentoStr = combo_descuento.SelectedItem.ToString();

            if (int.TryParse(descuentoStr, out int descuento))
            {
                txt_desc.Text = descuento.ToString(); // Mostrar el descuento en txt_desc

                if (float.TryParse(txt_subtotal.Text, out float subtotal))
                {
                    CalcularDescuento(descuento, subtotal);
                }
                else
                {
                    // Si no se puede convertir a float, simplemente establecer el monto de descuento en cero
                    txt_monto_descuento.Text = "0,00";
                }
            }
            else
            {
                MessageBox.Show("El valor de descuento no es válido.");
                // Puedes manejar este caso de acuerdo a tus necesidades
            }
        }



        private void CalcularDescuento(int desc, float subtotal)
        {
            if (subtotal > 0)
            {
                txt_monto_descuento.Text = (desc * subtotal / 100).ToString("N2");
            }
            else
            {
                txt_monto_descuento.Text = "0,00";
            }
        }

        private void sumaFinal(float subtotal, float recargo, float descuento)
        {
            string condicionCliente = txt_condicion_iva.Text.Trim();

            // Verificar si el cliente es Responsable Monotributo
            if (condicionCliente.Contains("Monotributista") || condicionCliente.Contains("Responsable Inscripto"))
            {
                txt_subtotal.Text = (subtotal + recargo - descuento - CalcularIVA(subtotal, recargo, descuento)).ToString("N2");
                txt_total.Text = (subtotal + recargo - descuento).ToString("N2");
                txt_iva.Text = CalcularIVA(subtotal, recargo, descuento).ToString("N2");
            }
            else
            {
                txt_total.Text = (subtotal + recargo - descuento).ToString("N2");
            }
        }



        public void ActualizarTotales()
        {
            totalFactura();
            desc();
            float subtotal, recargo, descuento;
            if (!float.TryParse(txt_subtotal.Text, out subtotal)) subtotal = 0;
            if (!float.TryParse(txt_monto_recargo.Text, out recargo)) recargo = 0;
            if (!float.TryParse(txt_monto_descuento.Text, out descuento)) descuento = 0;
            sumaFinal(subtotal, recargo, descuento);
        }


        public DataGridView GetFacturaDataGrid()
        {
            //Ocultas la primera columna de la tabla (es una columna de seleccion de fila)
            Factura.RowHeadersVisible = false;

            Factura.CellPainting += Factura_CellPainting;

            return Factura;
        }



        private float CalcularIVA(float subtotal, float recargo, float descuento)
        {
            // Calcular el total base (subtotal + recargo - descuento)
            float totalBase = subtotal + recargo - descuento;

            // Calcular el IVA (21% del total base)
            float iva = totalBase * 0.21f;

            // Actualizar el monto del IVA en el txt_iva
            return iva;
            //txt_iva.Text = iva.ToString("0.00"); // Formato de 2 decimales
        }

        private void ActualizarDescuentosYCuotas()
        {
            string formaPago = combo_forma_pago.SelectedItem.ToString();

            if (formaPago == "Efectivo")
            {
                txt_desc.Text = "10";
                combo_descuento.SelectedIndex = 1; // 10%
                combo_cuotas.SelectedIndex = 0; // 1 cuota
                combo_cuotas.Enabled = false;
            }
            else if (formaPago == "Mercado Pago")
            {
                txt_desc.Text = "0";
                combo_descuento.SelectedIndex = 0; // 0%
                combo_cuotas.SelectedIndex = 0; // 1 cuota
                combo_cuotas.Enabled = false;
            }
            else // tarjeta
            {

                txt_desc.Text = "0";
                combo_descuento.SelectedIndex = 0; // 0%
                combo_cuotas.Enabled = true;
            }
        }

        // Método para calcular el recargo según las cuotas seleccionadas
        private void CalcularRecargo()
        {
            if (combo_cuotas.SelectedItem != null)
            {
                int cuotas = Convert.ToInt32(combo_cuotas.SelectedItem);
                float recargo = (cuotas - 1) * 5; // 5% de recargo por cada cuota extra
                txt_rec.Text = recargo.ToString();
                // Obtener el subtotal desde el textbox
                float subtotal;
                if (float.TryParse(txt_subtotal.Text, out subtotal))
                {
                    CalcularImporteRecargo(subtotal, recargo);
                }
                else
                {
                    MessageBox.Show("El subtotal no es un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string tipo_de_factura()
        {
            String cond_frente_al_iva = txt_condicion_iva.Text;
            String tipo_De_factura = "";
            if (cond_frente_al_iva == "Responsable Inscripto" || cond_frente_al_iva == "Monotributista")
            {
               tipo_De_factura = "A";
            }
            else
            {
               tipo_De_factura = "B";
            }
            return tipo_De_factura;
        }
        private void combo_forma_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDescuentosYCuotas();
            ActualizarTotales();
            if (combo_forma_pago.SelectedItem.ToString() != "Efectivo")
            {
                btn_imprimir.Visible = false;
                btn_pago.Visible = true;
            }
            else
            {
                btn_imprimir.Visible = true;
                btn_pago.Visible = false;
            }
        }

        private void btn_pago_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pago realizado exitosamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btn_imprimir.Visible = true;
            btn_pago.Visible = false;
        }

        private void combo_cuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularRecargo();
            ActualizarTotales();
        }

        private void combo_descuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_descuento.SelectedItem != null && int.TryParse(combo_descuento.SelectedItem.ToString(), out int descuento))
            {
                txt_desc.Text = descuento.ToString(); // Establece el valor en txt_desc
            }
            else
            {
                // Si el valor seleccionado no es un número entero, establece el texto en 0
                txt_desc.Text = "0";
            }
            ActualizarTotales();
        }
 

        private void CrearFactura()
        {
            try
            {
                Empleado empleadoAFacturar = new Empleado();

                // Obtener los valores de los controles del formulario

                int id = FacturaControlador.ObtenerProximoIdFactura(); 
                DateTime fecha = DateTime.Now;
                int sucursalId = Program.sucursal;
                int vendedorId = Program.logueado.id;
                int clienteId = clientefactura.id;
                if (clienteId == 0)
                {
                    clienteId = 1;
                }
                string formaDePago = combo_forma_pago.SelectedItem.ToString();
                double precioTotal = double.Parse(txt_total.Text);
                double recargoTarjeta = double.Parse(txt_monto_recargo.Text);
                double descuento = double.Parse(txt_monto_descuento.Text);
                int numeroDeCaja = int.Parse(txt_numero_caja.Text);
                string tipoConsumidor = clientefactura.condicion_frente_al_iva;
                if (string.IsNullOrEmpty(tipoConsumidor))
                {
                    tipoConsumidor = "Consumidor Final";
                }
                string origen = "Local";
                string facturaPdf = "";
                string numFactura = txt_numero_factura.Text;
                string tipoDeFactura = tipo_de_factura();


                /*MessageBox.Show($"numFactura: {numFactura}\n" +
                $"fecha: {fecha}\n" +
                $"sucursalId: {sucursalId}\n" +
                $"vendedorId: {vendedorId}\n" +
                $"clienteId: {clienteId}\n" +
                $"formaDePago: {formaDePago}\n" +
                $"precioTotal: {precioTotal}\n" +
                $"recargoTarjeta: {recargoTarjeta}\n" +
                $"descuento: {descuento}\n" +
                $"numeroDeCaja: {numeroDeCaja}\n" +
                $"tipoConsumidor: {tipoConsumidor}\n" +
                $"origen: {origen}\n" +
                $"facturaPdf: {facturaPdf}");*/


                // Llamar al método crearFactura desde FacturaControlador
                bool exito = FacturaControlador.crearFactura(id,fecha,sucursalId,vendedorId,clienteId,
            formaDePago,precioTotal,recargoTarjeta,descuento,numeroDeCaja,tipoConsumidor,origen,facturaPdf,numFactura,tipoDeFactura);

                if (exito)
                {
                    MessageBox.Show("Factura creada exitosamente.");

                }
                else
                {
                    MessageBox.Show("Hubo un problema al crear la factura.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la factura: " + ex.Message);
            }
        }

        private void CrearDetalleFactura()
        {
            try
            {
                // Verificar si numFactura es un número entero válido
                int numFactura = 0;
                if (!int.TryParse(txt_numero_factura.Text, out numFactura))
                {
                    MessageBox.Show("El número de factura no es válido.");
                    return;
                }
                PerfumeEnPromoControlador promoController = new PerfumeEnPromoControlador();
                // Recorrer las filas del DataGridView
                foreach (DataGridViewRow row in Factura.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // Verificar si perfume_id es un número entero válido
                        int perfume_id = 0;
                        if (!int.TryParse(row.Cells["Id_Perfume"].Value.ToString(), out perfume_id))
                        {
                            MessageBox.Show($"El ID del perfume en la fila no es válido.");
                            return;
                        }

                        // Verificar si cantidad es un número entero válido
                        int cantidad = 0;
                        if (!int.TryParse(row.Cells["cantidad"].Value.ToString(), out cantidad) || cantidad <= 0)
                        {
                            MessageBox.Show($"La cantidad en la fila del perfume ID {perfume_id} no es un número válido o es menor o igual a cero.");
                            return;
                        }

                        // Verificar si el precio_unitario es un valor float válido
                        float precio_unitario = 0f;
                        if (!float.TryParse(row.Cells["precio_unitario"].Value.ToString(), out precio_unitario) || precio_unitario <= 0)
                        {
                            MessageBox.Show($"El precio unitario en la fila del perfume ID {perfume_id} no es un número válido o es menor o igual a cero.");
                            return;
                        }
                        int? promocion_id = promoController.obtenerPromocionIdPorPerfume(perfume_id);
                        int? promocion_id10 = promoController.obtenerPromocionIdPorPerfumeConDescuento10(perfume_id);

                        if (cantidad > 1 && promocion_id != null)
                        {
                            //MessageBox.Show($"PromocionID: {promocion_id}");
                        }
                        else if (cantidad == 1 && promocion_id10 != null)
                        {
                            promocion_id = promoController.obtenerPromocionIdPorPerfumeConDescuento10(perfume_id);
                            //MessageBox.Show($"PromocionID: {promocion_id}");
                        }
                        else
                        {
                            promocion_id = 1;
                           // MessageBox.Show($"PromocionID: {promocion_id}");
                        }

                        int id_factura = FacturaControlador.ObtenerMaxIdFactura();
                        //MessageBox.Show("Numero de factura:" + id_factura);

                        //MessageBox.Show($"Enviando datos2: NumFactura: {id_factura}, PerfumeID: {perfume_id}, Cantidad: {cantidad}, PrecioUnitario: {precio_unitario}, PromocionID: {promocion_id}");

                        bool exito = DetalleFacturaControlador.crearDetalleFactura(id_factura, perfume_id, cantidad, precio_unitario, promocion_id);

                        if (!exito)
                        {
                            MessageBox.Show($"Error al agregar el perfume ID {perfume_id} al detalle de la factura.");
                            return;
                        }

                        int sucursalId = Program.sucursal;
                        StockControlador.updateStock(perfume_id, sucursalId, -cantidad);
                        //MessageBox.Show($"Actualizando stock de perfume {perfume_id} en sucursal {sucursalId} con cantidad {-cantidad}");

                    }
                }

                //MessageBox.Show("Detalle de factura creado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el detalle de la factura: " + ex.Message);
            }
        }




        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            string numero = Program.NumeroCajaActual;

            if (Factura.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un artículo para facturar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

            

            if (numero != null && numero != "Caja sin asignar")
            {
                // Si hay caja asignada     
                SaveFileDialog guardarFactura = new SaveFileDialog();
                guardarFactura.FileName = DateTime.Now.ToString("ddMMyyyyHHss") + ".pdf";
                guardarFactura.Filter = "Archivos PDF (*.pdf)|*.pdf"; // Filtro para archivos PDF
                guardarFactura.DefaultExt = "pdf"; // Extensión por defecto
                guardarFactura.AddExtension = true; // Agrega la extensión si el usuario no la pone
                string filePath = guardarFactura.FileName;

                string condicionCliente = txt_condicion_iva.Text.Trim();
                    MessageBox.Show("Condicion cliente: " + condicionCliente);
                    string PaginaHTML_Texto = "";

                    // Verificar si el cliente es Responsable Monotributo
                    // CREACION DE PDF DE LA FACTURA B
                    if (condicionCliente == "Consumidor Final" || condicionCliente == "Exento")
                {
                    PaginaHTML_Texto = Properties.Resources.PlantillaFactura.ToString();

                    string dni = txt_dni.Text;
                    string localidad = "Sin localidad";
                    string domicilio = "Sin calle";
                    string numeracion_calle = "Sin numeración";
                    string domicilioEntero = "Sin domicilio";

                    if (string.IsNullOrWhiteSpace(dni))
                    {
                        dni = "Sin DNI";
                    }
                    else
                    {
                        long dniNumerico;
                        localidad = "Sin localidad";
                        domicilio = "Sin calle";
                        numeracion_calle = "Sin numeración";
                        if (!long.TryParse(dni, out dniNumerico))
                        {
                            MessageBox.Show("El DNI ingresado no es válido.");
                            return;
                        }
                        dniNumerico = long.Parse(dni);
                        Cliente cliente = new Cliente();
                        cliente = ClienteControlador.obtenerPorDni(dniNumerico);
                        if (cliente.localidad_id != null)
                        {
                            localidad = cliente.localidad_id.nombre;
                        }

                        if (cliente.calle_id != null)
                        {
                            domicilio = cliente.calle_id.nombre;
                        }

                        if (cliente.numeracion_calle != null)
                        {
                            numeracion_calle = cliente.numeracion_calle.ToString();
                        }
                        domicilioEntero = domicilio + " " + numeracion_calle;
                    }
                    

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txt_nombre_cliente.Text);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", dni);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NUMEROFACTURA", txt_numero_factura.Text);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CONDIVA", txt_condicion_iva.Text);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOMICILIO", domicilioEntero);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@LOCALIDAD", localidad);


                        string filas = string.Empty;
                    decimal total = 0;
                    foreach (DataGridViewRow row in Factura.Rows)
                    {
                        filas += "<tr>";
                        filas += "<td>" + row.Cells["Nombre_Perfume"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Precio_Unitario"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Descuento"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Tot"].Value.ToString() + "</td>";
                        filas += "</tr>";
                        total += decimal.Parse(row.Cells["Tot"].Value.ToString());
                    }


                        double precioTotal = double.Parse(txt_total.Text);
                    double precioSubtotal = double.Parse(txt_subtotal.Text);
                    double recargoTarjeta = double.Parse(txt_monto_recargo.Text);
                    double descuento = double.Parse(txt_monto_descuento.Text);

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SUBTOTAL", precioSubtotal.ToString());
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@RECARGO", recargoTarjeta.ToString());
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCUENTO", descuento.ToString());
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", precioTotal.ToString());

                    }

                // CREACION DE PDF DE LA FACTURA A
                else
                {
                    PaginaHTML_Texto = Properties.Resources.FacturaA.ToString();



                        string dni = txt_dni.Text;
                        string localidad = "Sin localidad";
                        string domicilio = "Sin calle";
                        string numeracion_calle = "Sin numeración";
                        string domicilioEntero = "Sin domicilio";

                        if (string.IsNullOrWhiteSpace(dni))
                        {
                            dni = "Sin DNI";
                        }
                        else
                        {
                            long dniNumerico;
                            localidad = "Sin localidad";
                            domicilio = "Sin calle";
                            numeracion_calle = "Sin numeración";
                            if (!long.TryParse(dni, out dniNumerico))
                            {
                                MessageBox.Show("El DNI ingresado no es válido.");
                                return;
                            }
                            dniNumerico = long.Parse(dni);
                            Cliente cliente = new Cliente();
                            cliente = ClienteControlador.obtenerPorDni(dniNumerico);
                            if (cliente.localidad_id != null)
                            {
                                localidad = cliente.localidad_id.nombre;
                            }

                            if (cliente.calle_id != null)
                            {
                                domicilio = cliente.calle_id.nombre;
                            }

                            if (cliente.numeracion_calle != null)
                            {
                                numeracion_calle = cliente.numeracion_calle.ToString();
                            }
                            domicilioEntero = domicilio + " " + numeracion_calle;
                        }


                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txt_nombre_cliente.Text);
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", dni);
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NUMEROFACTURA", txt_numero_factura.Text);
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CONDIVA", txt_condicion_iva.Text);
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOMICILIO", domicilioEntero);
                        PaginaHTML_Texto = PaginaHTML_Texto.Replace("@LOCALIDAD", localidad);


                        string filas = string.Empty;
                    decimal total = 0;
                    foreach (DataGridViewRow row in Factura.Rows)
                    {
                        filas += "<tr>";
                        filas += "<td>" + row.Cells["Nombre_Perfume"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Precio_Unitario"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Descuento"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Tot"].Value.ToString() + "</td>";
                        filas += "</tr>";
                        total += decimal.Parse(row.Cells["Tot"].Value.ToString());
                    }

                    double precioTotal = double.Parse(txt_total.Text);
                    double precioSubtotal = double.Parse(txt_subtotal.Text);
                    double recargoTarjeta = double.Parse(txt_monto_recargo.Text);
                    double iva = double.Parse(txt_iva.Text);
                    double descuento = double.Parse(txt_monto_descuento.Text);

                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SUBTOTAL", precioSubtotal.ToString());
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@RECARGO", recargoTarjeta.ToString());
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCUENTO", descuento.ToString());
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@IVA", iva.ToString());
                    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", precioTotal.ToString());
                }

                if (guardarFactura.ShowDialog() == DialogResult.OK)
                {

                    using (FileStream stream = new FileStream(guardarFactura.FileName, FileMode.Create))
                    {
                        //Creamos un nuevo documento y lo definimos como PDF
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        //Agregamos la imagen del banner al documento
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.LogoEtereaFactura, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        //img.SetAbsolutePosition(10,100);
                        img.SetAbsolutePosition(pdfDoc.LeftMargin + 12, pdfDoc.Top - 73);
                        pdfDoc.Add(img);

                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }
                }
                CrearFactura();
                CrearDetalleFactura();

                ReiniciarFormulario();

                if (!string.IsNullOrWhiteSpace(txt_email.Text))
                {
                    EnviarCorreo(filePath, txt_email.Text.Trim());
                }
            }
            else
            {
                // No hay caja asignada, mostrar FormNumeroDeCaja para elegirla
                MessageBox.Show("\"Debes ingresar un número de caja. \n Haz click en 'Abrir Caja' ", "Número de Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
        }

        private void ReiniciarFormulario()
        {
            txt_nombre_cliente.Text = "Consumidor Final";
            txt_condicion_iva.Text = "Consumidor Final";
            txt_total.Text = "0,00";
            txt_subtotal.Text = "0,00";
            txt_monto_recargo.Text = "0,00";
            txt_monto_descuento.Text = "0,00";
            txt_iva.Text = "0,00";
            txt_email.Text = "";
            txt_dni.Text = "";
            Factura.Rows.Clear();
            combo_forma_pago.SelectedIndex = 0;
            combo_descuento.SelectedIndex = 0;
            combo_cuotas.SelectedIndex = 0;
            int puntoDeVenta = Program.sucursal;
            txt_numero_factura.Text = Num_factura_máximo();
        }

        private void EnviarCorreo(string rutaArchivo, string correoDestino)
        {
            try
            {
                // Correo del emisor y contraseña de aplicación
                string correoEmisor = "maximiliano.kitagawa@davinci.edu.ar"; // Cambia esto por tu correo
                string claveEmisor = "oeyh khop xsff gyyf"; // Usa una contraseña de aplicación generada en tu cuenta de Gmail

                // Creación del mensaje
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(correoEmisor);
                mail.To.Add(correoDestino); // Dirección de correo del destinatario
                mail.Subject = "Factura de tu compra"; // Asunto del correo
                mail.Body = "Adjunto encontrarás tu factura en PDF. ¡Gracias por tu compra!"; // Cuerpo del correo

                // Adjuntar la factura (archivo PDF)
                mail.Attachments.Add(new Attachment(rutaArchivo));

                // Configuración del cliente SMTP (para Gmail)
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(correoEmisor, claveEmisor); // Credenciales del emisor
                smtp.EnableSsl = true; // Habilitar SSL para una conexión segura

                // Enviar el correo
                smtp.Send(mail);

                // Mostrar mensaje de éxito
                MessageBox.Show("Factura enviada con éxito a " + correoDestino, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Si ocurre un error, mostrar el mensaje de error
                MessageBox.Show("Error al enviar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       



      
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txt_scan_factura.Text))
                {
                    ProcesarCodigoBarras(txt_scan_factura.Text.Trim());
                    txt_scan_factura.Clear();
                    return true; // Consumimos la tecla Enter
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void btn_enviar_Click(object sender, EventArgs e)
        {
            string numero = Program.NumeroCajaActual;

            if (numero != null && numero != "Caja sin asignar")
            {

            }
            {
                // No hay caja asignada, mostrar FormNumeroDeCaja para elegirla
                MessageBox.Show("\"Debes ingresar un número de caja. \n Haz click en 'Abrir Caja' ", "Número de Caja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Diseño del combo box
        private void comboBoxdiseño_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            // Obtener el ComboBox y el texto del ítem actual
            ComboBox combo = sender as ComboBox;
            string text = combo.Items[e.Index].ToString();

            // Definir colores personalizados
            Color backgroundColor;
            Color textColor;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                // Color cuando el ítem está seleccionado
                backgroundColor = Color.FromArgb(195, 156, 164);
                textColor = Color.White;
            }
            else
            {
                // Color cuando el ítem NO está seleccionado
                backgroundColor = Color.FromArgb(250, 236, 239); // Color personalizado
                textColor = Color.FromArgb(195, 156, 164);
            }

            // Pintar el fondo del ítem
            using (SolidBrush brush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            // Dibujar el texto
            TextRenderer.DrawText(e.Graphics, text, e.Font, e.Bounds, textColor, TextFormatFlags.Left);

            // Evitar problemas visuales
            e.DrawFocusRectangle();
        }

        //Diseño del boton del datagridview
        private void Factura_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && Factura.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                e.Handled = true;
                e.PaintBackground(e.CellBounds, true);

                // Crear un rectángulo para el botón
                System.Drawing.Rectangle buttonRect = e.CellBounds;
                buttonRect.Inflate(-2, -2); // Reducir tamaño para dar efecto de borde

                // Definir colores personalizados
                Color buttonColor = Color.FromArgb(228, 137, 164); // Color de fondo del botón
                Color textColor = Color.FromArgb(250, 236, 239); // Color del texto

                using (SolidBrush brush = new SolidBrush(buttonColor))
                {
                    e.Graphics.FillRectangle(brush, buttonRect);
                }

                // Dibujar el texto del botón
                TextRenderer.DrawText(e.Graphics, (string)e.Value, e.CellStyle.Font, buttonRect, textColor,
                                      TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

     


    }
}
