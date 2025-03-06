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
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@perfume_id", aromaDelPerfume.perfume.id);
            cmd.Parameters.AddWithValue("@tipo_de_aroma_id", aromaDelPerfume.tipoDeAroma.id);
            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
        }

        public static List<AromaDelPerfume> getAllByIDPerfume(int id)
        {
            List<AromaDelPerfume> aromasDelPerfume = new List<AromaDelPerfume>();
            string query = "SELECT * FROM dbo.aroma_del_perfume WHERE perfume_id = @id";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Perfume perfume = new Perfume(r.GetInt32(0));
                    TipoDeAroma tipoDeAroma = new TipoDeAroma(r.GetInt32(0), null);
                    perfume.id = r.GetInt32(0);
                    tipoDeAroma.id = r.GetInt32(1);
                    aromasDelPerfume.Add(new AromaDelPerfume(perfume, tipoDeAroma));
                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return aromasDelPerfume;
        }


        public static bool deleteBYTipoDePerfume(int id)
        {
            bool result = false;
            string query = "DELETE FROM dbo.aroma_del_perfume WHERE tipo_de_aroma_id = @id";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                result = true;
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return result;
        }
    }


}
