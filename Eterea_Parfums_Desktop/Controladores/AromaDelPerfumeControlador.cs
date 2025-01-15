using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class AromaDelPerfumeControlador
    {
        public static void create(AromaDelPerfume aromaDelPerfume)
        {
            string query = "INSERT INTO eterea.aroma_del_perfume VALUES (@perfume_id, @tipo_de_aroma_id)";
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
    }

   
    }
