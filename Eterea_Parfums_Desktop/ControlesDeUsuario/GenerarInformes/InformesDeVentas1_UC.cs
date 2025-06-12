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
        private bool inicioCargado = false;
        private bool finalCargado = false;
        public InformesDeVentas1_UC()
        {
            InitializeComponent();


            lbl_error_fecha.Text = "";
            lbl_error_fecha2.Text = "";
            

        }
        public InformesDeVentas1_UC(int numeroSucursal)
        {
            InitializeComponent();
            inicializarDatePickers();

            lbl_error_fecha.Text = "";
            lbl_error_fecha2.Text = "";

            txt_monto_total.Text = "";
            txt_cantidad_ventas.Text = "";

            this.numeroSucursal = numeroSucursal;
            var sucursal = SucursalControlador.getAll().FirstOrDefault(s => s.id == numeroSucursal);
            lbl_info.Text = sucursal.nombre;

            this.Cursor = Cursors.Default;
            this.UseWaitCursor = false;
        }

        private bool validarFechas()
        {
            bool esValido = true;

            if (dateTimeInicio.Value.Date >= dateTimeFinal.Value.Date)
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
            txt_cantidad_ventas.Text = "";
            txt_monto_total.Text = "";
            richTextBox_mas_vendido.Text = "";
            richTextBox_menos_vendido.Text = "";

            lbl_fecha_Inicio.Text = "...................................";
            lbl_fecha_Fin.Text = "...................................";

            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

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
                List<DetalleFactura> detalles = DetalleFacturaControlador.getByIdFactura(factura.id);
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


          var perfumesAgrupados = detalles_Totales
          .GroupBy(d => d.perfume.id) // Agrupar por ID del perfume
          .Select(g => new
          {
              IdPerfume = g.Key,
              Nombre = g.First().perfume.nombre, // Asumimos que todos tienen el mismo nombre
              CantidadVendida = g.Sum(d => d.cantidad)
          })
          .ToList();

           

            // Encontrar la mayor cantidad vendida
            int mayorCantidad = perfumesAgrupados.Max(p => p.CantidadVendida);

            // Filtrar los perfumes que tienen esa mayor cantidad
            var perfumesMasVendidos = perfumesAgrupados
                .Where(p => p.CantidadVendida == mayorCantidad)
                .Select(p => p.Nombre)
                .ToList();


            string nombresMasVendidos = string.Join(Environment.NewLine, perfumesMasVendidos);
            MessageBox.Show(nombresMasVendidos);
            // Asignar al TextBox
            richTextBox_mas_vendido.Text = nombresMasVendidos;
            richTextBox_mas_vendido.SelectAll();
            richTextBox_mas_vendido.SelectionAlignment = HorizontalAlignment.Center;


            // Encontrar la menor cantidad vendida
            int menorCantidad = perfumesAgrupados.Min(p => p.CantidadVendida);
     
            // Filtrar los perfumes que tienen esa menor cantidad
            var perfumesMenosVendidos = perfumesAgrupados
                .Where(p => p.CantidadVendida == menorCantidad)
                .Select(p => p.Nombre)
                .ToList();

 

            string nombresMenosVendidos = string.Join(Environment.NewLine, perfumesMenosVendidos);
      
            // Asignar al TextBox
            richTextBox_menos_vendido.Text = nombresMenosVendidos;
            richTextBox_menos_vendido.SelectAll();
            richTextBox_menos_vendido.SelectionAlignment = HorizontalAlignment.Center;

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;

        }

        private void btn_exportar_pdf_Click(object sender, EventArgs e)
        {
            // Validación de las fechas
            if (!validarFechas())
            {
                MessageBox.Show("Error verifique las fechas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resetearDatos();
                return;
            }

            SaveFileDialog guardarFactura = new SaveFileDialog
            {
                FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf",
                Filter = "Archivos PDF (.pdf)|.pdf",
                DefaultExt = "pdf",
                AddExtension = true
            };

            //int sucursalId = EmpleadoControlador.obtenerPorId(numeroSucursal).sucursal_id.id;
            Sucursal sucursal = SucursalControlador.getById(numeroSucursal);

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
                                               .Replace("@MONTO_TOTAL_VENTAS", txt_monto_total.Text);

            string perfumesMasVendidosHtml = richTextBox_mas_vendido.Text.Replace("\n", "<br />").Replace("\r", "");
            string perfumesMenosVendidosHtml = richTextBox_menos_vendido.Text.Replace("\n", "<br />").Replace("\r", "");

            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@PERFUME_MAS_VENDIDO", perfumesMasVendidosHtml)
                                               .Replace("@PERFUME_MENOS_VENDIDO", perfumesMenosVendidosHtml);

         

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
                resetearDatos();
                resetearDatePickers();


                MessageBox.Show("PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


     

        private void cargarDatosSeguro()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(cargarDatosSeguro));
                return;
            }

            cargarDatos();
        }



        //Inicializar los DatePickers

        private void inicializarDatePickers()
        {

            // Desuscribimos eventos
            dateTimeInicio.ValueChanged -= dateTimeInicio_ValueChanged;
            dateTimeFinal.ValueChanged -= dateTimeFinal_ValueChanged;

            // Inicialmente mostrar campos vacíos
            dateTimeInicio.Format = DateTimePickerFormat.Custom;
            dateTimeInicio.CustomFormat = " ";
            dateTimeFinal.Format = DateTimePickerFormat.Custom;
            dateTimeFinal.CustomFormat = " ";

            // Configurar valores máximos
            dateTimeInicio.MaxDate = DateTime.Now;
            dateTimeFinal.MaxDate = DateTime.Now;

            // Marcamos que aún no se seleccionó una fecha
            inicioCargado = false;
            finalCargado = false;

            // Volvemos a suscribir
            dateTimeInicio.ValueChanged += dateTimeInicio_ValueChanged;
            dateTimeFinal.ValueChanged += dateTimeFinal_ValueChanged;

            

        }


        private void resetearDatePickers()
        {
            inicioCargado = false;
            finalCargado = false;

            dateTimeInicio.Format = DateTimePickerFormat.Custom;
            dateTimeInicio.CustomFormat = " ";
            //dateTimeInicio.Value = DateTime.Today;

            dateTimeFinal.Format = DateTimePickerFormat.Custom;
            dateTimeFinal.CustomFormat = " ";
            //dateTimeFinal.Value = DateTime.Today;
        }

        private async void dateTimeInicio_ValueChanged(object sender, EventArgs e)
        {
            if (!inicioCargado)
            {
                dateTimeInicio.Format = DateTimePickerFormat.Short;
                inicioCargado = true;

            }

            if (inicioCargado && finalCargado)
            {
                await Task.Run(() => cargarDatosSeguro());
            };

        }

        private async void dateTimeFinal_ValueChanged(object sender, EventArgs e)
        {
            if (!finalCargado)
            {
                dateTimeFinal.Format = DateTimePickerFormat.Short;
                finalCargado = true;

            }

            if (inicioCargado && finalCargado)
            {
                await Task.Run(() => cargarDatosSeguro());
            }


        }
    }
}
