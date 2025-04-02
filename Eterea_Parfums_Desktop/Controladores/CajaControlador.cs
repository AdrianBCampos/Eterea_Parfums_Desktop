using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class CajaControlador
    {
        public static int? ObtenerUnicaCajaDisponibleEnSucursal(int sucursalId)
        {
           

            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            {
                connection.Open();

                string query = @"SELECT numCaja 
                                 FROM dbo.caja 
                                 WHERE sucursal_id = @SucursalId 
                                   AND disponible = 1";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SucursalId", sucursalId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        var cajasDisponibles = new List<int>();

                        while (reader.Read())
                        {
                            cajasDisponibles.Add(reader.GetInt32(0));
                        }

                        if (cajasDisponibles.Count == 1)
                            return (int?)cajasDisponibles[0];
                        else
                            return null;
                    }
                }
            }
        }





        public static bool CajaDisponibleEnSucursal(int numeroCaja, int sucursalId)
        {
            

            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            {
                connection.Open();

                string query = @"SELECT COUNT(*) 
                         FROM dbo.caja
                         WHERE numCaja = @NumeroCaja 
                           AND sucursal_id = @SucursalId 
                           AND disponible = 1";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@NumeroCaja", numeroCaja);
                    cmd.Parameters.AddWithValue("@SucursalId", sucursalId);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }









    }
}
