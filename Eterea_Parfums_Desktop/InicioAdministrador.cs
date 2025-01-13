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
    public partial class InicioAdministrador : Form
    {
        public InicioAdministrador()
        {
            InitializeComponent();

            string rutaLogo = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaLogo);

            string rutaCerrarSesion = Program.Ruta_Base + @"CerrarSesion.png";
            btn_cerrar_sesion.Image = Image.FromFile(rutaCerrarSesion);

            txt_saludo.Text = Program.logueado.nombre + " " + Program.logueado.apellido;
        }

        

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            Program.logueado = new Empleado();
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btn_administrar_stock_Click(object sender, EventArgs e)
        {
            NumeroDeSucursal numeroDeSucursal = new NumeroDeSucursal();
            numeroDeSucursal.Show();
            this.Hide();
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            NumeroDeCaja numeroDeCaja = new NumeroDeCaja();
            numeroDeCaja.Show();
            this.Hide();
        }

        private void btn_gestionar_Click(object sender, EventArgs e)
        {
            MenuABM menuABM = new MenuABM();
            menuABM.Show();
            this.Hide();
        }

        private void btn_generar_informes_Click(object sender, EventArgs e)
        {
            InformesDeVentas informesDeVentas = new InformesDeVentas();
            informesDeVentas.Show();
            this.Hide();
        }
    }
}
