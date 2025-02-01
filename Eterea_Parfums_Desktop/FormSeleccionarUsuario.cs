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
    public partial class FormSeleccionarUsuario : Form
    {
        public string UsuarioSeleccionado { get; private set; }
        public FormSeleccionarUsuario()
        {
            InitializeComponent();

            // Cargar nombres de usuarios en el ComboBox
            comboBoxUsuarios.Items.Add("Adri");
            comboBoxUsuarios.Items.Add("Dami");
            comboBoxUsuarios.Items.Add("Luis");
            comboBoxUsuarios.Items.Add("Maxi");
            comboBoxUsuarios.Items.Add("Marino");

            comboBoxUsuarios.SelectedIndex = 0; // Seleccionar el primer usuario por defecto
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (comboBoxUsuarios.SelectedItem != null)
            {
                UsuarioSeleccionado = comboBoxUsuarios.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
