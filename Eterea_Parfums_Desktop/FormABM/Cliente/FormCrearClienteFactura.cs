using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.ControlesDeUsuario;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormCrearClienteFactura : Form
    {
        public List<Pais> paises;
        public List<Provincia> provincias;
        public List<Localidad> localidades;
        public List<Calle> calles;

        public FormCrearClienteFactura()
        {
            InitializeComponent();

  

            lbl_nombreE.Hide();
            lbl_apellidoE.Hide();
            lbl_dniE.Hide();
            lbl_cond_ivaE.Hide();
            lbl_emailE.Hide();

            combo_con_iva.Items.Clear();
            combo_con_iva.Items.Add("Consumidor Final");
            combo_con_iva.Items.Add("Responsable Inscripto");
            combo_con_iva.Items.Add("Responsable no Inscripto");
            combo_con_iva.Items.Add("Responsable Monotributo");
        }

        public FormCrearClienteFactura(long dni)
        {
            InitializeComponent();

            lbl_nombreE.Hide();
            lbl_apellidoE.Hide();
            lbl_dniE.Hide();
            lbl_cond_ivaE.Hide();
            lbl_emailE.Hide();

            // Establece el valor del DNI en el TextBox txt_dni
            txt_dni.Text = dni.ToString();

            combo_con_iva.Items.Clear();
            combo_con_iva.Items.Add("Consumidor Final");
            combo_con_iva.Items.Add("Responsable Inscripto");
            combo_con_iva.Items.Add("Responsable no Inscripto");
            combo_con_iva.Items.Add("Responsable Monotributo");
        }

        private void Txt_dni_TextChanged(object sender, EventArgs e)
        {
            string texto = txt_dni.Text.Trim();

            if (texto.Length == 8)
            {
                lbl_dni.Text = "DNI";
            }
            else if (texto.Length == 11)
            {
                lbl_dni.Text = "CUIT";
            }
            else
            {
                lbl_dni.Text = "Documento";
            }
        }


        private void btn_crear_cliente_Click(object sender, EventArgs e)
        {
            bool clienteValidado = validarCliente(out string errorMsg);
            if (clienteValidado)
            {

                string rol = "cliente";
                Pais pais = PaisControlador.getByName("Argentina");
                Provincia provincia = ProvinciaControlador.getByName("Buenos Aires");
                Localidad localidad = LocalidadControlador.getByName("CABA");
                Calle calle = CalleControlador.getByName("Av. Cabildo");
                DateTime fecha = new DateTime(1900, 1, 1);


                Cliente cliente = new Cliente(0, txt_nombre.Text, txt_dni.Text, txt_nombre.Text, txt_apellido.Text,
                    long.Parse(txt_dni.Text), combo_con_iva.Text, fecha, "0", txt_email.Text,
                    pais, provincia, localidad, 0, calle, 0,
                    "0", "0", " ",
                     true, rol);

                if (ClienteControlador.crearCliente(cliente))
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
        }
        private bool validarCliente(out string errorMsg)
        {
            errorMsg = "";
            limpiarMensajesError();

            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                errorMsg += "Debes ingresar el nombre" + Environment.NewLine;
                lbl_nombreE.Text = "Debes ingresar tu nombre de pila";
                lbl_nombreE.Show();
            }
            else if (!Regex.IsMatch(txt_nombre.Text, @"^[a-zA-Z]+$"))
            {
                errorMsg += "El nombre solo puede contener letras" + Environment.NewLine;
                lbl_nombreE.Text = "El nombre solo puede contener letras";
                lbl_nombreE.Show();
            }
            else
            {

                lbl_nombreE.Visible = false;

            }


            if (string.IsNullOrEmpty(txt_apellido.Text))
            {
                errorMsg += "Debes ingresar el apellido" + Environment.NewLine;
                lbl_apellidoE.Text = "Debes ingresar tu apellido";
                lbl_apellidoE.Show();

            }
            // Verifica si el campo txt_apellido contiene solo letras y tiene como máximo 45 caracteres
            else if (!Regex.IsMatch(txt_apellido.Text, @"^[a-zA-Z]+$") || txt_apellido.Text.Length > 45)
            {
                if (!Regex.IsMatch(txt_apellido.Text, @"^[a-zA-Z]+$"))
                {
                    errorMsg += "El apellido solo puede contener letras" + Environment.NewLine;
                    lbl_apellidoE.Text = "El apellido solo puede contener letras";
                }
                if (txt_apellido.Text.Length > 45)
                {
                    errorMsg += "El apellido no puede tener más de 45 caracteres" + Environment.NewLine;
                    lbl_apellidoE.Text = "El apellido no puede tener más de 45 caracteres";
                }
                lbl_apellidoE.Show();
            }

            else
            {

                lbl_apellidoE.Visible = false;

            }




            if (string.IsNullOrEmpty(txt_email.Text))
            {
                errorMsg += "Debes ingresar una dirección de correo electrónico" + Environment.NewLine;
                lbl_emailE.Text = "Debes ingresar una dirección de correo electrónico";
                lbl_emailE.Show();

            }
            // Verifica si el campo txt_mail tiene un formato de correo electrónico válido y tiene como máximo 80 caracteres
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") || txt_email.Text.Length > 80)
            {
                if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    errorMsg += "Debes ingresar una dirección de correo electrónico válida" + Environment.NewLine;
                    lbl_emailE.Text = "Debes ingresar una dirección de correo electrónico válida";
                }
                if (txt_email.Text.Length > 80)
                {
                    errorMsg += "La dirección de correo electrónico no puede tener más de 80 caracteres" + Environment.NewLine;
                    lbl_emailE.Text = "La dirección de correo electrónico no puede tener más de 80 caracteres";
                }
                lbl_emailE.Show();
            }
            else
            {

                lbl_emailE.Visible = false;

            }



            if (combo_con_iva.SelectedItem == null)
            {
                errorMsg += "Debe seleccionar una condición frente al IVA" + Environment.NewLine;
                lbl_cond_ivaE.Text = "Debe seleccionar una condición frente al IVA";
                lbl_cond_ivaE.Show();

            }
            else
            {
                lbl_cond_ivaE.Visible = false;
            }


            if (string.IsNullOrEmpty(errorMsg))
            {
                lbl_nombreE.Visible = false;
                lbl_apellidoE.Visible = false;
                lbl_emailE.Visible = false;
                lbl_cond_ivaE.Visible = false;


            }

            return string.IsNullOrEmpty(errorMsg);
        }

        private void limpiarMensajesError()
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facturar_UC facturacion = new Facturar_UC();
            facturacion.Show();
            this.Close();
        }
    }
}
