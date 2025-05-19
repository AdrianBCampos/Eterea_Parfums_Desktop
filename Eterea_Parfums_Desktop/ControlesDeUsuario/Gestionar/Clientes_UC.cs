using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario
{
    public partial class Clientes_UC : UserControl
    {
        List<Cliente> clientes;

        public Clientes_UC()
        {
            InitializeComponent();
            txt_buscar_dni.MaxLength = 8;

            // Asocia el evento KeyPress para aceptar solo números
            txt_buscar_dni.KeyPress += txt_buscar_dni_KeyPress;
            txt_buscar_dni.TextChanged += txt_buscar_dni_TextChanged;
            cargarClientes();
        }

        private void cargarClientes(string filtroDni = "")
        {
            //Ocultas la primera columna de la tabla (es una columna de seleccion de fila)
            dataGridViewClientes.RowHeadersVisible = false;

            clientes = ClienteControlador.obtenerTodos();

            dataGridViewClientes.Rows.Clear();
            foreach (Cliente cliente in clientes)
            {
                if (cliente.activo == true && (string.IsNullOrEmpty(filtroDni) || cliente.dni.ToString().Contains(filtroDni)))
                {
                    int rowIndex = dataGridViewClientes.Rows.Add();

                    dataGridViewClientes.Rows[rowIndex].Cells[0].Value = cliente.id.ToString();
                    dataGridViewClientes.Rows[rowIndex].Cells[1].Value = cliente.usuario.ToString();
                    dataGridViewClientes.Rows[rowIndex].Cells[2].Value = cliente.nombre.ToString();
                    dataGridViewClientes.Rows[rowIndex].Cells[3].Value = cliente.apellido.ToString();
                    dataGridViewClientes.Rows[rowIndex].Cells[4].Value = cliente.dni.ToString();

                    dataGridViewClientes.Rows[rowIndex].Cells[5].Value = cliente.celular.ToString();
                    dataGridViewClientes.Rows[rowIndex].Cells[6].Value = cliente.e_mail.ToString();

                    if (cliente.activo.ToString() == "1")
                    {
                        dataGridViewClientes.Rows[rowIndex].Cells[7].Value = "Activo";
                    }
                    else
                    {
                        dataGridViewClientes.Rows[rowIndex].Cells[7].Value = "Inactivo";
                    }

                    dataGridViewClientes.Rows[rowIndex].Cells[8].Value = "Editar";
                    dataGridViewClientes.Rows[rowIndex].Cells[9].Value = "Eliminar";
                }
                dataGridViewClientes.ClearSelection();

                dataGridViewClientes.CellPainting += dataGridView1_CellPainting;
            }
        }

        private void btn_crear_cliente_Click(object sender, EventArgs e)
        {
            FormCrearCliente formCrearClienteABM = new FormCrearCliente();
            DialogResult dr = formCrearClienteABM.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                Trace.WriteLine("OK");

                //ACTUALIZAR LA LISTA
                cargarClientes();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "Editar")
            {
                //EDITAMOS

                int id = int.Parse(dataGridViewClientes.Rows[e.RowIndex].Cells[0].Value.ToString());

                Trace.WriteLine("El id es: " + id);

                Cliente cliente_editar = ClienteControlador.obtenerPorId(id);

                FormEditarCliente formEditarClienteABM = new FormEditarCliente(cliente_editar);

                DialogResult dr = formEditarClienteABM.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK");

                    //ACTUALIZAR LA LISTA
                    cargarClientes();

                }
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                //ELIMINAMOS
                int id = int.Parse(dataGridViewClientes.Rows[e.RowIndex].Cells[0].Value.ToString());

                Trace.WriteLine("El id es: " + id);

                Cliente cliente_eliminar = ClienteControlador.obtenerPorId(id);

                FormEliminarCliente formEliminarClienteABM = new FormEliminarCliente(cliente_eliminar, id);

                DialogResult dr = formEliminarClienteABM.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK");

                    //ACTUALIZAR LA LISTA
                    cargarClientes();

                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridViewClientes.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
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

        private void txt_buscar_dni_TextChanged(object sender, EventArgs e)
        {
            string filtroDni = txt_buscar_dni.Text.Trim();

            // Actualiza el DataGridView con el filtro
            cargarClientes(filtroDni);
        }

        private void txt_buscar_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, retroceso y control (como copiar/pegar)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar entrada no válida
            }
        }

    }
}
