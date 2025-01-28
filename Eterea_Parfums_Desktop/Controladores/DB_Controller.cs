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
        //public static string connectionString = "";
        public static SqlConnection connection;

        /*public static void initialize()
        {
            var builder = new SqlConnectionStringBuilder();

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
                    connectionString = "Data Source=DESKTOP-N6TI9JV\\MSSQLSERVER02;Initial Catalog=eterea;Integrated Security=True;";
                    break;
                case "Marino":
                    connectionString = "Data Source=(localdb)\\Local;Initial Catalog=eterea;Integrated Security=True;";
                    break;
                default:
                    throw new Exception("Usuario no válido.");
            }

            connection = new SqlConnection(connectionString);

        }
    }
}
