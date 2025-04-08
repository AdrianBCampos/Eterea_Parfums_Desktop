using Eterea_Parfums_Desktop.Controladores;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormListaDeEnvios : Form
    {
        public FormListaDeEnvios()
        {
            InitializeComponent();

            OrdenControlador controlador = new OrdenControlador();
            int cantidad = controlador.ObtenerCantidadOrdenesActivas();
            txt_cantidad_ordenes.Text = cantidad.ToString();

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);


            txt_nombre_empleado.Text = Program.logueado.nombre + " " + Program.logueado.apellido;

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
            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow orden in dtOrdenes.Rows)
            {
                int numeroOrden = Convert.ToInt32(orden["numero_de_orden"]);
                int numFactura = Convert.ToInt32(orden["num_factura"]);

                Label lblOrden = new Label
                {
                    Text = $"Orden Nº {numeroOrden} - Cliente: {orden["nombre_cliente"]} {orden["apellido_cliente"]} - Fecha: {Convert.ToDateTime(orden["fecha"]).ToShortDateString()}",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Padding = new Padding(5),
                    Margin = new Padding(5)
                };
                flowLayoutPanel1.Controls.Add(lblOrden);

                DataGridView dgvPerfumes = new DataGridView
                {
                    Width = flowLayoutPanel1.Width - 25,
                    Height = 150,
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                };

                DataTable dtPerfumes = controlador.ObtenerPerfumesDeFactura(numFactura);
               
                dgvPerfumes.DataSource = dtPerfumes;

                flowLayoutPanel1.Controls.Add(dgvPerfumes);
                flowLayoutPanel1.Controls.Add(new Label { Text = "", Height = 10 });
            }
        }

        private void FormListaDeEnvios_Load(object sender, EventArgs e)
        {
            CargarOrdenes();
        }



    }
}
