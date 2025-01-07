using Eterea_Parfums_Desktop.Controladores;
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

      
        /// <summary>
        /// public static Vendedor logueado;
        /// </summary>
       

        public static String Ruta_Base;
        public static String Ruta_Web;
        public static String entorno = "dami";

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
                Ruta_Base = @"C:\Users\damim\source\repos"; 
                Ruta_Base = @"C:\Users\Alumno\Desktop\Eterea_Web\Eterea_Web\Content\ImgPerfumes\";
            }
            else if (entorno == "adri")
            {
                Ruta_Base = @"C:\Users\intersan\Desktop\Avanzando TP Plataformas\Eterea_Parfums\Eterea_Parfums\Resources\";
                Ruta_Web = @"C:\Users\intersan\source\repos\Eterea_Web\Eterea_Web\Content\ImgPerfumes\";
            }
            else if (entorno == "maxi")
            {
                Ruta_Base = @"C:\Users\intersan\Desktop\Avanzando TP Plataformas\Eterea_Parfums\Eterea_Parfums\Resources\";
                Ruta_Web = @"C:\Users\intersan\source\repos\Eterea_Web\Eterea_Web\Content\ImgPerfumes\";
            }
            else if (entorno == "jose")
            {
                Ruta_Base = @"C:\Users\intersan\Desktop\Avanzando TP Plataformas\Eterea_Parfums\Eterea_Parfums\Resources\";
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
