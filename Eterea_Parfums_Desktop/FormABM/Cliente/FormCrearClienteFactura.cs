﻿using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.ControlesDeUsuario;
using Eterea_Parfums_Desktop.Modelos;
using PdfSharp.Quality;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
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

        private long _dni;


        public FormCrearClienteFactura(long dni)
        {
            InitializeComponent();

            _dni = dni;
            this.Load += FormCrearClienteFactura_Load; // ✅ SUSCRIPCIÓN AL EVENTO

            

            
        }
        private void FormCrearClienteFactura_Load(object sender, EventArgs e)
        {
            lbl_nombreE.Hide();
            lbl_apellidoE.Hide();
            lbl_dniE.Hide();
            lbl_cond_ivaE.Hide();
            lbl_emailE.Hide();

            if (_dni.ToString().Length == 11)
            {
                lbl_dni.Text = "CUIT";
                lbl_nombre.Text = "Empresa";
                lbl_apellido.Text = "Tipo";

                lbl_nombreE.Text = "Debe ingresar la razón social.";
                lbl_apellidoE.Text = "Debe ingresar el tipo de sociedad.";
            }
            else if (_dni.ToString().Length == 8)
            {
                lbl_dni.Text = "DNI";
                lbl_nombre.Text = "Nombre";
                lbl_apellido.Text = "Apellido";


                lbl_nombreE.Text = "Debe ingresar un nombre.";
                lbl_apellidoE.Text = "Debe ingresar un apellido.";
            }
           

            txt_dni.Text = _dni.ToString(); // ✅ Esta es la línea correcta
            txt_dni.ReadOnly = true;

            combo_con_iva.Items.Clear();
            combo_con_iva.Items.Add("Consumidor Final");
            combo_con_iva.Items.Add("Responsable Inscripto");
            combo_con_iva.Items.Add("Exento");
            combo_con_iva.Items.Add("Monotributista");

            combo_con_iva.DrawMode = DrawMode.OwnerDrawFixed;
            combo_con_iva.DrawItem += comboBoxdiseño_DrawItem;
            combo_con_iva.DropDownStyle = ComboBoxStyle.DropDownList;

            
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
                string usuario = txt_dni.Text; // ✅ usar DNI o CUIT como usuario
                string clavePorDefecto = txt_dni.Text;

                // ✅ Hashear la clave
                string claveHasheada = PasswordHelper.CrearHash(clavePorDefecto);

                string rol = "cliente";
                Pais pais = PaisControlador.getByName("Argentina");
                Provincia provincia = ProvinciaControlador.getByName("Buenos Aires");
                Localidad localidad = LocalidadControlador.getByName("CABA");
                Calle calle = CalleControlador.getById(1);
                DateTime fecha = new DateTime(1900, 1, 1);


                Cliente cliente = new Cliente(0, usuario, claveHasheada, txt_nombre.Text, txt_apellido.Text,
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
              
                lbl_apellidoE.Show();

            }
            // Verifica si el campo txt_apellido contiene solo letras y tiene como máximo 45 caracteres
            else if (!Regex.IsMatch(txt_apellido.Text, @"^[a-zA-Z]+$") || txt_apellido.Text.Length > 45)
            {
                if (!Regex.IsMatch(txt_apellido.Text, @"^[a-zA-Z]+$"))
                {
                    errorMsg += "Solo puede contener letras" + Environment.NewLine;
                    lbl_apellidoE.Text = "Solo puede contener letras";
                }
                if (txt_apellido.Text.Length > 45)
                {
                    errorMsg += "No puede tener más de 45 caracteres" + Environment.NewLine;
                    lbl_apellidoE.Text = "No puede tener más de 45 caracteres";
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

        private void button2_Click(object sender, EventArgs e)
        {          
            this.Close();
        }

        //Diseño del combo box
        private void comboBoxdiseño_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            // Obtener el ComboBox y el texto del ítem actual
            ComboBox combo = sender as ComboBox;
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
    }
}
