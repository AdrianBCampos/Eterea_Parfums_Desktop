using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario
{
    public partial class Promos_UC : UserControl
    {
        List<Promocion> promociones;
        public Promos_UC()
        {
            InitializeComponent();
            cargarPromociones();
        }

        public void recargarPromociones()
        {
            // Código para volver a cargar el DataGridView con las promociones actualizadas
            var promociones = PromoControlador.obtenerTodos();
            dataGridViewPromos.DataSource = promociones;
        }

        private void cargarPromociones(string filtroNombre = "")
        {
            promociones = PromoControlador.obtenerTodos();

            dataGridViewPromos.Rows.Clear();
            foreach (Promocion promocion in promociones)
            {
                if (string.IsNullOrEmpty(filtroNombre) || promocion.nombre.ToString().IndexOf(filtroNombre, StringComparison.OrdinalIgnoreCase) >= 0)

                {
                    int rowIndex = dataGridViewPromos.Rows.Add();

                    dataGridViewPromos.Rows[rowIndex].Cells[0].Value = promocion.id.ToString();
                    dataGridViewPromos.Rows[rowIndex].Cells[1].Value = promocion.nombre.ToString();
                    dataGridViewPromos.Rows[rowIndex].Cells[3].Value = promocion.fecha_inicio.ToString("dd-MM-yyyy");
                    dataGridViewPromos.Rows[rowIndex].Cells[4].Value = promocion.fecha_fin.ToString("dd-MM-yyyy");
                    //dataGV_Promos.Rows[rowIndex].Cells[2].Value = promocion.descuento.ToString();
                    int descuento = promocion.descuento; // Obtén el valor del descuento como entero

                    string textoPromocion;

                    switch (descuento)
                    {
                        case 50:
                            textoPromocion = "2 x 1";
                            break;
                        case 25:
                            textoPromocion = "2da Unidad 50% Dto.";
                            break;
                        case 35:
                            textoPromocion = "2da Unidad 70% Dto.";
                            break;
                        case 40:
                            textoPromocion = "2da Unidad 80% Dto.";
                            break;
                        case 10:
                            textoPromocion = "Descuento especial del 10%";
                            break;
                        default:
                            textoPromocion = "Sin promoción"; // Texto predeterminado para otros valores
                            break;
                    }

                    // Asigna el texto al DataGridView
                    dataGridViewPromos.Rows[rowIndex].Cells[2].Value = textoPromocion;

                    if (promocion.activo.ToString() == "1")
                    {
                        dataGridViewPromos.Rows[rowIndex].Cells[5].Value = "Activo";
                    }
                    else
                    {
                        dataGridViewPromos.Rows[rowIndex].Cells[5].Value = "Inactivo";
                    }

                    dataGridViewPromos.Rows[rowIndex].Cells[6].Value = "Editar";
                    dataGridViewPromos.Rows[rowIndex].Cells[7].Value = "Eliminar";
                }
            }
        }
        private void txt_buscar_nombre_TextChanged(object sender, EventArgs e)
        {
            string filtroNombre = textbox_nombrePromo.Text.Trim();

            // Actualiza el DataGridView con el filtro
            cargarPromociones(filtroNombre);
        }



        private void btn_crear_promo_Click(object sender, EventArgs e)
        {
            FormCrearPromo formCrearPromo = new FormCrearPromo();
            DialogResult dr = formCrearPromo.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Trace.WriteLine("OK");

                //ACTUALIZAR LA LISTA
                cargarPromociones();
            }
        }

        private void dataGridViewPromos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si el clic fue en la columna de editar (puedes verificar el índice de la columna)
            if (e.ColumnIndex == dataGridViewPromos.Columns[6].Index && e.RowIndex >= 0)
            {
                // Obtener el ID de la promoción de la fila seleccionada
                var idPromoCell = dataGridViewPromos.Rows[e.RowIndex].Cells[0].Value;

                // Verificar si el ID de la promoción es válido
                if (idPromoCell != null && int.TryParse(idPromoCell.ToString(), out int idPromo))
                {
                    /* int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                Trace.WriteLine("El id es: " + id);

                Cliente cliente_editar = ClienteControlador.obtenerPorId(id);

                FormEditarClienteABM formEditarClienteABM = new FormEditarClienteABM(cliente_editar);

                DialogResult dr = formEditarClienteABM.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK");

                    //ACTUALIZAR LA LISTA
                    cargarClientes();

                }*/
                    // Crear una nueva instancia del formulario de edición
                    Promocion promocion_editar = PromoControlador.obtenerPorId(idPromo);
                    FormEditarPromo formEditarPromo = new FormEditarPromo(promocion_editar);
                    DialogResult dr = formEditarPromo.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                        Trace.WriteLine("OK");

                        //ACTUALIZAR LA LISTA
                        cargarPromociones();

                    }

                }
            }
            // Verificar si el clic fue en la columna de "Eliminar"
            if (e.ColumnIndex == dataGridViewPromos.Columns[7].Index && e.RowIndex >= 0)
            {
                // Obtener el ID y el nombre de la promoción de la fila seleccionada
                var idPromoCellEliminar = dataGridViewPromos.Rows[e.RowIndex].Cells[0].Value;
                var nombrePromoCellEliminar = dataGridViewPromos.Rows[e.RowIndex].Cells[1].Value;

                // Verificar si el ID de la promoción es válido
                if (idPromoCellEliminar != null && int.TryParse(idPromoCellEliminar.ToString(), out int idPromoEliminar))
                {
                    string nombrePromoEliminar = nombrePromoCellEliminar?.ToString() ?? "Sin nombre";

                    // Crear una nueva instancia del formulario de eliminación y pasar datos
                    FormEliminarPromo formEliminarPromo = new FormEliminarPromo(idPromoEliminar, nombrePromoEliminar);

                    // Mostrar el formulario
                    formEliminarPromo.ShowDialog();
                    cargarPromociones();
                }
                else
                {
                    // Mostrar un mensaje de error si el ID no es válido
                    MessageBox.Show("No se pudo obtener el ID de la promoción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
 }

