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

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);

            lbl_error_user.Visible = false;
            lbl_error_pass.Visible = false;
            lbl_error_auth.Visible = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            lbl_error_user.Visible = false;
            lbl_error_pass.Visible = false;
            lbl_error_auth.Visible = false;

            string usuraio = txt_usuario.Text;
            string clave = txt_contraseña.Text;


            if (!validarCampos())
            {
                if (EmpleadoControlador.auth(txt_usuario.Text, txt_contraseña.Text))//, true))
                {

                    if (Program.logueado.rol == "Admin")
                    {
                        InicioAdministrador InicioAdministrador = new InicioAdministrador();
                        InicioAdministrador.Show();
                        this.Hide();
                    }
                    else
                    {
                        InicioVendedor InicioVendedor = new InicioVendedor();
                        InicioVendedor.Show();
                        this.Hide();
                    }


                }
                else
                {
                    lbl_error_auth.Text = "El usuario o la contraseña están mal ingresados. Vuelva a intentar.";
                    lbl_error_auth.Visible = true;
                }
            }


            /*
            if (EmpleadoControlador.auth(usuraio, clave))
            {
                InicioAdministrador InicioAdministrador = new InicioAdministrador();
                InicioAdministrador.Show();
                this.Hide();
            }
            */
                
        }

        private bool validarCampos()
        {
            bool tieneError = false;
            //VALIDAR QUE AMBOS TEXTOS NO ESTEN VACIOS
            if (string.IsNullOrEmpty(txt_usuario.Text) & string.IsNullOrEmpty(txt_contraseña.Text))
            {
                lbl_error_user.Text = "Se debe ingresar un usuario.";
                lbl_error_user.Visible = true;
                lbl_error_pass.Text = "Se debe ingresar una contraseña.";
                lbl_error_pass.Visible = true;
                tieneError = true;
            }

            else if (string.IsNullOrEmpty(txt_usuario.Text))
            {
                lbl_error_user.Text = "Se debe ingresar un usuario.";
                lbl_error_user.Visible = true;
                tieneError = true;
            }
            else if (string.IsNullOrEmpty(txt_contraseña.Text))
            {
                lbl_error_pass.Text = "Se debe ingresar una contraseña.";
                lbl_error_pass.Visible = true;
                tieneError = true;
            }

            else
            {
                lbl_error_user.Visible = false;
            }
            return tieneError;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicioAutoConsultas inicio = new InicioAutoConsultas();
            inicio.Show();
            this.Close();
        }
    }
}
