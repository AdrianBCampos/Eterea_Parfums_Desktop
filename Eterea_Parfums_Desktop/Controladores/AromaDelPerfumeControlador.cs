using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class AromaDelPerfumeControlador
    {
        public static void create(AromaDelPerfume aromaDelPerfume)
        {
            string query = "INSERT INTO dbo.aroma_del_perfume VALUES (@perfume_id, @tipo_de_aroma_id)";
            using (SqlConnection conn = new SqlConnection(DB_Controller.GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@perfume_id", aromaDelPerfume.perfume.id);
                cmd.Parameters.AddWithValue("@tipo_de_aroma_id", aromaDelPerfume.tipoDeAroma.id);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Hay un error en la query: " + e.Message);
                }
            }
        }

        public static List<AromaDelPerfume> getAllByIDPerfume(int id)
        {
            List<AromaDelPerfume> aromasDelPerfume = new List<AromaDelPerfume>();
            string query = "SELECT * FROM dbo.aroma_del_perfume WHERE perfume_id = @id";

            using (SqlConnection conn = new SqlConnection(DB_Controller.GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    conn.Open();
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            Perfume perfume = new Perfume(r.GetInt32(0));
                            TipoDeAroma tipoDeAroma = new TipoDeAroma(r.GetInt32(1), null);
                            aromasDelPerfume.Add(new AromaDelPerfume(perfume, tipoDeAroma));
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Hay un error en la query: " + e.Message);
                }
            }

            return aromasDelPerfume;
        }

        public static bool deleteBYTipoDePerfume(int id)
        {
            bool result = false;
            string query = "DELETE FROM dbo.aroma_del_perfume WHERE tipo_de_aroma_id = @id";

            using (SqlConnection conn = new SqlConnection(DB_Controller.GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    result = true;
                }
                catch (Exception e)
                {
                    throw new Exception("Hay un error en la query: " + e.Message);
                }
            }

            return result;
        }

        public static List<int> getPerfumeIdsPorAroma(int aromaId)
        {
            List<int> perfumeIds = new List<int>();
            string query = "SELECT DISTINCT perfume_id FROM dbo.aroma_del_perfume WHERE tipo_de_aroma_id = @aromaId";

            using (SqlConnection conn = new SqlConnection(DB_Controller.GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@aromaId", aromaId);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            perfumeIds.Add(reader.GetInt32(0));
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Hay un error en la query: " + e.Message);
                }
            }

            return perfumeIds;
        }
    }
}
