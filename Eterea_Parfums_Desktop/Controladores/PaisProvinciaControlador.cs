using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class PaisProvinciaControlador
    {
        public static List<Provincia> getProvinciasPorPais(int paisId)
        {
            List<Provincia> provincias = new List<Provincia>();

            string query = @"
        SELECT p.id, p.nombre
        FROM dbo.provincia p
        INNER JOIN dbo.pais_provincia pp ON p.id = pp.provincia_id
        WHERE pp.pais_id = @PaisId
        ORDER BY p.nombre";

            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PaisId", paisId);
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Provincia provincia = new Provincia
                    {
                        id = reader.GetInt32(0),
                        nombre = reader.GetString(1)
                    };
                    provincias.Add(provincia);
                }
                reader.Close();
            }

            return provincias;
        }

    }
}
