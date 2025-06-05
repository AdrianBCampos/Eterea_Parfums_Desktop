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


namespace Eterea_Parfums_Desktop
{
    public partial class FormFacturacion : Form
    {
        public string NumeroCaja { get; set; }
        Cliente clientefactura = new Cliente();

        public int IdHistorialCaja { get; set; }

        private StringBuilder codigoBarrasBuffer = new StringBuilder();
        private DateTime ultimaLectura = DateTime.Now;
        private const int TIEMPO_ENTRE_LECTURAS_MS = 100;

        

        public FormFacturacion()
        {
            InitializeComponent();

           

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = System.Drawing.Image.FromFile(rutaCompletaImagen);

            txt_nombre_empleado.Text = Program.logueado.nombre + " " + Program.logueado.apellido;

            this.Load += Facturar_UC_Load;
            txt_scan_factura.Leave += Txt_scan_factura_Leave;
            txt_scan_factura.TextChanged += Txt_scan_factura_TextChanged;
            Factura.CellContentClick += DataGridViewFactura_CellContentClick;
        

            combo_forma_pago.SelectedIndexChanged -= combo_forma_pago_SelectedIndexChanged;

            txt_nombre_cliente.Text = "Consumidor Final";
            txt_condicion_iva.Text = "Consumidor final";

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
            combo_descuento.SelectedIndex = 1;

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
            
            

           

            

        }

        private void Txt_scan_factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((DateTime.Now - ultimaLectura).TotalMilliseconds > TIEMPO_ENTRE_LECTURAS_MS)
            {
                codigoBarrasBuffer.Clear();
            }

            ultimaLectura = DateTime.Now;

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string codigo = codigoBarrasBuffer.ToString().Trim();
                if (!string.IsNullOrEmpty(codigo))
                {
                    ProcesarCodigoBarras(codigo);
                    txt_scan_factura.Clear();
                    codigoBarrasBuffer.Clear();
                }
            }
            else
            {
                codigoBarrasBuffer.Append(e.KeyChar);
            }
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

            foreach (DataGridViewRow fila in Factura.Rows)
            {
                if (fila.Cells[0].Value.ToString() == perfume.id.ToString()) // Columna ID
                {
                    if (int.TryParse(fila.Cells[1].Value.ToString(), out int cantidadActual))
                    {
                        fila.Cells[1].Value = cantidadActual + 1;
                        PerfumeEnPromoControlador promoController = new PerfumeEnPromoControlador();
                        int descuentoPorcentaje = promoController.obtenerMayorDescuentoPorPerfume(perfume.id) ?? 0;
                        decimal precioUnitario = Convert.ToDecimal(perfume.precio_en_pesos);
                        decimal descuentoMonto = ((precioUnitario * descuentoPorcentaje) / 100);
                        fila.Cells[6].Value = descuentoMonto;
                        //facturacionForm.GetFacturaDataGrid().Rows[rowIndex].Cells["Tot"].Value = perfume.precio_en_pesos.ToString();
                        fila.Cells[7].Value = (cantidadActual+1) * perfume.precio_en_pesos;
                        descuentoUnitario();
                        ActualizarTotales();
                    }
                    return;
                }
            }

            int rowIndex = Factura.Rows.Add(perfume.id, 1, "", "", perfume.nombre, perfume.precio_en_pesos,"", "", ""); ;

         
           
