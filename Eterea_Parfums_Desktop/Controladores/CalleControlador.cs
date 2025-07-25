using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class CalleControlador
    {
        // GET ALL
        public static List<Calle> getAll()
        {
            List<Calle> list = new List<Calle>();
            string query = "SELECT * FROM dbo.calle ORDER BY nombre ASC;";

            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new Calle(r.GetInt32(0), r.GetString(1)));
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Hay un error en la query: " + e.Message);
                }
            }

            return list;
        }

        // GET ONE BY NAME
        public static Calle getByName(string nombre)
        {
            Calle calle = null;
            string query = "SELECT * FROM dbo.calle WHERE nombre = @nombre;";

            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);

                try
                {
                    connection.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            calle = new Calle(r.GetInt32(0), r.GetString(1));
                        }
                    }
                }
                catch (Exception e)
                {
                    Trace.Write("Error al consultar la DB: " + e.Message);
                }
            }

            return calle;
        }

        // GET ONE BY ID
        public static Calle getById(int id)
        {
            Calle calle = null;
            string query = "SELECT * FROM dbo.calle WHERE id = @id;";

            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                connection.Open();

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        calle = new Calle(r.GetInt32(0), r.GetString(1));
                    }
                }
            }

            return calle;
        }

        // GET ALL BY LOCALIDAD_ID
        public static List<Calle> getCallesPorLocalidadId(int localidadId)
        {
            List<Calle> listaCalles = new List<Calle>();
            string query = "SELECT id, nombre FROM dbo.calle WHERE localidad_id = @localidadId;";

            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@localidadId", localidadId);
                connection.Open();

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        Calle calle = new Calle(r.GetInt32(0), r.GetString(1));
                        listaCalles.Add(calle);
                    }
                }
            }

            return listaCalles;
        }
    }
}
