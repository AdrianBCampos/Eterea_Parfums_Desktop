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
    public partial class Stock : Form
    {
        private Perfume perfume;
        private int idSucursal;
        public Stock()
        {
            InitializeComponent();
        }

        public Stock(int idSucursal)
        {
            InitializeComponent();
            this.idSucursal = idSucursal;
            txt_numero_sucursal.Text = idSucursal.ToString();
            //txt_cantidad_producto.Text = "0";
            txt_codigo_producto.MaxLength = 13;
            txt_codigo_producto.KeyPress += txt_codigo_producto_KeyPress;
            txt_codigo_producto.TextChanged += txt_codigo_producto_TextChanged;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumeroDeSucursal numeroDeSucursal = new NumeroDeSucursal();
            numeroDeSucursal.Show();
            this.Close();
        }

        private bool validarSiExisteCodigoPerfume(string codigo)
        {
            perfume = PerfumeControlador.getByCodigo(codigo);
            // Si el perfume no existe, perfume.nombre es null
            return perfume.nombre != null;
        }


        private void txt_codigo_producto_TextChanged(object sender, EventArgs e)
        {
            if (txt_codigo_producto.Text.Length == 13)
            {
                if (!validarSiExisteCodigoPerfume(txt_codigo_producto.Text.Trim()))
                {
                    MessageBox.Show("Código inexistente, intente nuevamente.");
                    txt_codigo_producto.Clear(); // Borra el texto si el código no existe
                    txt_datos_producto.Text = ""; // Limpia el campo de datos del producto
                    txt_cantidad_producto.Text = "";
                   
                }
                else
                {
                    txt_datos_producto.Text = perfume.nombre; // Muestra el nombre del perfume si existe
                    if (StockControlador.getStock(perfume.id, idSucursal) != -1)
                    {
                        txt_cantidad_producto.Text = StockControlador.getStock(perfume.id, idSucursal).ToString();
                    }
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
            string mensaje = "";
            if (string.IsNullOrEmpty(txt_codigo_producto.Text))
            {
                mensaje += "Por favor, ingrese un código de producto.";
            } else if (txt_codigo_producto.Text.Length != 13)
            {
                mensaje += "\nCódigo inexistente.";
            }
            if (string.IsNullOrEmpty(txt_cantidad_producto.Text))
            {
                mensaje += "\nPor favor, ingrese cantidad de producto.";
            }else if (int.Parse(txt_cantidad_producto.Text) < 0)
            {
                mensaje += "\nPor favor, ingrese una cantidad valida.";
            }

            if (string.IsNullOrEmpty(mensaje))
            {
                int cantidad = int.Parse(txt_cantidad_producto.Text);
                if (StockControlador.getStock(perfume.id, idSucursal) != -1)
                {
                    StockControlador.updateStock(perfume.id, idSucursal, cantidad);

                }
                else
                {
                    StockControlador.insertStock(perfume.id, idSucursal, cantidad);
                }
                MessageBox.Show("Se ha ingresado con éxito.");
            }
            else
            {
                MessageBox.Show(mensaje);
                txt_codigo_producto.Clear(); // Borra el texto si el código no existe
                txt_datos_producto.Text = ""; // Limpia el campo de datos del producto
                txt_cantidad_producto.Text = "";
            }
        }
    }
}
