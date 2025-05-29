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
        private int numeroSucursal;
        public InformesDeVentas1_UC()
        {
            InitializeComponent();


            lbl_error_fecha.Text = "";
            lbl_error_fecha2.Text = "";
        }
        public InformesDeVentas1_UC(int numeroSucursal)
        {
            InitializeComponent();
     

            lbl_error_fecha.Text = "";
            lbl_error_fecha2.Text = "";
            this.numeroSucursal = numeroSucursal;

            lbl_info.Text = numeroSucursal.ToString();
        }

        private bool validarFechas()
        {
            bool esValido = true;

            if (dateTimeInicio.Value >= dateTimeFinal.Value)
            {
                lbl_error_fecha.Text = "La fecha de inicio no puede ser mayor o igual a la fecha final.";
                esValido = false;
            }
            else
            {
                lbl_error_fecha.Text = "";
            }

            if (dateTimeFinal.Value > DateTime.Now)
            {
                lbl_error_fecha2.Text = "La fecha final no puede ser mayor a la fecha actual.";
                esValido = false;
            }
            else
            {
                lbl_error_fecha2.Text = "";
            }

            return esValido;
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

            lbl_fecha_Inicio.Text = dateTimeInicio.Value.ToString("dd 'de' MMMM 'de' yyyy");
            lbl_fecha_Fin.Text = dateTimeFinal.Value.ToString("dd 'de' MMMM 'de' yyyy");

            // Validación de las fechas
            if (!validarFechas())
            {
                resetearDatos();
                return;
            }

            List<Factura> facturas = FacturaControlador.getAllIntervaloFechas(dateTimeInicio.Value, dateTimeFinal.Value);

            //SE FILTRA POR SUCURSAL
            facturas = facturas.Where(f => f.sucursal_id.id == numeroSucursal).ToList();

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
                //Se completa la información de cada detalle de factura con el perfume correspondiente
                foreach (DetalleFactura detalle in detalles)
                {
                    var detalle_factura = detalle;
                    detalle_factura.perfume = PerfumeControlador.getByID(detalle.perfume.id);
                    //Console.WriteLine("perfumeID " + detalle_factura.perfume.id + "perfume " + detalle_factura.perfume.nombre);
                    detalles_Totales.Add(detalle_factura);
                }
            }


            if (detalles_Totales.Count == 0)
            {
                resetearDatos();
                return;
            }


            // Agrupar perfumes por ventas
            var perfumesAgrupados = detalles_Totales
                .GroupBy(d => d.perfume)
                .Select(g => new
                {
                    Perfume = g.Key,
                    CantidadVendida = g.Sum(d => d.cantidad)
                })
                .ToList();

            // Encontrar la mayor cantidad vendida
            int mayorCantidad = perfumesAgrupados.Max(p => p.CantidadVendida);

            // Filtrar los perfumes que tienen esa mayor cantidad
            var perfumesMasVendidos = perfumesAgrupados
                .Where(p => p.CantidadVendida == mayorCantidad)
                .Select(p => p.Perfume.nombre)
                .ToList();

            // Concatenar los nombres
            string nombresMasVendidos = string.Join(", ", perfumesMasVendidos);

            // Asignar al TextBox
            txt_mas_vendido.Text = nombresMasVendidos;


            // Encontrar la menor cantidad vendida
            int menorCantidad = perfumesAgrupados.Min(p => p.CantidadVendida);

            // Filtrar los perfumes que tienen esa menor cantidad
            var perfumesMenosVendidos = perfumesAgrupados
                .Where(p => p.CantidadVendida == menorCantidad)
                .Select(p => p.Perfume.nombre)
                .ToList();

            // Concatenar los nombres
            string nombresMenosVendidos = string.Join(", ", perfumesMenosVendidos);

            // Asignar al TextBox
            txt_menos_vendido.Text = nombresMenosVendidos;

        }

        private void btn_exportar_pdf_Click(object sender, EventArgs e)
        {
            // Validación de las fechas
            if (!validarFechas())
            {
                MessageBox.Show("Error verifique las fechas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //DateTime fechaSeleccionada = dateTimeInicio.Value;
            //lbl_fecha_Inicio.Text = fechaSeleccionada.ToString("dd 'de' MMMM 'de' yyyy");
                 
        }

        private void dateTimeFinal_ValueChanged(object sender, EventArgs e)
        {
            cargarDatos();
            //DateTime fechaSeleccionada = dateTimeFinal.Value;
            //lbl_fecha_Fin.Text = fechaSeleccionada.ToString("dd 'de' MMMM 'de' yyyy");
        } 

    }
}
