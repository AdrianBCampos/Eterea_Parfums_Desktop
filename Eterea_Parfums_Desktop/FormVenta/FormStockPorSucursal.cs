using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormStockPorSucursal : Form
    {
        private string nombrePerfume;

        public FormStockPorSucursal(string nombrePerfume)
        {
            InitializeComponent();
            this.nombrePerfume = nombrePerfume;

            AplicarEstiloDataGridView();  // 👈 Llamada para aplicar el estilo

            CargarDatos();
        }

        private void CargarDatos()
        {
            // Obtener todas las sucursales
            List<Sucursal> sucursales = SucursalControlador.getAll();

            // Configurar DataGridView
            dataGridViewStock.Columns.Clear();
            dataGridViewStock.Rows.Clear();

            // Modo de ajuste general
            dataGridViewStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Agregar columnas principales
            dataGridViewStock.Columns.Add("Nombre", "Nombre");
            dataGridViewStock.Columns.Add("Presentacion", "Presentación");
            dataGridViewStock.Columns.Add("Tipo", "Tipo");
            dataGridViewStock.Columns.Add("Genero", "Género");
            dataGridViewStock.Columns.Add("Precio", "Precio");

            foreach (var suc in sucursales)
            {
                dataGridViewStock.Columns.Add($"Sucursal_{suc.id}", suc.nombre);
            }

            // Asignar pesos a las columnas principales
            dataGridViewStock.Columns["Nombre"].FillWeight = 35;
            dataGridViewStock.Columns["Presentacion"].FillWeight = 8;
            dataGridViewStock.Columns["Tipo"].FillWeight = 10;
            dataGridViewStock.Columns["Genero"].FillWeight = 8;
            dataGridViewStock.Columns["Precio"].FillWeight = 14;

            // Calcular peso restante para las columnas de sucursal
            int cantidadSucursales = sucursales.Count;
            float pesoRestante = 100 - (35 + 10 + 10 + 10 + 15);
            float pesoPorSucursal = (cantidadSucursales > 0) ? (pesoRestante / cantidadSucursales) : 0;

            foreach (var suc in sucursales)
            {
                dataGridViewStock.Columns[$"Sucursal_{suc.id}"].FillWeight = pesoPorSucursal;
            }

            // Obtener perfumes con ese nombre
            List<Perfume> perfumes = PerfumeControlador.getByNombre(nombrePerfume);
            var stockPorPerfumeSucursal = StockControlador.ObtenerTodosLosStocksPorSucursal();

            foreach (var perfume in perfumes)
            {
                int rowIndex = dataGridViewStock.Rows.Add();
                var row = dataGridViewStock.Rows[rowIndex];
                row.Cells["Nombre"].Value = perfume.nombre;
                row.Cells["Presentacion"].Value = perfume.presentacion_ml + " ml";
                row.Cells["Tipo"].Value = TipoDePerfumeControlador.getById(perfume.tipo_de_perfume.id).tipo_de_perfume;
                row.Cells["Genero"].Value = GeneroControlador.getById(perfume.genero.id).genero;
                row.Cells["Precio"].Value = perfume.precio_en_pesos.ToString("C", CultureInfo.CurrentCulture);

                foreach (var suc in sucursales)
                {
                    int cantidad = 0;
                    if (stockPorPerfumeSucursal.TryGetValue((perfume.id, suc.id), out int stock))
                    {
                        cantidad = stock;
                    }
                    row.Cells[$"Sucursal_{suc.id}"].Value = cantidad;
                }
            }

            dataGridViewStock.ClearSelection();
        }

        private void AplicarEstiloDataGridView()
        {
            // Fondo general
            dataGridViewStock.BackgroundColor = Color.FromArgb(250, 236, 239);  // Igual que Consultas
            dataGridViewStock.GridColor = Color.FromArgb(195, 156, 164);        // Color de línea

            // Fuente general
            dataGridViewStock.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridViewStock.DefaultCellStyle.ForeColor = Color.FromArgb(195, 156, 164);
            dataGridViewStock.DefaultCellStyle.BackColor = Color.White;
            dataGridViewStock.DefaultCellStyle.SelectionBackColor = Color.FromArgb(195, 156, 164);
            dataGridViewStock.DefaultCellStyle.SelectionForeColor = Color.White;

            // Encabezados
            dataGridViewStock.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(228, 137, 164);
            dataGridViewStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewStock.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewStock.EnableHeadersVisualStyles = false;

            // Bordes y estilos
            dataGridViewStock.BorderStyle = BorderStyle.None;
            dataGridViewStock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewStock.RowHeadersVisible = false;

        }



        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
