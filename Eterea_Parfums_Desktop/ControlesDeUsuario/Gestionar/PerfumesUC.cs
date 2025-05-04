using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario
{
    public partial class PerfumesUC : UserControl
    {

        private List<Perfume> perfumes;
        public PerfumesUC()
        {
            InitializeComponent();

            this.Scale(new SizeF(Program.ScaleFactor, Program.ScaleFactor));

            txt_buscar_codigo.MaxLength = 13;
            txt_buscar_codigo.KeyPress += txt_buscar_codigo_KeyPress;
            txt_buscar_codigo.TextChanged += txt_buscar_codigo_TextChanged;
            cargarPerfumes();
        }

        private void btn_crear_perfume_Click_1(object sender, EventArgs e)
        {
            FormCrearPerfume1 productos = new FormCrearPerfume1(this);          

            DialogResult dr = productos.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                Trace.WriteLine("OK");

                //ACTUALIZAR LA LISTA
                cargarPerfumes();
            }
        }

        internal void cargarPerfumes(string filtroPerfume = "")
        {
            //Ocultas la primera columna de la tabla (es una columna de seleccion de fila)
            dataGridViewPerfumes.RowHeadersVisible = false;

            perfumes = PerfumeControlador.getAll();
            List<Stock> stocks = StockControlador.getAll();

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


                    // Agrupar por id de perfume y sumar las cantidades
                    var stockTotal = stocks
                        .Where(s => s.perfume.id == perfume.id)
                        .Sum(p => p.cantidad);
                   

                    dataGridViewPerfumes.Rows[rowIndex].Cells[11].Value = stockTotal.ToString();

                    dataGridViewPerfumes.Rows[rowIndex].Cells[12].Value = "Editar";
                    dataGridViewPerfumes.Rows[rowIndex].Cells[13].Value = "Eliminar";
                }

                dataGridViewPerfumes.CellPainting += dataGridView1_CellPainting;

            }
        }

        private void dataGridViewPerfumes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
                FormEditarPerfume1 formEditarProductoABM = new FormEditarPerfume1(perfume_editar, this);


                //ACTUALIZAR LA LISTA
                //cargarPerfumes();
                //formEditarProductoABM.ShowDialog();

                DialogResult dr = formEditarProductoABM.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK");

                    //ACTUALIZAR LA LISTA
                    cargarPerfumes();
                }
            }


            else if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                //ELIMINAMOS
                int id = int.Parse(dataGridViewPerfumes.Rows[e.RowIndex].Cells[0].Value.ToString());
                Perfume perfume = PerfumeControlador.getByID(id);
                FormEliminarPerfume formEliminarProductoABM = new FormEliminarPerfume(perfume, this);

                DialogResult dr = formEliminarProductoABM.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK");
                    cargarPerfumes();
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridViewPerfumes.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                e.Handled = true;
                e.PaintBackground(e.CellBounds, true);

                // Crear un rectángulo para el botón
                Rectangle buttonRect = e.CellBounds;
                buttonRect.Inflate(-2, -2); // Reducir tamaño para dar efecto de borde

                // Definir colores personalizados
                Color buttonColor = Color.FromArgb(228, 137, 164); // Color de fondo del botón
                Color textColor = Color.FromArgb(250, 236, 239); // Color del texto

                using (SolidBrush brush = new SolidBrush(buttonColor))
                {
                    e.Graphics.FillRectangle(brush, buttonRect);
                }

                // Dibujar el texto del botón
                TextRenderer.DrawText(e.Graphics, (string)e.Value, e.CellStyle.Font, buttonRect, textColor,
                                      TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
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
