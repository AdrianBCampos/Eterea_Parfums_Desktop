using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eterea_Parfums_Desktop.Modelos;

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
                    DetalleFactura detalle = new DetalleFactura();
                    detalle.factura = FacturaControlador.getById(reader.GetInt32(0));
                    detalle.perfume = PerfumeControlador.getByID(reader.GetInt32(1));
                    detalle.cantidad = reader.GetInt32(2);
                    detalle.precio_unitario = reader.GetDouble(3);
                    detalle.promocion = PromoControlador.obtenerPorId(reader.GetInt32(4));
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
