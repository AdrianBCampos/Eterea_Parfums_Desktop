using System.Windows.Forms;
using System.Drawing;

namespace Eterea_Parfums_Desktop
{
    public partial class FormFondoOscuro : Form
    {
        public static FormFondoOscuro Instance { get; private set; }

        public FormFondoOscuro()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            WindowState = FormWindowState.Maximized;
            BackColor = Color.Black;
            Opacity = 0.5;
            ShowInTaskbar = false;
            TopMost = false;
        }

        public static void Mostrar(Form owner)
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new FormFondoOscuro();
                Instance.Owner = owner;
                Instance.Show(owner);
            }
        }

        public static void Ocultar()
        {
            if (Instance != null && !Instance.IsDisposed)
            {
                Instance.Close();
                Instance = null;
            }
        }

        public static void EnviarAlFondo()
        {
            if (Instance != null && !Instance.IsDisposed)
            {
                Instance.SendToBack();
            }
        }
    }
}
