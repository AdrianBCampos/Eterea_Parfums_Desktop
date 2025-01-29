using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class FacturaControlador
    {

        public static int ObtenerProximoIdFactura()
        {
            int proximoId = 0;

            string query = "SELECT MAX(num_factura) FROM dbo.Factura;";



            using (SqlConnection connection = new SqlConnection(DB_Controller.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = cmd.ExecuteScalar();
                    connection.Close();

                    if (result != null && result != DBNull.Value)
                    {
                        proximoId = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        proximoId = 1;
                    }
                }
            }

            return proximoId;
        }

        //CREAR UNA FACTURA AL IMPRIMIR LA VENTA

        public static bool crearFactura(int num_factura, DateTime fecha, int sucursal_id, int vendedor_id, int cliente_id, string forma_de_pago, double precio_total,
            double recargo, double descuento, int numero_caja, string tipo_consumidor, string origen, string factura_pdf)
        {

            string query = "insert into dbo.Factura values" +
                "(@num_factura, " +
                "@fecha, " +
                "@sucursal_id, " +
                "@vendedor_id, " +
                "@cliente_id, " +
                "@forma_de_pago, " +
                "@precio_total, " +
                "@recargo, " +
                "@descuento, " +
                "@numero_caja, " +
                "@tipo_consumidor, " +
                "@origen, " +
                "@factura_pdf); ";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            cmd.Parameters.AddWithValue("@num_factura", num_factura);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@sucursal_id", sucursal_id);
            cmd.Parameters.AddWithValue("@vendedor_id", vendedor_id);
            cmd.Parameters.AddWithValue("@cliente_id", cliente_id);
            cmd.Parameters.AddWithValue("@forma_de_pago", forma_de_pago);
            cmd.Parameters.AddWithValue("@precio_total", precio_total);
            cmd.Parameters.AddWithValue("@recargo", recargo);
            cmd.Parameters.AddWithValue("@descuento", descuento);
            cmd.Parameters.AddWithValue("@numero_caja", numero_caja);
            cmd.Parameters.AddWithValue("@tipo_consumidor", tipo_consumidor);
            cmd.Parameters.AddWithValue("@origen", origen);
            cmd.Parameters.AddWithValue("@factura_pdf", factura_pdf);

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }




        }
    }
}
