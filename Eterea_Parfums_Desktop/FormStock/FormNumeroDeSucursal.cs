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
        }

        private void CargarSucursales()
        {
            var sucursales = SucursalControlador.getAll();
            combo_sucursales.Items.Clear();
            foreach (Sucursal sucursal in sucursales)
            {
                combo_sucursales.Items.Add(sucursal.id.ToString());
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

            int idSucursal = int.Parse(combo_sucursales.SelectedItem.ToString());

            // Lanza el evento con la sucursal seleccionada
            ConfirmarNumeroSucursal?.Invoke(this, idSucursal);

            this.Close(); // Cierra esta ventana, vuelve al formulario que la abrió
        }

        
    }
}
