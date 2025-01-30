using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop
{
    public partial class NumeroDeSucursal : Form
    {
        public NumeroDeSucursal()
        {
            InitializeComponent();

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);
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
            InicioAdministrador InicioAdministrador = new InicioAdministrador();
            InicioAdministrador.Show();
            this.Close();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {

            int idSucursal = int.Parse(combo_sucursales.SelectedItem.ToString());

            Stock stock = new Stock(idSucursal);
            stock.Show();
            this.Hide();
        }
    }
}
