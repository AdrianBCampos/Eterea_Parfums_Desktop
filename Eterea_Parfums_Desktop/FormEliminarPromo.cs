using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.ControlesDeUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormEliminarPromo : Form
    {
        private int promoId; // ID de la promoción
        private string promoNombre; // Nombre de la promoción
        public FormEliminarPromo(int idPromo, string nombrePromo)
        {
            InitializeComponent();

            promoId = idPromo;
            promoNombre = nombrePromo;

            // Mostrar el nombre de la promoción en una etiqueta o cuadro de texto
            lbl_nombre_promo_seleccionada.Text = nombrePromo;
        }


        private void btn_eliminar_promo_Click(object sender, EventArgs e)
        {
            //PromoControlador.eliminarPromo(promoId);

            // Confirmar si desea eliminar la promoción
            var confirmResult = MessageBox.Show(
                "¿Está seguro de que desea eliminar permanentemente esta promoción?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    // Llamar al método para eliminar la promoción
                    bool resultado = PromoControlador.eliminarPromo(promoId);

                    if (resultado)
                    {
                        MessageBox.Show(
                            "La promoción se eliminó con éxito.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                      

                        // Cerrar el formulario de eliminación
                        this.Close();
                       
                        


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Ocurrió un error al eliminar la promoción: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btn_x_cerrar_ventana_eliminar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }
    }


    
}
