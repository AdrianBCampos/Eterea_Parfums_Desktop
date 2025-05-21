using Eterea_Parfums_Desktop;
using System.Windows.Forms;
using System.Linq;


public static class ModalHelper
{
    public static DialogResult MostrarModalConFondoOscuro(Form formularioModal)
    {
        // ✅ Detectar correctamente el formulario principal (aunque estés en un UserControl)
        Form owner = formularioModal.Owner ?? GetFormularioPrincipalActivo();

        // ✅ Mostrar fondo oscuro con referencia al owner
        FormFondoOscuro.Mostrar(owner);

        // ✅ Enviar el fondo al fondo después de mostrarlo
        FormFondoOscuro.EnviarAlFondo();

        // ✅ Asegurar visibilidad del modal
        formularioModal.TopMost = true;
        formularioModal.StartPosition = FormStartPosition.CenterScreen;
        formularioModal.ShowInTaskbar = false;

        // ✅ Mostrar modal y luego ocultar fondo
        DialogResult resultado = formularioModal.ShowDialog();

        FormFondoOscuro.Ocultar();
        return resultado;
    }

    private static Form GetFormularioPrincipalActivo()
    {
        Form active = Form.ActiveForm;

        if (active != null && active.Visible)
            return active;

        // Si no hay formulario activo, buscar uno visible
        return Application.OpenForms
            .Cast<Form>()
            .FirstOrDefault(f => f.Visible && f.Enabled && f.Modal == false);
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
