using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.Helpers
{
    public static class ModalHelper
    {
        private static bool overlayActivo = false;

        public static DialogResult MostrarModalConFondoOscuro(Form formularioModal)
        {
            FormFondoOscuro.Mostrar();

            // Forzamos que el formulario modal esté encima antes de mostrarlo
            formularioModal.Load += (s, e) =>
            {
                FormFondoOscuro.EnviarAlFondo(); // ✅ Mueve el fondo detrás
                formularioModal.BringToFront();  // ✅ Asegura visibilidad
            };

            DialogResult resultado = formularioModal.ShowDialog();

            FormFondoOscuro.Ocultar();
            return resultado;
        }

        public static DialogResult MostrarModalSinAgregarNuevoFondo(Form modal)
        {
            // Se usa cuando ya hay fondo activo
            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.ShowInTaskbar = false;
            modal.TopMost = true;

            return modal.ShowDialog();
        }
    }

}