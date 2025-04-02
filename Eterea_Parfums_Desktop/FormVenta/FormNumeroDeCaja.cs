using Eterea_Parfums_Desktop.Controladores;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormNumeroDeCaja : Form
    {
        // Declarar el evento personalizado ConfirmarNumeroCaja
        public event EventHandler<string> ConfirmarNumeroCaja;

        // Declaro una propiedad para almacenar el valor del número de caja
        public string NumeroCaja { get; private set; }

        public FormNumeroDeCaja()
        {
            InitializeComponent();
            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);

            lbl_error_caja.Visible = false;

            // Obtener y mostrar el nombre de la sucursal en el label
            txt_nombre_suc.Text = SucursalControlador.ObtenerNombreSucursalPorId(Program.sucursal);

        }




        private void FormNumeroDeCaja_Load(object sender, EventArgs e)
        {
            try
            {
                int? cajaDisponible = CajaControlador.ObtenerUnicaCajaDisponibleEnSucursal(Program.sucursal);

                if (cajaDisponible.HasValue)
                {
                    NumeroCaja = cajaDisponible.Value.ToString();
                    ConfirmarNumeroCaja?.Invoke(this, NumeroCaja);

                    FormFacturacion facturacion = new FormFacturacion();
                    facturacion.NumeroCaja = NumeroCaja;
                    facturacion.Show();

                    // Cerramos el formulario después de que termine de cargarse completamente
                    this.BeginInvoke(new Action(() => this.Close()));
                }
                else
                {
                    txt_ing_numero_caja.Visible = true;
                    lbl_error_caja.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Load: " + ex.Message);
            }
        }










        private void button2_Click(object sender, EventArgs e)
        {

            if (Program.logueado.rol == "admin")
            {
                // Buscar si ya existe una instancia de FormInicioAdministrador
                FormInicioAdministrador inicioAdmin = Application.OpenForms.OfType<FormInicioAdministrador>().FirstOrDefault();

                if (inicioAdmin != null)
                {
                    inicioAdmin.Show();
                    inicioAdmin.BringToFront();
                }
                else
                {
                    inicioAdmin = new FormInicioAdministrador();
                    inicioAdmin.Show();
                }

                this.Close(); // Cierra el formulario actual (login)
            }
            else
            {
                // Buscar si ya existe una instancia de FormInicioVendedor
                FormInicioVendedor inicioVendedor = Application.OpenForms.OfType<FormInicioVendedor>().FirstOrDefault();

                if (inicioVendedor != null)
                {
                    inicioVendedor.Show();
                    inicioVendedor.BringToFront();
                }
                else
                {
                    inicioVendedor = new FormInicioVendedor();
                    inicioVendedor.Show();
                }

                this.Close(); // Cierra el formulario actual (login)
            }
        }



        private void btn_continuar_Click(object sender, EventArgs e)
        {
            // Obtengo el valor ingresado en el txt_ing_numero_caja
            string numCaja = txt_ing_numero_caja.Text;

            // Verifico si el valor ingresado es un número válido
            if (!string.IsNullOrWhiteSpace(numCaja) && int.TryParse(numCaja, out int numeroCaja))
            {
                // Validar existencia y disponibilidad de la caja
                if (CajaControlador.CajaDisponibleEnSucursal(numeroCaja, Program.sucursal))
                {
                    NumeroCaja = numCaja;

                    ConfirmarNumeroCaja?.Invoke(this, NumeroCaja);

                    FormFacturacion facturacion = new FormFacturacion();
                    facturacion.NumeroCaja = numCaja;
                    facturacion.Show();
                    this.Close();
                }
                else
                {
                    lbl_error_caja.Text = "La caja no existe en esta sucursal o no está disponible.";
                    lbl_error_caja.Visible = true;
                    txt_ing_numero_caja.Clear();
                    txt_ing_numero_caja.Focus();
                }
            }
            else
            {
                lbl_error_caja.Text = "Por favor, ingresa un número de caja válido.";
                lbl_error_caja.Visible = true;
                txt_ing_numero_caja.Clear();
                txt_ing_numero_caja.Focus();
            }
        }


       




    }
}
