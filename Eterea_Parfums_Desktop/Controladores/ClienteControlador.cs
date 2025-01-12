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
    internal class ClienteControlador
    {

        //GET ONE


        //POST

        public static bool crearCliente(Cliente cliente)
        {
            //Dar de alta un cliente en la base de datos

            string query = "insert into eterea.cliente values" +
                "(@id, " +
                "@usuario, " +
                "@clave, " +
                "@nombre, " +
                "@apellido, " +
                "@dni, " +
                "@condicion_frente_al_iva, " +
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

                "@activo, " +
                "@rol);";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@usuario", cliente.usuario);
            cmd.Parameters.AddWithValue("@clave", cliente.clave);
            cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
            cmd.Parameters.AddWithValue("@dni", cliente.dni);
            cmd.Parameters.AddWithValue("@condicion_frente_al_iva", cliente.condicion_frente_al_iva);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", cliente.fecha_nacimiento);
            cmd.Parameters.AddWithValue("@celular", cliente.celular);
            cmd.Parameters.AddWithValue("@e_mail", cliente.e_mail);
            cmd.Parameters.AddWithValue("@pais", cliente.pais_id.id);
            cmd.Parameters.AddWithValue("@provincia_id", cliente.provincia_id.id);
            cmd.Parameters.AddWithValue("@localidad_id", cliente.localidad_id.id);
            cmd.Parameters.AddWithValue("@codigo_postal", cliente.codigo_postal);
            cmd.Parameters.AddWithValue("@calle_id", cliente.calle_id.id);
            cmd.Parameters.AddWithValue("@numeracion_calle", cliente.numeracion_calle);
            cmd.Parameters.AddWithValue("@piso", cliente.piso);
            cmd.Parameters.AddWithValue("@departamento", cliente.departamento);
            cmd.Parameters.AddWithValue("@comentarios_domicilio", cliente.comentarios_domicilio);

            cmd.Parameters.AddWithValue("@activo", cliente.activo);
            cmd.Parameters.AddWithValue("@rol", cliente.rol);

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
            string query = "select max(id) from eterea.cliente;";

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

        public static List<Cliente> obtenerTodos()
        {
            List<Cliente> list = new List<Cliente>();
            string query = "select * from eterea.cliente;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    Pais pais = PaisControlador.getById(r.GetInt32(10));
                    Provincia provincia = ProvinciaControlador.getById(r.GetInt32(11));
                    Localidad localidad = LocalidadControlador.getById(r.GetInt32(12));
                    Calle calle = CalleControlador.getById(r.GetInt32(14));

                    list.Add(new Cliente(r.GetInt32(0), r.GetString(1), "", r.GetString(3), r.GetString(4),
                        r.GetInt32(5), r.GetString(6), r.GetDateTime(7), r.GetString(8), r.GetString(9), pais,
                        provincia, localidad, r.GetInt32(13), calle, r.GetInt32(15),
                        r.GetString(16), r.GetString(17), r.GetString(18),
                         r.GetInt32(19), r.GetString(20)));

                    Trace.WriteLine("Cliente encontrado, nombre: " + r.GetString(1));
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

        public static Cliente obtenerPorId(int id)
        {
            Cliente cliente = new Cliente();

            Pais pais = new Pais();
            Provincia provincia = new Provincia();
            Localidad localidad = new Localidad();
            Calle calle = new Calle();

            string query = "select * from eterea.cliente where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    pais.id = r.GetInt32(10);
                    provincia.id = r.GetInt32(11);
                    localidad.id = r.GetInt32(12);
                    calle.id = r.GetInt32(14);


                    cliente = new Cliente(r.GetInt32(0), r.GetString(1), "", r.GetString(3), r.GetString(4),
                        r.GetInt32(5), r.GetString(6), r.GetDateTime(7), r.GetString(8), r.GetString(9), pais,
                        provincia, localidad, r.GetInt32(13), calle, r.GetInt32(15),
                        r.GetString(16), r.GetString(17), r.GetString(18),
                         r.GetInt32(19), r.GetString(20));
                }
                r.Close();
                DB_Controller.connection.Close();

                cliente.pais_id = PaisControlador.getById(pais.id);
                cliente.provincia_id = ProvinciaControlador.getById(provincia.id);
                cliente.localidad_id = LocalidadControlador.getById(localidad.id);
                cliente.calle_id = CalleControlador.getById(calle.id);

            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return cliente;

        }

        //GET ONE BY DNI

        public static Cliente obtenerPorDni(int dni)
        {
            Cliente cliente = null;

            Pais pais = new Pais();
            Provincia provincia = new Provincia();
            Localidad localidad = new Localidad();
            Calle calle = new Calle();

            string query = "select * from eterea.cliente where dni = @dni;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@dni", dni);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    pais.id = r.GetInt32(10);
                    provincia.id = r.GetInt32(11);
                    localidad.id = r.GetInt32(12);
                    calle.id = r.GetInt32(14);

                    cliente = new Cliente(r.GetInt32(0), r.GetString(1), "", r.GetString(3), r.GetString(4),
                        r.GetInt32(5), r.GetString(6), r.GetDateTime(7), r.GetString(8), r.GetString(9), pais,
                        provincia, localidad, r.GetInt32(13), calle, r.GetInt32(15),
                        r.GetString(16), r.GetString(17), r.GetString(18),
                         r.GetInt32(19), r.GetString(20));
                }
                r.Close();
                DB_Controller.connection.Close();

                if (cliente != null)
                {
                    cliente.pais_id = PaisControlador.getById(pais.id);
                    cliente.provincia_id = ProvinciaControlador.getById(provincia.id);
                    cliente.localidad_id = LocalidadControlador.getById(localidad.id);
                    cliente.calle_id = CalleControlador.getById(calle.id);
                }

            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return cliente;

        }


        //EDIT ó PUT

        public static bool editarCliente(Cliente cliente)
        {
            //Dar de alta un vendedor en la base de datos

            string query = "update eterea.cliente set usuario = @usuario, " +
                "nombre = @nombre, " +
                "apellido = @apellido, " +
                "dni = @dni, " +
                "@condicion_frente_al_iva = condicion_frente_al_iva, " +
                "fecha_nacimiento = @fecha_nacimiento, " +
                "celular = @celular, " +
                "e_mail = @e_mail, " +
                "pais_id = @pais_id, " +
                "provincia_id = @provincia_id, " +
                "localidad_id = @localidad_id, " +
                "codigo_postal = @codigo_postal, " +
                "calle_id = @calle_id, " +
                "numeracion_calle = @numeracion_calle, " +
                "piso = @piso, " +
                "departamento = @departamento, " +
                "comentarios_domicilio = @comentarios_domicilio, " +

                "activo = @activo, " +
                "rol = @rol " +
                "where id = @id;";


            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@usuario", cliente.usuario);
            //cmd.Parameters.AddWithValue("@clave", vendedor.contraseña);  //hc.PassHash(vendedor.contraseña)
            cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
            cmd.Parameters.AddWithValue("@dni", cliente.dni);
            cmd.Parameters.AddWithValue("@condicion_frene_al_iva", cliente.condicion_frente_al_iva);
            cmd.Parameters.AddWithValue("@fecha_nacimiento", cliente.fecha_nacimiento);
            cmd.Parameters.AddWithValue("@celular", cliente.celular);
            cmd.Parameters.AddWithValue("@e_mail", cliente.e_mail);
            cmd.Parameters.AddWithValue("@pais_id", cliente.pais_id.id);
            cmd.Parameters.AddWithValue("@provincia_id", cliente.provincia_id.id);
            cmd.Parameters.AddWithValue("@localidad_id", cliente.localidad_id.id);
            cmd.Parameters.AddWithValue("@codigo_postal", cliente.codigo_postal);
            cmd.Parameters.AddWithValue("@calle_id", cliente.calle_id.id);
            cmd.Parameters.AddWithValue("@numeracion_calle", cliente.numeracion_calle);
            cmd.Parameters.AddWithValue("@piso", cliente.piso);
            cmd.Parameters.AddWithValue("@departamento", cliente.departamento);
            cmd.Parameters.AddWithValue("@comentarios_domicilio", cliente.comentarios_domicilio);

            cmd.Parameters.AddWithValue("@activo", cliente.activo);
            cmd.Parameters.AddWithValue("@rol", cliente.rol);

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

        public static bool eliminarCliente(int id)
        {
            int activo = 0;
            //Dar de baja lógica a un cliente en la base de datos
            string query = "update eterea.cliente set activo = @activo " +

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



    }
}
