using System;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormSeleccionarInformeVenta : Form
    {
        public FormSeleccionarInformeVenta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInicioAdministrador InicioAdministrador = new FormInicioAdministrador();
            InicioAdministrador.Show();
            this.Close();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            FormInformesDeVentas1 InformesDeVentas2 = new FormInformesDeVentas1();
            InformesDeVentas2.Show();
            this.Hide();
        }
    }
}
