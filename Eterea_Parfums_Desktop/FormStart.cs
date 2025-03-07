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
    public partial class FormStart : Form
    {
        private BarcodeReceiver barcodeReceiver;
        public FormStart()
        {
            InitializeComponent();

            barcodeReceiver = new BarcodeReceiver();
            barcodeReceiver.StartServer(); // Inicia el servidor TCP

            this.KeyPreview = true;


        }


        private void InicioAutoConsultas_KeyDown_1(object sender, KeyEventArgs e)
        {
           

            // Detectar si se presionan las teclas Ctrl + X
            if (e.Control && e.KeyCode == Keys.X)
            {
                DialogResult result = MessageBox.Show(
                    "¿Está seguro que desea cerrar la aplicación?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            FormInicioAutoconsulta autoconsulta = new FormInicioAutoconsulta();
            autoconsulta.ShowDialog();
        }
    }
}
