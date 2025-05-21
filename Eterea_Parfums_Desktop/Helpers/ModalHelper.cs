using Eterea_Parfums_Desktop;
using System.Windows.Forms;
using System.Linq;


public static class ModalHelper
{
    public static DialogResult MostrarModalConFondoOscuro(Form formularioModal)
    {
        Form owner = GetFormularioPrincipalActivo();

        if (FormFondoOscuro.Instance == null || FormFondoOscuro.Instance.IsDisposed)
        {
            FormFondoOscuro.Mostrar(owner);
        }

        FormFondoOscuro.EnviarAlFondo();

        formularioModal.StartPosition = FormStartPosition.CenterScreen;
        formularioModal.ShowInTaskbar = false;
        formularioModal.TopMost = true;

        var resultado = formularioModal.ShowDialog(owner);

        FormFondoOscuro.Ocultar();
        return resultado;
    }

    private static Form GetFormularioPrincipalActivo()
    {
        return Application.OpenForms.Cast<Form>()
            .FirstOrDefault(f => f.Visible && f.Enabled && f.Modal == false && !(f is FormFondoOscuro));
    }

    public static DialogResult MostrarModalSinAgregarNuevoFondo(Form modal)
    {
        modal.StartPosition = FormStartPosition.CenterScreen;
        modal.ShowInTaskbar = false;
        modal.TopMost = true;

        FormFondoOscuro.EnviarAlFondo();

        return modal.ShowDialog();
    }
}