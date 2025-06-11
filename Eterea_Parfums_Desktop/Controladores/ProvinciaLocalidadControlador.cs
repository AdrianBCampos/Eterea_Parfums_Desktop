using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class ProvinciaLocalidadControlador
    {
        public static List<Localidad> getLocalidadesPorProvincia(int provinciaId)
        {
            List<Localidad> localidades = new List<Localidad>();

            string query = @"
        SELECT l.id, l.nombre
        FROM dbo.localidad l
        INNER JOIN dbo.provincia_localidad pl ON l.id = pl.localidad_id
        WHERE pl.provincia_id = @ProvinciaId
        ORDER BY l.nombre";

            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ProvinciaId", provinciaId);
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Localidad localidad = new Localidad
                    {
                        id = reader.GetInt32(0),
                        nombre = reader.GetString(1)
                    };
                    localidades.Add(localidad);
                }
                reader.Close();
            }

            return localidades;
        }

    }
}
