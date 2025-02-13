using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormEliminarClienteABM : Form
    {
        int id_eliminar;

        public FormEliminarClienteABM()
        {
            InitializeComponent();
        }


        //SOBRECARGAR EL CONSTRUCTOR PARA INICIAR EL FORM CON LA INFO PARA ELIMINAR
        public FormEliminarClienteABM(Cliente eliminado, int id)
            
        {
            InitializeComponent();

            id_eliminar = id;

            txt_nombre_cliente.Text = eliminado.nombre.ToString() + " " + eliminado.apellido.ToString();        
            txt_dni_eliminar.Text = eliminado.dni.ToString();
            
        }

        

        private void btn_eliminar_cliente_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {

            int activo = 0;

            Cliente cliente = new Cliente(id_eliminar, activo);

            if (ClienteControlador.eliminarCliente(id_eliminar))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
