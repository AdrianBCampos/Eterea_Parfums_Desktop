using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.Helpers
{
    public static class ModalHelper
    {
        public static DialogResult MostrarModalConFondoOscuro(Form modal)
        {
            using (FormFondoOscuro fondoOscuro = new FormFondoOscuro())
            {
                fondoOscuro.Show();

                modal.StartPosition = FormStartPosition.CenterScreen;
                modal.ShowInTaskbar = false;
                modal.TopMost = true;

                DialogResult resultado = modal.ShowDialog();

                fondoOscuro.Close();

                return resultado;
            }
        }

    }
}

