using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario
{
    public partial class Empleados_UC : UserControl
    {
        List<Empleado> empleados;
        public Empleados_UC()
        {
            InitializeComponent();

            // Asocia el evento KeyPress para aceptar solo números
            txt_buscar_dni.KeyPress += txt_buscar_dni_KeyPress;
            txt_buscar_dni.TextChanged += txt_buscar_dni_TextChanged;

            cargarEmpleados();
        }

        private void cargarEmpleados(string filtroDni = "")
        {
            //Ocultas la primera columna de la tabla (es una columna de seleccion de fila)
            dataGridView1.RowHeadersVisible = false;

            empleados = EmpleadoControlador.obtenerTodos();

            dataGridView1.Rows.Clear();
            foreach (Empleado empleado in empleados)
            {
                if (empleado.activo == 1 && (string.IsNullOrEmpty(filtroDni) || empleado.dni.ToString().Contains(filtroDni)))
                {
                    int rowIndex = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowIndex].Cells[0].Value = empleado.id.ToString();
                    dataGridView1.Rows[rowIndex].Cells[1].Value = empleado.usuario.ToString();
                    dataGridView1.Rows[rowIndex].Cells[2].Value = empleado.nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[3].Value = empleado.apellido.ToString();
                    dataGridView1.Rows[rowIndex].Cells[4].Value = empleado.dni.ToString();


                    dataGridView1.Rows[rowIndex].Cells[5].Value = empleado.celular.ToString();
                    dataGridView1.Rows[rowIndex].Cells[6].Value = empleado.e_mail.ToString();


                    dataGridView1.Rows[rowIndex].Cells[7].Value = (SucursalControlador.getById(empleado.sucursal_id.id)).nombre;


                    if (empleado.rol.ToString() == "1")
                    {
                        dataGridView1.Rows[rowIndex].Cells[8].Value = "admin";
                    }
                    else
                    {
                        dataGridView1.Rows[rowIndex].Cells[8].Value = "vendedor";
                    }


                    dataGridView1.Rows[rowIndex].Cells[9].Value = "Editar";
                    dataGridView1.Rows[rowIndex].Cells[10].Value = "Eliminar";
                }
                dataGridView1.CellPainting += dataGridView1_CellPainting;
            }
        }
        private void btn_crear_empleado_Click(object sender, EventArgs e)
        {
            FormCrearEmpleado frmVend = new FormCrearEmpleado();
            DialogResult dr = frmVend.ShowDialog(this);

            if (dr == DialogResult.OK)
            {
                Trace.WriteLine("OK");

                //ACTUALIZAR LA LISTA
                cargarEmpleados();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex].Name == "Editar")
            {
                //EDITAMOS

                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                Trace.WriteLine("El id es: " + id);

                Empleado empleado_editar = EmpleadoControlador.obtenerPorId(id);

                FormEditarEmpleado frmVend = new FormEditarEmpleado(empleado_editar);

                DialogResult dr = frmVend.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK");

                    //ACTUALIZAR LA LISTA
                    cargarEmpleados();

                }
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                //ELIMINAMOS
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                Trace.WriteLine("El id es: " + id);

                Empleado empleado_eliminar = EmpleadoControlador.obtenerPorId(id);

                FormEliminarEmpleado frmVend = new FormEliminarEmpleado(empleado_eliminar, id);

                DialogResult dr = frmVend.ShowDialog(this);

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK");

                    //ACTUALIZAR LA LISTA
                    cargarEmpleados();

                }
            }

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
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

        /*       private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
               {
                   var senderGrid = (DataGridView)sender;

                   if (senderGrid.Columns[e.ColumnIndex].Name == "Editar")
                   {
                       //EDITAMOS

                       int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                       Trace.WriteLine("El id es: " + id);

                       Empleado empleado_editar = EmpleadoControlador.obtenerPorId(id);

                       FormEmpleado frmVend = new FormEmpleado(empleado_editar);

                       DialogResult dr = frmVend.ShowDialog();

                       if (dr == DialogResult.OK)
                       {
                           Trace.WriteLine("OK");

                           //ACTUALIZAR LA LISTA
                           cargarEmpleados();

                       }
                   }
                        else if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
                          {
                              //ELIMINAMOS
                              int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                              Trace.WriteLine("El id es: " + id);



                              Empleado empleado_eliminar = EmpleadoControlador.obtenerPorId(id);

                        FormEmpleado frmVend = new FormEmpleado(empleado_eliminar, id);

                              DialogResult dr = frmVend.ShowDialog();

                              if (dr == DialogResult.OK)
                              {
                                  Trace.WriteLine("OK");

                                  //ACTUALIZAR LA LISTA
                                  cargarEmpleados();

                              }
                          }
               }
        */

        private void txt_buscar_dni_TextChanged(object sender, EventArgs e)
        {
            string filtroDni = txt_buscar_dni.Text.Trim();

            // Actualiza el DataGridView con el filtro
            cargarEmpleados(filtroDni);
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
