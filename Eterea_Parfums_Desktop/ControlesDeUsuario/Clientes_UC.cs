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

            cargarClientes();
        }

        private void cargarClientes()
        {
            clientes = ClienteControlador.obtenerTodos();

            dataGridView1.Rows.Clear();
            foreach (Cliente cliente in clientes)
            {
                if (cliente.activo == 1)
                {
                    int rowIndex = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowIndex].Cells[0].Value = cliente.id.ToString();
                    dataGridView1.Rows[rowIndex].Cells[1].Value = cliente.usuario.ToString();
                    dataGridView1.Rows[rowIndex].Cells[2].Value = cliente.nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[3].Value = cliente.apellido.ToString();

                    dataGridView1.Rows[rowIndex].Cells[4].Value = cliente.celular.ToString();
                    dataGridView1.Rows[rowIndex].Cells[5].Value = cliente.e_mail.ToString();

                    if (cliente.activo.ToString() == "1")
                    {
                        dataGridView1.Rows[rowIndex].Cells[6].Value = "Activo";
                    }
                    else
                    {
                        dataGridView1.Rows[rowIndex].Cells[6].Value = "Inactivo";
                    }

                    dataGridView1.Rows[rowIndex].Cells[7].Value = "Editar";
                    dataGridView1.Rows[rowIndex].Cells[8].Value = "Eliminar";
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

                FormEditarClienteABM formEditarClienteABMl = new FormEditarClienteABM(cliente_editar);

                DialogResult dr = formEditarClienteABMl.ShowDialog();

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
    }
}
