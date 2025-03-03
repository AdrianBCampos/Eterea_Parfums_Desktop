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
            if (txt_tipo_informe.SelectedIndex == 0)
            {
                FormInformesDeVentas1 InformesDeVentas1 = new FormInformesDeVentas1();
                InformesDeVentas1.Show();
                this.Hide();
            }
            else if (txt_tipo_informe.SelectedIndex == 1)
            {
                FormInformesDeVentas2 InformesDeVentas2 = new FormInformesDeVentas2();
                InformesDeVentas2.Show();
                this.Hide();
            }
        }
    }
}
