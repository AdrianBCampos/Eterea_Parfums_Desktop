using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class EmpleadoControlador
    {

        public static bool auth(string usuario, string password)
        {
            // Recupera el empleado de la base de datos
            Empleado empleado = obtenerEmpleadoPorUsuario(usuario);

            // Si no se encontró el empleado o su clave es nula o vacía
            if (empleado == null || string.IsNullOrEmpty(empleado.clave))
                return false;

            // Verifica la contraseña utilizando el helper
            return PasswordHelper.VerificarPassword(password, empleado.clave);
        }




        /* public static bool auth(string usr, string pass)
         {
             Empleado empleadoLogueado = new Empleado();

             Pais pais = new Pais();
             Provincia provincia = new Provincia();
             Localidad localidad = new Localidad();
             Calle calle = new Calle();
             Sucursal sucursal = new Sucursal();

             string query = "SELECT * FROM dbo.empleado WHERE usuario = @user AND clave = @pass;";

             try
             {
                 using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString())) // ✅ Nueva conexión
                 {
                     connection.Open();

                     using (SqlCommand cmd = new SqlCommand(query, connection))
                     {
                         cmd.Parameters.AddWithValue("@user", usr);
                         cmd.Parameters.AddWithValue("@pass", pass);

                         using (SqlDataReader r = cmd.ExecuteReader())
                         {
                             if (!r.HasRows) // ✅ Si no hay registros, devolvemos false directamente
                             {
                                 return false;
                             }

                             while (r.Read())
                             {
                                 Trace.WriteLine("=================================");
                                 Trace.WriteLine("Empleado encontrado, nombre: " + r.GetString(3)+ " " + r.GetString(4));
                                 Trace.WriteLine("=================================");

                                 //Obtener id de los datos de las claves foraneas de empleado

                                 int paisId = r.GetInt32(9);
                                 int provinciaId = r.GetInt32(10);
                                 int localidadId = r.GetInt32(11);
                                 int calleId = r.GetInt32(13);
                                 int sucursalId = r.GetInt32(18);




                                 // ✅ Obtenemos los objetos completos
                                 pais = PaisControlador.getById(paisId);
                                 provincia = ProvinciaControlador.getById(provinciaId);
                                 localidad = LocalidadControlador.getById(localidadId);
                                 calle = CalleControlador.getById(calleId);
                                 sucursal = SucursalControlador.getById(sucursalId);

                                 // ✅ Creamos el objeto empleado
                                 empleadoLogueado = new Empleado(
                                     r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4),
                                     r.GetInt32(5), r.GetDateTime(6), r.GetString(7), r.GetString(8), pais,
                                     provincia, localidad, r.GetInt32(12), calle, r.GetInt32(14),
                                     r.GetString(15), r.GetString(16), r.GetString(17),
                                     sucursal, r.GetDateTime(19), r.GetInt32(20), r.GetInt32(21), r.GetString(22)
                                 );
                             }

                         }
                     }
                 }

                 // ✅ Si no se encontró un empleado, retornamos false
                 if (empleadoLogueado == null)
                 {
                     return false;
                 }

                 // ✅ Comprobación de usuario y clave
                 if (empleadoLogueado.usuario == usr && empleadoLogueado.clave == pass)
                 {
                     Program.logueado = empleadoLogueado;
                     Trace.WriteLine("=================================");
                     Trace.WriteLine($"Empleado logueado: ID={empleadoLogueado.id}, Usuario={empleadoLogueado.usuario}, " +
                      $"Nombre={empleadoLogueado.nombre} {empleadoLogueado.apellido}, " +
                      $"País ID={empleadoLogueado.pais_id.id}, País Nombre={empleadoLogueado.pais_id.nombre}, " +
                      $"Provincia ID={empleadoLogueado.provincia_id.id}, Provincia Nombre={empleadoLogueado.provincia_id.nombre}, " +
                      $"Localidad ID={empleadoLogueado.localidad_id.id}, Localidad Nombre={empleadoLogueado.localidad_id.nombre}, " +
                      $"Calle ID={empleadoLogueado.calle_id.id}, Calle Nombre={empleadoLogueado.calle_id.nombre}, " +
                      $"Sucursal ID={empleadoLogueado.sucursal_id.id}, Sucursal Nombre={empleadoLogueado.sucursal_id.nombre}");
                     Trace.WriteLine("=================================");

                     return true;

                 }

                 return false;
             }
             catch (Exception e)
             {
                 MessageBox.Show("Error en la autenticación: " + e.Message);
                 return false;
             }
         } */


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
            // Acá usamos el PasswordHelper para hashear la clave antes de guardarla
            cmd.Parameters.AddWithValue("@clave", PasswordHelper.CrearHash(empleado.clave));
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
                        suc, r.GetDateTime(19), r.GetInt32(20), r.GetBoolean(21), r.GetString(22)));

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

                    empleado = new Empleado(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4),
                        r.GetInt32(5), r.GetDateTime(6), r.GetString(7), r.GetString(8), pais,
                        provincia, localidad, r.GetInt32(12), calle, r.GetInt32(14),
                        r.GetString(15), r.GetString(16), r.GetString(17),
                        sucursal, r.GetDateTime(19), r.GetInt32(20), r.GetBoolean(21), r.GetString(22));
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

        //Obtener empleado por usuario

        public static Empleado obtenerEmpleadoPorUsuario(string usuario)
        {
            Empleado empleado = new Empleado();

            Pais pais = new Pais();
            Provincia provincia = new Provincia();
            Localidad localidad = new Localidad();
            Calle calle = new Calle();
            Sucursal sucursal = new Sucursal();

            string query = "select * from dbo.empleado where usuario = @usuario;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@usuario", usuario);

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

                    empleado = new Empleado(
                        r.GetInt32(0),    // id
                        r.GetString(1),   // usuario
                        r.GetString(2),   // clave hasheada
                        r.GetString(3),   // nombre
                        r.GetString(4),   // apellido
                        r.GetInt32(5),    // dni
                        r.GetDateTime(6), // fecha_nacimiento
                        r.GetString(7),   // celular
                        r.GetString(8),   // e_mail
                        pais,
                        provincia,
                        localidad,
                        r.GetInt32(12),   // codigo_postal
                        calle,
                        r.GetInt32(14),   // numeracion_calle
                        r.GetString(15),  // piso
                        r.GetString(16),  // departamento
                        r.GetString(17),  // comentarios_domicilio
                        sucursal,
                        r.GetDateTime(19),// fecha_ingreso
                        r.GetInt32(20),   // sueldo
                        r.GetBoolean(21),   // activo
                        r.GetString(22)   // rol
                    );
                }
                r.Close();
                DB_Controller.connection.Close();

                // Actualizar referencias de objetos complejos
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
            int idSuc = -1; // Valor predeterminado para sucursales inexistentes

            string query = "SELECT sucursal_id FROM dbo.empleado WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, DB_Controller.connection))
            {
                cmd.Parameters.AddWithValue("@id", id_empleado);

                try
                {
                    // Abrir conexión
                    DB_Controller.connection.Open();

                    // Ejecutar consulta
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            idSuc = reader.GetInt32(0); // Leer sucursal_id
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Hay un error en la query: " + e.Message);
                }
                finally
                {
                    // Asegurar el cierre de la conexión
                    if (DB_Controller.connection.State == System.Data.ConnectionState.Open)
                        DB_Controller.connection.Close();
                }
            }

            return idSuc;
        }


        public static int? BuscarIdPorDni(string dni)
        {
            int? idEmpleado = null;

            string query = "SELECT id FROM empleado WHERE dni = @dni";

            using (SqlCommand cmd = new SqlCommand(query, DB_Controller.connection))
            {
                // Intentamos convertir el string a int
                if (!int.TryParse(dni, out int dniNumerico))
                {
                    throw new Exception("El DNI proporcionado no es numérico.");
                }

                cmd.Parameters.AddWithValue("@dni", dniNumerico);

                try
                {
                    DB_Controller.connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idEmpleado = reader.GetInt32(0);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar el empleado por DNI: " + ex.Message);
                }
                finally
                {
                    if (DB_Controller.connection.State == System.Data.ConnectionState.Open)
                        DB_Controller.connection.Close();
                }
            }

            return idEmpleado; // null si no se encontró
        }
    }
}
