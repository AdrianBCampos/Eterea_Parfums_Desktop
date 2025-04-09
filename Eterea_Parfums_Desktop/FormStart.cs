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

            lbl_escala.Visible = false;
            comboEscala.Visible = false;

            comboEscala.Items.AddRange(new object[] {
                "100%", "90%", "80%", "70%", "60%"
            });
            comboEscala.SelectedItem = "100%"; // Valor por defecto
            comboEscala.SelectedIndexChanged += ComboEscala_SelectedIndexChanged;



            barcodeReceiver = new BarcodeReceiver();
            barcodeReceiver.StartServer(); // Inicia el servidor TCP

            this.KeyPreview = true;

            //this.Load += FormStart_Load; // Suscribir el evento Load al método FormStart_Load

        }

        private void ComboEscala_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = comboEscala.SelectedItem.ToString().Replace("%", "");
            if (float.TryParse(seleccion, out float porcentaje))
            {
                Program.ScaleFactor = porcentaje / 100f;
                MessageBox.Show($"Factor de escala configurado en {Program.ScaleFactor}", "Escala configurada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

            btn_start.Hide();
            FormInicioAutoconsulta formInicioAutoconsulta = new FormInicioAutoconsulta();
            formInicioAutoconsulta.ShowDialog();
            btn_start.Visible = false;
            btn_escalar.Visible = false;
            lbl_escala.Visible = false;
            comboEscala.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_escalar.Visible = false;
            lbl_escala.Visible = true;
            comboEscala.Visible = true;
        }









        /* private void FormStart_Load(object sender, EventArgs e)
          {
              // Llamar al método para abrir FormInicioAutoconsulta automáticamente
              AbrirFormInicioAutoconsulta();
          }

          public void AbrirFormInicioAutoconsulta()
          {
              // Buscar si FormInicioAutoconsulta ya está abierto
              FormInicioAutoconsulta formAutoconsulta = Application.OpenForms.OfType<FormInicioAutoconsulta>().FirstOrDefault();

              if (formAutoconsulta != null)
              {
                  formAutoconsulta.Show();
                  formAutoconsulta.BringToFront(); // Lo trae al frente
                  formAutoconsulta.Activate(); // Hace que sea la ventana activa
              }
              else
              {
                  formAutoconsulta = new FormInicioAutoconsulta();
                  formAutoconsulta.Owner = this; // Asegura que FormStart sea el "dueño"
                  formAutoconsulta.Show();
                  formAutoconsulta.Activate();
              }

              // **Deshabilitar FormStart para que no reciba clics ni interacciones**
              this.Enabled = false;
          }*/




    }
}