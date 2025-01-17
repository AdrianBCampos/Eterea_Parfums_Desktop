using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class NotasDelPerfumeControlador
    {
        public static List<NotasDelPerfume> getByIDPerfume(int id)
        {
            List<NotasDelPerfume> notas = new List<NotasDelPerfume>();
            string query = "SELECT * FROM dbo.notas_del_perfume WHERE perfume_id = @id";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Perfume perfume = new Perfume();
                    NotaConTipoDeNota nota = new NotaConTipoDeNota();
                    perfume.id = r.GetInt32(0);
                    nota.id = r.GetInt32(1);

                    notas.Add(new NotasDelPerfume(perfume, nota));
                }
                r.Close();
                DB_Controller.connection.Close();
              
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return notas;
        }

        public static void create(NotasDelPerfume notasDelPerfume)
        {
            string query = "INSERT INTO dbo.notas_del_perfume VALUES (@perfume_id, @nota_id)";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@perfume_id", notasDelPerfume.perfume.id);
            cmd.Parameters.AddWithValue("@nota_id", notasDelPerfume.notaConTipoDeNota.id);
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
