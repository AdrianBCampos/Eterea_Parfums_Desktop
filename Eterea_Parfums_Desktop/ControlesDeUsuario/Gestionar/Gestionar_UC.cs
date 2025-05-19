using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario
{
    public partial class Gestionar_UC : UserControl
    {
        // Variable para almacenar el botón previamente seleccionado
        private Button botonAnterior;

        public Gestionar_UC()
        {
            InitializeComponent();

            this.Scale(new SizeF(Program.ScaleFactor, Program.ScaleFactor));

           

            PerfumesUC perfumesUC = new PerfumesUC();
            addUserControl(perfumesUC);

          

            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;

            // Cambiar el color de PictureBox
            pictureBox3.BackColor = Color.FromArgb(209, 167, 180);
            btn_perfumes.BackColor = Color.FromArgb(209, 167, 180);

            this.Cursor = Cursors.Default;
            this.UseWaitCursor = false;

            panel_abm.Cursor = Cursors.Default;
            panel_abm.UseWaitCursor = false;


        }

        private void btn_perfumes_Click_1(object sender, EventArgs e)
        {
            PerfumesUC perfumesUC = new PerfumesUC();
            addUserControl(perfumesUC);

            CambiarColorBoton1((Button)sender);
        }

        private void btn_empleados_Click_1(object sender, EventArgs e)
        {         
            Empleados_UC empleados_UC = new Empleados_UC();
            addUserControl(empleados_UC);

            CambiarColorBoton2((Button)sender);
        }

        private void btn_clientes_Click_1(object sender, EventArgs e)
        {
            Clientes_UC clientes_UC = new Clientes_UC();
            addUserControl(clientes_UC);

            CambiarColorBoton3((Button)sender);
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_abm.Controls.Clear();
            panel_abm.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_promociones_Click_1(object sender, EventArgs e)
        {
            Promos_UC promos_UC = new Promos_UC();
            addUserControl(promos_UC);

            CambiarColorBoton4((Button)sender);
        }

        private void CambiarColorBoton1(Button botonSeleccionado)
        {
            // Restaurar el color del botón anterior si existe
            if (botonAnterior != null)
            {
                botonAnterior.BackColor = Color.FromArgb(216, 182, 194); // Restaurar color original
                pictureBox1.BackColor = Color.FromArgb(216, 182, 194);  // Restaurar color original de PictureBox1

            }

            // Cambiar el color del botón seleccionado
            botonSeleccionado.BackColor = Color.FromArgb(209, 167, 180);

            // Cambiar el color de PictureBox
            pictureBox3.BackColor = Color.FromArgb(209, 167, 180);
            pictureBox1.BackColor = Color.FromArgb(216, 182, 194);
            pictureBox2.BackColor = Color.FromArgb(216, 182, 194);
            pictureBox4.BackColor = Color.FromArgb(216, 182, 194);

            // Mostrar PictureBox
            pictureBox5.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;

            // Guardar el botón actual como el anterior
            botonAnterior = botonSeleccionado;
        }

        private void CambiarColorBoton2(Button botonSeleccionado)
        {
            // Restaurar el color del botón anterior si existe
            if (botonAnterior != null)
            {
                botonAnterior.BackColor = Color.FromArgb(216, 182, 194); // Restaurar color original              
            }

            // Cambiar el color del botón seleccionado
            botonSeleccionado.BackColor = Color.FromArgb(209, 167, 180);

            btn_perfumes.BackColor = Color.FromArgb(216, 182, 194);

            // Cambiar el color de PictureBox
            pictureBox3.BackColor = Color.FromArgb(216, 182, 194);
            pictureBox1.BackColor = Color.FromArgb(209, 167, 180);
            pictureBox2.BackColor = Color.FromArgb(216, 182, 194);
            pictureBox4.BackColor = Color.FromArgb(216, 182, 194);

            // Mostrar PictureBox
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;

            // Guardar el botón actual como el anterior
            botonAnterior = botonSeleccionado;
        }

        private void CambiarColorBoton3(Button botonSeleccionado)
        {
            // Restaurar el color del botón anterior si existe
            if (botonAnterior != null)
            {
                botonAnterior.BackColor = Color.FromArgb(216, 182, 194); // Restaurar color original              
            }

            // Cambiar el color del botón seleccionado
            botonSeleccionado.BackColor = Color.FromArgb(209, 167, 180);

            btn_perfumes.BackColor = Color.FromArgb(216, 182, 194);

            // Cambiar el color de PictureBox
            pictureBox3.BackColor = Color.FromArgb(216, 182, 194);
            pictureBox1.BackColor = Color.FromArgb(216, 182, 194);
            pictureBox2.BackColor = Color.FromArgb(209, 167, 180);
            pictureBox4.BackColor = Color.FromArgb(216, 182, 194);

            // Mostrar PictureBox
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;

            // Guardar el botón actual como el anterior
            botonAnterior = botonSeleccionado;
        }

        private void CambiarColorBoton4(Button botonSeleccionado)
        {
            // Restaurar el color del botón anterior si existe
            if (botonAnterior != null)
            {
                botonAnterior.BackColor = Color.FromArgb(216, 182, 194); // Restaurar color original              
            }

            // Cambiar el color del botón seleccionado
            botonSeleccionado.BackColor = Color.FromArgb(209, 167, 180);

            btn_perfumes.BackColor = Color.FromArgb(216, 182, 194);

            // Cambiar el color de PictureBox
            pictureBox3.BackColor = Color.FromArgb(216, 182, 194);
            pictureBox1.BackColor = Color.FromArgb(216, 182, 194);
            pictureBox2.BackColor = Color.FromArgb(216, 182, 194);
            pictureBox4.BackColor = Color.FromArgb(209, 167, 180);

            // Mostrar PictureBox
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;

            // Guardar el botón actual como el anterior
            botonAnterior = botonSeleccionado;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
