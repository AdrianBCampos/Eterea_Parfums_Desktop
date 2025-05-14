using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormNumeroDeSucursal : Form
    {
        // Evento público que otros formularios pueden "escuchar"
        public event EventHandler<int> ConfirmarNumeroSucursal;

        public FormNumeroDeSucursal()
        {
            InitializeComponent();

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";          
            CargarSucursales();

            combo_sucursales.DrawMode = DrawMode.OwnerDrawFixed;
            combo_sucursales.DrawItem += comboBoxDiseño_DrawItem;
            combo_sucursales.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarSucursales()
        {
            var sucursales = SucursalControlador.getAll();
            combo_sucursales.Items.Clear();
            foreach (Sucursal sucursal in sucursales)
            {
                combo_sucursales.Items.Add(sucursal.nombre.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInicioAdministrador InicioAdministrador = new FormInicioAdministrador();
            InicioAdministrador.Show();
            this.Close();
        
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (combo_sucursales.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una sucursal.");
                return;
            }

            string nombreSucursal = combo_sucursales.SelectedItem.ToString();
            var sucursalSeleccionada = SucursalControlador.getAll().FirstOrDefault(s => s.nombre == nombreSucursal);

            if (sucursalSeleccionada != null)
            {
                int idSucursal = sucursalSeleccionada.id;
                ConfirmarNumeroSucursal?.Invoke(this, idSucursal);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la sucursal seleccionada.");
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
