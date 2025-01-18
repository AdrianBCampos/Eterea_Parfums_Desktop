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
    public partial class BuscarPedidos : Form
    {
        public BuscarPedidos()
        {
            InitializeComponent();

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicioVendedor InicioVendedor = new InicioVendedor();
            InicioVendedor.Show();
            this.Close();
        }

        private void btn_lista_envios_Click(object sender, EventArgs e)
        {
            ListaDeEnvios listaDeEnvios = new ListaDeEnvios();
            listaDeEnvios.Show();
            this.Close();
        }

        
    }
}
