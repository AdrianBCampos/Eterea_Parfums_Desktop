using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormListaDeEnvios : Form
    {
        public FormListaDeEnvios()
        {
            InitializeComponent();

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);


            txt_nombre_empleado.Text = Program.logueado.nombre + " " + Program.logueado.apellido;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInicioVendedor InicioVendedor = new FormInicioVendedor();
            InicioVendedor.Show();
            this.Close();
        }

        private void btn_consultas_Click(object sender, EventArgs e)
        {
            FormBuscarPedidos buscarPedidos = new FormBuscarPedidos();
            buscarPedidos.Show();
            this.Close();
        }


    }
}
