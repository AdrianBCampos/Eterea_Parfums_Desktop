using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public FormEliminarEmpleado(Cliente eliminado, int id)

        {
            InitializeComponent();

            id_eliminar = id;

            txt_dni.Text = eliminado.nombre.ToString();
            txt_nombre.Text = eliminado.dni.ToString();

        }
    }
}
