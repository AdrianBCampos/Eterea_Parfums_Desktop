using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormVerPerfumesSimilares : Form
    {
        private Perfume perfume;

        private static Perfume filtro = new Perfume();

        private List<Perfume> Perfumes_Completo = new List<Perfume>();
        private List<Perfume> Perfumes_Filtrado = new List<Perfume>();
        private List<Perfume> Perfumes_Paginados = new List<Perfume>();

        public List<Marca> marcas;
        public List<Genero> generos;

        //LA PAGINA ACTUAL
        private static int current = 0;
        private static int paginador = 5;

        //TOTAL DE PRODUCTOS
        private static int total = 0;
        private static int last_pag = 0;
        private static int current_pag = 1;


        public FormVerPerfumesSimilares(Perfume perfumeSeleccionado)
        {
            InitializeComponent();

            txt_nombre_perfume.Text = perfumeSeleccionado.nombre;
            this.perfume = perfumeSeleccionado;

            string nombreImagen = perfumeSeleccionado.imagen1.ToString();
            string rutaCompletaImagen = Program.Ruta_Base + nombreImagen + ".jpg";
            img_perfume.Image = Image.FromFile(rutaCompletaImagen);

            // Llamamos a la función que obtiene los perfumes similares
            Perfumes_Completo = PerfumeControlador.getPerfumesSimilares(perfumeSeleccionado);

            // Si no hay resultados, mostrar mensaje y cerrar el formulario
            if (Perfumes_Completo.Count == 0)
            {
                MessageBox.Show("No se encontraron perfumes similares para el perfume seleccionado.", "Sin coincidencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra la ventana actual
                return; // Sale del constructor para no seguir ejecutando el código
            }



            total = Perfumes_Completo.Count;
            last_pag = (int)Math.Ceiling((double)total / paginador);
            lbl_numero_pagina.Text = current_pag.ToString();

            //Mostrar los perfumes ene
            paginar(Perfumes_Completo);
            CargarMarcas();
            CargarGeneros();

            //Diseño del combo box
            combo_filtro_genero.DrawMode = DrawMode.OwnerDrawFixed;
            combo_filtro_genero.DrawItem += comboBoxdiseño_DrawItem;
            combo_filtro_genero.DropDownStyle = ComboBoxStyle.DropDownList;

            combo_filtro_marca.DrawMode = DrawMode.OwnerDrawFixed;
            combo_filtro_marca.DrawItem += comboBoxdiseño_DrawItem;
            combo_filtro_marca.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public FormVerPerfumesSimilares()
        {
        }

        private void CargarMarcas()
        {
            marcas = MarcaControlador.getAll();
            combo_filtro_marca.Items.Clear();
            combo_filtro_marca.Items.Add("Todas las marcas");
            foreach (Marca marca in marcas)
            {
                combo_filtro_marca.Items.Add(marca.nombre);
            }
            combo_filtro_marca.SelectedIndex = 0;
        }

        private void CargarGeneros()
        {
            generos = GeneroControlador.getAll();
            combo_filtro_genero.Items.Clear();
            combo_filtro_genero.Items.Add("Todos los generos");
            foreach (Genero genero in generos)
            {
                combo_filtro_genero.Items.Add(genero.genero);
            }
            combo_filtro_genero.SelectedIndex = 0;
        }

        private void paginar(List<Perfume> perfumeMostrar)
        {
            Perfumes_Paginados = perfumeMostrar.Skip(current).Take(paginador).ToList();
            VisualizarPerfumes(Perfumes_Paginados);
            lbl_paginacion_Info.Text = "Mostrando: " + (current + 1) + " a " + (current + Perfumes_Paginados.Count) + "  de  " + total;

            if (current_pag == 1)
            {
                btn_anterior.Hide();
            }
            else
            {
                btn_anterior.Show();
                btn_posterior.Show();
            }
            if (current_pag == last_pag)
            {
                btn_posterior.Hide();
            }
            else
            {
                btn_posterior.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btn_ver_detalles_Click(object sender, EventArgs e)
        {
            FormVerDetallePerfume verDetallePerfume = new FormVerDetallePerfume(perfume);
            verDetallePerfume.Show();
            this.Close();     
        }

        private void VisualizarPerfumes(List<Perfume> perfumeMostrar)
        {
            //Ocultas la primera columna de la tabla (es una columna de seleccion de fila)
            dataGridViewConsultas.RowHeadersVisible = false;

            dataGridViewConsultas.Rows.Clear();
            foreach (Perfume perfume in perfumeMostrar)
            {
                if (perfume.activo == 1)
                {
                    int rowIndex = dataGridViewConsultas.Rows.Add();

                    dataGridViewConsultas.Rows[rowIndex].Cells[0].Value = perfume.nombre.ToString();
                    dataGridViewConsultas.Rows[rowIndex].Cells[1].Value = (MarcaControlador.getById(perfume.marca.id)).nombre;
                    dataGridViewConsultas.Rows[rowIndex].Cells[2].Value = (GeneroControlador.getById(perfume.genero.id)).genero;
                    dataGridViewConsultas.Rows[rowIndex].Cells[3].Value = perfume.precio_en_pesos.ToString("C", CultureInfo.CurrentCulture);
                    dataGridViewConsultas.Rows[rowIndex].Cells[4].Value = "Ver";
                }
            }
        }

        private void dataGridViewConsultas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                int rowIndex = e.RowIndex;
                Perfume perfumeSeleccionado = Perfumes_Paginados[rowIndex];

                FormVerDetallePerfume detallesForm = new FormVerDetallePerfume(perfumeSeleccionado);
                detallesForm.Show();
            }
            dataGridViewConsultas.CellPainting += dataGridView1_CellPainting;
        }

       

        private void btn_anterior_Click_1(object sender, EventArgs e)
        {
            if (current >= paginador)
            {
                current = current - paginador;
                current_pag = current_pag - 1;
                lbl_numero_pagina.Text = current_pag.ToString();
                paginar(Perfumes_Completo);
            }
        }

        private void btn_posterior_Click_1(object sender, EventArgs e)
        {
            if (current >= paginador)
            {
                current = current + paginador;
                current_pag = current_pag + 1;
                lbl_numero_pagina.Text = current_pag.ToString();
                paginar(Perfumes_Completo);
            }
        }

        private void combo_filtro_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_filtro_marca.SelectedIndex > 0)
            {
                string marcaSeleccionada = combo_filtro_marca.SelectedItem.ToString();
                Marca marca = MarcaControlador.getByName(marcaSeleccionada);
                if (marca != null)
                {
                    filtro.marca = marca;
                    filtrar();
                }
            }
            else
            {
                filtro.marca = null;
                filtrar();
            }
        }

        private void combo_filtro_genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_filtro_genero.SelectedIndex > 0)
            {
                string generoSeleccionado = combo_filtro_genero.SelectedItem.ToString();
                Genero genero = GeneroControlador.getByName(generoSeleccionado);
                if (genero != null)
                {
                    filtro.genero = genero;
                    filtrar();
                }
            }
            else
            {
                filtro.genero = null;
                filtrar();
            }
        }     

        private void filtrar()
        {
            Perfumes_Filtrado = Perfumes_Completo;

            if (filtro.marca != null)
            {
                Perfumes_Filtrado = Perfumes_Filtrado.Where(x => x.marca.id == filtro.marca.id).ToList();
            }

            if (filtro.genero != null)
            {
                Perfumes_Filtrado = Perfumes_Filtrado.Where(x => x.genero.id == filtro.genero.id).ToList();
            }          

            total = Perfumes_Filtrado.Count;
            last_pag = (int)Math.Ceiling((double)total / paginador);
            current = 0;
            current_pag = 1;
            paginar(Perfumes_Filtrado);
            lbl_numero_pagina.Text = current_pag.ToString();
        }


        //Diseño del boton del datagridview
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridViewConsultas.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
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

        //Diseño del combo box
        private void comboBoxdiseño_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            // Obtener el ComboBox y el texto del ítem actual
            ComboBox combo = sender as ComboBox;
            combo.DropDownWidth = combo.Width + 5; // Ajustar tamaño para evitar borde azul
            string text = combo.Items[e.Index].ToString();

            // Definir colores personalizados
            Color backgroundColor;
            Color textColor;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                // Color cuando el ítem está seleccionado
                backgroundColor = Color.FromArgb(195, 156, 164);
                textColor = Color.White;
            }
            else
            {
                // Color cuando el ítem NO está seleccionado
                backgroundColor = Color.FromArgb(250, 236, 239); // Color personalizado
                textColor = Color.FromArgb(195, 156, 164);
            }

            // Pintar el fondo del ítem
            using (SolidBrush brush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            // Dibujar el texto
            TextRenderer.DrawText(e.Graphics, text, e.Font, e.Bounds, textColor, TextFormatFlags.Left);

            // Evitar problemas visuales
            e.DrawFocusRectangle();
        }
    }
}
