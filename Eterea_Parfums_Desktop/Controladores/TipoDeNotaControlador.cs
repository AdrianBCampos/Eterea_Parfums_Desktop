using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class TipoDeNotaControlador
    {
        public static List<TipoDeNota> getAll()
        {
            List<TipoDeNota> tipo_de_notas = new List<TipoDeNota>();
            string query = "SELECT * FROM dbo.tipo_de_nota";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tipo_de_notas.Add(new TipoDeNota(r.GetInt32(0), r.GetString(1)));
                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return tipo_de_notas;
        }

        public static TipoDeNota getById(int id)
        {
            TipoDeNota tipo_de_nota = new TipoDeNota();
            string query = "SELECT * FROM dbo.tipo_de_nota WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            try
            {
                cmd.Parameters.AddWithValue("@id", id);
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tipo_de_nota.id = r.GetInt32(0);
                    tipo_de_nota.nombre_tipo_de_nota = r.GetString(1);
                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return tipo_de_nota;
        }

        public static TipoDeNota getByNombre(string nombre)
        {
            TipoDeNota tipo_de_nota = new TipoDeNota();
            string query = "SELECT * FROM dbo.tipo_de_nota WHERE nombre = @nombre";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            try
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tipo_de_nota.id = r.GetInt32(0);
                    tipo_de_nota.nombre_tipo_de_nota = r.GetString(1);
                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return tipo_de_nota;
        }
    }
}
