using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class TipoDeAromaControlador
    {
        public static List<TipoDeAroma> getAll()
        {
            List<TipoDeAroma> tipo_de_aromas = new List<TipoDeAroma>();
            string query = "SELECT * FROM dbo.tipo_de_aroma";

            try
            {
                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
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
            TipoDeAroma tipo_de_aroma = null;
            string query = "SELECT * FROM dbo.tipo_de_aroma WHERE nombre = @nombre";
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tipo_de_aroma = new TipoDeAroma(r.GetInt32(0), r.GetString(1));
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
