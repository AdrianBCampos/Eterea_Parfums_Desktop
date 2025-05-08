using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class TipoDeAromaControlador
    {
        public static List<TipoDeAroma> getAll()
        {
            List<TipoDeAroma> tipo_de_aromas = new List<TipoDeAroma>();
            string query = "SELECT * FROM dbo.tipo_de_aroma ORDER BY nombre ASC";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tipo_de_aromas.Add(new TipoDeAroma(r.GetInt32(0), r.GetString(1)));
                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return tipo_de_aromas;
        }

        public static TipoDeAroma getByNombre(string nombre)
        {
            TipoDeAroma tipo_de_aroma = new TipoDeAroma();
            string query = "SELECT * FROM dbo.tipo_de_aroma WHERE nombre = @nombre";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            try
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tipo_de_aroma.id = r.GetInt32(0);
                    tipo_de_aroma.nombre = r.GetString(1);
                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return tipo_de_aroma;
        }

        public static TipoDeAroma getById(int id)
        {
            TipoDeAroma tipo_de_aroma = new TipoDeAroma();
            string query = "SELECT * FROM dbo.tipo_de_aroma WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                cmd.Parameters.AddWithValue("@id", id);
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tipo_de_aroma.id = r.GetInt32(0);
                    tipo_de_aroma.nombre = r.GetString(1);
                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return tipo_de_aroma;
        }
    }
}
