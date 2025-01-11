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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);

            
            txt_nombre_empleado.Text = Program.logueado.nombre + " " + Program.logueado.apellido;
            txt_numero_caja.Text = " ";
        }

        // Método para manejar el evento ConfirmarNumeroCaja
        private void ConfirmarNumeroCajaHandler(object sender, string numeroCaja)
        {
            // Asignar el número de caja al campo txt_numero_caja en FormVentas
            txt_numero_caja.Text = numeroCaja;

            // Mostrar FormVentas
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumeroDeCaja numeroDeCaja = new NumeroDeCaja();
            numeroDeCaja.Show();
            this.Hide();
        }
    }
}
