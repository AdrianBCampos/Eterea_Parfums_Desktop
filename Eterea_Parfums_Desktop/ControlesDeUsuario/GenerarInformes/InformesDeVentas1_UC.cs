using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario.GenerarInformes
{
    public partial class InformesDeVentas1_UC : UserControl
    {
        public InformesDeVentas1_UC()
        {
            InitializeComponent();
        }

       

        private bool validarFecha()
        {
            if (dateTimeInicio.Value >= dateTimeFinal.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor o igual a la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void resetearDatos()
        {
            txt_cantidad_ventas.Text = "0";
            txt_monto_total.Text = "$0";
            txt_mas_vendido.Text = "No hay registros";
            txt_menos_vendido.Text = "No hay registros";
        }
        private void cargarDatos()
        {
            // Validación de las fechas
            if (validarFecha() == false)
            {
                return;
            }

            List<Factura> facturas = FacturaControlador.getAllIntervaloFechas(dateTimeInicio.Value, dateTimeFinal.Value);

            if (facturas.Count == 0)
            {
                resetearDatos();
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

        private void btn_exportar_pdf_Click(object sender, EventArgs e)
        {
            // Validación de las fechas
            if (validarFecha() == false)
            {
                return;
            }


            SaveFileDialog guardarFactura = new SaveFileDialog
            {
                FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf",
                Filter = "Archivos PDF (.pdf)|.pdf",
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
                                               .Replace("@INICIO", dateTimeInicio.Value.ToString("dd/MM/yyyy"))
                                               .Replace("@FINAL", dateTimeFinal.Value.ToString("dd/MM/yyyy"))
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

        private void dateTimeInicio_ValueChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void dateTimeFinal_ValueChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
