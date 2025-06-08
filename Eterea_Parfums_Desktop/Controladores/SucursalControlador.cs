using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class SucursalControlador
    {
        // GET ALL

        public static List<Sucursal> getAll()
        {
            List<Sucursal> list = new List<Sucursal>();
            string query = "select * from dbo.sucursal;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    Pais pais = PaisControlador.getById(r.GetInt32(2));
                    Provincia provincia = ProvinciaControlador.getById(r.GetInt32(3));
                    Localidad localidad = LocalidadControlador.getById(r.GetInt32(4));
                    Calle calle = CalleControlador.getById(r.GetInt32(6));


                    list.Add(new Sucursal(r.GetInt32(0), r.GetString(1), pais, provincia,
                        localidad, r.GetInt32(5), calle, r.GetInt32(7), r.GetBoolean(8)));

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


        //GET ONE ByName
        public static Sucursal getByName(string nombre)
        {
            Sucursal sucursal = new Sucursal();
            string query = "select * from dbo.sucursal where " +
                "nombre = @nombre;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nombre", nombre);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    Pais pais = PaisControlador.getById(r.GetInt32(2));
                    Provincia provincia = ProvinciaControlador.getById(r.GetInt32(3));
                    Localidad localidad = LocalidadControlador.getById(r.GetInt32(4));
                    Calle calle = CalleControlador.getById(r.GetInt32(6));


                    sucursal = new Sucursal(r.GetInt32(0), r.GetString(1), pais, provincia,
                       localidad, r.GetInt32(5), calle, r.GetInt32(7), r.GetBoolean(8));
                }
                r.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception e)
            {
                Trace.Write("Error al consultar la DB: " + e.Message);

            }
            return sucursal;
        }

        //GET ONE ById
        public static Sucursal getById(int id)
        {
            Sucursal sucursal = null;
            string query = "SELECT * FROM dbo.sucursal WHERE id = @id;";

            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            Pais pais = PaisControlador.getById(r.GetInt32(2));
                            Provincia provincia = ProvinciaControlador.getById(r.GetInt32(3));
                            Localidad localidad = LocalidadControlador.getById(r.GetInt32(4));
                            Calle calle = CalleControlador.getById(r.GetInt32(6));

                            sucursal = new Sucursal(r.GetInt32(0), r.GetString(1), pais, provincia,
                                localidad, r.GetInt32(5), calle, r.GetInt32(7), r.GetBoolean(8));
                        }
                    }
                }
            }
            return sucursal;
        }




      
            public static string ObtenerNombreSucursalPorId(int sucursalId)
            {


            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            {
                    connection.Open();

                    string query = "SELECT nombre FROM dbo.sucursal WHERE id = @SucursalId";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SucursalId", sucursalId);

                        object result = cmd.ExecuteScalar();
                        return result != null ? result.ToString() : "Sucursal desconocida";
                    }
                }
            }


        public static List<Sucursal> getSucursalesActivas()
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            string query = "SELECT id, nombre FROM dbo.sucursal WHERE activo = 1";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Sucursal s = new Sucursal();
                    s.id = reader.GetInt32(0);
                    s.nombre = reader.GetString(1);
                    sucursales.Add(s);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener sucursales activas: " + e.Message);
            }
            finally
            {
                DB_Controller.connection.Close();
            }

            return sucursales;
        }






    }
}
