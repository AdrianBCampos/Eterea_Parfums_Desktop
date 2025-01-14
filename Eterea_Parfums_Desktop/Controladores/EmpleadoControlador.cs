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

        public static bool crearUsuario(Empleado empleado)
        {
            string query = "insert into eterea.empleado values" +
                "(@id, " +
                "@usuario, " +
                "@clave, " +
                "@nombre, " +
                "@apellido, " +
                "@dni, " +
                "@fecha_nacimiento, " +
                "@celular, " +
                "@e_mail, " +
                "@pais_id, " +
                "@provincia_id, " +
                "@localidad_id, " +
                "@codigo_postal, " +
                "@calle_id, " +
                "@numeracion_calle, " +
                "@piso, " +
                "@departamento, " +
                "@cometanrios_domicilio, " +
                "@sucursal_id, " +
                "@fecha_ingreso, " +
                "@sueldo, " +
                "@activo, " +
                "@rol);";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@usuario", empleado.usuario);
            cmd.Parameters.AddWithValue("@contraseña", empleado.clave);
            cmd.Parameters.AddWithValue("@nombre", empleado.nombre);
            cmd.Parameters.AddWithValue("@apellido", empleado.apellido);
            cmd.Parameters.AddWithValue("@dni", empleado.dni);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", empleado.fecha_nacimiento);
            cmd.Parameters.AddWithValue("@celular", empleado.celular);
            cmd.Parameters.AddWithValue("@e_mail", empleado.e_mail);
            cmd.Parameters.AddWithValue("@pais", empleado.pais_id);
            cmd.Parameters.AddWithValue("@provincia_id", empleado.provincia_id);
            cmd.Parameters.AddWithValue("@ciudad_id", empleado.localidad_id);
            cmd.Parameters.AddWithValue("@codigo_postal", empleado.codigo_postal);
            cmd.Parameters.AddWithValue("@calle_id", empleado.calle_id);
            cmd.Parameters.AddWithValue("@numeracion_calle", empleado.numeracion_calle);
            cmd.Parameters.AddWithValue("@piso", empleado.piso);
            cmd.Parameters.AddWithValue("@departamento", empleado.departamento);
            cmd.Parameters.AddWithValue("@comentarios_domicilio", empleado.comentarios_domicilio);
            cmd.Parameters.AddWithValue("@sucursal_id", empleado.sucursal_id);
            cmd.Parameters.AddWithValue("@fecha_ingreso", empleado.fecha_ingreso);
            cmd.Parameters.AddWithValue("@sueldo", empleado.sueldo);
            cmd.Parameters.AddWithValue("@activo", empleado.activo);
            cmd.Parameters.AddWithValue("@rol", empleado.rol);

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }

        }

        public static int obtenerMaxId()
        {
            int MaxId = 0;
            string query = "select max(id) from eterea.empleado;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MaxId = reader.GetInt32(0);
                }
                reader.Close();
                DB_Controller.connection.Close();
                return MaxId;
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
        }

    }
}
