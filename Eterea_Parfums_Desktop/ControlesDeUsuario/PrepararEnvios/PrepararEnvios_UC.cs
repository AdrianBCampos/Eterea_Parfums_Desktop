using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario.PrepararEnvios
{
    public partial class PrepararEnvios_UC : UserControl
    {
        public PrepararEnvios_UC()
        {
            InitializeComponent();

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);


            txt_nombre_empleado.Text = Program.logueado.nombre + " " + Program.logueado.apellido;
        }

        private void btn_consultas_Click(object sender, EventArgs e)
        {
            FormBuscarPedidos buscarPedidos = new FormBuscarPedidos();
            buscarPedidos.Show();
            
        }
    }
}
