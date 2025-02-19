using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;

namespace Eterea_Parfums_Desktop
{
    public partial class FormInformesDeVentas1 : Form
    {
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        
        public FormInformesDeVentas1()
        {
            InitializeComponent();
            lbl_error_fecha_inicio.Visible = false;
            lbl_error_fecha_final.Visible = false;
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
                        textBox.Text = string.Empty;
                        lbl_error_fecha_inicio.Text = "Formato de fecha inválido. Use YYYY-MM-DD.";
                        lbl_error_fecha_inicio.Visible = true;
                    }
                }
                else if (textBox.Text.Length > 10)
                {
                    textBox.Text = string.Empty;
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
                        textBox.Text = string.Empty;
                        lbl_error_fecha_final.Text = "Formato de fecha inválido. Use YYYY-MM-DD.";
                        lbl_error_fecha_final.Visible = true;
                    }
                }
                else if (textBox.Text.Length > 10)
                {
                    textBox.Text = string.Empty;
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


        private void btn_exportar_pdf_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            bool error = false;

            if (string.IsNullOrEmpty(txt_fecha_inicial.Text))
            {
                mensaje += "Debe ingresar una fecha inicial.\n";
                lbl_error_fecha_inicio.Text = "Debe ingresar una fecha inicial.";
                lbl_error_fecha_inicio.Show();
                error = true;
            }
            else
            {
                lbl_error_fecha_inicio.Visible = false;
            }

            if (string.IsNullOrEmpty(txt_fecha_final.Text))
            {
                mensaje += "Debe ingresar una fecha final.\n";
                lbl_error_fecha_final.Text = "Debe ingresar una fecha final.";
                lbl_error_fecha_final.Show();
                error = true;
            }
            else
            {
                lbl_error_fecha_final.Visible = false;
            }

            if (error) return;

            DateTime fechaInicio, fechaFinal;
            if (!DateTime.TryParse(txt_fecha_inicial.Text, out fechaInicio) ||
                !DateTime.TryParse(txt_fecha_final.Text, out fechaFinal))
            {
                MessageBox.Show("Formato de fecha incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fechaInicio > fechaFinal)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog guardarFactura = new SaveFileDialog
            {
                FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf",
                Filter = "Archivos PDF (*.pdf)|*.pdf",
                DefaultExt = "pdf",
                AddExtension = true
            };

            int sucursalId = EmpleadoControlador.obtenerPorId(Program.logueado.id).sucursal_id.id;
            Sucursal sucursal = SucursalControlador.getById(sucursalId);

            string PaginaHTML_Texto = Properties.Resources.PlantillaInformeVentas.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SUCURSAL", sucursal.nombre)
                                               .Replace("@CALLE", sucursal.calle_id.nombre)
                                               .Replace("@NUMERO", sucursal.numeracion_calle.ToString())
                                               .Replace("@PROVINCIA", sucursal.provincia_id.nombre)
                                               .Replace("@PAIS", sucursal.pais_id.nombre)
                                               .Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"))
                                               .Replace("@INICIO", txt_fecha_inicial.Text)
                                               .Replace("@FINAL", txt_fecha_final.Text)
                                               .Replace("@CANTIDAD", txt_cantidad_ventas.Text)
                                               .Replace("@MONTO_TOTAL_VENTAS", txt_monto_total.Text)
                                               .Replace("@PERFUME_MAS_VENDIDO", txt_mas_vendido.Text)
                                               .Replace("@PERFUME_MENOS_VENDIDO", txt_menos_vendido.Text);
            Console.WriteLine(sucursal.provincia_id.nombre + sucursal.numeracion_calle.ToString() + sucursal.provincia_id.nombre);

            Console.WriteLine(PaginaHTML_Texto);

            if (guardarFactura.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardarFactura.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    try
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.LogoEtereaFactura, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        pdfDoc.Add(img);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                     using (StringReader sr = new StringReader(PaginaHTML_Texto))
                     {
                         XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                     }

                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
