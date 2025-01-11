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
    public partial class NumeroDeSucursal : Form
    {
        public NumeroDeSucursal()
        {
            InitializeComponent();

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicioAdministrador InicioAdministrador = new InicioAdministrador();
            InicioAdministrador.Show();
            this.Close();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Show();
            this.Hide();
        }
    }
}
