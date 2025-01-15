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

namespace Eterea_Parfums_Desktop.ControlesDeUsuario
{
    public partial class PerfumesUC : UserControl
    {

        private List<Perfume> perfumes;
        public PerfumesUC()
        {
            InitializeComponent();
            cargarPerfumes();
        }

        private void btn_crear_perfume_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Hide();
        }

        private void cargarPerfumes()
        {
            perfumes = PerfumeControlador.getAll();

            dataGridViewPerfumes.Rows.Clear();
            foreach (Perfume perfume in perfumes)
            {
                if (perfume.activo == 1)
                {
                    int rowIndex = dataGridViewPerfumes.Rows.Add();

                    dataGridViewPerfumes.Rows[rowIndex].Cells[0].Value = perfume.id.ToString();
                    dataGridViewPerfumes.Rows[rowIndex].Cells[1].Value = perfume.codigo.ToString();
                    dataGridViewPerfumes.Rows[rowIndex].Cells[2].Value = (MarcaControlador.getById(perfume.marca.id)).nombre;
                    dataGridViewPerfumes.Rows[rowIndex].Cells[3].Value = perfume.nombre.ToString();
                    dataGridViewPerfumes.Rows[rowIndex].Cells[4].Value = (TipoDePerfumeControlador.getById(perfume.tipo_de_perfume.id)).tipo_de_perfume;
                    dataGridViewPerfumes.Rows[rowIndex].Cells[5].Value = (GeneroControlador.getById(perfume.genero.id)).genero;
                    dataGridViewPerfumes.Rows[rowIndex].Cells[6].Value = perfume.presentacion_ml.ToString();
                    dataGridViewPerfumes.Rows[rowIndex].Cells[7].Value = (PaisControlador.getById(perfume.pais.id)).nombre;

                    if (perfume.spray.ToString() == "1")
                    {
                        dataGridViewPerfumes.Rows[rowIndex].Cells[8].Value = "Si";
                    }
                    else
                    {
                        dataGridViewPerfumes.Rows[rowIndex].Cells[8].Value = "No";
                    }

                    if (perfume.recargable.ToString() == "1")
                    {
                        dataGridViewPerfumes.Rows[rowIndex].Cells[9].Value = "Si";
                    }
                    else
                    {
                        dataGridViewPerfumes.Rows[rowIndex].Cells[9].Value = "No";
                    }

                    dataGridViewPerfumes.Rows[rowIndex].Cells[10].Value = perfume.precio_en_pesos.ToString();


                    if (perfume.activo.ToString() == "1")
                    {
                        dataGridViewPerfumes.Rows[rowIndex].Cells[11].Value = "Si";
                    }
                    else
                    {
                        dataGridViewPerfumes.Rows[rowIndex].Cells[11].Value = "No";
                    }


                    dataGridViewPerfumes.Rows[rowIndex].Cells[12].Value = "Editar";
                    dataGridViewPerfumes.Rows[rowIndex].Cells[13].Value = "Eliminar";
                }



            }
        }

    }
}
