using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class EmpleadoControlador
    {
        public static bool auth(string usr, string pass)//, bool hasheado)
        {
            Empleado empleado = new Empleado();
            string query = "select * from eterea.empleado where " +
                "usuario = @user and clave = @pass;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@user", usr);
            cmd.Parameters.AddWithValue("@pass", pass);
            
            //if (hasheado)
            //{
            //cmd.Parameters.AddWithValue("@pass", pass);
            //}
            //else
            //{
            //cmd.Parameters.AddWithValue("@pass", HashSet.PassHash(pass));
            //}

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();



                while (r.Read())
                {
                    empleado = new Empleado();
                    empleado.id = r.GetInt32(0);
                    empleado.usuario = r.GetString(1);
                    empleado.clave = r.GetString(2);
                    empleado.nombre = r.GetString(3);
                    empleado.apellido = r.GetString(4);
                    empleado.rol = r.GetString(22);

                }
                r.Close();
                DB_Controller.connection.Close();

                if (empleado.usuario == usr && empleado.clave == pass)
                {

                    Program.logueado = empleado;
                    return true;
                }
                else
                {

                    return false;
                }

            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);

            }
        }

    }
}
