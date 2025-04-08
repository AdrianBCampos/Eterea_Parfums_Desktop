using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Controladores
{
    internal class OrdenControlador
    {
        public DataTable ObtenerOrdenes()
        {
            string query = @"
            SELECT DISTINCT o.numero_de_orden, f.num_factura, f.fecha, o.nombre_cliente, o.apellido_cliente
            FROM dbo.orden o
            JOIN dbo.factura f ON o.num_factura = f.num_factura
            WHERE o.estado = @estado
        ";

            SqlParameter[] parametros = {
            new SqlParameter("@estado", SqlDbType.Bit) { Value = 1 }
        };

            return EjecutarConsultaConParametros(query, parametros);
        }

        public DataTable ObtenerPerfumesDeFactura(int numFactura)
        {
            string query = @"
    SELECT 
        df.cantidad AS Cantidad,
        p.nombre AS NombrePerfume,
        m.nombre AS Marca,
        tp.tipo_de_perfume AS Tipo,
        g.genero AS Genero,
        CAST(p.presentacion_ml AS varchar) + ' ml' AS Presentacion
    FROM detalle_factura df
    JOIN perfume p ON df.perfume_id = p.id
    JOIN marca m ON p.marca_id = m.id
    JOIN tipo_de_perfume tp ON p.tipo_de_perfume_id = tp.id
    JOIN genero g ON p.genero_id = g.id
    WHERE df.num_factura = @numFactura
";


            SqlParameter[] parametros = {
            new SqlParameter("@numFactura", SqlDbType.Int) { Value = numFactura }
        };

            return EjecutarConsultaConParametros(query, parametros);
        }

        private DataTable EjecutarConsultaConParametros(string query, SqlParameter[] parametros)
        {
            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddRange(parametros);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }


        public int ObtenerCantidadOrdenesActivas()
        {
            string query = "SELECT COUNT(*) FROM dbo.orden WHERE estado = @estado";

            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@estado", 1);
                connection.Open();
                int cantidad = (int)command.ExecuteScalar();
                return cantidad;
            }
        }




    }
}
