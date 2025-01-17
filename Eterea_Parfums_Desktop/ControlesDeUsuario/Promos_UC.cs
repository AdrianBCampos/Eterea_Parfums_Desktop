using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
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
    public partial class Promos_UC : UserControl
    {
        List<Promocion> promociones;
        public Promos_UC()
        {
            InitializeComponent();
            cargarPromociones();
        }

        private void cargarPromociones()
        {
            promociones = PromoControlador.obtenerTodos();

            dataGV_Promos.Rows.Clear();
            foreach (Promocion promocion in promociones)
            {
                if (promocion.activo == 1)
                {
                    int rowIndex = dataGV_Promos.Rows.Add();

                    dataGV_Promos.Rows[rowIndex].Cells[0].Value = promocion.id.ToString();
                    dataGV_Promos.Rows[rowIndex].Cells[1].Value = promocion.nombre.ToString();
                    dataGV_Promos.Rows[rowIndex].Cells[2].Value = promocion.fecha_inicio.ToString("dd-MM-yyyy");
                    dataGV_Promos.Rows[rowIndex].Cells[3].Value = promocion.fecha_fin.ToString("dd-MM-yyyy");
                    dataGV_Promos.Rows[rowIndex].Cells[4].Value = promocion.descuento.ToString();

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
    }
}
