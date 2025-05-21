using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.Helpers
{
    public static class ModalHelper
    {
        private static bool overlayActivo = false;

        public static DialogResult MostrarModalConFondoOscuro(Form modal)
        {
            if (!overlayActivo)
            {
                FormFondoOscuro.Mostrar();
                overlayActivo = true;
            }

            modal.StartPosition = FormStartPosition.CenterScreen;
            modal.ShowInTaskbar = false;
            modal.TopMost = true;

            DialogResult resultado = modal.ShowDialog();

            overlayActivo = false;
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