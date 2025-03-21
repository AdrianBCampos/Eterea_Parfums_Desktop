using System;
using System.Windows.Forms;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop
{
    public partial class FormEscanear : Form
    {
        private FormInicioAutoconsulta _inicioAutoConsultas; // Referencia a InicioAutoConsulta

        private Timer timerEscaneo;
        private bool escaneoAutomatico = false;
        private DateTime ultimaEscritura; // Para medir el tiempo entre caracteres

        public FormEscanear(FormInicioAutoconsulta inicioAutoConsultas)
        {
            InitializeComponent();

            _inicioAutoConsultas = inicioAutoConsultas; // ✅ Guardar referencia del formulario principal

            // Configurar el Timer
            timerEscaneo = new Timer();
            timerEscaneo.Interval = 1000; // Ajusta según el lector
            timerEscaneo.Tick += TimerEscaneo_Tick;
        }

        private void FormEscanear_Load(object sender, EventArgs e)
        {
            // Activa el formulario y asigna el foco al TextBox
            this.Activate();
            txt_codigo_barras.Focus();
            
        }

       



        private void txt_codigo_barras_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_codigo_barras.Text))
            {
                ultimaEscritura = DateTime.Now; // Registra el tiempo de la última escritura
                timerEscaneo.Stop();
                timerEscaneo.Start(); // Reinicia el Timer para detectar si se ingresó rápido
            }
        }

        private void TimerEscaneo_Tick(object sender, EventArgs e)
        {
            timerEscaneo.Stop();

            // Si han pasado al menos 300 ms desde la última escritura, se considera que el código está completo
            if ((DateTime.Now - ultimaEscritura).TotalMilliseconds >= 1000)
            {
                escaneoAutomatico = true;
                // Prueba enviar "Enter" y si no funciona, llama directamente a KeyPress
                txt_codigo_barras.Focus();  // Asegurar que el TextBox tiene el foco
                try
                {
                    SendKeys.Send("{ENTER}");
                }
                catch
                {
                    // Si `SendKeys` no funciona, ejecutamos manualmente el evento KeyPress
                    txt_codigo_barras_KeyPress(txt_codigo_barras, new KeyPressEventArgs((char)Keys.Enter));
                }
            }
        }

        private void txt_codigo_barras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                ProcesarCodigoBarras(txt_codigo_barras.Text.Trim());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            _inicioAutoConsultas?.RestaurarUI();  // Restaurar UI
        }


        private void ProcesarCodigoBarras(string codigoBarras)
        {
            if (!string.IsNullOrEmpty(codigoBarras))
            {
                Perfume perfumeEncontrado = PerfumeControlador.getByCodigo(codigoBarras);

                if (perfumeEncontrado != null)
                {
                    FormVerDetallePerfume formDetalle = new FormVerDetallePerfume(perfumeEncontrado);

                    // ✅ Al cerrar `FormVerDetallePerfume`, cierra `FormEscanear` y restaura la UI en `FormInicioAutoconsulta`
                    formDetalle.FormClosed += (s, args) =>
                    {
                        this.Close();
                        RefrescarFormulario();
                    };
                    formDetalle.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Código no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_codigo_barras.Clear();
                    txt_codigo_barras.Focus();
                }
            }

            escaneoAutomatico = false;
        }



        private void RefrescarFormulario()
        {

            // ✅ Asegurar que la actualización de UI ocurre en el hilo principal
            if (_inicioAutoConsultas.InvokeRequired)
            {
                _inicioAutoConsultas.Invoke(new Action(() =>
                {
                    _inicioAutoConsultas.lbl_codigoBarras.Visible = false;  // Ocultar label
                    _inicioAutoConsultas.txt_scan.Visible = false;  // Ocultar TextBox
                    _inicioAutoConsultas.btn_escanear.Visible = true;  // Mostrar botón Escanear
                }));
            }
            else
            {
                _inicioAutoConsultas.lbl_codigoBarras.Visible = false;
                _inicioAutoConsultas.txt_scan.Visible = false;
                _inicioAutoConsultas.btn_escanear.Visible = true;
            }

            // ✅ Forzar la actualización inmediata de `FormInicioAutoconsulta`
            _inicioAutoConsultas.Refresh();
            Application.DoEvents();

            //this.Close(); // ✅ Cerrar `FormEscanear` después de actualizar la UI


        }
        }



    
}
