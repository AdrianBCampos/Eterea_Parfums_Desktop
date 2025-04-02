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



        public static bool MarcarCajaComoNoDisponible(int numeroCaja, int sucursalId)
        {
            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            {
                connection.Open();

                string query = @"UPDATE dbo.caja
                         SET disponible = 0
                         WHERE numCaja = @NumeroCaja AND sucursal_id = @SucursalId AND disponible = 1";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@NumeroCaja", numeroCaja);
                    cmd.Parameters.AddWithValue("@SucursalId", sucursalId);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0; // Devuelve true si se marcó correctamente
                }
            }
        }




        public static void MarcarCajaComoDisponible(int numeroCaja, int sucursalId)
        {
            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            {
                connection.Open();

                string query = @"UPDATE dbo.caja
                         SET disponible = 1
                         WHERE numCaja = @NumeroCaja AND sucursal_id = @SucursalId";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@NumeroCaja", numeroCaja);
                    cmd.Parameters.AddWithValue("@SucursalId", sucursalId);

                    cmd.ExecuteNonQuery();
                }
            }
        }



        public static int RegistrarAperturaDeCaja(int numeroCaja, int sucursalId, string usuario)
        {
            using (SqlConnection conn = new SqlConnection(DB_Controller.GetConnectionString()))
            {
                conn.Open();

                string query = @"INSERT INTO dbo.historialCaja (numCaja, sucursal_id, usuario, fecha_apertura)
                         VALUES (@numCaja, @sucursalId, @usuario, GETDATE());
                         SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@numCaja", numeroCaja);
                    cmd.Parameters.AddWithValue("@sucursalId", sucursalId);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    // Devolvemos el ID del registro insertado
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }




        public static void RegistrarCierreDeCaja(int idHistorial)
        {
            using (SqlConnection conn = new SqlConnection(DB_Controller.GetConnectionString()))
            {
                conn.Open();

                string query = @"UPDATE dbo.historialCaja
                         SET fecha_cierre = GETDATE()
                         WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idHistorial);
                    cmd.ExecuteNonQuery();
                }
            }
        }








    }
}
