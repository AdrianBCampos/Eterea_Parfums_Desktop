using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop
{
    public partial class FormInformesDeVentas1 : Form
    {
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        public FormInformesDeVentas1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSeleccionarInformeVenta informesDeVentas = new FormSeleccionarInformeVenta();
            informesDeVentas.Show();
            this.Close();
        }

        private void cargarDatos()
        {
            // Validación de las fechas
            if (string.IsNullOrEmpty(fechaInicio.ToString("yyyy-MM-dd")))
            {
                lbl_error_fecha_inicio.Text = "Por favor, ingrese una fecha de inicio.";
                lbl_error_fecha_inicio.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(fechaFinal.ToString("yyyy-MM-dd")))
            {
                lbl_error_fecha_final.Text = "Por favor, ingrese una fecha de fin.";
                lbl_error_fecha_final.Visible = true;
                return;
            }

            List<Factura> facturas = FacturaControlador.getAllIntervaloFechas(fechaInicio, fechaFinal);

            if (facturas.Count == 0)
            {
                MessageBox.Show("No se encontraron facturas en el rango de fechas especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txt_cantidad_ventas.Text = facturas.Count.ToString();
            txt_monto_total.Text = facturas.Sum(f => f.precio_total).ToString("C2");

            List<DetalleFactura> detalles_Totales = new List<DetalleFactura>();

            foreach (Factura factura in facturas)
            {
                List<DetalleFactura> detalles = DetalleFacturaControlador.getByIdFactura(factura.num_factura);
                Console.WriteLine("Cantidad de detales: " + detalles.Count());
                foreach (DetalleFactura detalle in detalles)
                {
                    var detalle_factura = detalle;
                    detalle_factura.perfume = PerfumeControlador.getByID(detalle.perfume.id);
                    Console.WriteLine("perfumeID " + detalle_factura.perfume.id + "perfume " + detalle_factura.perfume.nombre);
                    detalles_Totales.Add(detalle_factura);
                }
            }
            txt_mas_vendido.Text = detalles_Totales
            .GroupBy(d => d.perfume)
            .OrderByDescending(g => g.Sum(d => d.cantidad)) // Ordenar por la suma de cantidades vendidas
            .First().Key.nombre;  // Obtener el nombre del perfume con más ventas



            //txt_mas_vendido.Text = facturas.GroupBy(f => f.num_factura).OrderByDescending(g => g.Count()).First().Key.ToString();
            txt_menos_vendido.Text = detalles_Totales
            .GroupBy(d => d.perfume)
            .OrderBy(g => g.Sum(d => d.cantidad)) // Ordenar por la suma de cantidades vendidas
            .First().Key.nombre;  // Obtener el nombre del perfume con más ventas


        }


        private void txt_fecha_inicial_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {

                if (textBox.Text.Length == 10) // Verificamos si tiene el formato esperado (YYYY-MM-DD)
                {
                    if (DateTime.TryParse(textBox.Text, out fechaInicio))
                    {
                        //fecha_inicio = fechaInicio.ToString("yyyy-MM-dd");
                        lbl_error_fecha_inicio.Visible = false; // Ocultamos el mensaje de error si es válido
                        //Console.WriteLine(fecha_inicio);
                    }
                    else
                    {
                        //fecha_inicio = string.Empty;
                        lbl_error_fecha_inicio.Text = "Formato de fecha inválido. Use YYYY-MM-DD.";
                        lbl_error_fecha_inicio.Visible = true;
                    }
                }
                else if (textBox.Text.Length > 10)
                {
                    //fecha_inicio = string.Empty;
                    lbl_error_fecha_inicio.Text = "Formato de fecha inválido. Use YYYY-MM-DD.";
                    lbl_error_fecha_inicio.Visible = true;
                }
            }
        }

        private void txt_fecha_final_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {

                if (textBox.Text.Length == 10) // Verificamos si tiene el formato esperado (YYYY-MM-DD)
                {
                    if (DateTime.TryParse(textBox.Text, out fechaFinal))
                    {
                        //fecha_fin = fechaFinal.ToString("yyyy-MM-dd");
                        lbl_error_fecha_final.Visible = false; // Ocultamos el mensaje de error si es válido
                        //Console.WriteLine(fecha_inicio);
                    }
                    else
                    {
                        //fecha_fin = string.Empty;
                        lbl_error_fecha_final.Text = "Formato de fecha inválido. Use YYYY-MM-DD.";
                        lbl_error_fecha_final.Visible = true;
                    }
                }
                else if (textBox.Text.Length > 10)
                {
                    // fecha_fin = string.Empty;
                    lbl_error_fecha_final.Text = "Formato de fecha inválido. Use YYYY-MM-DD.";
                    lbl_error_fecha_final.Visible = true;
                }
            }
        }

        private void txt_fecha_inicial_KeyDown(object sender, KeyEventArgs e)

        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                // Validación para la fecha inicial
                if (string.IsNullOrEmpty(fechaFinal.ToString("yyyy-MM-dd")))
                {
                    lbl_error_fecha_inicio.Text = "Formato de fecha inválido. Use YYYY-MM-DD.";
                    lbl_error_fecha_inicio.Visible = true;
                    e.SuppressKeyPress = true; // Evita el cambio de foco si la fecha no es válida
                    return;
                }

                // Si la fecha es válida, mover el foco a txt_fecha_final
                txt_fecha_final.Focus();
            }
        }

        private void txt_fecha_final_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                // Validación para la fecha inicial
                if (string.IsNullOrEmpty(fechaFinal.ToString("yyyy-MM-dd")))
                {
                    lbl_error_fecha_final.Text = "Formato de fecha inválido. Use YYYY-MM-DD.";
                    lbl_error_fecha_final.Visible = true;
                    e.SuppressKeyPress = true; // Evita el cambio de foco si la fecha no es válida
                    return;
                }

                // Si la fecha es válida, mover el foco a txt_fecha_final
                txt_fecha_final.Focus();
                cargarDatos();
            }
        }

       /* private void btn_imprimir_Click(object sender, EventArgs e)
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
        }*/

        private void btn_exportar_pdf_Click(object sender, EventArgs e)
        {

        }
    }
}
