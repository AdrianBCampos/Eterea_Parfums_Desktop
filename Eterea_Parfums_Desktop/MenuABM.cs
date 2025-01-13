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
    public partial class MenuABM : Form
    {
        public MenuABM()
        {
            InitializeComponent();

            Clientes_UC clientes_UC = new Clientes_UC();
            addUserControl(clientes_UC);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicioAdministrador InicioAdministrador = new InicioAdministrador();
            InicioAdministrador.Show();
            this.Close();
        }


        }

        private void btn_empleados_Click(object sender, EventArgs e)
        {

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

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            InicioAdministrador InicioAdministrador = new InicioAdministrador();
            InicioAdministrador.Show();
            this.Close();
        }
    }
}
