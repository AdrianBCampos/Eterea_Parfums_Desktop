using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario.GenerarInformes
{
    public partial class GenerarInformes_UC : UserControl
    {
        public GenerarInformes_UC()
        {
            InitializeComponent();

            InformesDeVentas1_UC adminUC = new InformesDeVentas1_UC();
            addUserControl(adminUC);

            combobox_informe.DrawMode = DrawMode.OwnerDrawFixed;
            combobox_informe.DrawItem += comboBoxDiseño_DrawItem;
            combobox_informe.DropDownStyle = ComboBoxStyle.DropDownList;

            combobox_informe.SelectedIndex = 0; // Seleccionar el primer informe por defecto

            this.Cursor = Cursors.Default;
            this.UseWaitCursor = false;


        }

        public void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_info_ventas.Controls.Clear();
            panel_info_ventas.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (combobox_informe.SelectedIndex == 0)
            {
                InformesDeVentas1_UC adminUC = new InformesDeVentas1_UC();
                addUserControl(adminUC);
            }
            else if (combobox_informe.SelectedIndex == 1)
            {
                InformesDeVentas2_UC adminUC = new InformesDeVentas2_UC();
                addUserControl(adminUC);
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
