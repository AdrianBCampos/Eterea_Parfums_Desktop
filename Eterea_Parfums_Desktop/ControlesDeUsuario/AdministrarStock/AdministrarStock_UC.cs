using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario.AdministrarStock
{
    public partial class AdministrarStock_UC : UserControl
    {
        private Perfume perfume;
        private int idSucursal;     

        public AdministrarStock_UC(int idSucursal)
        {
            InitializeComponent();
            this.idSucursal = idSucursal;
            txt_numero_sucursal.Text = idSucursal.ToString();
            //txt_cantidad_producto.Text = "0";
            txt_codigo_producto.MaxLength = 13;
            txt_codigo_producto.KeyPress += txt_codigo_producto_KeyPress;
            txt_codigo_producto.TextChanged += txt_codigo_producto_TextChanged;
        }

        

        private void btn_sucursal_Click(object sender, EventArgs e)
        {
            FormNumeroDeSucursal FormNumeroDeSucursal = new FormNumeroDeSucursal();
            FormNumeroDeSucursal.ShowDialog();
        }

        private bool validarSiExisteCodigoPerfume(string codigo)
        {
            perfume = PerfumeControlador.getByCodigo(codigo);
            // Si el perfume no existe, perfume.nombre es null
            return perfume.nombre != null;
        }

        private bool Validar_Datos_Stock()
        {
            string mensaje = "";
            if (string.IsNullOrEmpty(txt_codigo_producto.Text))
            {
                mensaje += "Por favor, ingrese un código de producto.";
            }
            else if (txt_codigo_producto.Text.Length != 13)
            {
                mensaje += "\nCódigo ingresado es inexistente.";
            }
            if (string.IsNullOrEmpty(txt_cantidad_producto.Text))
            {
                mensaje += "\nPor favor, ingrese cantidad de producto.";
            }
            else if (int.Parse(txt_cantidad_producto.Text) < 0)
            {
                mensaje += "\nPor favor, ingrese una cantidad valida.";
            }

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje);
                // Limpiar los campos
                SetearDatos();
            }

            return string.IsNullOrEmpty(mensaje);
        }

        private void SetearDatos()
        {
            txt_codigo_producto.Clear(); // Borra el texto si el código no existe
            txt_datos_producto.Text = ""; // Limpia el campo de datos del producto
            txt_cantidad_producto.Text = "";
            perfume = null;
        }


        private void txt_codigo_producto_TextChanged(object sender, EventArgs e)
        {
            if (txt_codigo_producto.Text.Length == 13)
            {
                if (!validarSiExisteCodigoPerfume(txt_codigo_producto.Text.Trim()))
                {
                    MessageBox.Show("Código inexistente, intente nuevamente.");
                    SetearDatos();

                }
                else
                {
                    txt_datos_producto.Text = perfume.nombre; // Muestra el nombre del perfume si existe
                    txt_tamaño_producto.Text = perfume.presentacion_ml.ToString();
                    //txt_cantidad_actual_producto.Text = perfume.
                }
            }
        }

        private void txt_codigo_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar entrada no válida
            }
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

            if (Validar_Datos_Stock())
            {
                int cantidad = int.Parse(txt_cantidad_producto.Text);
                //Si el stock ya existe, se actualiza la cantidad
                if (StockControlador.getStock(perfume.id, idSucursal) != -1)
                {
                    StockControlador.updateStock(perfume.id, idSucursal, cantidad);

                }
                else
                {
                    StockControlador.insertStock(perfume.id, idSucursal, cantidad);
                }
                MessageBox.Show("Se ha ingresado con éxito.");
                SetearDatos();

            }
        }

        private void Stock_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Verifica que la razón de cierre no sea por un cierre forzado de la aplicación
            if (e.CloseReason == CloseReason.UserClosing)
            {
                FormInicioAdministrador inicioAdministrador = new FormInicioAdministrador();
                inicioAdministrador.Show();
            }
        }
    }
}
