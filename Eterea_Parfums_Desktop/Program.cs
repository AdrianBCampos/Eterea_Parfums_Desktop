using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.ControlesDeUsuario;
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
        //public static int debug_mode = 1;

        public static Empleado logueado;

        public static String Ruta_Base;
        public static String Ruta_Web;
        public static String entorno = "jose";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar el formulario de selección de usuario
            FormSeleccionarUsuario formSeleccionarUsuario = new FormSeleccionarUsuario();
            if (formSeleccionarUsuario.ShowDialog() == DialogResult.OK)
            {
                string usuarioSeleccionado = formSeleccionarUsuario.UsuarioSeleccionado;

                // Configurar la conexión a la base de datos con el usuario seleccionado
                DB_Controller.ConfigurarConexion(usuarioSeleccionado);

                // Configurar rutas según el usuario
                ConfigurarRutas(usuarioSeleccionado);

                // Llamamos a ActualizarEstadoPromociones al inicio del programa
                PromocionService.ActualizarEstadoPromociones();

                // Iniciar la aplicación principal

                Application.Run(new MenuABM());
                //Application.Run(new InicioAutoConsultas());
            }
            else
            {
                // Si el usuario no selecciona nada y cierra el formulario, salir de la aplicación
                MessageBox.Show("Debe seleccionar un usuario para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        // Método para configurar rutas según el usuario
        private static void ConfigurarRutas(string usuario)
            {
                switch (usuario.ToLower())
                {
                    case "escuela":
                        Ruta_Base = @"C:\Users\Alumno\Desktop\Eterea_Parfums\Eterea_Parfums\Resources\";
                        Ruta_Web = @"C:\Users\Alumno\Desktop\Eterea_Web\Eterea_Web\Content\ImgPerfumes\";
                        break;
                    case "dami":
                        Ruta_Base = @"C:\Users\damim\source\repos\Eterea_Parfums_Desktop\Eterea_Parfums_Desktop\Resources\";
                        Ruta_Web = @"C:\Users\damim\Source\Repos\Eterea_Parfums_Desktop\Eterea_Parfums_Desktop\Resources\";
                        break;
                    case "adri":
                        Ruta_Base = @"C:\Users\intersan\Desktop\TESIS\Eterea_Parfums_Desktop\Eterea_Parfums_Desktop\Resources\";
                        Ruta_Web = @"C:\Users\intersan\source\repos\Eterea_Web\Eterea_Web\Content\ImgPerfumes\";
                        break;
                    case "luis":
                        Ruta_Base = @"C:\Users\josel\source\repos\Eterea_Parfums_Desktop\Eterea_Parfums_Desktop\Resources\";
                        Ruta_Web = @"C:\Users\intersan\source\repos\Eterea_Web\Eterea_Web\Content\ImgPerfumes\";
                        break;
                case "maxi":
                        Ruta_Base = @"C:\Users\usuario\source\repos\Eterea_Parfums_Desktop\Eterea_Parfums_Desktop\Resources\";
                        Ruta_Web = @"C:\Users\usuario\source\repos\Eterea_Parfums_Desktop\Eterea_Parfums_Desktop\Resources\";
                        break;
                    default:
                        MessageBox.Show("Usuario no válido, no se configuraron rutas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

            /*DB_Controller.initialize();

            if (connectionIsValid())
            {
                if (debug_mode == 1)
                {
                    Trace.WriteLine("Conexion a la DB creada con exito.");
                }

            }

            // Llamamos a ActualizarEstadoPromociones al inicio del programa
            PromocionService.ActualizarEstadoPromociones();

            //Application.Run(new FormCrearPromo());
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
            }*/
            /*
            // Mostrar el formulario de selección de usuario
            FormSeleccionarUsuario formSeleccionarUsuario = new FormSeleccionarUsuario();
            if (formSeleccionarUsuario.ShowDialog() == DialogResult.OK)
            {
                // Configurar la conexión basada en el usuario seleccionado
                DB_Controller.ConfigurarConexion(formSeleccionarUsuario.UsuarioSeleccionado);

                // Llamamos a ActualizarEstadoPromociones al inicio del programa
                PromocionService.ActualizarEstadoPromociones();

                //Application.Run(new FormCrearPromo());
                Application.Run(new InicioAutoConsultas());
            }*/

        




    }
}
