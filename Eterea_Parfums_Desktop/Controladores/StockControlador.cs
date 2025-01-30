using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class StockControlador
    {
        public static int getStock(int perfume_id, int sucursal_id)
        {
            int cantidad = -1;
            string query = "SELECT cantidad FROM dbo.stock WHERE perfume_id = " + 
                "@perfume_id AND sucursal_id = @sucursal_id";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@perfume_id", perfume_id);
            cmd.Parameters.AddWithValue("@sucursal_id", sucursal_id);
            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    cantidad = r.GetInt32(0);
                }
                r.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception e)
            {
                Trace.Write("Error al consultar la DB: " + e.Message);

            }
            return cantidad;

        }


        public static void updateStock(int perfume_id, int sucursal_id, int cantidad)
        {
            string query = "UPDATE dbo.stock SET cantidad = @cantidad WHERE " +
                "perfume_id = @perfume_id AND sucursal_id = @sucursal_id";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.AddWithValue("@perfume_id", perfume_id);
            cmd.Parameters.AddWithValue("@sucursal_id", sucursal_id);
            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                Trace.Write("Error al actualizar la DB: " + e.Message);
            }
        }

        public static void insertStock(int perfume_id, int sucursal_id, int cantidad)
        {
            string query = "INSERT INTO dbo.stock (perfume_id, sucursal_id, cantidad) " +
                "VALUES (@perfume_id, @sucursal_id, @cantidad)";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@perfume_id", perfume_id);
            cmd.Parameters.AddWithValue("@sucursal_id", sucursal_id);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                Trace.Write("Error al insertar en la DB: " + e.Message);
            }
        }
    }
}
