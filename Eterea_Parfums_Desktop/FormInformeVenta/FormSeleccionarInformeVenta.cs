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
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "FormInicioAutoconsulta") // Asegúrate de que el nombre sea correcto
                {
                    form.Show();
                    break;
                }
            }

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
