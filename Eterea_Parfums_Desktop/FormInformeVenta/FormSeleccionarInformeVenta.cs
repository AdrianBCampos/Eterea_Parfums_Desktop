using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormSeleccionarInformeVenta : Form
    {

        public FormSeleccionarInformeVenta()
        {
            InitializeComponent();

            combobox_informe.DrawMode = DrawMode.OwnerDrawFixed;
            combobox_informe.DrawItem += comboBoxDiseño_DrawItem;
            combobox_informe.DropDownStyle = ComboBoxStyle.DropDownList;

            combobox_informe.SelectedIndex = 0; // Seleccionar el primer usuario por defecto

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInicioAdministrador InicioAdministrador = new FormInicioAdministrador();
            InicioAdministrador.Show();
            this.Close();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (combobox_informe.SelectedIndex == 0)
            {
                FormInformesDeVentas1 InformesDeVentas1 = new FormInformesDeVentas1();
                InformesDeVentas1.ShowDialog();
                this.Hide();
            }
            else if (combobox_informe.SelectedIndex == 1)
            {
                FormInformesDeVentas2 InformesDeVentas2 = new FormInformesDeVentas2();
                InformesDeVentas2.ShowDialog();
                this.Hide();
            }
        }

        private void comboBoxDiseño_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            // Obtener el ComboBox y el texto del ítem actual
            ComboBox combo = sender as ComboBox;
         
            string text = combo.Items[e.Index].ToString();

            // Definir colores personalizados
            Color backgroundColor;
            Color textColor;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                // Color cuando el ítem está seleccionado
                backgroundColor = Color.FromArgb(195, 156, 164);
                textColor = Color.White;
            }
            else
            {
                // Color cuando el ítem NO está seleccionado
                backgroundColor = Color.FromArgb(250, 236, 239); // Color personalizado
                textColor = Color.FromArgb(195, 156, 164);
            }

            // Pintar el fondo del ítem
            using (SolidBrush brush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            // Dibujar el texto
            TextRenderer.DrawText(e.Graphics, text, e.Font, e.Bounds, textColor, TextFormatFlags.Left);

            // Evitar problemas visuales
            e.DrawFocusRectangle();
        }
    }
}
