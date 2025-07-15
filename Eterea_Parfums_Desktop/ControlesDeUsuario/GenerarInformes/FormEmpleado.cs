using Eterea_Parfums_Desktop.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario.GenerarInformes
{
    public partial class FormEmpleado : Form
    {
        public FormEmpleado(string usuario)
        {
            InitializeComponent();
            CargarDatosEmpleado(usuario);
        }

        private void CargarDatosEmpleado(string usuario)
        {
            var empleado = EmpleadoControlador.GetEmpleadoPorUsuario(usuario);
            if (empleado == null)
            {
                MessageBox.Show("No se encontró el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lbl_legajo.Text = empleado.Id.ToString("D6"); // formato 000123
            lbl_nombre.Text = empleado.Nombre;
            lbl_apellido.Text = empleado.Apellido;
            lbl_dni.Text = empleado.Dni;
            lbl_mail.Text = empleado.Email;
            lbl_sucursal.Text = empleado.SucursalNombre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
