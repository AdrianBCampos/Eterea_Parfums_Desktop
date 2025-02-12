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
    public partial class InformesDeVentas2 : Form
    {
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        public InformesDeVentas2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InformesDeVentas informesDeVentas = new InformesDeVentas();
            informesDeVentas.Show();
            this.Close();
        }

        private void cargarDatos()
        {
            // Validación de las fechas
            if (string.IsNullOrEmpty(fechaInicio.ToString("yyyy-MM-dd")))
            {
                lbl_error_fecha_inicio.Text = "Por favor, ingrese una fecha de inicio.";
                lbl_error_fecha_inicio.Visible = true;
                return;
            }
            if (string.IsNullOrEmpty(fechaFinal.ToString("yyyy-MM-dd")))
            {
                lbl_error_fecha_final.Text = "Por favor, ingrese una fecha de fin.";
                lbl_error_fecha_final.Visible = true;
                return;
            }

            List<Factura> facturas = FacturaControlador.getAllIntervaloFechas(fechaInicio, fechaFinal);

            if (facturas.Count == 0)
            {
                MessageBox.Show("No se encontraron facturas en el rango de fechas especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txt_cantidad_ventas.Text = facturas.Count.ToString();
            txt_monto_total.Text = facturas.Sum(f => f.precio_total).ToString("C2");

            List<DetalleFactura> detalles_Totales = new List<DetalleFactura>();

            foreach (Factura factura in facturas)
            {
                List<DetalleFactura> detalles = DetalleFacturaControlador.getByIdFactura(factura.num_factura);
                foreach (DetalleFactura detalle in detalles)
                {
                    detalles_Totales.Add(detalle);
                }
            }
            txt_mas_vendido.Text = detalles_Totales.GroupBy(d => d.perfume).OrderByDescending(g => g.Count()).First().Key.nombre;
            //txt_mas_vendido.Text = facturas.GroupBy(f => f.num_factura).OrderByDescending(g => g.Count()).First().Key.ToString();
            txt_menos_vendido.Text = detalles_Totales.GroupBy(d => d.perfume).OrderBy(g => g.Count()).First().Key.nombre;


        }

    
        private void txt_fecha_inicial_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {

                if (textBox.Text.Length == 10) // Verificamos si tiene el formato esperado (YYYY-MM-DD)
                {
                    if (DateTime.TryParse(textBox.Text, out fechaInicio))
                    {
                        //fecha_inicio = fechaInicio.ToString("yyyy-MM-dd");
                        lbl_error_fecha_inicio.Visible = false; // Ocultamos el mensaje de error si es válido
                        //Console.WriteLine(fecha_inicio);
                    }
                    else
                    {
                        //fecha_inicio = string.Empty;
                        lbl_error_fecha_inicio.Text = "Formato de fecha inválido. Use YYYY-MM-DD.";
                        lbl_error_fecha_inicio.Visible = true;
                    }
                }else if(textBox.Text.Length > 10)
                {
                    //fecha_inicio = string.Empty;
                    lbl_error_fecha_inicio.Text = "Formato de fecha inválido. Use YYYY-MM-DD.";
                    lbl_error_fecha_inicio.Visible = true;
                }    
            }
        }

        private void txt_fecha_final_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {

                if (textBox.Text.Length == 10) // Verificamos si tiene el formato esperado (YYYY-MM-DD)
                {
                    if (DateTime.TryParse(textBox.Text, out fechaFinal))
                    {
                        //fecha_fin = fechaFinal.ToString("yyyy-MM-dd");
                        lbl_error_fecha_final.Visible = false; // Ocultamos el mensaje de error si es válido
                        //Console.WriteLine(fecha_inicio);
                    }
                    else
                    {
                        //fecha_fin = string.Empty;
                        lbl_error_fecha_final.Text = "Formato de fecha inválido. Use YYYY-MM-DD.";
                        lbl_error_fecha_final.Visible = true;
                    }
                }
                else if (textBox.Text.Length > 10)
                {
                    // fecha_fin = string.Empty;
                    lbl_error_fecha_final.Text = "Formato de fecha inválido. Use YYYY-MM-DD.";
                    lbl_error_fecha_final.Visible = true;
                }
            }
        }

        private void txt_fecha_inicial_KeyDown(object sender, KeyEventArgs e)
        
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    // Validación para la fecha inicial
                    if (string.IsNullOrEmpty(fechaFinal.ToString("yyyy-MM-dd")))
                    {
                        lbl_error_fecha_inicio.Text = "Formato de fecha inválido. Use YYYY-MM-DD.";
                        lbl_error_fecha_inicio.Visible = true;
                        e.SuppressKeyPress = true; // Evita el cambio de foco si la fecha no es válida
                        return;
                    }

                    // Si la fecha es válida, mover el foco a txt_fecha_final
                    txt_fecha_final.Focus();
                }
            }

        private void txt_fecha_final_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                // Validación para la fecha inicial
                if (string.IsNullOrEmpty(fechaFinal.ToString("yyyy-MM-dd")))
                {
                    lbl_error_fecha_final.Text = "Formato de fecha inválido. Use YYYY-MM-DD.";
                    lbl_error_fecha_final.Visible = true;
                    e.SuppressKeyPress = true; // Evita el cambio de foco si la fecha no es válida
                    return;
                }

                // Si la fecha es válida, mover el foco a txt_fecha_final
                txt_fecha_final.Focus();
                cargarDatos();
            }
        }
    }
}
