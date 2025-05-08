using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class LocalidadControlador
    {
        // GET ALL

        public static List<Localidad> getAll()
        {
            List<Localidad> list = new List<Localidad>();
            string query = "select * from dbo.localidad ORDER BY nombre ASC;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    list.Add(new Localidad(r.GetInt32(0), r.GetString(1)));

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
        public static Localidad getByName(string nombre)
        {
            Localidad localidad = new Localidad();
            string query = "select * from dbo.localidad where " +
                "nombre = @nombre;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nombre", nombre);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    localidad = new Localidad(r.GetInt32(0), r.GetString(1));
                }
                r.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception e)
            {
                Trace.Write("Error al consultar la DB: " + e.Message);

            }
            return localidad;
        }

        //GET ONE ById
        public static Localidad getById(int id)
        {
            Localidad localidad = null;
            string query = "SELECT * FROM dbo.localidad WHERE id = @id;";

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
                            localidad = new Localidad(r.GetInt32(0), r.GetString(1));
                        }
                    }
                }
            }
            return localidad;
        }



    }
}