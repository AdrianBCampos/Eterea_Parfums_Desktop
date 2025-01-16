using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop
{
    public partial class FormEliminarEmpleado : Form
    {
        int id_eliminar;
        public FormEliminarEmpleado()
        {
            InitializeComponent();
        }

        //SOBRECARGAR EL CONSTRUCTOR PARA INICIAR EL FORM CON LA INFO PARA ELIMINAR
        public FormEliminarEmpleado(Empleado eliminado, int id)

        {
            InitializeComponent();

            id_eliminar = id;

            txt_dni.Text = eliminado.dni.ToString();
            txt_rol.Text = eliminado.rol.ToString();
            txt_nombre.Text = eliminado.nombre.ToString();

        }


        private void eliminar()
        {

            int activo = 0;

            Empleado empleado = new Empleado(id_eliminar, activo);

            if (EmpleadoControlador.eliminarEmpleado(id_eliminar))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            eliminar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
