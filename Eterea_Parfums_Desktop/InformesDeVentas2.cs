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
    public partial class InformesDeVentas2 : Form
    {
        public InformesDeVentas2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InformesDeVentas informesDeVentas = new InformesDeVentas();
            informesDeVentas.Show();
            this.Close();
        }
    }
}
