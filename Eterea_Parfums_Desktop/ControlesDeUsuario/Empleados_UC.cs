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
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario
{
    public partial class Empleados_UC : UserControl
    {
        List<Empleado> empleados;
        public Empleados_UC()
        {
            InitializeComponent();

            cargarEmpleados();
        }

        private void cargarEmpleados()
        {
            empleados = EmpleadoControlador.obtenerTodos();




            dataGridView1.Rows.Clear();
            foreach (Empleado empleado in empleados)
            {
                if (empleado.activo == 1)
                {
                    int rowIndex = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowIndex].Cells[0].Value = empleado.id.ToString();
                    dataGridView1.Rows[rowIndex].Cells[1].Value = empleado.usuario.ToString();
                    dataGridView1.Rows[rowIndex].Cells[2].Value = empleado.nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[3].Value = empleado.apellido.ToString();


                    dataGridView1.Rows[rowIndex].Cells[4].Value = empleado.celular.ToString();
                    dataGridView1.Rows[rowIndex].Cells[5].Value = empleado.e_mail.ToString();


                    dataGridView1.Rows[rowIndex].Cells[6].Value = (SucursalControlador.getById(empleado.sucursal_id.id)).nombre;




                    /*if (vendedor.activo.ToString() == "1")
                    {
                        dataGridView1.Rows[rowIndex].Cells[7].Value = "Activo";
                    }
                    else
                    {
                        dataGridView1.Rows[rowIndex].Cells[7].Value = "Inactivo";
                    }*/


                    if (empleado.rol.ToString() == "1")
                    {
                        dataGridView1.Rows[rowIndex].Cells[7].Value = "admin";
                    }
                    else
                    {
                        dataGridView1.Rows[rowIndex].Cells[7].Value = "vendedor";
                    }


                    dataGridView1.Rows[rowIndex].Cells[8].Value = "Editar";
                    dataGridView1.Rows[rowIndex].Cells[9].Value = "Eliminar";
                }
            }
        }


        private void btn_new_Click_1(object sender, EventArgs e)
        {
            FormEmpleado frmVend = new FormEmpleado();
            DialogResult dr = frmVend.ShowDialog();

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

                FormEliminarEmpleado frmVend = new FormEliminarEmpleado(empleado_eliminar, id);

                DialogResult dr = frmVend.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK");

                    //ACTUALIZAR LA LISTA
                    cargarEmpleados();

                }
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
    }
}
