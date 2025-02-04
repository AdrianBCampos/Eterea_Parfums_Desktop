using System;

using System.Data.SqlClient;
using System.Diagnostics;
using System.Collections.Generic;
using System.Diagnostics;


namespace Eterea_Parfums_Desktop.Controladores
{
    public static class DB_Controller
    {
        //public static string connectionString = "";
        public static SqlConnection connection;

        /*public static void initialize()
        {
            var builder = new SqlConnectionStringBuilder();

            builder.DataSource = @"(localdb)\Local";  //NOMBRE DEL SERVIDOR
            builder.InitialCatalog = "eterea";  //NOMBRE DE LA BASE DE DATOS
            builder.IntegratedSecurity = true;  //TIENE O NO SEGURIDAD INTEGRADA CON WINDOWS

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

            Trace.WriteLine("Conexion a la BD: " + connection);
        }*/

        // Método para configurar la conexión basada en el usuario
        public static void ConfigurarConexion(string usuario)
        {
            // Definir la cadena de conexión según el usuario seleccionado
            string connectionString;

            switch (usuario)
            {
                case "Adri":
                    connectionString = "Data Source=(localdb)\\Local;Initial Catalog=eterea;Integrated Security=True;";
                    break;
                case "Dami":
                    connectionString = "Data Source=LocalHost;Initial Catalog=eterea;Integrated Security=True;";
                    break;
                case "Luis":
                    connectionString = "Data Source=LocalHost;Initial Catalog=eterea;Integrated Security=True;";
                    break;
                case "Maxi":
                    connectionString = "Data Source=DESKTOP-N6TI9JV\\MSSQLSERVER02;Initial Catalog=eterea;Integrated Security=True;";
                    break;
                case "Marino":
                    connectionString = "Data Source=(localdb)\\Local;Initial Catalog=eterea;Integrated Security=True;";
                    break;
=========
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
>>>>>>>>> Temporary merge branch 2
                default:
                    throw new Exception("Usuario no válido.");
}
            connection = new SqlConnection(connectionString);

            // Mostrar los datos de conexión en la consola
            Console.WriteLine("=================================");
            Console.WriteLine($"Usuario seleccionado: {usuario}");
            Console.WriteLine($"Cadena de conexión: {connectionString}");
            Console.WriteLine("=================================");

        }
    }
}
