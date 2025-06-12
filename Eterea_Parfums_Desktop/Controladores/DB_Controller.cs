using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Eterea_Parfums_Desktop.Controladores
{
    public static class DB_Controller
    {
        //public static string connectionString = "";
        public static SqlConnection connection;

        

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
                case "Notebook Adri":
                    connectionString = "Data Source=DESKTOP-U4RUEJ1\\SQLEXPRESS;Initial Catalog=eterea;Integrated Security=True;";
                    break;
                default:
                    throw new Exception("Usuario no válido.");
            }

            connection = new SqlConnection(connectionString);

            // Mostrar los datos de conexión en la consola
            Trace.WriteLine("=================================");
            Trace.WriteLine($"Usuario seleccionado: {usuario}");
            Trace.WriteLine($"Cadena de conexión: {connectionString}");
            Trace.WriteLine("=================================");

        }


        public static string GetConnectionString()
        {
            return connection.ConnectionString; // Devolver la cadena de conexión actual
        }



    }
}