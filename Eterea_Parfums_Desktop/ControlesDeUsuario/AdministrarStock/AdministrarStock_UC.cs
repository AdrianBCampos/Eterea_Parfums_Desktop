using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            
            Sucursal sucursal = SucursalControlador.getById(idSucursal);

            if (sucursal != null)
            {
                txt_numero_sucursal.Text = sucursal.nombre;
            }
            else
            {
                txt_numero_sucursal.Text = "Sucursal no encontrada";
            }


            //txt_cantidad_producto.Text = "0";
            txt_codigo_producto.MaxLength = 13;
            txt_codigo_producto.KeyPress += txt_codigo_producto_KeyPress;
            txt_codigo_producto.TextChanged += txt_codigo_producto_TextChanged;

            // Imagen inicial por defecto
            CargarImagenPorDefecto();

            lbl_error_codigo.Visible = false;
            lbl_error_stock.Visible = false;

            this.Cursor = Cursors.Default;
            this.UseWaitCursor = false;

        }

        private void CargarImagenPorDefecto()
        {
            img_perfume.Image = Properties.Resources.sinImagen;

        }

        private bool validarSiExisteCodigoPerfume(string codigo)
        {
            perfume = PerfumeControlador.getByCodigo(codigo);
            // Si el perfume no existe, perfume.nombre es null
            return perfume != null;
        }


        // Validar datos de entrada del código de perfume
        private bool Validar_Datos_Codigo()
        {
            string mensaje = "";
            if (string.IsNullOrEmpty(txt_codigo_producto.Text))
            {
                mensaje = "Por favor, ingrese un código de producto.";
            }
            else if (txt_codigo_producto.Text.Length != 13)
            {
                mensaje = "Código ingresado es inexistente.";
            }
            else if (!validarSiExisteCodigoPerfume(txt_codigo_producto.Text.Trim()))
            {
                mensaje = "Código ingresado es inexistente.";
            }

            if (!string.IsNullOrEmpty(mensaje))
            {
                lbl_error_codigo.Text = mensaje;
                lbl_error_codigo.Visible = true;
            }

            return string.IsNullOrEmpty(mensaje);
        }

        // Validar datos de entrada del stock de perfume
        private bool Validar_Datos_Stock()
        {
            string mensaje = "";
            if (string.IsNullOrEmpty(txt_cantidad_producto.Text))
            {
                mensaje = "Por favor, ingrese cantidad de producto.";
            }
            else if (int.Parse(txt_cantidad_producto.Text) < 0)
            {
                mensaje = "Por favor, ingrese una cantidad valida.";
            }

            if (!string.IsNullOrEmpty(mensaje))
            {
                lbl_error_stock.Text = mensaje;
                lbl_error_stock.Visible = true;
            }

            return string.IsNullOrEmpty(mensaje);
        }
        /*private void SetearDatos()
        {
            txt_codigo_producto.Clear(); // Borra el texto si el código no existe
            txt_datos_producto.Text = ""; // Limpia el campo de datos del producto
            txt_cantidad_producto.Text = "";
            txt_tamaño_producto.Text = "";
            txt_cantidad_actual_producto.Text = "";

            img_perfume.Image = Properties.Resources.sinImagen;
            
            perfume = null;
                        
        }*/


        private void txt_codigo_producto_TextChanged(object sender, EventArgs e)
        {
            List<Stock> stocks = StockControlador.getAll();

            if (txt_codigo_producto.Text.Length == 13)
            {
                if (!validarSiExisteCodigoPerfume(txt_codigo_producto.Text.Trim()))
                {
                    lbl_error_codigo.Text = "Código ingresado es inexistente.";
                    lbl_error_codigo.Visible = true;

                    // Limpiar campos de datos si el código no existe
                    LimpiarCampos();
                }
                else
                {
                    lbl_error_codigo.Visible = false;

                    // Buscar el perfume correspondiente (aquí deberías obtenerlo con tu lógica)
                    var perfume = PerfumeControlador.getByCodigo(txt_codigo_producto.Text.Trim());  // Asumiendo que tienes este método

                    if (perfume != null)
                    {
                        txt_datos_producto.Text = perfume.nombre;
                        txt_tamaño_producto.Text = perfume.presentacion_ml.ToString() + " ML";

                        var stockTotal = stocks
                            .Where(s => s.perfume.id == perfume.id)
                            .Sum(p => p.cantidad);

                        txt_cantidad_actual_producto.Text = stockTotal.ToString();

                        string nombreImagen = perfume.imagen1.ToString();
                        string rutaCompletaImagen = Program.Ruta_Base + nombreImagen + ".jpg";

                        if (File.Exists(rutaCompletaImagen))
                        {
                            img_perfume.Image = Image.FromFile(rutaCompletaImagen);
                        }
                        else
                        {
                            img_perfume.Image = null;  // O imagen por defecto
                        }
                    }
                }
            }
            else
            {
                // Si el código no tiene 13 dígitos, limpia los campos
                LimpiarCampos();
            }
        }


        // Método auxiliar para limpiar los campos
        private void LimpiarCampos()
        {
            txt_datos_producto.Text = string.Empty;
            txt_tamaño_producto.Text = string.Empty;
            txt_cantidad_actual_producto.Text = string.Empty;

            // Cargar imagen por defecto en el PictureBox
            string rutaImagenPorDefecto = Program.Ruta_Base + "sinImagen.jpg";  // Cambia por tu ruta real
            if (File.Exists(rutaImagenPorDefecto))
            {
                img_perfume.Image = Image.FromFile(rutaImagenPorDefecto);
            }
            else
            {
                img_perfume.Image = null;  // O puedes mostrar un color sólido o ícono
            }

            lbl_error_codigo.Visible = false;
        }

        private void txt_cantidad_producto_TextChanged(object sender, EventArgs e)
        {
            if (perfume != null && int.TryParse(txt_cantidad_producto.Text, out int cantidadNueva))
            {
                int stockActual = StockControlador.getStock(perfume.id, idSucursal);
                int total = (stockActual != -1 ? stockActual : 0) + cantidadNueva;
                txt_total_stock.Text = total.ToString();
            }
            else
            {
                txt_total_stock.Text = ""; // Limpiar si no hay datos válidos
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
            // Limpiar mensajes anteriores
            lbl_error_codigo.Text = "";
            lbl_error_codigo.Visible = false;
            lbl_error_stock.Text = "";
            lbl_error_stock.Visible = false;
            bool stockValido = Validar_Datos_Stock();
            bool codigoValido = Validar_Datos_Codigo();

            // Si alguna validación falla, no continuar
            if (!stockValido || !codigoValido)
            {
                return;
            }

            int cantidad = int.Parse(txt_cantidad_producto.Text);

            // Si el stock ya existe, se actualiza la cantidad
            if (StockControlador.getStock(perfume.id, idSucursal) != -1)
            {
                StockControlador.updateStock(perfume.id, idSucursal, cantidad);
            }
            else
            {
                StockControlador.insertStock(perfume.id, idSucursal, cantidad);
            }

            MessageBox.Show("Se ha ingresado con éxito.");
            LimpiarCampos();


    }

        
    }
}
