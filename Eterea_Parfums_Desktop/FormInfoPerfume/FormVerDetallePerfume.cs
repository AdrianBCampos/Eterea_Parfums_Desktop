using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Eterea_Parfums_Desktop
{
    public partial class FormVerDetallePerfume : Form
    {
        //public static txt_porciento_rec fv = new txt_porciento_rec();

        //RECARGOS DE CUOTAS PARA LAS TARJETAS DE CREDITO
        private static string recargoUnPagoTarjeta = "10";
        private static string recargoTresCuotas = "15";
        private static string recargoSeisCuotas = "20";
        private static string recargoNueveCuotas = "28";
        private static string recargoDoceCuotas = "40";


        private Perfume perfume;

        public FormVerDetallePerfume(Perfume perfumeSeleccionado)
        {
            InitializeComponent();

            txt_nombre_perfume.Text = perfumeSeleccionado.nombre;
            richTextBox_descripcion.Text = perfumeSeleccionado.descripcion;
            txt_precio_lista.Text = perfumeSeleccionado.precio_en_pesos.ToString("N2");

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

            this.perfume = perfumeSeleccionado;

            //Diseño del combo box
            combo_medios_pago.DrawMode = DrawMode.OwnerDrawFixed;
            combo_medios_pago.DrawItem += comboBoxdiseño_DrawItem;
            combo_medios_pago.DropDownStyle = ComboBoxStyle.DropDownList;

            combo_cuotas.DrawMode = DrawMode.OwnerDrawFixed;
            combo_cuotas.DrawItem += comboBoxdiseño_DrawItem;
            combo_cuotas.DropDownStyle = ComboBoxStyle.DropDownList;

            combo_descuento.DrawMode = DrawMode.OwnerDrawFixed;
            combo_descuento.DrawItem += comboBoxdiseño_DrawItem;
            combo_descuento.DropDownStyle = ComboBoxStyle.DropDownList;

            ConfigurarDescuentos();
            cargarDataGridViewNotasDePerfume();
            CargarDataGridViewAromas();
        }

        public FormVerDetallePerfume()
        {
        }

        private void cargarDataGridViewNotasDePerfume()
        {
            //Ocultas la primera columna de la tabla (es una columna de seleccion de fila)
            dataGridViewTipoNota.RowHeadersVisible = false;

            //CARGAR DATAGRIDVIEW DE NOTAS DE PERFUME
            List<NotasDelPerfume> notas_del_perfume = NotasDelPerfumeControlador.getByIDPerfume(perfume.id);
            List<NotaConTipoDeNota> notas_con_tipo_de_nota = new List<NotaConTipoDeNota>();

            Nota nota = null;
            TipoDeNota tipo_de_nota = null;

            if (notas_del_perfume != null)
            {
                //dataGridViewNotasDelPerfume.DataSource = notas;
                foreach (NotasDelPerfume nota_del_perfume in notas_del_perfume)
                {
                    notas_con_tipo_de_nota.Add(NotaConTipoDeNotaControlador.getByID(nota_del_perfume.notaConTipoDeNota.id));
                }
            }

            if (notas_con_tipo_de_nota != null)
            {
                dataGridViewTipoNota.Rows.Clear();
                foreach (NotaConTipoDeNota nota_con_tipo_de_nota_ in notas_con_tipo_de_nota)
                {
                    nota = NotaControlador.getById(nota_con_tipo_de_nota_.nota.id);
                    tipo_de_nota = TipoDeNotaControlador.getById(nota_con_tipo_de_nota_.tipoDeNota.id);

                    int rowIndex = dataGridViewTipoNota.Rows.Add();
                    dataGridViewTipoNota.Rows[rowIndex].Cells[0].Value = nota_con_tipo_de_nota_.id;
                    dataGridViewTipoNota.Rows[rowIndex].Cells[1].Value = tipo_de_nota.nombre_tipo_de_nota;
                    dataGridViewTipoNota.Rows[rowIndex].Cells[2].Value = nota.nombre;
                }
            }
        }

        private void CargarDataGridViewAromas()
        {
            //Ocultas la primera columna de la tabla (es una columna de seleccion de fila)
            dataGridViewAromas.RowHeadersVisible = false;

            // Limpiar filas anteriores del DataGridView
            dataGridViewAromas.Rows.Clear();

            // Obtener la lista de aromas asociados al perfume
            List<AromaDelPerfume> aromasDelPerfume = AromaDelPerfumeControlador.getAllByIDPerfume(perfume.id);

            if (aromasDelPerfume != null)
            {
                foreach (AromaDelPerfume aromaDelPerfume in aromasDelPerfume)
                {
                    // Obtener el tipo de aroma
                    TipoDeAroma tipoDeAroma = TipoDeAromaControlador.getById(aromaDelPerfume.tipoDeAroma.id);

                    // Agregar una fila al DataGridView con la información del aroma
                    int rowIndex = dataGridViewAromas.Rows.Add();
                    dataGridViewAromas.Rows[rowIndex].Cells[0].Value = aromaDelPerfume.tipoDeAroma.id; // ID del aroma
                    dataGridViewAromas.Rows[rowIndex].Cells[1].Value = tipoDeAroma.nombre; // Nombre del tipo de aroma
                }
            }
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
                lbl_detalles_descuento.Visible = true;
            }
            else
            {
                combo_descuento.Visible = false;
                txt_valor_descuento.Visible = false;
                lbl_descuento.Visible = false;
                lbl_valor_descuento.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                lbl_detalles_descuento.Visible = false;
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
                combo_descuento.Items.Add("10");
                combo_descuento.Items.Add("15");

            }
            else if (formaPago == "Visa Débito")
            {
                combo_cuotas.Items.Add("1");

                combo_descuento.Items.Add("0");
                combo_descuento.Items.Add("10");
            }
            else if (formaPago == "Visa Crédito")
            {
                combo_cuotas.Items.Add("1");
                combo_cuotas.Items.Add("3");
                combo_cuotas.Items.Add("6");
                combo_cuotas.Items.Add("12");

                combo_descuento.Items.Add("0");

            }
            else if (formaPago == "Mastercard")
            {
                combo_cuotas.Items.Add("1");
                combo_cuotas.Items.Add("3");
                combo_cuotas.Items.Add("6");
                combo_cuotas.Items.Add("9");
                combo_cuotas.Items.Add("12");

                combo_descuento.Items.Add("0");

            }
            else if (formaPago == "Amex")
            {
                combo_cuotas.Items.Add("1");
                combo_cuotas.Items.Add("6");
                combo_cuotas.Items.Add("12");

                combo_descuento.Items.Add("0");

            }
            else if (formaPago == "Mercado Pago")
            {
                combo_cuotas.Items.Add("1");

                combo_descuento.Items.Add("0");
                combo_descuento.Items.Add("10");
            }

            combo_cuotas.SelectedIndex = 0;
            combo_descuento.SelectedIndex = 0;

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

                CalcularImporteRecargo(float.Parse(txt_precio_lista.Text), float.Parse(txt_recargo.Text));
                precioFinal(float.Parse(txt_precio_lista.Text), float.Parse(txt_valor_recargo.Text), float.Parse(txt_valor_descuento.Text));
                CalcularValorCuota(float.Parse(txt_recargo.Text), float.Parse(txt_precio_lista.Text));
            }
            else
            {
                txt_recargo.Text = "0,00";
            }
        }

        private void CalcularDescuento(int descuento, float preciolista)
        {
            if (preciolista > 0)
            {
                txt_valor_descuento.Text = (descuento * preciolista / 100).ToString("N2");
            }
            else
            {
                txt_valor_descuento.Text = "0,00";
            }
        }

        private void combo_descuento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (combo_descuento.SelectedItem != null)
            {
                desc();
                float preciolista, recargo, descuento;

                // Verificar que los valores sean válidos antes de llamar a sumaFinal
                if (float.TryParse(txt_precio_lista.Text, out preciolista) &&
                    float.TryParse(txt_valor_recargo.Text, out recargo) &&
                    float.TryParse(txt_valor_descuento.Text, out descuento))
                {
                    precioFinal(preciolista, recargo, descuento);
                }
                else
                {

                    // Se pueden agregar opciones
                }
            }
        }

        private void desc()
        {
            string descuentoStr = combo_descuento.SelectedItem.ToString();

            if (int.TryParse(descuentoStr, out int descuento))
            {
                if (float.TryParse(txt_precio_lista.Text, out float preciolista))
                {
                    CalcularDescuento(descuento, preciolista);
                }
                else
                {
                    // Si no se puede convertir a float, simplemente establecer el monto de descuento en cero
                    txt_valor_descuento.Text = "0,00";
                }
            }
            else
            {
                MessageBox.Show("El valor de descuento no es válido.");
            }
        }

        private void precioFinal(float preciolista, float recargo, float descuento)
        {
            txt_precio_final.Text = (preciolista + recargo - descuento).ToString("N2");
        }

        private void CalcularImporteRecargo(float recargo, float preciolist)
        {
            txt_valor_recargo.Text = (preciolist * recargo / 100).ToString("N2");
        }

        private void combo_cuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string formaPago = combo_medios_pago.SelectedItem.ToString();
            CalcularRecargo(formaPago);
            CalcularValorCuota(float.Parse(txt_recargo.Text), float.Parse(txt_precio_lista.Text));
            CalcularImporteRecargo(float.Parse(txt_precio_lista.Text), float.Parse(txt_recargo.Text));

        }

        private void CalcularValorCuota(float recargo, float precio)
        {
            // Calcular el precio final con el recargo
            float precioFinal = precio + (precio * recargo / 100);

            // Calcular el valor de cada cuota y mostrarlo
            int cantidadCuotas = int.Parse(combo_cuotas.SelectedItem.ToString());
            float valorCuota = precioFinal / cantidadCuotas;

            // Mostrar el valor de cada cuota
            txt_valor_cuota.Text = valorCuota.ToString("N2");
        }


        //Diseño del combo box
        private void comboBoxdiseño_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            // Obtener el ComboBox y el texto del ítem actual
            ComboBox combo = sender as ComboBox;
            combo.DropDownWidth = combo.Width + 5; // Ajustar tamaño para evitar borde azul
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


        private void btn_buscar_perfumes_simi_Click(object sender, EventArgs e)
        {
            // Intentar abrir el formulario de perfumes similares
            FormVerPerfumesSimilares verPerfumesSimilares = new FormVerPerfumesSimilares(perfume);

            // Si el formulario no se cerró por falta de datos, mostrarlo
            if (!verPerfumesSimilares.IsDisposed)
            {
                verPerfumesSimilares.ShowDialog();
                this.Close(); // Cerrar el formulario actual solo si el otro se abrió con éxito
            }
        }


        private void btn_ver_promociones_Click(object sender, EventArgs e)
        {
            FormVerPromociones verPromociones = new FormVerPromociones(perfume);
            verPromociones.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            // Si FormInicioAutoconsulta está abierto, deshabilita el escaneo
            FormInicioAutoconsulta formInicio = Application.OpenForms.OfType<FormInicioAutoconsulta>().FirstOrDefault();
            if (formInicio != null)
            {
                formInicio.ResetAutoConsulta(); // Deshabilita txt_scan
            }
        }
    }
}
