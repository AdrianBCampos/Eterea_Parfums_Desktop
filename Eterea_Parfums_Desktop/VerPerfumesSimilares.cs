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
    public partial class VerPerfumesSimilares : Form
    {
        public VerPerfumesSimilares()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerDetallePerfume verDetallePerfume = new VerDetallePerfume();
            verDetallePerfume.Show();
            this.Close();
        }

        private void btn_ver_detalles_Click(object sender, EventArgs e)
        {
            VerDetallePerfume verDetallePerfume = new VerDetallePerfume();
            verDetallePerfume.Show();
            this.Close();     
        }
    }
}
