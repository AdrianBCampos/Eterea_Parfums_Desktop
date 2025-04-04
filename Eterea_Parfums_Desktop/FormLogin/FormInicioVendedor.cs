using Eterea_Parfums_Desktop.ControlesDeUsuario;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormInicioVendedor : Form
    {
        // Declarar la instancia de ToolTip
        private ToolTip toolTip = new ToolTip();

        // Variable para almacenar el botón previamente seleccionado
        private Button botonAnterior;

        public FormInicioVendedor()
        {
            InitializeComponent();

            // Configurar las imágenes
            string rutaLogo = Program.Ruta_Base + @"Diseño Logo1.png";
            img_logo.Image = Image.FromFile(rutaLogo);

            string rutaCerrarSesion = Program.Ruta_Base + @"CerrarSesion.png";
            btn_cerrar_sesion.Image = Image.FromFile(rutaCerrarSesion);

            // Configurar el saludo
            txt_saludo.Text = Program.logueado.nombre + " " + Program.logueado.apellido;

            // Configurar el ToolTip para el botón de cerrar sesión
            toolTip.SetToolTip(btn_cerrar_sesion, "Cerrar sesión");

            Facturar_UC adminUC = new Facturar_UC();
            

            pictureBox10.Visible = false;

            // Cambiar el color de PictureBox
            pictureBox1.BackColor = Color.FromArgb(232, 186, 197);
            btn_facturar.BackColor = Color.FromArgb(232, 186, 197);
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            Program.logueado = new Empleado();
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            Facturar_UC facturarUC = new Facturar_UC();
           
            CambiarColorBoton1((Button)sender);
        }

        private void btn_generar_informes_Click(object sender, EventArgs e)
        {
            FormListaDeEnvios listaDeEnvios = new FormListaDeEnvios();
            listaDeEnvios.Show();
            this.Hide();

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "FormInicioAutoconsulta") // Asegúrate de que el nombre sea correcto
                {
                    form.Hide();
                    break;
                }
            }
        }


        private void CambiarColorBoton1(Button botonSeleccionado)
        {
            // Restaurar el color del botón anterior si existe
            if (botonAnterior != null)
            {
                botonAnterior.BackColor = Color.FromArgb(232, 196, 206); // Restaurar color original
                pictureBox1.BackColor = Color.FromArgb(232, 196, 206);  // Restaurar color original de PictureBox1

            }

            // Cambiar el color del botón seleccionado
            botonSeleccionado.BackColor = Color.FromArgb(232, 186, 197);

            // Cambiar el color de PictureBox
            
            pictureBox1.BackColor = Color.FromArgb(232, 186, 197);           
            pictureBox9.BackColor = Color.FromArgb(232, 196, 206);

            // Mostrar PictureBox         
            pictureBox3.Visible = true;         
            pictureBox10.Visible = false;

            // Guardar el botón actual como el anterior
            botonAnterior = botonSeleccionado;
        }


    }
}