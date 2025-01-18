using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario
{
    public partial class Promos_UC : UserControl
    {
        List<Promocion> promociones;
        public Promos_UC()
        {
            InitializeComponent();
            cargarPromociones();
        }

        private void cargarPromociones(string filtroNombre = "")
        {
            promociones = PromoControlador.obtenerTodos();

            dataGV_Promos.Rows.Clear();
            foreach (Promocion promocion in promociones)
            {
                if (promocion.activo == 1 && (string.IsNullOrEmpty(filtroNombre) || promocion.nombre.ToString().IndexOf(filtroNombre, StringComparison.OrdinalIgnoreCase) >= 0))

                {
                    int rowIndex = dataGV_Promos.Rows.Add();

                    dataGV_Promos.Rows[rowIndex].Cells[0].Value = promocion.id.ToString();
                    dataGV_Promos.Rows[rowIndex].Cells[1].Value = promocion.nombre.ToString();
                    dataGV_Promos.Rows[rowIndex].Cells[3].Value = promocion.fecha_inicio.ToString("dd-MM-yyyy");
                    dataGV_Promos.Rows[rowIndex].Cells[4].Value = promocion.fecha_fin.ToString("dd-MM-yyyy");
                    //dataGV_Promos.Rows[rowIndex].Cells[2].Value = promocion.descuento.ToString();
                    int descuento = promocion.descuento; // Obtén el valor del descuento como entero

                    string textoPromocion;

                    switch (descuento)
                    {
                        case 50:
                            textoPromocion = "2 x 1";
                            break;
                        case 25:
                            textoPromocion = "2da Unidad 50% Dto.";
                            break;
                        case 35:
                            textoPromocion = "2da Unidad 70% Dto.";
                            break;
                        case 40:
                            textoPromocion = "2da Unidad 80% Dto.";
                            break;
                        default:
                            textoPromocion = "Sin promoción"; // Texto predeterminado para otros valores
                            break;
                    }

                    // Asigna el texto al DataGridView
                    dataGV_Promos.Rows[rowIndex].Cells[2].Value = textoPromocion;

                    if (promocion.activo.ToString() == "1")
                    {
                        dataGV_Promos.Rows[rowIndex].Cells[5].Value = "Activo";
                    }
                    else
                    {
                        dataGV_Promos.Rows[rowIndex].Cells[5].Value = "Inactivo";
                    }

                    dataGV_Promos.Rows[rowIndex].Cells[6].Value = "Editar";
                    dataGV_Promos.Rows[rowIndex].Cells[7].Value = "Eliminar";
                }
            }
        }
        private void txt_buscar_nombre_TextChanged(object sender, EventArgs e)
        {
            string filtroNombre = textbox_nombrePromo.Text.Trim();

            // Actualiza el DataGridView con el filtro
            cargarPromociones(filtroNombre);
        }

       

        private void btn_crear_promo_Click(object sender, EventArgs e)
        {
            FormCrearPromo formCrearPromo = new FormCrearPromo();
            DialogResult dr = formCrearPromo.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Trace.WriteLine("OK");

                //ACTUALIZAR LA LISTA
                cargarPromociones();
            }
        }
    }
}
