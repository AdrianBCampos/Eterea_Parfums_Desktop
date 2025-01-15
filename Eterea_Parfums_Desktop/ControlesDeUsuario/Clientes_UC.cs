using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            clientes = ClienteControlador.obtenerTodos();

            dataGridView1.Rows.Clear();
            foreach (Cliente cliente in clientes)
            {
                if (cliente.activo == 1 && (string.IsNullOrEmpty(filtroDni) || cliente.dni.ToString().Contains(filtroDni)))
                {
                    int rowIndex = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowIndex].Cells[0].Value = cliente.id.ToString();
                    dataGridView1.Rows[rowIndex].Cells[1].Value = cliente.usuario.ToString();
                    dataGridView1.Rows[rowIndex].Cells[2].Value = cliente.nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[3].Value = cliente.apellido.ToString();
                    dataGridView1.Rows[rowIndex].Cells[4].Value = cliente.dni.ToString();

                    dataGridView1.Rows[rowIndex].Cells[5].Value = cliente.celular.ToString();
                    dataGridView1.Rows[rowIndex].Cells[6].Value = cliente.e_mail.ToString();

                    if (cliente.activo.ToString() == "1")
                    {
                        dataGridView1.Rows[rowIndex].Cells[7].Value = "Activo";
                    }
                    else
                    {
                        dataGridView1.Rows[rowIndex].Cells[7].Value = "Inactivo";
                    }

                    dataGridView1.Rows[rowIndex].Cells[8].Value = "Editar";
                    dataGridView1.Rows[rowIndex].Cells[9].Value = "Eliminar";
                }
            }
        }

        private void btn_crear_cliente_Click(object sender, EventArgs e)
        {
            FormCrearClienteABM formCrearClienteABM = new FormCrearClienteABM();       
            DialogResult dr = formCrearClienteABM.ShowDialog();

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

                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                Trace.WriteLine("El id es: " + id);

                Cliente cliente_editar = ClienteControlador.obtenerPorId(id);

                FormEditarClienteABM formEditarClienteABM = new FormEditarClienteABM(cliente_editar);

                DialogResult dr = formEditarClienteABM.ShowDialog();

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
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                Trace.WriteLine("El id es: " + id);

                Cliente cliente_eliminar = ClienteControlador.obtenerPorId(id);

                FormEliminarClienteABM formEliminarClienteABM = new FormEliminarClienteABM(cliente_eliminar, id);

                DialogResult dr = formEliminarClienteABM.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK");

                    //ACTUALIZAR LA LISTA
                    cargarClientes();

                }
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
