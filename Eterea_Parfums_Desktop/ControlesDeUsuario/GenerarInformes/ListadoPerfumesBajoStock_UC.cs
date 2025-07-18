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
    public partial class ListadoPerfumesBajoStock_UC : UserControl
    {
        private int idSucursal;
        public ListadoPerfumesBajoStock_UC(int idSucursal)
        {
            InitializeComponent();

            this.idSucursal = idSucursal;

            var sucursal = SucursalControlador.getAll().FirstOrDefault(s => s.id == idSucursal);
            if (sucursal != null)
            {
                lbl_info.Text = sucursal.nombre;
            }

            CargarDatos();

            this.Cursor = Cursors.Default;
            this.UseWaitCursor = false;

        }
        private void CargarDatos()
        {
            dataGridViewPerfumesBajoStock.Rows.Clear();

            //Se oculta la primera columna de la tabla (es una columna de seleccion de fila)
            dataGridViewPerfumesBajoStock.RowHeadersVisible = false;

            var perfumes = PerfumeControlador.getAll(); // devuelve List<Perfume>
            var stocks = StockControlador.getAll()
                .Where(s => s.sucursal != null && s.sucursal.id == idSucursal)
                .ToList(); // List<Stock> de la sucursal actual

            foreach (var stock in stocks)
            {
                var perfume = perfumes.FirstOrDefault(p => p.id == stock.perfume.id);
                if (perfume == null) continue;

                int cantidadStock = stock.cantidad;
                bool? activo = perfume.activo;

                bool incluir =
                    (cantidadStock > 0 && cantidadStock <= 5) ||
                    (cantidadStock == 0 && (
                        (activo ?? false) || // si es null, lo tratamos como false
                        (!activo.GetValueOrDefault() && perfume.fecha_baja.HasValue && perfume.fecha_baja.Value >= DateTime.Now.AddDays(-30))
                    ));

                if (incluir)
                {
                    string marca = perfume.marca != null ? MarcaControlador.getById(perfume.marca.id)?.nombre ?? "Sin marca" : "Sin marca";
                    string tipo = perfume.tipo_de_perfume != null ? TipoDePerfumeControlador.getById(perfume.tipo_de_perfume.id)?.tipo_de_perfume ?? "Sin tipo" : "Sin tipo";
                    string genero = perfume.genero != null ? GeneroControlador.getById(perfume.genero.id)?.genero ?? "Sin género" : "Sin género";

                    dataGridViewPerfumesBajoStock.Rows.Add(
                        perfume.codigo,
                        marca,
                        perfume.nombre,
                        tipo,
                        genero,
                        $"{perfume.presentacion_ml} ml",
                        perfume.precio_en_pesos.ToString("C"),
                        cantidadStock
                    );


                }
            }
        }

        public void ActualizarSucursal(Sucursal nuevaSucursal)
        {
            this.idSucursal = nuevaSucursal.id;
            lbl_info.Text = nuevaSucursal.nombre;
            CargarDatos(); // Para refrescar la tabla
        }

        private void btn_exportar_pdf_Click(object sender, EventArgs e)
        {
            if (dataGridViewPerfumesBajoStock.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Sucursal sucursal = SucursalControlador.getById(idSucursal);

            SaveFileDialog guardarInventario = new SaveFileDialog
            {
                FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf",
                Filter = "Archivos PDF (*.pdf)|*.pdf",
                DefaultExt = "pdf",
                AddExtension = true
            };

            if (guardarInventario.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardarInventario.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4.Rotate(), 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Logo
                    try
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Properties.Resources.LogoEtereaFactura, System.Drawing.Imaging.ImageFormat.Png);
                        logo.ScaleToFit(70, 70);
                        logo.Alignment = iTextSharp.text.Image.UNDERLYING;
                        pdfDoc.Add(logo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar el logo: " + ex.Message);
                    }

                    // Encabezado
                    Paragraph header = new Paragraph();
                    header.Alignment = Element.ALIGN_CENTER;
                    header.Add(Chunk.NEWLINE);
                    header.Add(new Chunk("INVENTARIO - Bajo Stock", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 21)));
                    header.Add(Chunk.NEWLINE);
                    header.Add(Chunk.NEWLINE);
                    header.Add(new Chunk($"{sucursal.nombre} - {sucursal.calle_id.nombre} {sucursal.numeracion_calle} - {sucursal.provincia_id.nombre} - {sucursal.pais_id.nombre}.",
                        FontFactory.GetFont(FontFactory.HELVETICA, 12)));
                    header.Add(Chunk.NEWLINE);
                    header.Add(Chunk.NEWLINE);
                    header.Add(Chunk.NEWLINE);
                    pdfDoc.Add(header);

                    // Tabla (8 columnas)
                    PdfPTable table = new PdfPTable(8) { WidthPercentage = 100 };
                    table.SetWidths(new float[] { 12f, 12f, 14f, 14f, 12f, 12f, 12f, 12f });

                    string[] columnas = { "Código", "Marca", "Nombre", "Tipo", "Género", "Presentación", "Precio", "Stock" };
                    foreach (string col in columnas)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(col, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)))
                        {
                            BackgroundColor = new BaseColor(200, 200, 200),
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        table.AddCell(cell);
                    }

                    int totalStock = 0;

                    foreach (DataGridViewRow row in dataGridViewPerfumesBajoStock.Rows)
                    {
                        if (row.IsNewRow || row.Cells.Count < 8) continue;

                        for (int i = 0; i < 8; i++)
                        {
                            string valor = row.Cells[i].FormattedValue?.ToString() ?? "N/A";
                            table.AddCell(new PdfPCell(new Phrase(valor))
                            {
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                VerticalAlignment = Element.ALIGN_MIDDLE
                            });
                        }

                        // Sumamos stock
                        if (int.TryParse(row.Cells[7].Value?.ToString(), out int stock))
                        {
                            totalStock += stock;
                        }
                    }

                    pdfDoc.Add(table);

                    /*
                    // Total
                    Paragraph totalParagraph = new Paragraph($"Total de unidades en stock: {totalStock}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))
                    {
                        Alignment = Element.ALIGN_RIGHT
                    };
                    pdfDoc.Add(totalParagraph);*/

                    // Footer
                    Paragraph footer = new Paragraph();
                    footer.Add(Chunk.NEWLINE);
                    footer.Add(new Chunk("Reporte generado el " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), FontFactory.GetFont(FontFactory.HELVETICA, 8)));
                    footer.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(footer);

                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListadoPerfumesBajoStock_UC_Load(object sender, EventArgs e)
        {

        }
    }
}
