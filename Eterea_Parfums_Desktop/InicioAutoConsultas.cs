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
    public partial class InicioAutoConsultas : Form
    {
        

        public InicioAutoConsultas()
        {
            InitializeComponent();

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);

        }

        private void btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();  
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_escanear_Click(object sender, EventArgs e)
        {
            Escanear escanear = new Escanear();
            escanear.Show();
            this.Hide();
        }

        private void btn_ver_detalles_Click(object sender, EventArgs e)
        {
            VerDetallePerfume verDetallePerfume = new VerDetallePerfume();
            verDetallePerfume.Show();
            this.Hide();
        }
    }
}
