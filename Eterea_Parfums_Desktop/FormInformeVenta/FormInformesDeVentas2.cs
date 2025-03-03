using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop
{
    public partial class FormInformesDeVentas2 : Form
    {

        private List<Perfume> perfumes;
        private List<Stock> stocks;
        public FormInformesDeVentas2()
        {
            InitializeComponent();
        }

        private Boolean validarFecha()
        { 
            string mensaje = "";

            if (string.IsNullOrEmpty(dateTimeFechaInicio.Value.ToString("yyyy-MM-dd")))
            {
                mensaje = "Debe seleccionar una fecha de inicio";
            }
            if (string.IsNullOrEmpty(dateTimeFechaFin.Value.ToString("yyyy-MM-dd")))
            {
                mensaje = "Debe seleccionar una fecha de fin";
            }
            if (dateTimeFechaInicio.Value > dateTimeFechaFin.Value)
            {
                mensaje = "La fecha de inicio no puede ser mayor a la fecha de fin";
            }

            if (mensaje != "")
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private Image redimensionarImagen(Image img, int cellWidth, int cellHeight)
        {
            Bitmap resizedImage = new Bitmap(cellWidth, cellHeight);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(img, 0, 0, cellWidth, cellHeight);
            }
            return resizedImage;
        }


        private void cargarDatos()
        {
            //Ocultas la primera columna de la tabla (es una columna de seleccion de fila)
            dataGridViewPerfumes.RowHeadersVisible = false;
            perfumes = PerfumeControlador.getAll()
            .Where(p => p.activo == 1 && p.anio_de_lanzamiento == 2011)
            .ToList();

            stocks = StockControlador.getAll();
             

            dataGridViewPerfumes.Rows.Clear();
            foreach (Stock stock in stocks)
            {
                Perfume perfume = perfumes.Find(p => p.id == stock.perfume.id);
                if(perfume != null)
                {
                    int rowIndex = dataGridViewPerfumes.Rows.Add();
                    string rutaCompletaImagen = Program.Ruta_Base + perfume.imagen1;

                    int cellWidth = dataGridViewPerfumes.Columns[0].Width;
                    int cellHeight = dataGridViewPerfumes.RowTemplate.Height;
                    // Verificar si la imagen existe antes de cargarla

                    if (File.Exists(rutaCompletaImagen))
                    {
                        using (Image originalImage = Image.FromFile(rutaCompletaImagen))
                        {
                            dataGridViewPerfumes.Rows[rowIndex].Cells[0].Value = redimensionarImagen(originalImage, cellWidth, cellHeight);
                        }
                    }
                    else
                    {
                        dataGridViewPerfumes.Rows[rowIndex].Cells[0].Value = null; // O una imagen por defecto
                    }
                    ((DataGridViewImageCell)dataGridViewPerfumes.Rows[rowIndex].Cells[0]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dataGridViewPerfumes.Rows[rowIndex].Cells[0].Value = Image.FromFile(rutaCompletaImagen);
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
                    dataGridViewPerfumes.Rows[rowIndex].Cells[11].Value = SucursalControlador.getById(stock.sucursal.id).nombre;
                    dataGridViewPerfumes.Rows[rowIndex].Cells[12].Value = stock.cantidad;
                }

                //dataGridViewPerfumes.CellPainting += dataGridView1_CellPainting;

            }
        }

        private void dateTimeFechaFin_ValueChanged(object sender, EventArgs e)
        {
            if (validarFecha())
            {
               cargarDatos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSeleccionarInformeVenta informesDeVentas = new FormSeleccionarInformeVenta();
            informesDeVentas.Show();
            this.Close();
        }
    }
}
