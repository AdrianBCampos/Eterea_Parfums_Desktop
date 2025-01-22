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
        public string NumeroCaja { get; set; }

        public Facturacion()
        {
            InitializeComponent();
            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);           

            txt_nombre_empleado.Text = Program.logueado.nombre + " " + Program.logueado.apellido;
            
            lbl_dni_clienteE.Hide();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            txt_numero_caja.Text = NumeroCaja;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumeroDeCaja numeroDeCaja = new NumeroDeCaja();
            numeroDeCaja.Show();
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FormCrearClienteFactura formCrearClienteFactura = new FormCrearClienteFactura();
            formCrearClienteFactura.Show();
            this.Hide();
        }

        private void btn_consultas_Click(object sender, EventArgs e)
        {
            ConsultasPerfumeEmpleado consultasPerfumeEmpleado = new ConsultasPerfumeEmpleado();
            consultasPerfumeEmpleado.Show();
            this.Hide();
        }

        
    }
}
