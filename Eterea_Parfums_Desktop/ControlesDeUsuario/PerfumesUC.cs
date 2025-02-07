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
            txt_buscar_codigo.MaxLength = 13;
            txt_buscar_codigo.KeyPress += txt_buscar_codigo_KeyPress;
            txt_buscar_codigo.TextChanged += txt_buscar_codigo_TextChanged;
            cargarPerfumes();
        }

        private void btn_crear_perfume_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos(this);
            productos.Show();
        }

        internal void cargarPerfumes(string filtroPerfume = "")
        {
            perfumes = PerfumeControlador.getAll();

            dataGridViewPerfumes.Rows.Clear();
            foreach (Perfume perfume in perfumes)
            {
                if (perfume.activo == 1 && (string.IsNullOrEmpty(filtroPerfume) || perfume.codigo.Contains(filtroPerfume)))
                {
                    int rowIndex = dataGridViewPerfumes.Rows.Add();

                    dataGridViewPerfumes.Rows[rowIndex].Cells[0].Value = perfume.id.ToString();
                    dataGridViewPerfumes.Rows[rowIndex].Cells[1].Value = perfume.codigo;
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

        private void dataGridViewPerfumes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "Editar")
            {
                //EDITAMOS

                int id = int.Parse(dataGridViewPerfumes.Rows[e.RowIndex].Cells[0].Value.ToString());

                Trace.WriteLine("El id es: " + id);

                Perfume perfume_editar = PerfumeControlador.getByID(id);

                Marca marca = MarcaControlador.getById(perfume_editar.marca.id);
                TipoDePerfume tipo_de_perfume = TipoDePerfumeControlador.getById(perfume_editar.tipo_de_perfume.id);
                Genero genero = GeneroControlador.getById(perfume_editar.genero.id);
                Pais pais = PaisControlador.getById(perfume_editar.pais.id);
                perfume_editar = new Perfume(perfume_editar.id, perfume_editar.codigo, marca, perfume_editar.nombre, tipo_de_perfume, genero, perfume_editar.presentacion_ml, pais, perfume_editar.spray, perfume_editar.recargable, perfume_editar.descripcion, perfume_editar.anio_de_lanzamiento, perfume_editar.precio_en_pesos, perfume_editar.activo, perfume_editar.imagen1, perfume_editar.imagen2);
                EditarProducto formEditarProductoABM = new EditarProducto(perfume_editar, this);
                //ACTUALIZAR LA LISTA
                cargarPerfumes();
                formEditarProductoABM.Show();
            }


            else if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                //ELIMINAMOS
            

                int id = int.Parse(dataGridViewPerfumes.Rows[e.RowIndex].Cells[0].Value.ToString());
                Perfume perfume = PerfumeControlador.getByID(id);
                FormEliminarProductoABM formEliminarProductoABM = new FormEliminarProductoABM(perfume);
                DialogResult dr = formEliminarProductoABM.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK");
                    cargarPerfumes();
                }
            }

        }

        private void txt_buscar_codigo_TextChanged(object sender, EventArgs e)
        {
            string filtroCodigo = txt_buscar_codigo.Text.Trim();
            cargarPerfumes(filtroCodigo);

        }

        private void txt_buscar_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar entrada no válida
            }
        }
    }
}
