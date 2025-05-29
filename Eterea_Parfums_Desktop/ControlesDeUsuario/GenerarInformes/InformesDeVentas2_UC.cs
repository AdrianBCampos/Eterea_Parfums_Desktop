using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario.GenerarInformes
{
    public partial class InformesDeVentas2_UC : UserControl
    {
        private List<Perfume> perfumes;
        private List<Stock> stocks;
        private int numeroSucursal;

        public InformesDeVentas2_UC(int numeroSucursal)
        {
            InitializeComponent();
            this.numeroSucursal = numeroSucursal;
            cargarDatos();
            lbl_info.Text = numeroSucursal.ToString();
        }

        private System.Drawing.Image redimensionarImagen(System.Drawing.Image img, int cellWidth, int cellHeight)
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
            .Where(p => p.activo == true)
            .ToList();

            stocks = StockControlador.getAll()
            .Where(s => s.sucursal != null && s.sucursal.id == numeroSucursal)
            .ToList();
      

            dataGridViewPerfumes.Rows.Clear();
            foreach (Stock stock in stocks)
            {
                Perfume perfume = perfumes.Find(p => p.id == stock.perfume.id);
                if (perfume != null)
                {
                    int rowIndex = dataGridViewPerfumes.Rows.Add();
                    string rutaCompletaImagen = Program.Ruta_Base + perfume.imagen1 + ".jpg";

                    int cellWidth = dataGridViewPerfumes.Columns[0].Width;
                    int cellHeight = dataGridViewPerfumes.RowTemplate.Height;
                    // Verificar si la imagen existe antes de cargarla

                    if (File.Exists(rutaCompletaImagen))
                    {
                        using (System.Drawing.Image originalImage = System.Drawing.Image.FromFile(rutaCompletaImagen))
                        {
                            dataGridViewPerfumes.Rows[rowIndex].Cells[0].Value = redimensionarImagen(originalImage, cellWidth, cellHeight);
                        }
                    }
                    else
                    {
                        dataGridViewPerfumes.Rows[rowIndex].Cells[0].Value = null; // O una imagen por defecto
                    }
                    ((DataGridViewImageCell)dataGridViewPerfumes.Rows[rowIndex].Cells[0]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dataGridViewPerfumes.Rows[rowIndex].Cells[1].Value = perfume.codigo;
                    dataGridViewPerfumes.Rows[rowIndex].Cells[2].Value = (MarcaControlador.getById(perfume.marca.id)).nombre;
                    dataGridViewPerfumes.Rows[rowIndex].Cells[3].Value = perfume.nombre.ToString();
                    dataGridViewPerfumes.Rows[rowIndex].Cells[4].Value = (TipoDePerfumeControlador.getById(perfume.tipo_de_perfume.id)).tipo_de_perfume;
                    dataGridViewPerfumes.Rows[rowIndex].Cells[5].Value = (GeneroControlador.getById(perfume.genero.id)).genero;
                    dataGridViewPerfumes.Rows[rowIndex].Cells[6].Value = perfume.presentacion_ml.ToString();


                    if (perfume.spray.ToString() == "1")
                    {
                        dataGridViewPerfumes.Rows[rowIndex].Cells[7].Value = "Si";
                    }
                    else
                    {
                        dataGridViewPerfumes.Rows[rowIndex].Cells[7].Value = "No";
                    }

                    dataGridViewPerfumes.Rows[rowIndex].Cells[8].Value = perfume.precio_en_pesos.ToString();
                    dataGridViewPerfumes.Rows[rowIndex].Cells[9].Value = SucursalControlador.getById(stock.sucursal.id).nombre;
                    dataGridViewPerfumes.Rows[rowIndex].Cells[10].Value = stock.cantidad;
                }

                //dataGridViewPerfumes.CellPainting += dataGridView1_CellPainting;

            }
        }

        private void btn_exportar_pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarInventario = new SaveFileDialog();
            guardarInventario.FileName = DateTime.Now.ToString("ddMMyyyyHHss") + ".pdf";
            guardarInventario.Filter = "Archivos PDF (*.pdf)|*.pdf";
            guardarInventario.DefaultExt = "pdf";
            guardarInventario.AddExtension = true;

            if (guardarInventario.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardarInventario.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4.Rotate(), 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    try
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Properties.Resources.LogoEtereaFactura, System.Drawing.Imaging.ImageFormat.Png);

                        //Ajustar tamaño del logo
                        logo.ScaleToFit(60, 60);
                        logo.Alignment = iTextSharp.text.Image.UNDERLYING; // Logo en el fondo


                        //Agregar el logo al documento
                        pdfDoc.Add(logo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar el logo: " + ex.Message);
                    }

                    Paragraph headerParagraph = new Paragraph();
                    headerParagraph.Add(Chunk.NEWLINE);  //Salto de línea
                    headerParagraph.Add(new Chunk("INVENTARIO", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 21)));
                    headerParagraph.Add(Chunk.NEWLINE);  //Salto de línea
                    headerParagraph.Add(new Chunk("Direccion: Av. Corrientes 1234, Buenos Aires, Argentina", FontFactory.GetFont(FontFactory.HELVETICA, 14)));
                    headerParagraph.Add(Chunk.NEWLINE);  //Salto de línea
                    headerParagraph.Add(new Chunk("Telefono: 1234-5678", FontFactory.GetFont(FontFactory.HELVETICA, 14)));
                    headerParagraph.Add(Chunk.NEWLINE);
                    headerParagraph.Add(Chunk.NEWLINE);  //Salto de línea
                    headerParagraph.Add(Chunk.NEWLINE);//Salto de línea
                    headerParagraph.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(headerParagraph);


                    //Crear tabla con 11 columnas
                    PdfPTable table = new PdfPTable(11) { WidthPercentage = 100 };
                    table.SetWidths(new float[] { 10f, 10f, 10f, 10f, 10f, 10f, 10f, 10f, 10f, 10f, 10f });

                    //Agregar encabezados
                    string[] headers = { "Imagen", "Código", "Marca", "Nombre", "Tipo", "Género", "Presentación (ml)", "Recargable", "Precio ($)", "Sucursal", "Stock" };
                    foreach (string header in headers)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(header, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)))
                        {
                            BackgroundColor = new BaseColor(200, 200, 200),
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        table.AddCell(cell);
                    }

                    decimal total = 0;
                    foreach (DataGridViewRow row in dataGridViewPerfumes.Rows)
                    {
                        // Insertar imagen en la celda
                        if (row.Cells[0].Value != null && row.Cells[0].Value is System.Drawing.Image)
                        {
                            System.Drawing.Image img = (System.Drawing.Image)row.Cells[0].Value;
                            using (MemoryStream ms = new MemoryStream())
                            {
                                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                iTextSharp.text.Image imgPdf = iTextSharp.text.Image.GetInstance(ms.ToArray());
                                imgPdf.ScaleAbsolute(40f, 40f);
                                PdfPCell imgCell = new PdfPCell(imgPdf, true)
                                {
                                    HorizontalAlignment = Element.ALIGN_CENTER,
                                    VerticalAlignment = Element.ALIGN_MIDDLE,
                                    Padding = 5
                                };
                                table.AddCell(imgCell);
                            }
                        }
                        else
                        {
                            PdfPCell emptyCell = new PdfPCell(new Phrase("Sin imagen"))
                            {
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                VerticalAlignment = Element.ALIGN_MIDDLE
                            };
                            table.AddCell(emptyCell);
                        }

                        //Insertar valores en la tabla
                        for (int i = 1; i <= 10; i++)
                        {
                            string valorCelda = row.Cells[i].Value?.ToString() ?? "N/A";
                            PdfPCell dataCell = new PdfPCell(new Phrase(valorCelda))
                            {
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                VerticalAlignment = Element.ALIGN_MIDDLE
                            };
                            table.AddCell(dataCell);
                        }

                        //Sumar total
                        if (decimal.TryParse(row.Cells[8].Value?.ToString(), out decimal precio))
                        {
                            total += precio * decimal.Parse(row.Cells[10].Value.ToString());
                        }
                    }

                    //Agregar tabla de productos
                    pdfDoc.Add(table);

                    //Agregar total
                    Paragraph totalParagraph = new Paragraph($"Total: {total.ToString("N2")}$", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))
                    {
                        Alignment = Element.ALIGN_RIGHT
                    };
                    pdfDoc.Add(totalParagraph);
                    Paragraph footerParagraph = new Paragraph();
                    footerParagraph.Add(Chunk.NEWLINE);
                    footerParagraph.Add(new Chunk("Reporte de stock - Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"),
                    FontFactory.GetFont(FontFactory.HELVETICA, 8)));
                    footerParagraph.Alignment = Element.ALIGN_CENTER;
                    footerParagraph.Add(Chunk.NEWLINE);
                    pdfDoc.Add(footerParagraph);

                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
