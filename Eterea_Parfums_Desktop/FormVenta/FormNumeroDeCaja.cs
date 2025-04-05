using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.ControlesDeUsuario;
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

        public bool AutoTomarCaja { get; set; } = true;



        public FormNumeroDeCaja()
        {
            InitializeComponent();
            

            lbl_error_caja.Visible = false;

            // Obtener y mostrar el nombre de la sucursal en el label
            txt_nombre_suc.Text = SucursalControlador.ObtenerNombreSucursalPorId(Program.sucursal);

        }




        private void FormNumeroDeCaja_Load(object sender, EventArgs e)
        {
            try
            {
                if (!AutoTomarCaja)
                {
                    // No hacer nada, solo mostrar pantalla con input de número de caja o botón
                    txt_ing_numero_caja.Visible = true;
                    lbl_error_caja.Visible = false;
                    return;
                }

                int? cajaDisponible = CajaControlador.ObtenerUnicaCajaDisponibleEnSucursal(Program.sucursal);

                if (cajaDisponible.HasValue)
                {
                    if (CajaControlador.MarcarCajaComoNoDisponible(cajaDisponible.Value, Program.sucursal))
                    {
                        NumeroCaja = cajaDisponible.Value.ToString();
                        ConfirmarNumeroCaja?.Invoke(this, NumeroCaja);

                        Facturar_UC facturacion = new Facturar_UC();
                        facturacion.NumeroCaja = NumeroCaja;
                        facturacion.IdHistorialCaja = CajaControlador.RegistrarAperturaDeCaja(Convert.ToInt32(NumeroCaja), Program.sucursal, Program.logueado.usuario);
                        facturacion.Show();

                        this.BeginInvoke(new Action(() => this.Close()));
                    }
                    else
                    {
                        lbl_error_caja.Text = "La caja ya fue tomada por otro usuario. Intente con otra.";
                        lbl_error_caja.Visible = true;
                    }
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
            string numCaja = txt_ing_numero_caja.Text;

            if (!string.IsNullOrWhiteSpace(numCaja) && int.TryParse(numCaja, out int numeroCaja))
            {
                // Intentamos marcar la caja como no disponible atómicamente
                if (CajaControlador.MarcarCajaComoNoDisponible(numeroCaja, Program.sucursal))
                {
                    NumeroCaja = numCaja;
                    ConfirmarNumeroCaja?.Invoke(this, NumeroCaja);

                    Facturar_UC facturacion = new Facturar_UC();
                    facturacion.NumeroCaja = numCaja;
                    facturacion.IdHistorialCaja = CajaControlador.RegistrarAperturaDeCaja(Convert.ToInt32(numCaja), Program.sucursal, Program.logueado.usuario);
                    facturacion.RecargarPantalla();

                    this.Close();
                }
                else
                {
                    lbl_error_caja.Text = "La caja ya fue tomada por otro usuario o no está disponible.";
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
