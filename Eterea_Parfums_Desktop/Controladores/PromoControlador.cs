using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class PromoControlador
    {
        // GET ALL
        public static List<Promocion> obtenerTodos()
        {
            List<Promocion> list = new List<Promocion>();
            string query = "select * from dbo.promocion;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    list.Add(new Promocion(r.GetInt32(0), r.GetString(1), r.GetDateTime(2), r.GetDateTime(3), r.GetInt32(4), r.GetInt32(5)));

                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return list;

        }
    }
}
