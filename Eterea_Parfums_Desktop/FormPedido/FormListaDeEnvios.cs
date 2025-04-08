using Eterea_Parfums_Desktop.Controladores;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormListaDeEnvios : Form
    {
        private string datosOrdenParaImprimir;
        private Bitmap qrBitmapParaImprimir;
        private string nombreSucursalActual;

        public FormListaDeEnvios()
        {
            InitializeComponent();

            OrdenControlador controlador = new OrdenControlador();
            int cantidad = controlador.ObtenerCantidadOrdenesActivas();
            txt_cantidad_ordenes.Text = cantidad.ToString();

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);


            txt_nombre_empleado.Text = Program.logueado.nombre + " " + Program.logueado.apellido;

            //SucursalControlador sucursalControlador = new SucursalControlador();
            nombreSucursalActual = SucursalControlador.ObtenerNombreSucursalPorId(Program.sucursal);

            this.Load += FormListaDeEnvios_Load;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInicioVendedor InicioVendedor = new FormInicioVendedor();
            InicioVendedor.Show();
            this.Close();
        }

        private void btn_consultas_Click(object sender, EventArgs e)
        {
            FormBuscarPedidos buscarPedidos = new FormBuscarPedidos();
            buscarPedidos.Show();
            this.Close();
        }


        private void CargarOrdenes()
        {
            OrdenControlador controlador = new OrdenControlador();

            DataTable dtOrdenes = controlador.ObtenerOrdenes();
            MessageBox.Show("Órdenes activas encontradas: " + dtOrdenes.Rows.Count);
            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow orden in dtOrdenes.Rows)
            {
                int numeroOrden = Convert.ToInt32(orden["numero_de_orden"]);
                int numFactura = Convert.ToInt32(orden["num_factura"]);

                Panel panelOrden = new Panel
                {
                    Width = flowLayoutPanel1.Width - 30,
                    Height = 250, // Aumentá un poco la altura para que entre el botón
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5)
                };

                Label lblOrden = new Label
                {
                    Text = $"Orden Nº {numeroOrden} - Cliente: {orden["nombre_cliente"]} {orden["apellido_cliente"]} - Fecha: {Convert.ToDateTime(orden["fecha"]).ToShortDateString()}",
                    Location = new Point(5, 5),
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    AutoSize = true
                };

                DataGridView dgvPerfumes = new DataGridView
                {
                    DataSource = controlador.ObtenerPerfumesDeFactura(numFactura),
                    Location = new Point(5, 30),
                    Width = panelOrden.Width - 10,
                    Height = 160,
                    ReadOnly = true,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false
                };

                // 🔽 BOTÓN "Imprimir Etiqueta"
                Button btnImprimir = new Button
                {
                    Text = "Imprimir Etiqueta",
                    Location = new Point(5, 195),
                    Width = 150,
                    Tag = numeroOrden
                };

                btnImprimir.Click += (s, e) =>
                {
                    var controladorInterno = new OrdenControlador();

                    string contenidoQR = $"Orden N° {numeroOrden}\n" +
                                         $"Cliente: {orden["nombre_cliente"]} {orden["apellido_cliente"]}\n" +
                                         $"DNI: {orden["dni"]}\n" +
                                         $"Email: {orden["e_mail_cliente"]}\n" +
                                         $"Domicilio: {orden["domicilio_de_envio"]}";

                    // 1. Guardar QR en base y desactivar orden
                    controladorInterno.GuardarQRyDesactivarOrden(numeroOrden, contenidoQR);

                    // 2. Generar QR
                    using (var qrGenerator = new QRCoder.QRCodeGenerator())
                    using (var qrData = qrGenerator.CreateQrCode(contenidoQR, QRCoder.QRCodeGenerator.ECCLevel.Q))
                    using (var qrCode = new QRCoder.QRCode(qrData))
                    {
                        qrBitmapParaImprimir = qrCode.GetGraphic(20);
                    }

                    // 3. Guardar datos en variable para impresión
                    datosOrdenParaImprimir = contenidoQR;

                    // 4. Imprimir
                    ImprimirOrden();

                    // 5. Refrescar pantalla
                    CargarOrdenes();
                };


                // Agregar controles al panel
                panelOrden.Controls.Add(lblOrden);
                panelOrden.Controls.Add(dgvPerfumes);
                panelOrden.Controls.Add(btnImprimir);

                // Agregar panel al FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(panelOrden);
            }
        }

        private void FormListaDeEnvios_Load(object sender, EventArgs e)
        {
            CargarOrdenes();
        }


        private void ImprimirOrden()
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintOrden_PrintPage);
            pd.Print();
        }

        private void PrintOrden_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = 50;
            float y = 50;

           
            string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // 🟡 Título principal
            Font tituloFont = new Font("Segoe UI", 16, FontStyle.Bold);
            e.Graphics.DrawString("ETIQUETA DE ENVÍO", tituloFont, Brushes.Black, x, y);

            y += 40;

            // 🔵 Número de orden destacado
            string numeroOrdenExtraido = datosOrdenParaImprimir.Split('\n')[0]; // "Orden N° XYZ"
            Font ordenFont = new Font("Segoe UI", 14, FontStyle.Bold);
            e.Graphics.DrawString(numeroOrdenExtraido, ordenFont, Brushes.Black, x, y);

            y += 40;

            // 🟢 Resto de los datos
            string[] lineas = datosOrdenParaImprimir.Split('\n');
            Font fontDatos = new Font("Segoe UI", 10);

            for (int i = 1; i < lineas.Length; i++)
            {
                e.Graphics.DrawString(lineas[i], fontDatos, Brushes.Black, x, y);
                y += 20;
            }

            // 🟣 Imagen QR
            if (qrBitmapParaImprimir != null)
            {
                y += 10;
                e.Graphics.DrawImage(qrBitmapParaImprimir, x, y, 150, 150);
                y += 160;
            }

            // 🔻 Línea inferior: fecha y sucursal
            Font fontPie = new Font("Segoe UI", 8, FontStyle.Italic);
            e.Graphics.DrawString($"Sucursal: {nombreSucursalActual}", fontPie, Brushes.Gray, x, y);
            e.Graphics.DrawString($"Impreso: {fechaHora}", fontPie, Brushes.Gray, x + 250, y); // A la derecha
        }





    }
}
