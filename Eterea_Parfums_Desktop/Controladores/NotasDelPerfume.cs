using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class NotasDelPerfume
    {
        public static List<NotasDelPerfume> getByIDPerfume(int id)
        {
            List<NotasDelPerfume> notas = new List<NotasDelPerfume>();
            string query = "SELECT * FROM eterea.notas_del_perfume WHERE id_perfume = @id";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {

                    notas.Add(new NotasDelPerfume(r.GetInt32(0), r.GetInt32(1)));
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
    }
}
