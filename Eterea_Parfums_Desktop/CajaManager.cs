using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.ControlesDeUsuario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.Helpers
{
    public static class CajaManager
    {
        public static bool HayCajaAsignada()
        {
            return !string.IsNullOrEmpty(Program.NumeroCajaActual) && Program.NumeroCajaActual != "Caja sin asignar";
        }

        public static void ResetCaja()
        {
            Program.NumeroCajaActual = "Caja sin asignar";
            Program.IdHistorialCajaActual = 0;
        }

        public static List<int> ObtenerCajasDisponibles(int sucursalId)
        {
            var cajasDisponibles = new List<int>();

            using (SqlConnection connection = new SqlConnection(DB_Controller.GetConnectionString()))
            {
                connection.Open();

                string query = @"SELECT numCaja FROM dbo.caja WHERE sucursal_id = @SucursalId AND disponible = 1";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@SucursalId", sucursalId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cajasDisponibles.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return cajasDisponibles;
        }

        public static bool IntentarAbrirCaja(int numeroCaja, int sucursalId, string usuario)
        {
            if (CajaControlador.MarcarCajaComoNoDisponible(numeroCaja, sucursalId))
            {
                Program.NumeroCajaActual = numeroCaja.ToString();
                Program.IdHistorialCajaActual = CajaControlador.RegistrarAperturaDeCaja(numeroCaja, sucursalId, usuario);
                return true;
            }
            return false;
        }

        public static void CerrarCaja()
        {
            if (int.TryParse(Program.NumeroCajaActual, out int numeroCaja))
            {
                CajaControlador.MarcarCajaComoDisponible(numeroCaja, Program.sucursal);
            }

            if (Program.IdHistorialCajaActual > 0)
            {
                CajaControlador.RegistrarCierreDeCaja(Program.IdHistorialCajaActual);
            }

            ResetCaja();
        }

        public static void VerificarCajaAlIngresarAFacturar(FormInicioAdministrador formInicio)

        {
            var cajas = ObtenerCajasDisponibles(Program.sucursal);

            if (cajas.Count == 0)
            {
                MessageBox.Show("No hay cajas disponibles en este momento.\nPor favor, comuníquese con el administrador o soporte técnico por los canales habilitados.", "Sin cajas disponibles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cajas.Count == 1)
            {
                if (IntentarAbrirCaja(cajas[0], Program.sucursal, Program.logueado.usuario))
                {
                    AbrirFacturarUC(formInicio);

                }
            }
            else
            {
                FormNumeroDeCaja formCaja = new FormNumeroDeCaja();
                formCaja.ConfirmarNumeroCaja += (s, numeroCaja) => AbrirFacturarUC(formInicio);

                ModalHelper.MostrarModalConFondoOscuro(formCaja);
            }
        }
    

       
      public static void IntentarAbrirCajaDesdeBoton(UserControl parentUC, Action<string> onCajaAsignada = null)
        {
            if (HayCajaAsignada())
            {
                MessageBox.Show("Ya hay una caja abierta.", "Caja en uso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var cajas = ObtenerCajasDisponibles(Program.sucursal);

            if (cajas.Count == 0)
            {
                MessageBox.Show("No hay cajas disponibles en este momento.\nPor favor, comuníquese con el administrador o soporte técnico por los canales habilitados.", "Sin cajas disponibles", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FormNumeroDeCaja formCaja = new FormNumeroDeCaja();
            formCaja.ConfirmarNumeroCaja += (s, numeroCaja) =>
            {
                MessageBox.Show($"Caja {numeroCaja} abierta correctamente.", "Caja abierta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                onCajaAsignada?.Invoke(numeroCaja); // <-- llamar a la acción de actualización de interfaz
            };
            ModalHelper.MostrarModalConFondoOscuro(formCaja);
        }


        private static void AbrirFacturarUC(FormInicioAdministrador formInicio)
        {
            formInicio.MostrarFacturar();  // reutiliza el mismo Facturar_UC si ya existe
        }




    }
}
