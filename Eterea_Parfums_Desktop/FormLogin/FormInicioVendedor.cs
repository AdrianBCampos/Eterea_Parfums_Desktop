using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormInicioVendedor : Form
    {
        // Declarar la instancia de ToolTip
        private ToolTip toolTip = new ToolTip();

        public FormInicioVendedor()
        {
            InitializeComponent();

            // Configurar las imágenes
            string rutaLogo = Program.Ruta_Base + @"Diseño Logo1.png";
            img_logo.Image = Image.FromFile(rutaLogo);

            string rutaCerrarSesion = Program.Ruta_Base + @"CerrarSesion.png";
            btn_cerrar_sesion.Image = Image.FromFile(rutaCerrarSesion);

            // Configurar el saludo
            txt_saludo.Text = Program.logueado.nombre + " " + Program.logueado.apellido;

            // Configurar el ToolTip para el botón de cerrar sesión
            toolTip.SetToolTip(btn_cerrar_sesion, "Cerrar sesión");
        }

        internal static bool HayOrdenesActivas()
        {
            OrdenControlador controlador = new OrdenControlador();
            return controlador.ObtenerCantidadOrdenesActivas() > 0;
        }


        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            Program.logueado = new Empleado();
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            FormNumeroDeCaja numeroDeCaja = new FormNumeroDeCaja();
            numeroDeCaja.Show();
            this.Hide();

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "FormInicioAutoconsulta") // Asegúrate de que el nombre sea correcto
                {
                    form.Hide();
                    break;
                }
            }
        }

        private void btn_gestionar_Click(object sender, EventArgs e)
        {
            if (HayOrdenesActivas())
            {
                FormListaDeEnvios listaDeEnvios = new FormListaDeEnvios();
                listaDeEnvios.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("En este momento no hay órdenes activas para despachar.", "Sin órdenes activas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_buscar_envios_Click(object sender, EventArgs e)
        {
            FormBuscarPedidos buscar = new FormBuscarPedidos();
            buscar.Show(); // o buscar.ShowDialog();
            this.Hide();
        }
    }
}