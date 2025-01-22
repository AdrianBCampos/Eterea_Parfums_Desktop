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

namespace Eterea_Parfums_Desktop
{
    public partial class VerDetallePerfume : Form
    {
        //public static txt_porciento_rec fv = new txt_porciento_rec();

        //RECARGOS DE CUOTAS PARA LAS TARJETAS DE CREDITO
        private static string recargoUnPagoTarjeta = "10";
        private static string recargoTresCuotas = "15";
        private static string recargoSeisCuotas = "20";
        private static string recargoNueveCuotas = "28";
        private static string recargoDoceCuotas = "40";

        public VerDetallePerfume(Perfume perfumeSeleccionado)
        {
            InitializeComponent();

            txt_nombre_perfume.Text = perfumeSeleccionado.nombre;
            richTextBox_descripcion.Text = perfumeSeleccionado.descripcion;
            txt_precio_lista.Text = perfumeSeleccionado.precio_en_pesos.ToString();

            combo_medios_pago.Items.Clear();
            combo_medios_pago.Items.Add("Efectivo");
            combo_medios_pago.Items.Add("Visa Débito");
            combo_medios_pago.Items.Add("Visa Crédito");
            combo_medios_pago.Items.Add("Mastercard");
            combo_medios_pago.Items.Add("Amex");
            combo_medios_pago.Items.Add("Mercado Pago");
            combo_medios_pago.SelectedIndex = 0;

            string nombreImagen = perfumeSeleccionado.imagen1.ToString();
            string rutaCompletaImagen = Program.Ruta_Base + nombreImagen + ".jpg";
            img_perfume.Image = Image.FromFile(rutaCompletaImagen);
        }

        public VerDetallePerfume()
        {
        }

        private void combo_medios_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_cuotas.Items.Clear();         
            string formaPago = combo_medios_pago.SelectedItem.ToString();

            if (formaPago == "Efectivo")
            {
                combo_cuotas.Items.Add("1");
            }
            else if (formaPago == "Visa Débito")
            {
                combo_cuotas.Items.Add("1");
            }
            else if (formaPago == "Visa Crédito")
            {
                combo_cuotas.Items.Add("1");
                combo_cuotas.Items.Add("3");
                combo_cuotas.Items.Add("6");
                combo_cuotas.Items.Add("12");
            }
            else if (formaPago == "Mastercard")
            {
                combo_cuotas.Items.Add("1");
                combo_cuotas.Items.Add("3");
                combo_cuotas.Items.Add("6");
                combo_cuotas.Items.Add("9");
                combo_cuotas.Items.Add("12");
            }
            else if (formaPago == "Amex")
            {
                combo_cuotas.Items.Add("1");
                combo_cuotas.Items.Add("6");
                combo_cuotas.Items.Add("12");               
            }
            else if (formaPago == "Mercado Pago")
            {
                combo_cuotas.Items.Add("1");              
            }

            combo_cuotas.SelectedIndex = 0;

            CalcularRecargo(formaPago);
        }

        private void CalcularRecargo(string formaPago)
        {
            int cantidadCuotas = Convert.ToInt32(combo_cuotas.SelectedItem.ToString());

            if (formaPago == "Visa Crédito" || formaPago == "Mastercard" || formaPago == "Amex")
            {
                if (cantidadCuotas == 1)
                {
                    txt_recargo.Text = recargoUnPagoTarjeta;
                }
                else if (cantidadCuotas == 3)
                {
                    txt_recargo.Text = recargoTresCuotas;
                }
                else if (cantidadCuotas == 6)
                {
                    txt_recargo.Text = recargoSeisCuotas;
                }
                else if (cantidadCuotas == 9)
                {
                    txt_recargo.Text = recargoNueveCuotas;
                }
                else if (cantidadCuotas == 12)
                {
                    txt_recargo.Text = recargoDoceCuotas;
                }
            }
            else
            {
                txt_recargo.Text = "0";
            }
        }

        private void combo_cuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string formaPago = combo_medios_pago.SelectedItem.ToString();
            CalcularRecargo(formaPago);
            CalcularTotal(int.Parse(txt_recargo.Text), int.Parse(txt_precio_lista.Text));
        }

        private void CalcularTotal(int recargo, int precio)
        {
            // Calcular el precio final con el recargo
            int precioFinal = precio + recargo * precio / 100;

            // Mostrar el precio final
            txt_precio_final.Text = precioFinal.ToString();

            // Calcular el valor de cada cuota y mostrarlo
            int cantidadCuotas = int.Parse(combo_cuotas.SelectedItem.ToString());
            int valorCuota = precioFinal / cantidadCuotas;

            // Mostrar el valor de cada cuota
            txt_valor_cuota.Text = valorCuota.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_perfumes_simi_Click(object sender, EventArgs e)
        {
            VerPerfumesSimilares verPerfumesSimilares = new VerPerfumesSimilares();
            verPerfumesSimilares.Show();
            this.Close();
        }

        private void btn_ver_promociones_Click(object sender, EventArgs e)
        {
            VerPromociones verPromociones = new VerPromociones();
            verPromociones.Show();
            this.Close();
        }

        
    }
}
