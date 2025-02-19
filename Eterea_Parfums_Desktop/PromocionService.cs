using Eterea_Parfums_Desktop.Controladores;
using System;
using System.Data.SqlClient;
namespace Eterea_Parfums_Desktop
{
    internal class PromocionService
    {
        public static void ActualizarEstadoPromociones()
        {
            SqlConnection connection = DB_Controller.connection;  // Suponiendo que DB_Controller.connection es una instancia de SqlConnection

            try
            {
                connection.Open();

                // Consulta para actualizar el estado de las promociones
                string query = @"
                UPDATE dbo.promocion
                SET activo = CASE
                    WHEN GETDATE() BETWEEN fecha_inicio AND fecha_fin THEN 1 -- Activa si la fecha actual está entre inicio y fin
                    ELSE 0 -- Inactiva en cualquier otro caso
                END;
                ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra durante la ejecución de la consulta
                Console.WriteLine("Error al actualizar estado de promociones: " + ex.Message);
            }
            finally
            {
                // Asegurarse de que la conexión se cierra siempre
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
