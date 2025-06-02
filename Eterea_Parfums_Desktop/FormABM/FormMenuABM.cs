using Eterea_Parfums_Desktop.ControlesDeUsuario;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormMenuABM : Form
    {
        public FormMenuABM()
        {
            InitializeComponent();

            this.Scale(new SizeF(Program.ScaleFactor, Program.ScaleFactor));

            Perfumes_UC perfumesUC = new Perfumes_UC();
            addUserControl(perfumesUC);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInicioAdministrador InicioAdministrador = new FormInicioAdministrador();
            InicioAdministrador.Show();
            this.Close();
        }

        private void btn_perfumes_Click(object sender, EventArgs e)
        {
            Perfumes_UC perfumesUC = new Perfumes_UC();
            addUserControl(perfumesUC);
        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {
            // FormEditarEmpleado formEmpleado = new FormEditarEmpleado();
            // formEmpleado.Show();
            Empleados_UC empleados_UC = new Empleados_UC();
            addUserControl(empleados_UC);
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Clientes_UC clientes_UC = new Clientes_UC();
            addUserControl(clientes_UC);
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_abm.Controls.Clear();
            panel_abm.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_promociones_Click(object sender, EventArgs e)
        {
            Promos_UC promos_UC = new Promos_UC();
            addUserControl(promos_UC);

           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormInicioAdministrador InicioAdministrador = new FormInicioAdministrador();
            InicioAdministrador.Show();
            this.Close();
        }
    }
}
