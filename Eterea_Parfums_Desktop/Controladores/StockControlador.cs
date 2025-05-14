using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
            string query = "UPDATE dbo.stock SET cantidad = cantidad + @cantidad WHERE perfume_id = @perfume_id AND sucursal_id = @sucursal_id;";
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

        public static List<Stock> getAll()
        {
            List<Stock> stocks = new List<Stock>();
            string query = "SELECT * FROM dbo.stock";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Perfume perfume = new Perfume();
                    Sucursal sucursal = new Sucursal();

                    perfume.id = r.GetInt32(0);
                    sucursal.id = r.GetInt32(1);

                    Stock stock = new Stock();
                    stock.perfume = perfume;
                    stock.sucursal = sucursal;
                    stock.cantidad = r.GetInt32(2);
                    stocks.Add(stock);
                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                Trace.Write("Error al consultar la DB: " + e.Message);
            }
            return stocks;
        }

        /*public static int ObtenerStockPorPerfumeYSucursal(int perfumeId, int sucursalId)
        {
            string query = "SELECT ISNULL(SUM(cantidad), 0) FROM dbo.stock WHERE perfume_id = @perfumeId AND sucursal_id = @sucursalId";

            using (SqlCommand cmd = new SqlCommand(query, DB_Controller.connection))
            {
                cmd.Parameters.AddWithValue("@perfumeId", perfumeId);
                cmd.Parameters.AddWithValue("@sucursalId", sucursalId);

                DB_Controller.connection.Open();
                int stock = Convert.ToInt32(cmd.ExecuteScalar());
                DB_Controller.connection.Close();

                return stock;
            }
        }*/


        public static Dictionary<int, int> ObtenerTodosLosStocksPorSucursal(int sucursalId)
        {
            string query = @"
        SELECT perfume_id, SUM(cantidad) AS total_stock
        FROM dbo.stock
        WHERE sucursal_id = @sucursalId
        GROUP BY perfume_id";

            Dictionary<int, int> resultado = new Dictionary<int, int>();

            using (SqlCommand cmd = new SqlCommand(query, DB_Controller.connection))
            {
                cmd.Parameters.AddWithValue("@sucursalId", sucursalId);

                DB_Controller.connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int perfumeId = reader.GetInt32(0);
                        int totalStock = reader.GetInt32(1);
                        resultado[perfumeId] = totalStock;
                    }
                }
                DB_Controller.connection.Close();
            }

            return resultado;
        }




    }
}
