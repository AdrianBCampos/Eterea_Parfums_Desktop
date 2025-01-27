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
            string query = "select * from dbo.empleado where " +
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

                    Pais pais = PaisControlador.getById(r.GetInt32(9));
                    Provincia provincia = ProvinciaControlador.getById(r.GetInt32(10));
                    Localidad localidad = LocalidadControlador.getById(r.GetInt32(11));
                    Calle calle = CalleControlador.getById(r.GetInt32(13));
                    Sucursal sucursal = SucursalControlador.getById(r.GetInt32(18));

                    empleado = new Empleado(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4),
                       r.GetInt32(5), r.GetDateTime(6), r.GetString(7), r.GetString(8), pais,
                       provincia, localidad, r.GetInt32(12), calle, r.GetInt32(14),
                       r.GetString(15), r.GetString(16), r.GetString(17),
                       sucursal, r.GetDateTime(19), r.GetInt32(20), r.GetInt32(21), r.GetString(22));

                    /*    empleado = new Empleado();
                        empleado.id = r.GetInt32(0);
                        empleado.usuario = r.GetString(1);
                        empleado.clave = r.GetString(2);
                        empleado.nombre = r.GetString(3);
                        empleado.apellido = r.GetString(4);
                        empleado.dni = r.GetInt32(5);
                        empleado.fecha_nacimiento = r.GetDateTime(6);
                        empleado.celular = r.GetString(7);
                        empleado.e_mail = r.GetString(8);
                        empleado.pais_id = PaisControlador.getById(r.GetInt32(9));
                        empleado.provincia_id = ProvinciaControlador.getById(r.GetInt32(10));
                        empleado.localidad_id = LocalidadControlador.getById(r.GetInt32(11));
                        empleado.codigo_postal = r.GetInt32(12);
                        empleado.calle_id = CalleControlador.getById(r.GetInt32(13));
                        empleado.numeracion_calle = r.GetInt32(14);
                        empleado.piso = r.GetString(15);
                        empleado.departamento = r.GetString(16);
                        empleado.comentarios_domicilio = r.GetString(17);
                        empleado.sucursal_id = SucursalControlador.getById(r.GetInt32(18));
                        empleado.fecha_ingreso = r.GetDateTime(19);
                        empleado.sueldo = r.GetInt32(20);
                        empleado.activo = r.GetInt32(21);
                        empleado.rol = r.GetString(22); */

                    Console.WriteLine($"ID: {empleado.id}, Usuario: {empleado.usuario}, Clave: {empleado.clave}, " +
      $"Nombre: {empleado.nombre}, Apellido: {empleado.apellido}, DNI: {empleado.dni}, " +
      $"Fecha Nacimiento: {empleado.fecha_nacimiento}, Celular: {empleado.celular}, Email: {empleado.e_mail}, " +
      $"País: {empleado.pais_id.nombre}, Provincia: {empleado.provincia_id.nombre}, Localidad: {empleado.localidad_id.nombre}, " +
      $"Código Postal: {empleado.codigo_postal}, Calle: {empleado.calle_id.nombre}, Numeración Calle: {empleado.numeracion_calle}, " +
      $"Piso: {empleado.piso}, Departamento: {empleado.departamento}, Comentarios Domicilio: {empleado.comentarios_domicilio}, " +
      $"Sucursal: {empleado.sucursal_id}, Fecha Ingreso: {empleado.fecha_ingreso}, Sueldo: {empleado.sueldo}, " +
      $"Activo: {empleado.activo}, Rol: {empleado.rol}");



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

        public static bool crearEmpleado(Empleado empleado)
        {
            string query = "insert into dbo.empleado values" +
                "(@id, " +
                "@usuario, " +
                "@clave, " +
                "@nombre, " +
                "@apellido, " +
                "@dni, " +
                "@fecha_nacimiento, " +
                "@celular, " +
                "@e_mail, " +
                "@pais, " +
                "@provincia_id, " +
                "@localidad_id, " +
                "@codigo_postal, " +
                "@calle_id, " +
                "@numeracion_calle, " +
                "@piso, " +
                "@departamento, " +
                "@comentarios_domicilio, " +
                "@sucursal_id, " +
                "@fecha_ingreso, " +
                "@sueldo, " +
                "@activo, " +
                "@rol);";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@usuario", empleado.usuario);
            cmd.Parameters.AddWithValue("@clave", empleado.clave);
            cmd.Parameters.AddWithValue("@nombre", empleado.nombre);
            cmd.Parameters.AddWithValue("@apellido", empleado.apellido);
            cmd.Parameters.AddWithValue("@dni", empleado.dni);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", empleado.fecha_nacimiento);
            cmd.Parameters.AddWithValue("@celular", empleado.celular);
            cmd.Parameters.AddWithValue("@e_mail", empleado.e_mail);
            cmd.Parameters.AddWithValue("@pais", empleado.pais_id.id);
            cmd.Parameters.AddWithValue("@provincia_id", empleado.provincia_id.id);
            cmd.Parameters.AddWithValue("@localidad_id", empleado.localidad_id.id);
            cmd.Parameters.AddWithValue("@codigo_postal", empleado.codigo_postal);
            cmd.Parameters.AddWithValue("@calle_id", empleado.calle_id.id);
            cmd.Parameters.AddWithValue("@numeracion_calle", empleado.numeracion_calle);
            cmd.Parameters.AddWithValue("@piso", empleado.piso);
            cmd.Parameters.AddWithValue("@departamento", empleado.departamento);
            cmd.Parameters.AddWithValue("@comentarios_domicilio", empleado.comentarios_domicilio);
            cmd.Parameters.AddWithValue("@sucursal_id", empleado.sucursal_id.id);
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

        // OBTENER EL MAX ID

        public static int obtenerMaxId()
        {
            int MaxId = 0;
            string query = "select max(id) from dbo.empleado;";

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

        // GET ALL

        public static List<Empleado> obtenerTodos()
        {
            List<Empleado> list = new List<Empleado>();

            Pais pais = new Pais();
            Provincia provincia = new Provincia();
            Localidad localidad = new Localidad();
            Calle calle = new Calle();
            Sucursal sucursal = new Sucursal();




            string query = "select * from dbo.empleado;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {

                    sucursal.id = r.GetInt32(18);

                    Sucursal suc = new Sucursal(sucursal.id, "", pais, provincia, localidad, 0, calle, 0, 0);

                    list.Add(new Empleado(r.GetInt32(0), r.GetString(1), "", r.GetString(3), r.GetString(4),
                        r.GetInt32(5), r.GetDateTime(6), r.GetString(7), r.GetString(8), pais,
                        provincia, localidad, r.GetInt32(12), calle, r.GetInt32(14),
                        r.GetString(15), r.GetString(16), r.GetString(17),
                        suc, r.GetDateTime(19), r.GetInt32(20), r.GetInt32(21), r.GetString(22)));

                    Trace.WriteLine("Vendedor encontrado, nombre: " + r.GetString(1));

                }
                r.Close();
                DB_Controller.connection.Close();






            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return list;

        }


        //GET ONE BY ID

        public static Empleado obtenerPorId(int id)
        {
            Empleado empleado = new Empleado();

            Pais pais = new Pais();
            Provincia provincia = new Provincia();
            Localidad localidad = new Localidad();
            Calle calle = new Calle();
            Sucursal sucursal = new Sucursal();

            string query = "select * from dbo.empleado where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    pais.id = r.GetInt32(9);
                    provincia.id = r.GetInt32(10);
                    localidad.id = r.GetInt32(11);
                    calle.id = r.GetInt32(13);
                    sucursal.id = r.GetInt32(18);

                    empleado = new Empleado(r.GetInt32(0), r.GetString(1), "", r.GetString(3), r.GetString(4),
                        r.GetInt32(5), r.GetDateTime(6), r.GetString(7), r.GetString(8), pais,
                        provincia, localidad, r.GetInt32(12), calle, r.GetInt32(14),
                        r.GetString(15), r.GetString(16), r.GetString(17),
                        sucursal, r.GetDateTime(19), r.GetInt32(20), r.GetInt32(21), r.GetString(22));
                }
                r.Close();
                DB_Controller.connection.Close();

                empleado.pais_id = PaisControlador.getById(pais.id);
                empleado.provincia_id = ProvinciaControlador.getById(provincia.id);
                empleado.localidad_id = LocalidadControlador.getById(localidad.id);
                empleado.calle_id = CalleControlador.getById(calle.id);
                empleado.sucursal_id = SucursalControlador.getById(sucursal.id);


            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return empleado;

        }



        public static bool editarEmpleado(Empleado empleado)
        {
            //Editar un empleado en la base de datos

            string query = "update dbo.empleado set usuario = @usuario, " +
                "clave = @clave, " +
                "nombre = @nombre, " +
                "apellido = @apellido, " +
                "dni = @dni, " +
                "fecha_nacimiento = @fecha_nacimiento, " +
                "celular = @celular, " +
                "e_mail = @e_mail, " +
                "pais_id = @pais, " +
                "provincia_id = @provincia_id, " +
                "localidad_id = @localidad_id, " +
                "codigo_postal = @codigo_postal, " +
                "calle_id = @calle_id, " +
                "numeracion_calle = @numeracion_calle, " +
                "piso = @piso, " +
                "departamento = @departamento, " +
                "comentarios_domicilio = @comentarios_domicilio, " +
                "sucursal_id = @sucursal_id, " +
                "fecha_ingreso = @fecha_ingreso, " +
                "sueldo = @sueldo, " +
                "activo = @activo, " +
                "rol = @rol " +
                "where id = @id;";


            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", empleado.id);
            cmd.Parameters.AddWithValue("@usuario", empleado.usuario);
            cmd.Parameters.AddWithValue("@clave", empleado.clave);  //hc.PassHash(vendedor.contraseña)
            cmd.Parameters.AddWithValue("@nombre", empleado.nombre);
            cmd.Parameters.AddWithValue("@apellido", empleado.apellido);
            cmd.Parameters.AddWithValue("@dni", empleado.dni);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", empleado.fecha_nacimiento);

            cmd.Parameters.AddWithValue("@celular", empleado.celular);
            cmd.Parameters.AddWithValue("@e_mail", empleado.e_mail);
            cmd.Parameters.AddWithValue("@pais", empleado.pais_id.id);
            cmd.Parameters.AddWithValue("@provincia_id", empleado.provincia_id.id);
            cmd.Parameters.AddWithValue("@localidad_id", empleado.localidad_id.id);
            cmd.Parameters.AddWithValue("@codigo_postal", empleado.codigo_postal);
            cmd.Parameters.AddWithValue("@calle_id", empleado.calle_id.id);
            cmd.Parameters.AddWithValue("@numeracion_calle", empleado.numeracion_calle);
            cmd.Parameters.AddWithValue("@piso", empleado.piso);
            cmd.Parameters.AddWithValue("@departamento", empleado.departamento);
            cmd.Parameters.AddWithValue("@comentarios_domicilio", empleado.comentarios_domicilio);
            cmd.Parameters.AddWithValue("@sucursal_id", empleado.sucursal_id.id);
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

        public static bool eliminarEmpleado(int id)
        {
            int activo = 0;
            //Dar de baja lógica a un empleado en la base de datos
            string query = "update dbo.empleado set activo = @activo " +

               "where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@activo", activo);

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


        public static int obtenerIdSucursal(int id_empleado)
        {
            int idSuc = 0;

            string query = "SELECT sucursal_id FROM dbo.empleado WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(DB_Controller.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id_empleado);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Verificar si el valor no es nulo antes de intentar convertirlo
                            if (!reader.IsDBNull(0))
                            {
                                idSuc = reader.GetInt32(0);
                            }
                            else
                            {
                                // Manejar el caso en el que el valor sea nulo (por ejemplo, asignar un valor predeterminado)
                                idSuc = -1; // o cualquier valor que desees
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        // Manejar la excepción (por ejemplo, log o lanzar una nueva excepción)
                        throw new Exception("Error al ejecutar la consulta SQL: " + e.Message);
                    }
                }
            }

            return idSuc;
        }
    }
}
