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
    public partial class NumeroDeCaja : Form
    {
        // Declarar el evento personalizado ConfirmarNumeroCaja
        public event EventHandler<string> ConfirmarNumeroCaja;

        // Declaro una propiedad para almacenar el valor del número de caja
        public string NumeroCaja { get; private set; }

        public NumeroDeCaja()
        {
            InitializeComponent();
            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);

            lbl_error_caja.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Program.logueado.rol == "admin")
            {
                InicioAdministrador InicioAdministrador = new InicioAdministrador();
                InicioAdministrador.Show();
                this.Close();
            }
            else
            {
                InicioVendedor InicioVendedor = new InicioVendedor();
                InicioVendedor.Show();
                this.Close();
            }
        }



        private void btn_continuar_Click(object sender, EventArgs e)
        {
            // Obtengo el valor ingresado en el txt_ingNumCaja
            string numCaja = txt_numero_caja.Text;

            // Verifico si el valor ingresado es un número válido
            if (!string.IsNullOrWhiteSpace(numCaja) && int.TryParse(numCaja, out int numeroValido))
            {
                // Asigno el valor del número de caja a la propiedad NumeroCaja
                NumeroCaja = numCaja;

                // Invocar el evento ConfirmarNumeroCaja con el número de caja confirmado
                ConfirmarNumeroCaja?.Invoke(this, NumeroCaja);
                Facturacion facturacion = new Facturacion();
                facturacion.Show();

                // Cierro este formulario
                this.Close();
                
          
            }
            else
            {
                // Muestra un mensaje de error si el valor ingresado no es un número válido
                
                lbl_error_caja.Text = "Por favor, ingresa un número de caja válido.";
                lbl_error_caja.Visible = true;

                // Limpia el contenido del TextBox
                txt_numero_caja.Text = string.Empty;

                // (Opcional) Coloca el foco de vuelta en el TextBox
                txt_numero_caja.Focus();
            }
        }

      
    }
}
