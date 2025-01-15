using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class TipoDeNotaControlador
    {
        public static List<TipoDeNota> getAll()
        {
            List<TipoDeNota> tipo_de_notas = new List<TipoDeNota>();
            string query = "SELECT * FROM eterea.tipo_de_nota";
            try
            {
                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
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
    }
}
