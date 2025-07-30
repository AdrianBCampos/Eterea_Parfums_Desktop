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

            /*lbl_fecha_Inicio.Text = "...................................";
            lbl_fecha_Fin.Text = "...................................";*/

            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

        }
        private void cargarDatos()
        {

            // Validación de las fechas
            if (!validarFechas())
            {
                resetearDatos();

                return;
            }

            // ✅ Muestra siempre las fechas seleccionadas, incluso si no hay ventas
            lbl_fecha_Inicio.Text = dateTimeInicio.Value.ToString("dd 'de' MMMM 'de' yyyy");
            lbl_fecha_Fin.Text = dateTimeFinal.Value.ToString("dd 'de' MMMM 'de' yyyy");

            List<Factura> facturas = FacturaControlador.getAllIntervaloFechas(dateTimeInicio.Value, dateTimeFinal.Value);
            //MessageBox.Show("Facturas encontradas: " + facturas.Count);
            //SE FILTRA POR SUCURSAL
            facturas = facturas.Where(f => f.sucursal_id.id == numeroSucursal).ToList();

            if (facturas.Count == 0)
            {
                resetearDatos();

                label6.Visible=false;
                label7.Visible=false;   
                label4.Visible=false;
                label5.Visible=false;

                // ✅ Mostrar mensaje indicando que no hubo ventas
                richTextBox_mas_vendido.Text = "\nNo hubo ventas en este período.";
                richTextBox_menos_vendido.Text = "\nNo hubo ventas en este período.";

                richTextBox_mas_vendido.SelectAll();
                richTextBox_mas_vendido.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox_menos_vendido.SelectAll();
                richTextBox_menos_vendido.SelectionAlignment = HorizontalAlignment.Center;

                // ✅ Mostrar valores en cero
                txt_cantidad_ventas.Text = "0";
                txt_monto_total.Text = "$ 0";

                return;
            }


                txt_cantidad_ventas.Text = facturas.Count.ToString();
            txt_monto_total.Text = facturas.Sum(f => f.precio_total).ToString("C2");

            List<DetalleFactura> detalles_Totales = new List<DetalleFactura>();
            foreach (Factura factura in facturas)
            {
                
                List<DetalleFactura> detalles = DetalleFacturaControlador.getByIdFactura(factura.id);
                //Console.WriteLine("Cantidad de detales: " + detalles.Count());
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
              Nombre = g.First().perfume.nombre, 
              Presentacion = g.First().perfume.presentacion_ml,
              CantidadVendida = g.Sum(d => d.cantidad)
          })
          .ToList();

           

            // Encontrar la mayor cantidad vendida
            int mayorCantidad = perfumesAgrupados.Max(p => p.CantidadVendida);

            // Filtrar los perfumes que tienen esa mayor cantidad
            var perfumesMasVendidos = perfumesAgrupados
                .Where(p => p.CantidadVendida == mayorCantidad)
                .Select(p => $"{p.Nombre} - {p.Presentacion} ml")
                .ToList();


            string nombresMasVendidos = string.Join(Environment.NewLine, perfumesMasVendidos);
 
            richTextBox_mas_vendido.Text = nombresMasVendidos;
            richTextBox_mas_vendido.SelectAll();
            richTextBox_mas_vendido.SelectionAlignment = HorizontalAlignment.Center;


            // Encontrar la menor cantidad vendida
            int menorCantidad = perfumesAgrupados.Min(p => p.CantidadVendida);
     
            // Filtrar los perfumes que tienen esa menor cantidad
            var perfumesMenosVendidos = perfumesAgrupados
                .Where(p => p.CantidadVendida == menorCantidad)
                 .Select(p => $"{p.Nombre} - {p.Presentacion} ml")
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

            List<Factura> facturas = FacturaControlador.getAllIntervaloFechas(dateTimeInicio.Value, dateTimeFinal.Value)
                .Where(f => f.sucursal_id.id == numeroSucursal)
                .ToList();

            bool sinVentas = facturas.Count == 0;


            string PaginaHTML_Texto = Properties.Resources.PlantillaInformeVentas.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SUCURSAL", sucursal.nombre)
                                               .Replace("@CALLE", sucursal.calle_id.nombre)
                                               .Replace("@NUMERO", sucursal.numeracion_calle.ToString())
                                               .Replace("@PROVINCIA", sucursal.provincia_id.nombre)
                                               .Replace("@PAIS", sucursal.pais_id.nombre)
                                               .Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"))
                                               .Replace("@INICIO", dateTimeInicio.Value.ToString("dd/MM/yyyy"))
                                               .Replace("@FINAL", dateTimeFinal.Value.ToString("dd/MM/yyyy"))
                                               .Replace("@CANTIDAD", sinVentas ? " 0" : txt_cantidad_ventas.Text)
                                               .Replace("@MONTO_TOTAL_VENTAS", sinVentas ? "$ 0.-" : txt_monto_total.Text);

            string perfumesMasVendidosHtml;
            string perfumesMenosVendidosHtml;

            if (sinVentas)
            {
                perfumesMasVendidosHtml = "<br /><strong>No hubo ventas en este período.</strong>";
                perfumesMenosVendidosHtml = "<br /><strong>No hubo ventas en este período.</strong>";
            }
            else
            {
                perfumesMasVendidosHtml = richTextBox_mas_vendido.Text.Replace("\n", "<br />").Replace("\r", "");
                perfumesMenosVendidosHtml = richTextBox_menos_vendido.Text.Replace("\n", "<br />").Replace("\r", "");
            }

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
            // Desuscribimos eventos previos
            dateTimeInicio.ValueChanged -= dateTimeInicio_ValueChanged;
            dateTimeFinal.ValueChanged -= dateTimeFinal_ValueChanged;

            // Formato vacío inicial
            dateTimeInicio.Format = DateTimePickerFormat.Custom;
            dateTimeInicio.CustomFormat = " ";
            dateTimeFinal.Format = DateTimePickerFormat.Custom;
            dateTimeFinal.CustomFormat = " ";

            // Configurar valores máximos
            dateTimeInicio.MaxDate = DateTime.Now;
            dateTimeFinal.MaxDate = DateTime.Now;

            // Estado de carga
            inicioCargado = false;
            finalCargado = false;

            // Suscribir eventos
            dateTimeInicio.ValueChanged += dateTimeInicio_ValueChanged;
            dateTimeInicio.DropDown += dateTimeInicio_DropDown;

            dateTimeFinal.ValueChanged += dateTimeFinal_ValueChanged;
            dateTimeFinal.DropDown += dateTimeFinal_DropDown;

            // ✅ Suscribir DropDown para mostrar calendario sin autocompletar
            dateTimeInicio.DropDown += dateTimeInicio_DropDown;
            dateTimeFinal.DropDown += dateTimeFinal_DropDown;
        }


        private void resetearDatePickers()
        {
            inicioCargado = false;
            finalCargado = false;

            dateTimeInicio.Format = DateTimePickerFormat.Custom;
            dateTimeInicio.CustomFormat = " ";
            dateTimeInicio.Value = DateTime.Today.AddDays(-2);

            dateTimeFinal.Format = DateTimePickerFormat.Custom;
            dateTimeFinal.CustomFormat = " ";
            dateTimeFinal.Value = DateTime.Today.AddDays(-1);
            //dateTimeFinal.Value = DateTime.Today;
        }

        private async void dateTimeInicio_ValueChanged(object sender, EventArgs e)
        {
            dateTimeInicio.Format = DateTimePickerFormat.Short;
            inicioCargado = true;

            // Siempre actualizar MinDate del final
            dateTimeFinal.MinDate = dateTimeInicio.Value;

            // Si la fecha final es anterior a la nueva fecha de inicio, ajustarla automáticamente
            if (dateTimeFinal.Value < dateTimeInicio.Value)
            {
                dateTimeFinal.Value = dateTimeInicio.Value;
                dateTimeFinal.Format = DateTimePickerFormat.Short;
                finalCargado = true;
            }

            if (inicioCargado && finalCargado)
            {
                await Task.Run(() => cargarDatosSeguro());
            }
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


        public void ActualizarSucursal(Sucursal nuevaSucursal)
        {
            this.numeroSucursal = nuevaSucursal.id;
            lbl_info.Text = nuevaSucursal.nombre;
        }

        private void dateTimeInicio_DropDown(object sender, EventArgs e)
        {
            if (!inicioCargado)
            {
                dateTimeInicio.Value = DateTime.Today; // Asignar temporalmente para evitar error
                dateTimeInicio.Format = DateTimePickerFormat.Short;
                dateTimeInicio.CustomFormat = "dd/MM/yyyy";
                inicioCargado = true;
            }
        }

        private void dateTimeFinal_DropDown(object sender, EventArgs e)
        {
            if (!finalCargado)
            {
                dateTimeFinal.Value = DateTime.Today;
                dateTimeFinal.Format = DateTimePickerFormat.Short;
                dateTimeFinal.CustomFormat = "dd/MM/yyyy";
                finalCargado = true;
            }
        }



    }
}
