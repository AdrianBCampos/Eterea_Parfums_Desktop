using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;

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

        private void btn_exportar_pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarFactura = new SaveFileDialog();
            guardarFactura.FileName = DateTime.Now.ToString("ddMMyyyyHHss") + ".pdf";
            guardarFactura.Filter = "Archivos PDF (*.pdf)|*.pdf"; // Filtro para archivos PDF
            guardarFactura.DefaultExt = "pdf"; // Extensión por defecto
            guardarFactura.AddExtension = true;
            string PaginaHTML_Texto = Properties.Resources.PlantillaFactura.ToString();
            
            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridViewPerfumes.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells[0].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[1].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[2].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[3].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[4].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[5].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[6].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[7].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[8].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[9].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[10].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[11].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells[12].Value.ToString() + "</td>";
                filas += "</tr>";
                total += Convert.ToDecimal(row.Cells[10].Value.ToString());
            }

            
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            if (guardarFactura.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(guardarFactura.FileName, FileMode.Create))
                    {
                        //Creamos un nuevo documento y lo definimos como PDF
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        //Agregamos la imagen del banner al documento
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.LogoEtereaFactura, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;

                        //img.SetAbsolutePosition(10,100);
                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                        pdfDoc.Add(img);

                        using (StringReader sr = new StringReader(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }
                }
            }

        }
    }
}
