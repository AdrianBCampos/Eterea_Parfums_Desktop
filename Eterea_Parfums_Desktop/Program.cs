using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static int debug_mode = 1;

      

        public static Empleado logueado;
        
       

        public static String Ruta_Base;
        public static String Ruta_Web;
        public static String entorno = "maxi";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (entorno == "escuela")
            {
                Ruta_Base = @"C:\Users\Alumno\Desktop\Eterea_Parfums\Eterea_Parfums\Resources\";
                Ruta_Base = @"C:\Users\Alumno\Desktop\Eterea_Web\Eterea_Web\Content\ImgPerfumes\";
            }
            
            else if (entorno == "dami")
            {
                Ruta_Base = @"C:\Users\damim\source\repos\Eterea_Parfums_Desktop\Eterea_Parfums_Desktop\Resources\"; 
                Ruta_Web = @"C:\Users\damim\Source\Repos\Eterea_Parfums_Desktop\Eterea_Parfums_Desktop\Resources\";
            }
            else if (entorno == "adri")
            {
                Ruta_Base = @"C:\Users\PC\source\repos\Eterea_Parfums_Desktop\Eterea_Parfums_Desktop\Resources\";
                Ruta_Web = @"C:\Users\intersan\source\repos\Eterea_Web\Eterea_Web\Content\ImgPerfumes\";
            }
            else if (entorno == "maxi")
            {
                Ruta_Base = @"C:\Users\Maxi\source\repos";
                Ruta_Base = @"C:\Users\Maxi\source\repos\Eterea_Parfums_Desktop\Eterea_Parfums_Desktop\Resources\";
            }
            else if (entorno == "jose")
            {
                Ruta_Base = @"C:\Users\josel\source\repos";
                Ruta_Web = @"C:\Users\intersan\source\repos\Eterea_Web\Eterea_Web\Content\ImgPerfumes\";
            }
            else if (entorno == "marino")
            {
                Ruta_Base = @"C:\Users\intersan\Desktop\Avanzando TP Plataformas\Eterea_Parfums\Eterea_Parfums\Resources\";
                Ruta_Web = @"C:\Users\intersan\source\repos\Eterea_Web\Eterea_Web\Content\ImgPerfumes\";

            }


            DB_Controller.initialize();

            if (connectionIsValid())
            {
                if (debug_mode == 1)
                {
                    Trace.WriteLine("Conexion a la DB creada con exito.");
                }

            }

          Application.Run(new InicioAutoConsultas());
        }

        public static bool connectionIsValid()
        {
            try
            {
                DB_Controller.connection.Open();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception e)
            {
                if (debug_mode == 1)
                {
                    Trace.WriteLine("Conexion a la DB con error." + e.Message);

                }
                return false;
            }

        }
    }
}
