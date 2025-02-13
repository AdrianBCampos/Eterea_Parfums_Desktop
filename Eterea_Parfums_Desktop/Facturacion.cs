using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using static System.Net.WebRequestMethods;


namespace Eterea_Parfums_Desktop
{
    public partial class Facturacion : Form
    {
        public string NumeroCaja { get; set; }
        Cliente clientefactura = new Cliente();

        public Facturacion()
        {
            InitializeComponent();
            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = System.Drawing.Image.FromFile(rutaCompletaImagen);

            txt_nombre_empleado.Text = Program.logueado.nombre + " " + Program.logueado.apellido;

            combo_forma_pago.SelectedIndexChanged -= combo_forma_pago_SelectedIndexChanged;

            combo_forma_pago.Items.Clear();
            combo_forma_pago.Items.Add("Efectivo");
            combo_forma_pago.Items.Add("Visa Débito");
            combo_forma_pago.Items.Add("Visa Crédito");
            combo_forma_pago.Items.Add("Mastercard");
            combo_forma_pago.Items.Add("Amex");
            combo_forma_pago.Items.Add("Mercado Pago");
            combo_forma_pago.SelectedIndex = 0;


            combo_descuento.Items.Clear();
            combo_descuento.Items.AddRange(new object[] { 0 ,10, 20, 30 });
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
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            txt_numero_caja.Text = NumeroCaja;
            txt_numero_factura.Text = FacturaControlador.ObtenerProximoIdFactura().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumeroDeCaja numeroDeCaja = new NumeroDeCaja();
            numeroDeCaja.Show();
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
 
            if (string.IsNullOrWhiteSpace(txt_dni.Text))
             {
                 MessageBox.Show("Ingrese un número de DNI antes de buscar un cliente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }
             // Validar la longitud del DNI
             if (txt_dni.Text.Length != 8)
             {
                 MessageBox.Show("El número ingresado debe ser de 8 o 11 dígitos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }
            if (!txt_dni.Text.All(char.IsDigit))
            {
                MessageBox.Show("El DNI solo puede contener números.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int dni = int.Parse(txt_dni.Text);
            Cliente cliente = ClienteControlador.obtenerPorDni(dni);
            if (cliente != null) {
            clientefactura = cliente;
            }
            if (cliente != null)
            {
                // Si se encuentra el cliente, llenar los campos en el formulario actual
                txt_nombre_cliente.Text = cliente.nombre + " " + cliente.apellido;
                txt_condicion_iva.Text = cliente.condicion_frente_al_iva;
                
            }
            else
            {
                int dniIngresado = int.Parse(txt_dni.Text);
                // Si no se encuentra el cliente, abrir el formulario para agregar un nuevo cliente
                FormCrearClienteFactura formCrearClienteFactura = new FormCrearClienteFactura(dni);
                formCrearClienteFactura.ShowDialog(); // Cambiado a ShowDialog para esperar que el formulario se cierre

                // Luego de cerrar el formulario de clientes, verifica si se creó un nuevo cliente
                Cliente nuevoCliente = ClienteControlador.obtenerPorDni(int.Parse(txt_dni.Text));
                if (nuevoCliente != null)
                {
                    // Asigna los datos del nuevo cliente al formulario actual
                    txt_nombre_cliente.Text = nuevoCliente.nombre + " " + nuevoCliente.apellido;
                    txt_condicion_iva.Text = nuevoCliente.condicion_frente_al_iva;
                }
            }
            ActualizarTotales();
        }

        private void btn_consultas_Click(object sender, EventArgs e)
        {
            ConsultasPerfumeEmpleado consultasPerfumeEmpleado = new ConsultasPerfumeEmpleado(this);
            consultasPerfumeEmpleado.Show();
            //this.Hide();
        }

        private void dataGridViewFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                Factura.Rows.RemoveAt(e.RowIndex);
                ActualizarTotales();
                /*
                totalFactura();
                CalcularImporteRecargo(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text));

                desc();
                sumaFinal(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text), float.Parse(txt_monto_descuento.Text));
                */
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                int cant = int.Parse(Factura.Rows[e.RowIndex].Cells[1].Value.ToString());
                Factura.Rows[e.RowIndex].Cells[1].Value = cant + 1;

                int rowIndex = e.RowIndex;

                int valorMultiplicador = Convert.ToInt32(Factura.Rows[rowIndex].Cells[1].Value);
                double precio = Convert.ToDouble(Factura.Rows[rowIndex].Cells[5].Value);


                Factura.Rows[e.RowIndex].Cells[6].Value = (precio * valorMultiplicador).ToString();

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

                    Factura.Rows[e.RowIndex].Cells[6].Value = (precio * valorMultiplicador).ToString();

                    ActualizarTotales();
                    //Meti este codigo dentro del metodo ActualizarTotales para no repetir codigo
                    /*
                    totalFactura();
                    CalcularImporteRecargo(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text));

                    desc();
                    sumaFinal(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text), float.Parse(txt_monto_descuento.Text));
                    */
                }
                else
                {
                    Factura.Rows.RemoveAt(e.RowIndex);
                    ActualizarTotales();
                    /*
                    totalFactura();
                    CalcularImporteRecargo(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text));

                    desc();
                    sumaFinal(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text), float.Parse(txt_monto_descuento.Text));
                    */

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
                    if (double.TryParse(fila.Cells[6].Value.ToString(), out precioFila))
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
            if (condicionCliente.Contains("Responsable Monotributo"))
            {
                txt_total.Text = (subtotal + recargo - descuento - CalcularIVA(subtotal,recargo,descuento)).ToString("N2");
            } else { 
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

            float subtotal, recargo, descuento, iva;

            desc();
            CalcularMontoRecargo();
            // Verificamos que los valores sean válidos para evitar errores de conversión
            if (!float.TryParse(txt_subtotal.Text, out subtotal)) subtotal = 0;
            if (!float.TryParse(txt_monto_recargo.Text, out recargo)) recargo = 0;
            if (!float.TryParse(txt_monto_descuento.Text, out descuento)) descuento = 0;

            if (!float.TryParse(txt_subtotal.Text, out subtotal) || subtotal == 0)
            {
                // Si el subtotal es 0, poner todos los montos a 0
                txt_monto_recargo.Text = "0,00";
                txt_monto_descuento.Text = "0,00";
                txt_iva.Text = "0,00";
                txt_total.Text = "0,00";
                return; // Salir del método sin hacer más cálculos
            }

            //CalcularImporteRecargo(subtotal, recargo);
            
            //CalcularIVA(subtotal, recargo, descuento);
            //if (!float.TryParse(txt_iva.Text, out iva)) iva = 0;
            sumaFinal(subtotal, recargo, descuento);
            VerificarCondicionIVA(subtotal, recargo, descuento);
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
        private void VerificarCondicionIVA(float subtotal, float recargo, float descuento)
        {
            string condicionCliente = txt_condicion_iva.Text.Trim();

            // Verificar si el cliente es Responsable Monotributo
            if (condicionCliente.Contains("Responsable Monotributo"))
            {
                // Deshabilitar el campo de IVA
                txt_iva.Enabled = true;
                txt_iva.Text = CalcularIVA(subtotal, recargo, descuento).ToString("0.00");
            }
            else if (condicionCliente.Contains("Consumidor Final"))
            {
                // Si no es monotributista, habilitar el campo de IVA
                txt_iva.Enabled = false;
                txt_iva.Text = "0,00";
            }
            else if (condicionCliente.Contains("Responsable Inscripto") || condicionCliente.Contains("Responsable no Inscripto"))
            {
                txt_iva.Enabled = true;
                txt_iva.Text = CalcularIVA(subtotal, recargo, descuento).ToString("0.00");
            }
        }

        private void CrearFactura()
        {
            try
            {
                Empleado empleadoAFacturar = new Empleado();

                // Obtener los valores de los controles del formulario
                int numFactura = int.Parse(txt_numero_factura.Text);
                DateTime fecha = DateTime.Now;
                int sucursalId = (EmpleadoControlador.obtenerPorId(Program.logueado.id)).sucursal_id.id;
                //int sucursalId = Program.logueado.sucursal_id.id; 
                int vendedorId = Program.logueado.id; 
                int clienteId = clientefactura.id; 
                string formaDePago = combo_forma_pago.SelectedItem.ToString();
                double precioTotal = double.Parse(txt_total.Text);
                double recargoTarjeta = double.Parse(txt_monto_recargo.Text);
                double descuento = double.Parse(txt_monto_descuento.Text);
                int numeroDeCaja = int.Parse(txt_numero_caja.Text);
                string tipoConsumidor = clientefactura.condicion_frente_al_iva;
                string origen = "V";
                string facturaPdf = "";

                MessageBox.Show($"numFactura: {numFactura}\n" +
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
                bool exito = FacturaControlador.crearFactura(numFactura, fecha, sucursalId, vendedorId, clienteId, formaDePago,
                    precioTotal, recargoTarjeta, descuento, numeroDeCaja, tipoConsumidor, origen, facturaPdf);

                if (exito)
                {
                    MessageBox.Show("Factura creada exitosamente.");

                    // Cerrar el formulario actual y abrir uno nuevo
                    this.Close(); // Cierra el formulario actual

                    Facturacion nuevaFacturacion = new Facturacion();

                    // Mostrar el nuevo formulario
                    nuevaFacturacion.Show();
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarFactura = new SaveFileDialog();
            guardarFactura.FileName = DateTime.Now.ToString("ddMMyyyyHHss") + ".pdf";
            guardarFactura.Filter = "Archivos PDF (*.pdf)|*.pdf"; // Filtro para archivos PDF
            guardarFactura.DefaultExt = "pdf"; // Extensión por defecto
            guardarFactura.AddExtension = true; // Agrega la extensión si el usuario no la pone
            

            string PaginaHTML_Texto = Properties.Resources.PlantillaFactura.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", txt_nombre_cliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NUMEROFACTURA", txt_numero_factura.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in Factura.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Nombre_Perfume"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio_Unitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Tot"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["Tot"].Value.ToString());
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());



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
           // CrearFactura();
        }
    }
}
