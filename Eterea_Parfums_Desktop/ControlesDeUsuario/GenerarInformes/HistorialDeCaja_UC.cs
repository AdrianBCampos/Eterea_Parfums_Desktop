using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario.GenerarInformes
{
    public partial class HistorialDeCaja_UC : UserControl
    {
        private int numeroSucursal;
        private List<HistorialCajaDTO> historial;

        public HistorialDeCaja_UC(int numeroSucursal)
        {
            InitializeComponent();
            this.numeroSucursal = numeroSucursal;
            CargarHistorial();
            this.dataGridViewHistorialCaja.CellClick += dataGridViewHistorialCaja_CellClick;

        }
        private void CargarHistorial()
        {
            historial = HistorialCajaControlador.GetPorSucursal(numeroSucursal);

            dataGridViewHistorialCaja.RowHeadersVisible = false;

            dataGridViewHistorialCaja.Columns.Clear();
            dataGridViewHistorialCaja.DataSource = null;
            dataGridViewHistorialCaja.AutoGenerateColumns = false;
            dataGridViewHistorialCaja.RowHeadersVisible = false; // <--- Esto elimina la columna vacía de encabezados

            // Columnas personalizadas
            dataGridViewHistorialCaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Caja N°",
                DataPropertyName = "NumeroCaja",
                ReadOnly = true
            });

            dataGridViewHistorialCaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Apertura",
                DataPropertyName = "FechaApertura",
                ReadOnly = true
            });

            dataGridViewHistorialCaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cierre",
                DataPropertyName = "FechaCierre",
                ReadOnly = true
            });

            dataGridViewHistorialCaja.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Empleado",
                DataPropertyName = "Empleado",
                ReadOnly = true
            });

            // Botón "Ver Empleado"
            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn
            {
                HeaderText = "Datos Empleado",
                Text = "Ver Empleado",
                UseColumnTextForButtonValue = true,
                Name = "btnVerEmpleado"
            };
            dataGridViewHistorialCaja.Columns.Add(btnCol);

            dataGridViewHistorialCaja.DataSource = historial;

            dataGridViewHistorialCaja.CellPainting += dataGridViewHistorialCaja_CellPainting;


        }


        // Manejo del clic en botón
        private void dataGridViewHistorialCaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewHistorialCaja.Columns[e.ColumnIndex].Name == "btnVerEmpleado")
            {
                var usuario = historial[e.RowIndex].Usuario;
                FormEmpleado form = new FormEmpleado(usuario);
                form.StartPosition = FormStartPosition.CenterScreen; // Opcional: lo centra en pantalla
                form.TopMost = true; // Lo muestra encima de todo
                form.ShowDialog(); // Usar Show() si querés que no bloquee la UI. Usar ShowDialog() si querés que sea modal.
                form.BringToFront(); // Asegura que esté al frente
                form.Focus(); // Pone el foco
            }
        }

        public void ActualizarSucursal(int nuevaSucursal)
        {
            this.numeroSucursal = nuevaSucursal;
            CargarHistorial();
        }

        private void dataGridViewHistorialCaja_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridViewHistorialCaja.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
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
