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
            string query = "SELECT * FROM dbo.nota";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            try
            {        
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
            string query = "SELECT * FROM dbo.nota WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            try
            {             
                cmd.Parameters.AddWithValue("@id", id);
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    nota.id = r.GetInt32(0);
                    nota.nombre = r.GetString(1);
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

        public static Nota getByNombre(string nombre)
        {
            Nota nota = new Nota();
            string query = "SELECT * FROM dbo.nota WHERE nombre = @nombre";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            try
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    nota.id = r.GetInt32(0);
                    nota.nombre = r.GetString(1);
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
