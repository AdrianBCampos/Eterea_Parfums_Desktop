using Eterea_Parfums_Desktop.ControlesDeUsuario;
using Eterea_Parfums_Desktop.ControlesDeUsuario.AdministrarStock;
using Eterea_Parfums_Desktop.ControlesDeUsuario.GenerarInformes;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormInicioAdministrador : Form
    {
        // Declarar la instancia de ToolTip
        private ToolTip toolTip = new ToolTip();

        // Variable para almacenar el botón previamente seleccionado
        private Button botonAnterior;

        public FormInicioAdministrador()
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

            Gestionar_UC adminUC = new Gestionar_UC();
            addUserControl(adminUC);

            pictureBox3.Visible = false;
            pictureBox5.Visible = false;
            pictureBox10.Visible = false;

            // Cambiar el color de PictureBox
            pictureBox4.BackColor = Color.FromArgb(232, 186, 197);
            btn_gestionar.BackColor = Color.FromArgb(232, 186, 197);


        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            Program.logueado = new Empleado();

            // Buscar si FormStart ya está abierto
            FormStart formStart = null;
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormStart)
                {
                    formStart = (FormStart)form;
                    break;
                }
            }

            // Asegurar que FormStart siga visible y en el fondo
            if (formStart != null)
            {
                formStart.Show();
                formStart.SendToBack(); // Lo envía al fondo
            }

            // Mostrar el login sobre FormStart
            FormLogin login = new FormLogin();
            login.Show();

            // Cerrar este formulario (FormInicioAdministrador)
            this.Close();
        }

        private void btn_gestionar_Click(object sender, EventArgs e)
        {
            Gestionar_UC adminUC = new Gestionar_UC();
            addUserControl(adminUC);

            CambiarColorBoton1((Button)sender);
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            Facturar_UC facturarUC = new Facturar_UC();
            addUserControl(facturarUC);

            CambiarColorBoton2((Button)sender);

            FormNumeroDeCaja numeroDeCaja = new FormNumeroDeCaja();
            numeroDeCaja.ShowDialog();
            
        }

        private void btn_administrar_stock_Click(object sender, EventArgs e)
        {
            AdministrarStock_UC administrarStockUC = new AdministrarStock_UC();
            addUserControl(administrarStockUC);

            CambiarColorBoton3((Button)sender);
        }    

        private void btn_generar_informes_Click(object sender, EventArgs e)
        {
            GenerarInformes_UC informesDeVentas1UC = new GenerarInformes_UC();
            addUserControl(informesDeVentas1UC);

            CambiarColorBoton4((Button)sender);
        }


        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_admin.Controls.Clear();
            panel_admin.Controls.Add(uc);
            uc.BringToFront();
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
            pictureBox4.BackColor = Color.FromArgb(232, 186, 197);
            pictureBox1.BackColor = Color.FromArgb(232, 196, 206);
            pictureBox8.BackColor = Color.FromArgb(232, 196, 206);
            pictureBox9.BackColor = Color.FromArgb(232, 196, 206);

            // Mostrar PictureBox
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox5.Visible = false;
            pictureBox10.Visible = false;

            // Guardar el botón actual como el anterior
            botonAnterior = botonSeleccionado;
        }

        private void CambiarColorBoton2(Button botonSeleccionado)
        {
            // Restaurar el color del botón anterior si existe
            if (botonAnterior != null)
            {
                botonAnterior.BackColor = Color.FromArgb(232, 196, 206); // Restaurar color original           
            }

            // Cambiar el color del botón seleccionado
            botonSeleccionado.BackColor = Color.FromArgb(232, 186, 197);

            btn_gestionar.BackColor = Color.FromArgb(232, 196, 206);

            // Cambiar el color de PictureBox
            pictureBox4.BackColor = Color.FromArgb(232, 196, 206);
            pictureBox1.BackColor = Color.FromArgb(232, 186, 197);
            pictureBox8.BackColor = Color.FromArgb(232, 196, 206);
            pictureBox9.BackColor = Color.FromArgb(232, 196, 206);


            // Mostrar PictureBox
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox5.Visible = false;
            pictureBox10.Visible = false;

            // Guardar el botón actual como el anterior
            botonAnterior = botonSeleccionado;
        }

        private void CambiarColorBoton3(Button botonSeleccionado)
        {
            // Restaurar el color del botón anterior si existe
            if (botonAnterior != null)
            {
                botonAnterior.BackColor = Color.FromArgb(232, 196, 206); // Restaurar color original           
            }

            // Cambiar el color del botón seleccionado
            botonSeleccionado.BackColor = Color.FromArgb(232, 186, 197);

            btn_gestionar.BackColor = Color.FromArgb(232, 196, 206);

            // Cambiar el color de PictureBox
            pictureBox4.BackColor = Color.FromArgb(232, 196, 206);
            pictureBox1.BackColor = Color.FromArgb(232, 196, 206);
            pictureBox8.BackColor = Color.FromArgb(232, 186, 197);
            pictureBox9.BackColor = Color.FromArgb(232, 196, 206);


            // Mostrar PictureBox
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox5.Visible = true;
            pictureBox10.Visible = false;

            // Guardar el botón actual como el anterior
            botonAnterior = botonSeleccionado;
        }

        private void CambiarColorBoton4(Button botonSeleccionado)
        {
            // Restaurar el color del botón anterior si existe
            if (botonAnterior != null)
            {
                botonAnterior.BackColor = Color.FromArgb(232, 196, 206); // Restaurar color original
            }

            // Cambiar el color del botón seleccionado
            botonSeleccionado.BackColor = Color.FromArgb(232, 186, 197);

            btn_gestionar.BackColor = Color.FromArgb(232, 196, 206);

            // Cambiar el color de PictureBox
            pictureBox4.BackColor = Color.FromArgb(232, 196, 206);
            pictureBox1.BackColor = Color.FromArgb(232, 196, 206);
            pictureBox8.BackColor = Color.FromArgb(232, 196, 206);
            pictureBox9.BackColor = Color.FromArgb(232, 186, 197);
            

            // Mostrar PictureBox
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox5.Visible = false;
            pictureBox10.Visible = true;

            // Guardar el botón actual como el anterior
            botonAnterior = botonSeleccionado;
        }

        
    }
}