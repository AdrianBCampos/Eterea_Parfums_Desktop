using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class CalleLocalidadControlador
    {
        public static List<Calle> getCallesPorLocalidad(int localidadId)
        {
            List<Calle> calles = new List<Calle>();

            string query = @"
        SELECT c.id, c.nombre
        FROM dbo.calle c
        INNER JOIN dbo.calle_localidad cl ON c.id = cl.calle_id
        WHERE cl.localidad_id = @LocalidadId
        ORDER BY c.nombre";

            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@LocalidadId", localidadId);
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Calle calle = new Calle
                    {
                        id = reader.GetInt32(0),
                        nombre = reader.GetString(1)
                    };
                    calles.Add(calle);
                }
                reader.Close();
            }

            return calles;
        }

    }
}
