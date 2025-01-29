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
            
            lbl_dniE.Hide();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            txt_numero_caja.Text = NumeroCaja;
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
                 MessageBox.Show("El número ingresado debe ser de 8 dígitos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            ConsultasPerfumeEmpleado consultasPerfumeEmpleado = new ConsultasPerfumeEmpleado();
            consultasPerfumeEmpleado.Show();
            this.Hide();
        }

    }
}
