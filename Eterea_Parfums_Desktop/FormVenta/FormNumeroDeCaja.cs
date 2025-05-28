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

            txt_ing_numero_caja.KeyDown += Txt_ing_numero_caja_KeyDown; // Se asigna el evento

            this.Shown += FormNumeroDeCaja_Shown; // 🔥 Nuevo evento

        }




        /* private void FormNumeroDeCaja_Load(object sender, EventArgs e)
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

                         FormFacturacion facturacion = new FormFacturacion();
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
         }*/

        private void FormNumeroDeCaja_Load(object sender, EventArgs e)
        {
            try
            {
                if (!AutoTomarCaja)
                {
                    txt_ing_numero_caja.Visible = true;
                    lbl_error_caja.Visible = false;
                    txt_ing_numero_caja.Focus();  // 🔥 Establecer foco aquí
                    return;
                }

                int? cajaDisponible = CajaControlador.ObtenerUnicaCajaDisponibleEnSucursal(Program.sucursal);

                if (cajaDisponible.HasValue)
                {
                    if (CajaControlador.MarcarCajaComoNoDisponible(cajaDisponible.Value, Program.sucursal))
                    {
                        NumeroCaja = cajaDisponible.Value.ToString();

                        Program.NumeroCajaActual = NumeroCaja;
                        Program.IdHistorialCajaActual = CajaControlador.RegistrarAperturaDeCaja(
                            Convert.ToInt32(NumeroCaja), Program.sucursal, Program.logueado.usuario);

                        ConfirmarNumeroCaja?.Invoke(this, NumeroCaja);
                        this.Close(); // Cerrar el form
                    }
                    else
                    {
                        lbl_error_caja.Text = "La caja ya fue tomada por otro usuario. Intente con otra.";
                        lbl_error_caja.Visible = true;
                        txt_ing_numero_caja.Focus();  // 🔥 Establecer foco aquí si ocurre error
                    }
                }
                else
                {
                    txt_ing_numero_caja.Visible = true;
                    lbl_error_caja.Visible = false;
                    txt_ing_numero_caja.Focus();  // 🔥 Establecer foco aquí
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Load: " + ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {                
            this.Close(); // Cierra FormNumeroDeCaja
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

                    // Solo registrar si aún no hay una caja asignada globalmente
                    if (Program.NumeroCajaActual == "Caja sin asignar")
                    {
                        Program.NumeroCajaActual = NumeroCaja;
                        Program.IdHistorialCajaActual = CajaControlador.RegistrarAperturaDeCaja(
                            Convert.ToInt32(NumeroCaja), Program.sucursal, Program.logueado.usuario
                        );
                    }

                    ConfirmarNumeroCaja?.Invoke(this, NumeroCaja);
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

        private void Txt_ing_numero_caja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de beep
                btn_continuar.PerformClick(); // Simula el click del botón confirmar
            }
        }

        private void FormNumeroDeCaja_Shown(object sender, EventArgs e)
        {
            if (txt_ing_numero_caja.Visible && txt_ing_numero_caja.Enabled)
            {
                txt_ing_numero_caja.Focus(); // 🔥 Ahora sí el foco se establece correctamente
            }
        }




    }
}
