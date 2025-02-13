using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormInicioAdministrador : Form
    {
        // Declarar la instancia de ToolTip
        private ToolTip toolTip = new ToolTip();

        public FormInicioAdministrador()
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

        private void btn_administrar_stock_Click(object sender, EventArgs e)
        {
            FormNumeroDeSucursal numeroDeSucursal = new FormNumeroDeSucursal();
            numeroDeSucursal.Show();
            this.Hide();
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            FormNumeroDeCaja numeroDeCaja = new FormNumeroDeCaja();
            numeroDeCaja.Show();
            this.Hide();
        }

        private void btn_gestionar_Click(object sender, EventArgs e)
        {
            FormMenuABM menuABM = new FormMenuABM();
            menuABM.Show();
            this.Hide();
        }

        private void btn_generar_informes_Click(object sender, EventArgs e)
        {
            FormSeleccionarInformeVenta informesDeVentas = new FormSeleccionarInformeVenta();
            informesDeVentas.Show();
            this.Hide();
        }
    }
}