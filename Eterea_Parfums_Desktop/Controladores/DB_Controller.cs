using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Controladores
{
    public static class DB_Controller
    {
        public static string connectionString = "";
        public static SqlConnection connection;

        public static void initialize()
        {
            // Lista de posibles nombres de servidores
            List<string> serverNames = new List<string>
            {
                @"LocalHost",
                @"(localdb)\Local",                    
                @"DESKTOP-N6TI9JV\MSSQLSERVER02"
            };

            string databaseName = "eterea1";
            bool integratedSecurity = true;

            foreach (var serverName in serverNames)
            {
                try
                {
                    // Construir la cadena de conexión
                    var builder = new SqlConnectionStringBuilder
                    {
                        DataSource = serverName,        // Nombre del servidor
                        InitialCatalog = databaseName, // Nombre de la base de datos
                        IntegratedSecurity = integratedSecurity
                    };

                    connectionString = builder.ToString();
                    connection = new SqlConnection(connectionString);

                    // Intentar abrir la conexión
                    connection.Open();
                    Trace.WriteLine($"Conexión exitosa al servidor: {serverName}");
                    connection.Close();
                    break; // Si la conexión es exitosa, salir del bucle
                }
                catch (Exception ex)
                {
                    Trace.WriteLine($"No se pudo conectar al servidor: {serverName}. Error: {ex.Message}");
                }
            }

            if (connection == null || connection.State != System.Data.ConnectionState.Closed)
            {
                throw new Exception("No se pudo conectar a ninguno de los servidores especificados.");
            }
        }
    }
}
