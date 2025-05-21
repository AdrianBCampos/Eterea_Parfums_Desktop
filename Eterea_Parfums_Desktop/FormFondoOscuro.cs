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
    public partial class FormFondoOscuro : Form
    {
        public FormFondoOscuro()
        {
            InitializeComponent(); // solo si estás usando el diseñador
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.Black;
            this.Opacity = 0.5;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
    }

}
