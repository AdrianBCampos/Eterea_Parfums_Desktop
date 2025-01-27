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
    public partial class VerPromociones : Form
    {
        public VerPromociones()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_perfumes_simi_Click(object sender, EventArgs e)
        {
            VerPerfumesSimilares verPerfumesSimilares = new VerPerfumesSimilares();
            verPerfumesSimilares.Show();
            this.Close();
        }
    }
}
