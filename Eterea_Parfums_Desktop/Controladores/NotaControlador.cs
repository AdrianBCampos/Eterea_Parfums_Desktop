using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class NotaControlador
    {
        public static List<Nota> getAll()
        {
            List<Nota> notas = new List<Nota>();
            string query = "SELECT * FROM eterea.nota";
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    notas.Add(new Nota(r.GetInt32(0), r.GetString(1)));
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

        public static Nota getById(int id)
        {
            Nota nota = new Nota();
            string query = "SELECT * FROM eterea.nota WHERE id = @id";
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
                cmd.Parameters.AddWithValue("@id", id);
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    nota = new Nota(r.GetInt32(0), r.GetString(1));
                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return nota;
        }
    }
}
