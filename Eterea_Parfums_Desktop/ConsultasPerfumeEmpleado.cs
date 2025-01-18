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
    public partial class ConsultasPerfumeEmpleado : Form
    {
        public ConsultasPerfumeEmpleado()
        {
            InitializeComponent();

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);

            txt_nombre_empleado.Text = Program.logueado.nombre + " " + Program.logueado.apellido;
            txt_numero_caja.Text = " ";
        }

        private void btn_facturacion_Click(object sender, EventArgs e)
        {
            Facturacion facturacion = new Facturacion();
            facturacion.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumeroDeCaja numeroDeCaja = new NumeroDeCaja();
            numeroDeCaja.Show();
            this.Close();
        }
    }
}
