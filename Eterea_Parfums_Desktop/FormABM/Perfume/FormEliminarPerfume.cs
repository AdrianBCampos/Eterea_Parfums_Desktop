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
    public partial class FormEliminarPerfume : Form
    {
        int id_eliminar;

        public FormEliminarPerfume()
        {
            InitializeComponent();
        }


        //SOBRECARGAR EL CONSTRUCTOR PARA INICIAR EL FORM CON LA INFO PARA ELIMINAR
        public FormEliminarPerfume(Perfume eliminado)
            
        {
            InitializeComponent();

            id_eliminar = eliminado.id;
            txt_codigo_perfume.Text = eliminado.codigo;
            txt_nombre_perfume.Text = eliminado.nombre;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_cliente_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar()
        {

            if (PerfumeControlador.delete(id_eliminar))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
