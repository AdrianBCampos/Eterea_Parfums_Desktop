using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class DetalleFacturaControlador
    {
        public static List<DetalleFactura> getByIdFactura(int num_factura)
        {
            List<DetalleFactura> detalles = new List<DetalleFactura>();
            string query = "SELECT * FROM dbo.detalle_factura where num_factura = @num_factura";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@num_factura", num_factura);



            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Factura factura = new Factura();
                    Perfume perfume = new Perfume();
                    Promocion promocion = new Promocion();
                    factura.num_factura = reader.GetInt32(0);
                    perfume.id = reader.GetInt32(1);
                    promocion.id = reader.GetInt32(4);
                    DetalleFactura detalle = new DetalleFactura(factura, perfume, reader.GetInt32(2), reader.GetDouble(3), promocion);
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
    }
}
