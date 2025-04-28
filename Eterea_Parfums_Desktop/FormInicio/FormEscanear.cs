using System;
using System.Windows.Forms;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop
{
    public partial class FormEscanear : Form
    {
        private FormInicioAutoconsulta _inicioAutoConsultas;

        public FormEscanear(FormInicioAutoconsulta inicioAutoConsultas)
        {
            InitializeComponent();
            _inicioAutoConsultas = inicioAutoConsultas;
        }

        private void FormEscanear_Load(object sender, EventArgs e)
        {
            this.Activate();
            txt_codigo_barras.Focus(); // Solo setea el foco
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
                    _inicioAutoConsultas?.ResetAutoConsulta();
                };

                formDetalle.ShowDialog();
            }
            else
            {
                DialogResult resultado = MessageBox.Show(
                    "Código no encontrado.\n¿Desea intentar ingresarlo nuevamente?",
                    "Código no encontrado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    txt_codigo_barras.Clear();
                    txt_codigo_barras.Focus();
                }
                else
                {
                    this.Close();
                    _inicioAutoConsultas?.ResetAutoConsulta();
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            _inicioAutoConsultas?.ResetAutoConsulta();
            _inicioAutoConsultas?.PrepararParaNuevoEscaneo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Primero, cerrar el formulario de ingreso manual
            this.Close();

            // Luego, restaurar la UI en FormInicioAutoconsulta para que el botón "Escanear" esté disponible
            if (_inicioAutoConsultas != null)
            {
                _inicioAutoConsultas.PrepararParaNuevoEscaneo();
            }
        }
    }
}
