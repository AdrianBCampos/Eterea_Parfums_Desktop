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

namespace Eterea_Parfums_Desktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuraio = txt_usuario.Text;
            string clave = txt_contraseña.Text;

            if (EmpleadoControlador.auth(usuraio, clave))
            {
                InicioAutoConsultas inicioAutoConsultas = new InicioAutoConsultas();
                inicioAutoConsultas.Show();
                this.Hide();
            }
                
        }
    }
}
