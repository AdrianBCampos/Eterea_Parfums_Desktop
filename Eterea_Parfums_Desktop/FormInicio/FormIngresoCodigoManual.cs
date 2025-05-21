using System;
using System.Windows.Forms;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Helpers;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop
{
    public partial class FormIngresoCodigoManual : Form
    {
        private Form _formInvocador;

        private Perfume _perfumeParaVer;


        public FormIngresoCodigoManual(Form formInvocador)
        {
            InitializeComponent();
            _formInvocador = formInvocador;

            this.FormClosed += FormIngresoCodigoManual_FormClosed;
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
                _perfumeParaVer = perfumeEncontrado;
                this.Close(); // NO mostrar acá el detalle
            }
            else
            {
                this.Close();
                FormCartelCodigoNoEncontrado cartel = new FormCartelCodigoNoEncontrado(_formInvocador);
                ModalHelper.MostrarModalSinAgregarNuevoFondo(cartel);
            }
        }

        private void FormIngresoCodigoManual_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_perfumeParaVer != null)
            {
                FormVerDetallePerfume detalle = new FormVerDetallePerfume(_perfumeParaVer);

                ModalHelper.MostrarModalSinAgregarNuevoFondo(detalle);

                var metodoReset = _formInvocador.GetType().GetMethod("ResetAutoConsulta");
                metodoReset?.Invoke(_formInvocador, null);
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
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese un código de barras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Perfume perfumeEncontrado = PerfumeControlador.getByCodigo(codigo);

            if (perfumeEncontrado != null)
            {
                _perfumeParaVer = perfumeEncontrado;
                this.Close(); // NO mostrar nada acá
            }
            else
            {
                this.Close(); // Cerramos primero

                FormCartelCodigoNoEncontrado cartel = new FormCartelCodigoNoEncontrado(_formInvocador);
                ModalHelper.MostrarModalSinAgregarNuevoFondo(cartel);
            }
        }




    }
}
