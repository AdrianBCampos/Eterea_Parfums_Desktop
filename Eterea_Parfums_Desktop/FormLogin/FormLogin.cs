using Eterea_Parfums_Desktop.Controladores;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            string rutaCompletaImagen = Program.Ruta_Base + @"Diseño Logo1.png";
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

                    if (Program.logueado.rol == "admin")
                    {
                        FormInicioAdministrador InicioAdministrador = new FormInicioAdministrador();
                        InicioAdministrador.Show();
                        this.Hide();
                    }
                    else
                    {
                        FormInicioVendedor InicioVendedor = new FormInicioVendedor();
                        InicioVendedor.Show();
                        this.Hide();
                    }


                }
                else
                {
                    lbl_error_auth.Text = "El usuario o la contraseña están mal ingresados.";
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
            FormInicioAutoconsulta inicio = new FormInicioAutoconsulta();
            inicio.Show();
            this.Close();
        }
    }
}