            // Asignar botones a las celdas de la nueva fila
            Factura.Rows[rowIndex].Cells[2] = new DataGridViewButtonCell() { Value = "➕" };
            Factura.Rows[rowIndex].Cells[3] = new DataGridViewButtonCell() { Value = "➖" };
            Factura.Rows[rowIndex].Cells[8] = new DataGridViewButtonCell() { Value = "Eliminar" };// "🗑" 



           
            descuentoUnitario();
            ActualizarTotales();
        }


     
        private void Facturar_UC_Load(object sender, EventArgs e)
        {
            txt_numero_caja.Text = NumeroCaja;
            txt_numero_factura.Text = FacturaControlador.ObtenerProximoIdFactura().ToString();
            txt_scan_factura.Focus(); // Forzar el foco en txt_scan_factura al cargar el formulario
        }

        private void Txt_scan_factura_Leave(object sender, EventArgs e)
        {
            txt_scan_factura.Focus(); // Si pierde el foco, volver a asignárselo automáticamente
        }

        private void Txt_scan_factura_TextChanged(object sender, EventArgs e)
        {
            if ((DateTime.Now - ultimaLectura).TotalMilliseconds > TIEMPO_ENTRE_LECTURAS_MS)
            {
                string codigo = txt_scan_factura.Text.Trim();
                if (!string.IsNullOrEmpty(codigo))
                {
                    ProcesarCodigoBarras(codigo);
                    txt_scan_factura.Clear();
                }
            }
            ultimaLectura = DateTime.Now;
        }



      

        private void button2_Click(object sender, EventArgs e)
        {
            // Convertimos el número de caja de string a int
            if (int.TryParse(NumeroCaja, out int numCaja))
            {
                CajaControlador.MarcarCajaComoDisponible(numCaja, Program.sucursal);
            }

            if (IdHistorialCaja > 0)
            {
                CajaControlador.RegistrarCierreDeCaja(IdHistorialCaja);
            }


            FormNumeroDeCaja numeroDeCaja = new FormNumeroDeCaja();
            numeroDeCaja.AutoTomarCaja = false; // No volver a tomar la única caja automáticamente
            numeroDeCaja.Show();
            this.Close();
        }


       






        private void btn_buscar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_dni.Text))
            {
                MessageBox.Show("Ingrese un número de DNI o CUIT antes de hacer clic en buscar un cliente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validar la longitud del DNI
            if (txt_dni.Text.Length != 8 && txt_dni.Text.Length != 11)
            {
                MessageBox.Show("El número ingresado debe tener 8 u 11 dígitos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!txt_dni.Text.All(char.IsDigit))
            {
                MessageBox.Show("El DNI o CUIT solo puede contener números, sin guiones.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            long dni = long.Parse(txt_dni.Text);
            Cliente cliente = ClienteControlador.obtenerPorDni(dni);

            if (cliente != null)
            {
                clientefactura = cliente;
            }
            if (cliente != null)
            {
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
                formCrearClienteFactura.ShowDialog(); // Cambiado a ShowDialog para esperar que el formulario se cierre

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
            ActualizarTotales();
        }

        /*private void btn_consultas_Click(object sender, EventArgs e)
        {
            FormConsultasPerfumeEmpleado consultasPerfumeEmpleado = new FormConsultasPerfumeEmpleado(this);
            consultasPerfumeEmpleado.Show();
            //this.Hide();
        }*/


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

                //Meti este codigo dentro del metodo ActualizarTotales para no repetir codigo
                /*totalFactura();
                CalcularImporteRecargo(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text));

                desc();
                sumaFinal(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text), float.Parse(txt_monto_descuento.Text));
                */
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
                       else {
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
        /*
        private void CalcularMontoRecargo()
        {
            if (float.TryParse(txt_rec.Text, out float porcentajeRecargo) && float.TryParse(txt_subtotal.Text, out float subtotal))
            {
                float montoRecargo = (porcentajeRecargo / 100) * subtotal;
                txt_monto_recargo.Text = montoRecargo.ToString("0.00"); // Mostrar con dos decimales
            }
            else
            {
                txt_monto_recargo.Text = "0.00"; // Si hay un error en la conversión, dejarlo en cero
            }
        }*/


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
            if (condicionCliente.Contains("Responsable Monotributo"))
            {
                txt_total.Text = (subtotal + recargo - descuento - CalcularIVA(subtotal, recargo, descuento)).ToString("N2");
            }
            else
            {
                txt_total.Text = (subtotal + recargo - descuento).ToString("N2");
            }
        }
        public DataGridView GetFacturaDataGrid()
        {
            return Factura;
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
            }
        }

        private void combo_forma_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDescuentosYCuotas();
            ActualizarTotales();
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
                int id = int.Parse(txt_numero_factura.Text);
                DateTime fecha = DateTime.Now;
                int sucursalId = (EmpleadoControlador.obtenerPorId(Program.logueado.id)).sucursal_id.id;
                //int sucursalId = Program.logueado.sucursal_id.id; 
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
                string num_factura = "VER FORM FACTURACION";
                string tipo_de_factura = "VER FORM FACTURACION";

                MessageBox.Show($"numFactura: {id}\n" +
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
                $"facturaPdf: {facturaPdf}");


                // Llamar al método crearFactura desde FacturaControlador
                bool exito = FacturaControlador.crearFactura(id, fecha, sucursalId, vendedorId, clienteId, formaDePago,
                    precioTotal, recargoTarjeta, descuento, numeroDeCaja, tipoConsumidor, origen, facturaPdf, num_factura, tipo_de_factura);

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
                            MessageBox.Show($"PromocionID: {promocion_id}");
                        }
                        else if (cantidad == 1 && promocion_id10 != null)
                        {
                            promocion_id = promoController.obtenerPromocionIdPorPerfumeConDescuento10(perfume_id);
                            MessageBox.Show($"PromocionID: {promocion_id}");
                        } 
                        else
                        {
                            promocion_id = 1;
                            MessageBox.Show($"PromocionID: {promocion_id}");
                        }


                        MessageBox.Show($"Enviando datos2: NumFactura: {numFactura}, PerfumeID: {perfume_id}, Cantidad: {cantidad}, PrecioUnitario: {precio_unitario}, PromocionID: {promocion_id}");

                        bool exito = DetalleFacturaControlador.crearDetalleFactura(numFactura, perfume_id, cantidad, precio_unitario, promocion_id);

                        if (!exito)
                        {
                            MessageBox.Show($"Error al agregar el perfume ID {perfume_id} al detalle de la factura.");
                            return;
                        }
                        // TERMINAR CON EL METODO PARA DESCONTAR EL STOCK CUANDO SE FACTURAAAAAAAA MAXI
                           /*  int sucursalId = (EmpleadoControlador.obtenerPorId(Program.logueado.id)).sucursal_id.id;
                             StockControlador.updateStock(perfume_id, sucursalId , - cantidad);
                        MessageBox.Show($"Actualizando stock de perfume {perfume_id} en sucursal {sucursalId} con cantidad {-cantidad}"); */

                    }
                }

                MessageBox.Show("Detalle de factura creado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el detalle de la factura: " + ex.Message);
            }
        }




        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            

            SaveFileDialog guardarFactura = new SaveFileDialog();
            guardarFactura.FileName = DateTime.Now.ToString("ddMMyyyyHHss") + ".pdf";
            guardarFactura.Filter = "Archivos PDF (*.pdf)|*.pdf"; // Filtro para archivos PDF
            guardarFactura.DefaultExt = "pdf"; // Extensión por defecto
            guardarFactura.AddExtension = true; // Agrega la extensión si el usuario no la pone
            string filePath = guardarFactura.FileName;

            string condicionCliente = txt_condicion_iva.Text.Trim();
            string PaginaHTML_Texto = "";

            // Verificar si el cliente es Responsable Monotributo
            if (condicionCliente.Contains("Responsable Inscripto"))
            {
                PaginaHTML_Texto = Properties.Resources.PlantillaFactura.ToString();
            

            
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txt_nombre_cliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", txt_dni.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NUMEROFACTURA", txt_numero_factura.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

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

            } else {
                PaginaHTML_Texto = Properties.Resources.FacturaA.ToString();



                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txt_nombre_cliente.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", txt_dni.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NUMEROFACTURA", txt_numero_factura.Text);
                PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

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
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
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

            if (!string.IsNullOrWhiteSpace(txt_email.Text))
            {
                EnviarCorreo(filePath, txt_email.Text.Trim());
            }
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

    }
}
