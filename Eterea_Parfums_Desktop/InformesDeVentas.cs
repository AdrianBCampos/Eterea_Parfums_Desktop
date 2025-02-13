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
    public partial class InformesDeVentas : Form
    {
        public InformesDeVentas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicioAdministrador InicioAdministrador = new InicioAdministrador();
            InicioAdministrador.Show();
            this.Close();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            InformesDeVentas2 InformesDeVentas2 = new InformesDeVentas2();
            InformesDeVentas2.Show();
            this.Hide();
        }
    }
}
