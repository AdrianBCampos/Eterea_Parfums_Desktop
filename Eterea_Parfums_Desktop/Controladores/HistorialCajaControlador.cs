using Eterea_Parfums_Desktop.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Eterea_Parfums_Desktop.Controladores
{
    public static class HistorialCajaControlador
    {
        public static List<HistorialCajaDTO> GetPorSucursal(int sucursalId)
        {
            List<HistorialCajaDTO> lista = new List<HistorialCajaDTO>();

            string query = @"
                SELECT hc.numCaja, hc.fecha_apertura, hc.fecha_cierre, e.nombre, e.apellido, hc.usuario
                FROM dbo.historialCaja hc
                INNER JOIN dbo.empleado e ON hc.usuario = e.usuario
                WHERE hc.sucursal_id = @sucursalId
                ORDER BY hc.fecha_apertura DESC";

            using (SqlConnection conn = new SqlConnection(DB_Controller.GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@sucursalId", sucursalId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HistorialCajaDTO item = new HistorialCajaDTO
                        {
                            NumeroCaja = reader.GetInt32(0),
                            FechaApertura = reader.GetDateTime(1),
                            FechaCierre = reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2),
                            Empleado = $"{reader.GetString(3)} {reader.GetString(4)}",
                            Usuario = reader.GetString(5)
                        };

                        lista.Add(item);
                    }
                }
            }

            return lista;
        }
    }
}
