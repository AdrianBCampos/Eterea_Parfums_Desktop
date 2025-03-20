using Eterea_Parfums_Desktop.Controladores;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
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
                if (EmpleadoControlador.auth(txt_usuario.Text, txt_contraseña.Text))
                {
                    // Obtener la referencia de FormStart y FormInicioAutoconsulta
                    FormStart formStart = Application.OpenForms.OfType<FormStart>().FirstOrDefault();
                    FormInicioAutoconsulta formAutoconsulta = Application.OpenForms.OfType<FormInicioAutoconsulta>().FirstOrDefault();

                    // Ocultar FormInicioAutoconsulta correctamente
                    if (formAutoconsulta != null)
                    {
                        formAutoconsulta.Hide();
                        formAutoconsulta.SendToBack(); // Asegura que no reaparezca en primer plano
                    }

                    // Determinar el formulario a abrir según el rol del usuario
                    Form nuevoFormulario = null;
                    if (Program.logueado.rol == "admin")
                    {
                        nuevoFormulario = new FormInicioAdministrador();
                    }
                    else if (Program.logueado.rol == "vendedor")
                    {
                        nuevoFormulario = new FormInicioVendedor();
                    }

                    if (nuevoFormulario != null && formStart != null)
                    {
                        // Asegurar que FormStart sea el dueño del nuevo formulario
                        nuevoFormulario.Owner = formStart;
                        nuevoFormulario.Show(); // Mostrar sin bloquear

                        // Forzar que el nuevo formulario esté al frente
                        nuevoFormulario.BringToFront();
                        nuevoFormulario.Activate(); // Asegura que reciba el foco
                        nuevoFormulario.TopMost = true;
                        nuevoFormulario.TopMost = false; // Restaurar estado normal después

                        // Cerrar el formulario actual (login)
                        this.Close();


                    }
                }
                else
                {
                    lbl_error_auth.Text = "El usuario o la contraseña están mal ingresados.";
                    lbl_error_auth.Visible = true;
                }
            }

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

        private void close_Click(object sender, EventArgs e)
        {
            FormInicioAutoconsulta inicioAutoconsulta = null;
            FormStart formStart = null;

            // Buscar FormInicioAutoconsulta y FormStart en Application.OpenForms
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormInicioAutoconsulta)
                {
                    inicioAutoconsulta = (FormInicioAutoconsulta)form;
                }
                if (form is FormStart)
                {
                    formStart = (FormStart)form;
                }
            }

            // Si FormInicioAutoconsulta ya está abierto, asegurarse de que esté visible y en primer plano
            if (inicioAutoconsulta != null)
            {
                if (!inicioAutoconsulta.IsHandleCreated)
                {
                    inicioAutoconsulta.CreateControl(); // Asegurar que el identificador de ventana está creado
                }

                inicioAutoconsulta.Show();
                inicioAutoconsulta.WindowState = FormWindowState.Normal; // Restaurar si estaba minimizado
                inicioAutoconsulta.TopMost = true;  // Forzar que quede sobre FormStart
                inicioAutoconsulta.BringToFront();   // Asegurar que quede sobre FormStart
                inicioAutoconsulta.Activate();       // Darle foco
                inicioAutoconsulta.TopMost = false;  // Restaurar el estado normal de TopMost
            }
            else
            {
                // Si FormInicioAutoconsulta no está en la lista, crear una nueva instancia
                inicioAutoconsulta = new FormInicioAutoconsulta();
                inicioAutoconsulta.Show();
                inicioAutoconsulta.TopMost = true;  // Forzar que quede sobre FormStart
                inicioAutoconsulta.BringToFront();
                inicioAutoconsulta.Activate();
                inicioAutoconsulta.TopMost = false; // Restaurar el estado normal de TopMost
            }

            // Asegurar que FormStart sigue abierto pero en el fondo
            if (formStart != null)
            {
                formStart.Show();
                formStart.SendToBack(); // Mantener FormStart en el fondo
            }

            // Ocultar primero FormLogin antes de cerrarlo
            this.Hide();

            // Cerrar el FormLogin con un pequeño retraso para asegurar que el otro formulario se muestra bien
            Task.Delay(100).ContinueWith(_ => this.Close(), TaskScheduler.FromCurrentSynchronizationContext());
        }


    }
}
