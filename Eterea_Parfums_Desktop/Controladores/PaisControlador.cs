using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class PaisControlador
    {
        // GET ALL
        public static List<Pais> getAll()
        {
            List<Pais> list = new List<Pais>();
            string query = "select * from dbo.pais;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    list.Add(new Pais(r.GetInt32(0), r.GetString(1)));

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
        public static Pais getByName(string nombre)
        {
            Pais pais = new Pais();
            string query = "select * from dbo.pais where " +
                "nombre = @nombre;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nombre", nombre);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    pais = new Pais(r.GetInt32(0), r.GetString(1));
                }
                r.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception e)
            {
                Trace.Write("Error al consultar la DB: " + e.Message);

            }
            return pais;
        }

        //GET ONE ById
        public static Pais getById(int id)
        {
            Pais pais = null;
            string query = "SELECT * FROM dbo.pais WHERE id = @id;";

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
                            pais = new Pais(r.GetInt32(0), r.GetString(1));
                        }
                    }  // 🔹 Aca se cierra automáticamente `SqlDataReader`
                }  // 🔹 Aca se cierra automáticamente `SqlCommand`
            }  // 🔹 Aca se cierra automáticamente `SqlConnection`
            return pais;
        }

    }
}