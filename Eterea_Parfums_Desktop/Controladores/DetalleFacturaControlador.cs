using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class DetalleFacturaControlador
    {
        public static List<DetalleFactura> getByIdFactura(int factura_id)
        {
            List<DetalleFactura> detalles = new List<DetalleFactura>();
            string query = "SELECT * FROM dbo.detalle_factura where factura_id = @factura_id";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@factura_id", factura_id);



            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Factura factura = new Factura();
                    Perfume perfume = new Perfume();
                    Promocion promocion = new Promocion();
                    Promocion promocion2 = new Promocion();
                    factura.id = reader.GetInt32(0);
                    perfume.id = reader.GetInt32(1);
                    promocion.id = reader.GetInt32(4);
                    promocion2.id = reader.GetInt32(5);
                    DetalleFactura detalle = new DetalleFactura(factura, perfume, reader.GetInt32(2), reader.GetDouble(3), promocion, promocion2);
                    detalles.Add(detalle);
                }
                reader.Close();
                DB_Controller.connection.Close();
                return detalles;
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }

        }

        public static bool crearDetalleFactura(int factura_id, int perfume_id, int cantidad, float precio_unitario, int? promocion_id, int? promocion2_id)
        {
            string query = "INSERT INTO dbo.detalle_factura (factura_id, perfume_id, cantidad, precio_unitario, promocion_id, promocion2_id) " +
                           "VALUES (@factura_id, @perfume_id, @cantidad, @precio_unitario, @promocion_id, @promocion2_id);";

            try
            {
                using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@factura_id", factura_id);
                        cmd.Parameters.AddWithValue("@perfume_id", perfume_id);
                        cmd.Parameters.AddWithValue("@cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@precio_unitario", precio_unitario);
                        cmd.Parameters.AddWithValue("@promocion_id", promocion_id);
                        cmd.Parameters.AddWithValue("@promocion2_id", promocion2_id);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return true; // Si la operación fue exitosa
            }
            catch (Exception e)
            {

                throw new Exception("Hay un error en la query: " + e.Message);
               
            }
        }
    }
}
