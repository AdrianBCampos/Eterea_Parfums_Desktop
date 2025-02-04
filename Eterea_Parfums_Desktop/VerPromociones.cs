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

namespace Eterea_Parfums_Desktop
{
    public partial class VerPromociones : Form
    {
        private Perfume perfume;

        public VerPromociones(Perfume perfumeSeleccionado)
        {
            InitializeComponent();
            txt_nombre_perfume.Text = perfumeSeleccionado.nombre;
            txt_precio_lista.Text = perfumeSeleccionado.precio_en_pesos.ToString("N2");
            this.perfume = perfumeSeleccionado;

            string nombreImagen = perfumeSeleccionado.imagen1.ToString();
            string rutaCompletaImagen = Program.Ruta_Base + nombreImagen + ".jpg";
            img_perfume.Image = Image.FromFile(rutaCompletaImagen);

            //perfume = perfumeSeleccionado;
            CargarDataGridViewPromociones();
        }
     
        private void btn_ver_detalles_Click(object sender, EventArgs e)
        {
            VerDetallePerfume verDetallePerfume = new VerDetallePerfume(perfume);
            verDetallePerfume.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDataGridViewPromociones()
        {
            //Ocultas la primera columna de la tabla (es una columna de seleccion de fila)
            dataGridViewpromociones.RowHeadersVisible = false;

            // Limpiar DataGridView
            dataGridViewpromociones.Rows.Clear();

            // Obtener promociones asociadas al perfume
            List<Promocion> promociones = PromoControlador.getByIDPerfume(perfume.id);

            if (promociones != null && promociones.Count > 0)
            {
                foreach (Promocion promo in promociones)
                {
                    int rowIndex = dataGridViewpromociones.Rows.Add();
                    dataGridViewpromociones.Rows[rowIndex].Cells[0].Value = promo.id;
                    dataGridViewpromociones.Rows[rowIndex].Cells[1].Value = promo.nombre;
                    dataGridViewpromociones.Rows[rowIndex].Cells[2].Value = "Ver";
                }
                dataGridViewpromociones.CellPainting += dataGridViewpromociones_CellPainting;
            }           
            else
            {
                MessageBox.Show("Este perfume no tiene promociones disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewpromociones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que no se haga clic en el encabezado de la columna
            if (e.RowIndex >= 0 && e.ColumnIndex == 2) // La columna del botón "Ver"
            {
                // Obtiene la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridViewpromociones.Rows[e.RowIndex];

                // Obtiene los valores de la fila
                int idPromo = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                string nombre = filaSeleccionada.Cells[1].Value.ToString();

                // Buscar la promoción en la lista
                Promocion promocionSeleccionada = PromoControlador.getByIDPerfume(perfume.id)
                    .FirstOrDefault(p => p.id == idPromo);

                if (promocionSeleccionada != null)
                {
                    // Obtener precio de lista del perfume
                    double precioLista = perfume.precio_en_pesos;

                    // Obtener porcentaje de descuento
                    double porcentajeDescuento = promocionSeleccionada.descuento;

                    // Calcular el valor del descuento
                    double valorDescuento = precioLista * (porcentajeDescuento / 100);

                    // Calcular el precio final con descuento
                    double precioFinal = precioLista - valorDescuento;

                    // Mostrar los datos en los TextBox
                    txt_nombre.Text = promocionSeleccionada.nombre;
                    txt_fecha_inicio.Text = promocionSeleccionada.fecha_inicio.ToShortDateString();
                    txt_fecha_fin.Text = promocionSeleccionada.fecha_fin.ToShortDateString();
                    txt_descuento.Text = porcentajeDescuento.ToString("N2") + " %";
                    txt_valor_descuento.Text = valorDescuento.ToString("N2");
                    txt_precio_final.Text = precioFinal.ToString("N2");


                }
            }
        }    

        private void dataGridViewpromociones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridViewpromociones.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
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

        
    }
}
