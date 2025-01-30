using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Drawing;
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

            txt_marca.Text = MarcaControlador.getById(perfumeSeleccionado.marca.id).nombre;
            txt_genero.Text = GeneroControlador.getById(perfumeSeleccionado.genero.id).genero;
            txt_pais.Text = PaisControlador.getById(perfumeSeleccionado.pais.id).nombre;
            txt_fecha.Text = perfumeSeleccionado.anio_de_lanzamiento.ToString();
            txt_ml.Text = perfumeSeleccionado.presentacion_ml.ToString() + " ml";
            txt_tipo.Text = TipoDePerfumeControlador.getById(perfumeSeleccionado.tipo_de_perfume.id).tipo_de_perfume;
            txt_codigo.Text = perfumeSeleccionado.codigo.ToString();
            txt_spray.Text = (perfumeSeleccionado.spray == 1) ? "Sí" : "No";
            txt_recargable.Text = (perfumeSeleccionado.recargable == 1) ? "Sí" : "No";

            combo_medios_pago.Items.Clear();
            combo_medios_pago.Items.Add("Efectivo");
            combo_medios_pago.Items.Add("Visa Débito");
            combo_medios_pago.Items.Add("Visa Crédito");
            combo_medios_pago.Items.Add("Mastercard");
            combo_medios_pago.Items.Add("Amex");
            combo_medios_pago.Items.Add("Mercado Pago");
            combo_medios_pago.SelectedIndex = 0;

            combo_descuento.Items.Clear();
            combo_descuento.Items.Add("0");
            combo_descuento.Items.Add("5");
            combo_descuento.Items.Add("10");
            combo_descuento.Items.Add("15");
            combo_descuento.Items.Add("20");
            combo_descuento.SelectedIndex = 0;

            string nombreImagen = perfumeSeleccionado.imagen1.ToString();
            string rutaCompletaImagen = Program.Ruta_Base + nombreImagen + ".jpg";
            img_perfume.Image = Image.FromFile(rutaCompletaImagen);

            //ConfigurarDescuentos();
        }

        public VerDetallePerfume()
        {
        }

        private void ConfigurarDescuentos()
        {
            if (Program.logueado != null)  // Verificamos si hay un usuario logueado
            {
                combo_descuento.Visible = true;
                txt_valor_descuento.Visible = true;
                lbl_descuento.Visible = true;
                lbl_valor_descuento.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
            else
            {
                combo_descuento.Visible = false;
                txt_valor_descuento.Visible = false;
                lbl_descuento.Visible = false;
                lbl_valor_descuento.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
        }

        private void combo_medios_pago_SelectedIndexChanged(object sender, EventArgs e)
        {               
            combo_cuotas.Items.Clear();
            combo_descuento.Items.Clear();
            
            string formaPago = combo_medios_pago.SelectedItem.ToString();

            if (formaPago == "Efectivo")
            {
                combo_cuotas.Items.Add("1");

                combo_descuento.Items.Add("0");
                combo_descuento.Items.Add("5");
                combo_descuento.Items.Add("10");
                combo_descuento.Items.Add("15");
                combo_descuento.Items.Add("20");
            }
            else if (formaPago == "Visa Débito")
            {
                combo_cuotas.Items.Add("1");

                combo_descuento.Items.Add("0");
                combo_descuento.Items.Add("5");
                combo_descuento.Items.Add("10");
                combo_descuento.Items.Add("15");
                combo_descuento.Items.Add("20");
            }
            else if (formaPago == "Visa Crédito")
            {
                combo_cuotas.Items.Add("1");
                combo_cuotas.Items.Add("3");
                combo_cuotas.Items.Add("6");
                combo_cuotas.Items.Add("12");

                combo_descuento.Items.Add("0");
                txt_valor_descuento.Text = ("0");                
            }
            else if (formaPago == "Mastercard")
            {
                combo_cuotas.Items.Add("1");
                combo_cuotas.Items.Add("3");
                combo_cuotas.Items.Add("6");
                combo_cuotas.Items.Add("9");
                combo_cuotas.Items.Add("12");

                combo_descuento.Items.Add("0");
                txt_valor_descuento.Text = ("10");
            }
            else if (formaPago == "Amex")
            {
                combo_cuotas.Items.Add("1");
                combo_cuotas.Items.Add("6");
                combo_cuotas.Items.Add("12");

                combo_descuento.Items.Add("0");
                txt_valor_descuento.Text = ("10");
            }
            else if (formaPago == "Mercado Pago")
            {
                combo_cuotas.Items.Add("1");

                combo_descuento.Items.Add("0");
                combo_descuento.Items.Add("5");
                combo_descuento.Items.Add("10");
                combo_descuento.Items.Add("15");
                combo_descuento.Items.Add("20");
            }
           
            combo_cuotas.SelectedIndex = 0;
            combo_descuento.SelectedIndex = 0;

            CalcularRecargo(formaPago);
            CalcularDescuento();
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

        private void CalcularDescuento()
        {
            combo_descuento.SelectedIndex = 0;

            // Convertir el porcentaje de descuento seleccionado
            int porcentajeDescuento = Convert.ToInt32(combo_descuento.SelectedItem.ToString());

            int precio = int.Parse(txt_precio_lista.Text);
            
            // Variable para almacenar el valor del descuento
            int valorDescuento = 0;
          
            // Calcular el descuento según el porcentaje seleccionado
            valorDescuento = precio * porcentajeDescuento / 100;
           
            // Mostrar el valor del descuento en el TextBox
            txt_valor_descuento.Text = valorDescuento.ToString();
        }

        private void combo_cuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string formaPago = combo_medios_pago.SelectedItem.ToString();
            CalcularRecargo(formaPago);
            CalcularTotal(int.Parse(txt_recargo.Text), int.Parse(txt_precio_lista.Text));
            CalcularDescuento();
        }

        private void CalcularTotal(int recargo, int precio)
        {
            // Calcular el precio final con el recargo
            int precioFinal = precio + (precio * recargo / 100);

            // Mostrar el precio final
            txt_precio_final.Text = precioFinal.ToString();

            int valorRecargo = precio * recargo / 100;
            txt_valor_recargo.Text = valorRecargo.ToString();

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
