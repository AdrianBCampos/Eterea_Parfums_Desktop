using System;
using System.Data.SqlClient;


namespace Eterea_Parfums_Desktop.Controladores
{
    public static class DB_Controller
    {
        //public static string connectionString = "";
        public static SqlConnection connection;

        /*public static void initialize()
        {
            // Lista de posibles nombres de servidores
            List<string> serverNames = new List<string>
            {
                @"(localdb)\Local",
                @"LocalHost",
                @"DESKTOP-N6TI9JV\MSSQLSERVER02"
            };

            builder.DataSource = @"(localdb)\Local";  //NOMBRE DEL SERVIDOR
            builder.InitialCatalog = "eterea";  //NOMBRE DE LA BASE DE DATOS
            builder.IntegratedSecurity = true;  //TIENE O NO SEGURIDAD INTEGRADA CON WINDOWS

                    connectionString = builder.ToString();
                    connection = new SqlConnection(connectionString);

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
                    connectionString = "Data Source=(localdb)\\Local;Initial Catalog=eterea;Integrated Security=True;";
                    break;
                case "Marino":
                    connectionString = "Data Source=(localdb)\\Local;Initial Catalog=eterea;Integrated Security=True;";
                    break;
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