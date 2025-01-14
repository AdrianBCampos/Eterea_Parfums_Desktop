using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class TipoDePerfumeControlador
    {
        public static List<TipoDePerfume> getAll()
        {

            List<TipoDePerfume> lista_tipos_de_perfumes;

            try
            {
                lista_tipos_de_perfumes = new List<TipoDePerfume>();
                string query = "select * from eterea.Tipo_de_perfume;";
                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    lista_tipos_de_perfumes.Add(new TipoDePerfume(r.GetInt32(0), r.GetString(1)));

                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return lista_tipos_de_perfumes;

        }
    }
}
