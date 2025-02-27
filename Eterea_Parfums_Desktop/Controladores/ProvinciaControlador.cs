using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class ProvinciaControlador
    {
        // GET ALL
        public static List<Provincia> getAll()
        {
            List<Provincia> list = new List<Provincia>();
            string query = "select * from dbo.provincia;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    list.Add(new Provincia(r.GetInt32(0), r.GetString(1)));

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
        public static Provincia getByName(string nombre)
        {
            Provincia provincia = new Provincia();
            string query = "select * from dbo.provincia where " +
                "nombre = @nombre;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@nombre", nombre);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    provincia = new Provincia(r.GetInt32(0), r.GetString(1));
                }
                r.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception e)
            {
                Trace.Write("Error al consultar la DB: " + e.Message);

            }
            return provincia;
        }

        //GET ONE ById
        public static Provincia getById(int id)
        {
            Provincia provincia = null;
            string query = "SELECT * FROM dbo.provincia WHERE id = @id;";

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
                            provincia = new Provincia(r.GetInt32(0), r.GetString(1));
                        }
                    }
                }
            }
            return provincia;
        }

    }
}