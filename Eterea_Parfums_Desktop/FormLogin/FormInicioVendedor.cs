﻿using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.ControlesDeUsuario;
using Eterea_Parfums_Desktop.ControlesDeUsuario.PrepararEnvios;
using Eterea_Parfums_Desktop.Helpers;
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

          

            pictureBox10.Visible = false;
            pictureBox5.Visible = false;

            // Cambiar el color de PictureBox
            pictureBox1.BackColor = Color.FromArgb(232, 186, 197);
            btn_facturar.BackColor = Color.FromArgb(232, 186, 197);

            this.Shown += FormInicioVendedor_Shown;

            // Obtener y mostrar el nombre de la sucursal en el label
            txt_nombre_suc.Text = SucursalControlador.ObtenerNombreSucursalPorId(Program.sucursal);
        }

        internal static bool HayOrdenesActivas()
        {
            OrdenControlador controlador = new OrdenControlador();
            return controlador.ObtenerCantidadOrdenesActivas() > 0;
        }


        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_admin.Controls.Clear();
            panel_admin.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            if (CajaManager.HayCajaAsignada())
            {
                MessageBox.Show(
                    "Hay una caja abierta en uso.\nDebes cerrarla antes de cerrar sesión.",
                    "Cierre de sesión bloqueado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var confirm = MessageBox.Show("¿Estás seguro que deseas cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                // Limpiar datos de sesión
                Program.logueado = null;
                CajaManager.ResetCaja();

                // Mostrar el login encima del FormStart
                FormLogin formLogin = new FormLogin();
                formLogin.StartPosition = FormStartPosition.CenterScreen;
                formLogin.Show(); // Mostrar encima del FormStart

                // Cerrar este form (FormInicioAdministrador)
                this.Close();
            }
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            CambiarColorBoton1((Button)sender);
            Facturar_UC facturarUC = new Facturar_UC();
            addUserControl(facturarUC);
        }

        private void btn_preparar_envios_Click(object sender, EventArgs e)
        {
            CambiarColorBoton2((Button)sender);
            PrepararEnvios_UC prepararEnviosUC = new PrepararEnvios_UC();
            addUserControl(prepararEnviosUC);
        }

        private void btn_buscar_envios_Click(object sender, EventArgs e)
        {
            CambiarColorBoton3((Button)sender);
            BuscarPedidos_UC buscarPedidosUC = new BuscarPedidos_UC();
            addUserControl(buscarPedidosUC);
        }


        private void FormInicioVendedor_Shown(object sender, EventArgs e)
        {
            Facturar_UC vendedorUC = new Facturar_UC();
            addUserControl(vendedorUC);
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
            pictureBox2.BackColor = Color.FromArgb(232, 196, 206);
            pictureBox9.BackColor = Color.FromArgb(232, 196, 206);

            // Mostrar PictureBox         
            pictureBox3.Visible = true;
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

            btn_facturar.BackColor = Color.FromArgb(232, 196, 206);

            // Cambiar el color de PictureBox          
            pictureBox1.BackColor = Color.FromArgb(232, 196, 206);
            pictureBox2.BackColor = Color.FromArgb(232, 186, 197);
            pictureBox9.BackColor = Color.FromArgb(232, 196, 206);

            // Mostrar PictureBox
            pictureBox3.Visible = false;
            pictureBox5.Visible = false;
            pictureBox10.Visible = true;

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

            btn_facturar.BackColor = Color.FromArgb(232, 196, 206);

            // Cambiar el color de PictureBox          
            pictureBox1.BackColor = Color.FromArgb(232, 196, 206);
            pictureBox2.BackColor = Color.FromArgb(232, 196, 206);
            pictureBox9.BackColor = Color.FromArgb(232, 186, 197);

            // Mostrar PictureBox
            pictureBox3.Visible = false;
            pictureBox5.Visible = true;
            pictureBox10.Visible = false;

            // Guardar el botón actual como el anterior
            botonAnterior = botonSeleccionado;

        }


        private void btn_gestionar_Click(object sender, EventArgs e)
        {
            if (HayOrdenesActivas())
            {
                FormListaDeEnvios listaDeEnvios = new FormListaDeEnvios();
                listaDeEnvios.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("En este momento no hay órdenes activas para despachar.", "Sin órdenes activas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}