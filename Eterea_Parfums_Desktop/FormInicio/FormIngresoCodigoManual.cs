using System;
using System.Windows.Forms;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop
{
    public partial class FormIngresoCodigoManual : Form
    {
        private Form _formInvocador;

        public FormIngresoCodigoManual(Form formInvocador)
        {
            InitializeComponent();
            _formInvocador = formInvocador;
        }

        private void FormEscanear_Load(object sender, EventArgs e)
        {
            this.Activate();
            txt_codigo_barras.Focus(); // Poner foco automáticamente
        }

        private void txt_codigo_barras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarCodigo();
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            BuscarCodigo();
        }

        private void BuscarCodigo()
        {
            string codigoBarras = txt_codigo_barras.Text.Trim();

            if (string.IsNullOrEmpty(codigoBarras))
            {
                MessageBox.Show("Ingrese un código de barras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_codigo_barras.Focus();
                return;
            }

            Perfume perfumeEncontrado = PerfumeControlador.getByCodigo(codigoBarras);

            if (perfumeEncontrado != null)
            {
                FormVerDetallePerfume formDetalle = new FormVerDetallePerfume(perfumeEncontrado);

                formDetalle.FormClosed += (s, args) =>
                {
                    this.Close();
                    var metodoReset = _formInvocador.GetType().GetMethod("ResetAutoConsulta");
                    metodoReset?.Invoke(_formInvocador, null);
                };

                formDetalle.ShowDialog();
            }
            else
            {
                // ❌ Código no encontrado, mostrar el FormCartelCodigoNoEncontrado
                FormCartelCodigoNoEncontrado cartel = new FormCartelCodigoNoEncontrado(_formInvocador);
                this.Close();
                cartel.ShowDialog();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            var metodoReset = _formInvocador.GetType().GetMethod("ResetAutoConsulta");
            metodoReset?.Invoke(_formInvocador, null);

            var metodoPreparar = _formInvocador.GetType().GetMethod("PrepararParaNuevoEscaneo");
            metodoPreparar?.Invoke(_formInvocador, null);

        }

        private void txt_codigo_barras_TextChanged(object sender, EventArgs e)
        {
            string codigoIngresado = txt_codigo_barras.Text.Trim();

            // Si tiene exactamente 13 caracteres, hacer la búsqueda automática
            if (codigoIngresado.Length == 13)
            {
                BuscarCodigo(codigoIngresado);
            }
        }

        private void BuscarCodigo(string codigo)
        {
            Perfume perfumeEncontrado = PerfumeControlador.getByCodigo(codigo);

            if (perfumeEncontrado != null)
            {
                // Si lo encuentra, mostrar el detalle
                FormVerDetallePerfume detalleForm = new FormVerDetallePerfume(perfumeEncontrado);
                detalleForm.FormClosed += (s, args) =>
                {
                    this.Close();
                    var metodoReset = _formInvocador.GetType().GetMethod("ResetAutoConsulta");
                    metodoReset?.Invoke(_formInvocador, null);
                };
                detalleForm.ShowDialog();
            }
            else
            {
                // ❌ Código no encontrado, mostrar el FormCartelCodigoNoEncontrado
                FormCartelCodigoNoEncontrado cartel = new FormCartelCodigoNoEncontrado(_formInvocador);
                this.Close();
                cartel.ShowDialog();
            }
        }



    }
}
