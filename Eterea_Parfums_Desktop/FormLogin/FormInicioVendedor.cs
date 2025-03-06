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
        }

        private void btn_gestionar_Click(object sender, EventArgs e)
        {
            FormListaDeEnvios listaDeEnvios = new FormListaDeEnvios();
            listaDeEnvios.Show();
            this.Hide();
        }
    }
}