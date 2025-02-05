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
    public partial class Facturacion : Form
    {
        public string NumeroCaja { get; set; }

        public Facturacion()
        {
            InitializeComponent();
            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);

            txt_nombre_empleado.Text = Program.logueado.nombre + " " + Program.logueado.apellido;

            combo_forma_pago.SelectedIndexChanged -= combo_forma_pago_SelectedIndexChanged;

            combo_forma_pago.Items.Clear();
            combo_forma_pago.Items.Add("Efectivo");
            combo_forma_pago.Items.Add("Visa Débito");
            combo_forma_pago.Items.Add("Visa Crédito");
            combo_forma_pago.Items.Add("Mastercard");
            combo_forma_pago.Items.Add("Amex");
            combo_forma_pago.Items.Add("Mercado Pago");
            combo_forma_pago.SelectedIndex = 0;


            combo_descuento.Items.Clear();
            combo_descuento.Items.AddRange(new object[] { 0 ,10, 20, 30 });
            combo_descuento.SelectedIndex = 1;

            combo_cuotas.Items.Clear();
            combo_cuotas.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6 });
            combo_cuotas.SelectedIndex = 0;

            //txt_recargo.Hide();

            txt_total.Text = "0,00";
            txt_subtotal.Text = "0,00";
            txt_monto_recargo.Text = "0,00";
            txt_monto_descuento.Text = "0,00";
            txt_iva.Text = "0,00";

            combo_forma_pago.SelectedIndexChanged += combo_forma_pago_SelectedIndexChanged;
            ActualizarDescuentosYCuotas();

            lbl_dniE.Hide();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            txt_numero_caja.Text = NumeroCaja;
            txt_numero_factura.Text = FacturaControlador.ObtenerProximoIdFactura().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumeroDeCaja numeroDeCaja = new NumeroDeCaja();
            numeroDeCaja.Show();
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
 
            if (string.IsNullOrWhiteSpace(txt_dni.Text))
             {
                 MessageBox.Show("Ingrese un número de DNI antes de buscar un cliente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }
             // Validar la longitud del DNI
             if (txt_dni.Text.Length != 8)
             {
                 MessageBox.Show("El número ingresado debe ser de 8 o 11 dígitos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }
            if (!txt_dni.Text.All(char.IsDigit))
            {
                MessageBox.Show("El DNI solo puede contener números.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            int dni = int.Parse(txt_dni.Text);
            Cliente cliente = ClienteControlador.obtenerPorDni(dni);

            if (cliente != null)
            {
                // Si se encuentra el cliente, llenar los campos en el formulario actual
                txt_nombre_cliente.Text = cliente.nombre + " " + cliente.apellido;
                txt_condicion_iva.Text = cliente.condicion_frente_al_iva;
                
            }
            else
            {
                int dniIngresado = int.Parse(txt_dni.Text);
                // Si no se encuentra el cliente, abrir el formulario para agregar un nuevo cliente
                FormCrearClienteFactura formCrearClienteFactura = new FormCrearClienteFactura(dni);
                formCrearClienteFactura.ShowDialog(); // Cambiado a ShowDialog para esperar que el formulario se cierre

                // Luego de cerrar el formulario de clientes, verifica si se creó un nuevo cliente
                Cliente nuevoCliente = ClienteControlador.obtenerPorDni(int.Parse(txt_dni.Text));
                if (nuevoCliente != null)
                {
                    // Asigna los datos del nuevo cliente al formulario actual
                    txt_nombre_cliente.Text = nuevoCliente.nombre + " " + nuevoCliente.apellido;
                    txt_condicion_iva.Text = nuevoCliente.condicion_frente_al_iva;
                }
            }
        }

        private void btn_consultas_Click(object sender, EventArgs e)
        {
            ConsultasPerfumeEmpleado consultasPerfumeEmpleado = new ConsultasPerfumeEmpleado(this);
            consultasPerfumeEmpleado.Show();
            //this.Hide();
        }

        private void dataGridViewFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                Factura.Rows.RemoveAt(e.RowIndex);
                totalFactura();
                CalcularImporteRecargo(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text));

                desc();
                sumaFinal(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text), float.Parse(txt_monto_descuento.Text));

            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                int cant = int.Parse(Factura.Rows[e.RowIndex].Cells[1].Value.ToString());
                Factura.Rows[e.RowIndex].Cells[1].Value = cant + 1;

                int rowIndex = e.RowIndex;

                int valorMultiplicador = Convert.ToInt32(Factura.Rows[rowIndex].Cells[1].Value);
                double precio = Convert.ToDouble(Factura.Rows[rowIndex].Cells[5].Value);


                Factura.Rows[e.RowIndex].Cells[6].Value = (precio * valorMultiplicador).ToString();

                ActualizarTotales();

                //Meti este codigo dentro del metodo ActualizarTotales para no repetir codigo
                /*totalFactura();
                CalcularImporteRecargo(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text));

                desc();
                sumaFinal(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text), float.Parse(txt_monto_descuento.Text));
                */
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                int cant = int.Parse(Factura.Rows[e.RowIndex].Cells[1].Value.ToString());
                if (int.Parse(Factura.Rows[e.RowIndex].Cells[1].Value.ToString()) > 1)
                {
                    Factura.Rows[e.RowIndex].Cells[1].Value = cant - 1;

                    int rowIndex = e.RowIndex;

                    int valorMultiplicador = Convert.ToInt32(Factura.Rows[rowIndex].Cells[1].Value);
                    double precio = Convert.ToDouble(Factura.Rows[rowIndex].Cells[5].Value);

                    Factura.Rows[e.RowIndex].Cells[6].Value = (precio * valorMultiplicador).ToString();

                    //Meti este codigo dentro del metodo ActualizarTotales para no repetir codigo
                    /*
                    totalFactura();
                    CalcularImporteRecargo(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text));

                    desc();
                    sumaFinal(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text), float.Parse(txt_monto_descuento.Text));
                    */
                }
                else
                {
                    Factura.Rows.RemoveAt(e.RowIndex);
                    totalFactura();
                    CalcularImporteRecargo(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text));

                    desc();
                    sumaFinal(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text), float.Parse(txt_monto_descuento.Text));


                }

            }
        }
        private void totalFactura()
        {
            double sumaPrecios = 0; // Usar decimal para los precios

            // Iterar a través de las filas del DataGridView
            foreach (DataGridViewRow fila in Factura.Rows)
            {
                if (fila.Cells[4].Value != null)
                {
                    double precioFila = 0;
                    // Comprobar si el valor se puede convertir a decimal
                    if (double.TryParse(fila.Cells[6].Value.ToString(), out precioFila))
                    {
                        sumaPrecios += precioFila; // Sumar el valor al total
                    }
                }
            }
            // Mostrar la suma en un TextBox
            txt_subtotal.Text = sumaPrecios.ToString("N2");

        }

        private void CalcularImporteRecargo(float recargo, float subtotal)
        {
            txt_monto_recargo.Text = (subtotal * recargo / 100).ToString("N2");
        }

        private void desc()
        {
            string descuentoStr = combo_descuento.SelectedItem.ToString();

            if (int.TryParse(descuentoStr, out int descuento))
            {
                txt_desc.Text = descuento.ToString(); // Mostrar el descuento en txt_desc

                if (float.TryParse(txt_subtotal.Text, out float subtotal))
                {
                    CalcularDescuento(descuento, subtotal);
                }
                else
                {
                    // Si no se puede convertir a float, simplemente establecer el monto de descuento en cero
                    txt_monto_descuento.Text = "0,00";
                }
            }
            else
            {
                MessageBox.Show("El valor de descuento no es válido.");
                // Puedes manejar este caso de acuerdo a tus necesidades
            }
        }

        private void CalcularDescuento(int desc, float subtotal)
        {
            if (subtotal > 0)
            {
                txt_monto_descuento.Text = (desc * subtotal / 100).ToString("N2");
            }
            else
            {
                txt_monto_descuento.Text = "0,00";
            }
        }

        private void sumaFinal(float subtotal, float recargo, float descuento)
        {
            txt_total.Text = (subtotal + recargo - descuento).ToString("N2");

        }
        public DataGridView GetFacturaDataGrid()
        {
            return Factura;
        }

        public void ActualizarTotales()
        {
            totalFactura();

            float subtotal, recargo, descuento;

            // Verificamos que los valores sean válidos para evitar errores de conversión
            if (!float.TryParse(txt_subtotal.Text, out subtotal)) subtotal = 0;
            if (!float.TryParse(txt_monto_recargo.Text, out recargo)) recargo = 0;
            if (!float.TryParse(txt_monto_descuento.Text, out descuento)) descuento = 0;

            CalcularImporteRecargo(subtotal, recargo);
            desc();
            sumaFinal(subtotal, recargo, descuento);
        }
        private void ActualizarDescuentosYCuotas()
        {
            string formaPago = combo_forma_pago.SelectedItem.ToString();

            if (formaPago == "Efectivo")
            {
                txt_descuento_porcentaje.Text = "10";
                combo_descuento.SelectedIndex = 1; // 10%
                combo_cuotas.Enabled = false;
            }
            else if (formaPago == "Mercado Pago")
            {
                txt_descuento_porcentaje.Text = "0";
                combo_descuento.SelectedIndex = 0; // 0%
                combo_cuotas.Enabled = false;
            }
            else // tarjeta
            {
                
                txt_descuento_porcentaje.Text = "0";
                combo_descuento.SelectedIndex = 0; // 0%
                combo_cuotas.Enabled = true;
            }
        }

        private void combo_forma_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDescuentosYCuotas();
        }
    }
}
