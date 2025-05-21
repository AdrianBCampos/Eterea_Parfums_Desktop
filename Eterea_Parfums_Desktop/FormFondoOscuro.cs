using System.Windows.Forms;
using System.Drawing;

namespace Eterea_Parfums_Desktop
{
    public partial class FormFondoOscuro : Form
    {
        private static FormFondoOscuro _instancia;
        private static int _contadorFormularios = 0;

        public FormFondoOscuro()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.Black;
            this.Opacity = 0.5;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        public static void Mostrar(Form owner)
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new FormFondoOscuro();

                // Solo asignamos Owner si hay uno válido
                if (owner != null)
                {
                    _instancia.Owner = owner;
                }

                _instancia.Show(); // ❌ No usar Show(owner)
            }

            _contadorFormularios++;
        }

        public static void Ocultar()
        {
            _contadorFormularios--;

            if (_contadorFormularios <= 0 && _instancia != null && !_instancia.IsDisposed)
            {
                _instancia.Close();
                _instancia = null;
                _contadorFormularios = 0;
            }
        }

        public static void EnviarAlFondo()
        {
            if (_instancia != null && !_instancia.IsDisposed)
            {
                _instancia.TopMost = false;
                _instancia.SendToBack();
            }
        }


    }
}
