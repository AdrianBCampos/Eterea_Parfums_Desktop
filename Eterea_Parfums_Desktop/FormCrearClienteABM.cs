using Eterea_Parfums_Desktop.Controladores;
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
    public partial class FormCrearClienteABM : Form
    {
        public List<Pais> paises;
        public List<Provincia> provincias;
        public List<Localidad> localidades;
        public List<Calle> calles;

        public FormCrearClienteABM()
        {
            InitializeComponent();

            lbl_usuarioE.Hide();
            lbl_claveE.Hide();
            lbl_nombreE.Hide();
            lbl_apellidoE.Hide();
            lbl_dniE.Hide();
            lbl_cond_ivaE.Hide();
            lbl_celularE.Hide();
            lbl_emailE.Hide();
            lbl_cpE.Hide();
            lbl_num_calleE.Hide();
            lbl_pisoE.Hide();
            lbl_deptoE.Hide();
            lbl_comentariosE.Hide();
            lbl_nacE.Hide();
            lbl_paisE.Hide();
            lbl_provinciaE.Hide();
            lbl_localidadE.Hide();
            lbl_calleE.Hide();
            lbl_activoE.Hide();
            

            paises = PaisControlador.getAll();
            combo_pais.Items.Clear();
            foreach (Pais pais in paises)
            {
                combo_pais.Items.Add(pais.nombre.ToString());
            }

            provincias = ProvinciaControlador.getAll();
            combo_provincia.Items.Clear();
            foreach (Provincia provincia in provincias)
            {
                combo_provincia.Items.Add(provincia.nombre.ToString());
            }

            localidades = LocalidadControlador.getAll();
            combo_localidad.Items.Clear();
            foreach (Localidad localidad in localidades)
            {
                combo_localidad.Items.Add(localidad.nombre.ToString());
            }

            calles = CalleControlador.getAll();
            combo_calle.Items.Clear();
            foreach (Calle calle in calles)
            {
                combo_calle.Items.Add(calle.nombre.ToString());
            }

            combo_activo.Items.Clear();
            combo_activo.Items.Add("Activo");
            combo_activo.Items.Add("Inactivo");

            combo_con_iva.Items.Clear();
            combo_con_iva.Items.Add("Consumidor Final");
            combo_con_iva.Items.Add("Responsable Inscripto");
            combo_con_iva.Items.Add("Responsable no Inscripto");
            combo_con_iva.Items.Add("Responsable Monotributo");
            
        }

        private void btn_crear_cliente_Click(object sender, EventArgs e)
        {
            string errorMsg;

            if (validarDatosCliente(out errorMsg))
            {
                crear();
            }
            else
            {
                
            }

        }

        private void crear()
        {
            // ACA ANTES DE EJECUTAR CUALQUIER COSA, TIENEN QUE HACERSE LAS VALIDACIONES...
            //bool clienteValidado = validarDatosCliente(out string errorMsg);

            //if (clienteValidado)
            //{

            int activo = 1;
            if (combo_activo.SelectedItem.ToString() == "Inactivo")
            {
                activo = 0;
            }

            string rol = "cliente";

            //vendedor = new Vendedor()
            //{
            //id = 0,
            //usuario = txt_usuario.Text,
            //clave = txt_contraseña.Text,
            //nombre = txt_nombre.Text,
            //apellido = txt_apellido.Text,
            //dni = int.Parse(txt_dni.Text),
            //fecha_nacimiento = txt_fecha_nacimiento.Text,
            //celular = txt_celular.Text,
            //e_mail = txt_e_mail.Text,
            //pais_id = combo_pais_id.Text,

            //}
            Pais pais = PaisControlador.getByName(combo_pais.SelectedItem.ToString());
            Provincia provincia = ProvinciaControlador.getByName(combo_provincia.SelectedItem.ToString());
            Localidad ciudad = LocalidadControlador.getByName(combo_localidad.SelectedItem.ToString());
            Calle calle = CalleControlador.getByName(combo_calle.SelectedItem.ToString());


            Cliente cliente = new Cliente(0, txt_usuario.Text, txt_clave.Text, txt_nombre.Text, txt_apellido.Text,
                int.Parse(txt_dni.Text), combo_con_iva.Text, DateTime.Parse(dateTime_nac.Text), txt_celular.Text, txt_email.Text,
                pais, provincia, ciudad, int.Parse(txt_cp.Text), calle, int.Parse(txt_num_calle.Text),
                txt_piso.Text, txt_depto.Text, richTextBox_comentario.Text,
                 activo, rol);

            if (ClienteControlador.crearCliente(cliente))
            {
                this.DialogResult = DialogResult.OK;
            }
            /*}
            else 
            {
              MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              this.DialogResult = DialogResult.Cancel;
            }*/
        }

        private bool validarDatosCliente(out string errorMsg)
        {
            errorMsg = string.Empty;

            // Ocultar etiquetas de error
            lbl_usuarioE.Hide();
            lbl_claveE.Hide();
            lbl_nombreE.Hide();
            lbl_apellidoE.Hide();
            lbl_dniE.Hide();
            lbl_cond_ivaE.Hide();
            lbl_celularE.Hide();
            lbl_emailE.Hide();
            lbl_cpE.Hide();
            lbl_num_calleE.Hide();
            lbl_pisoE.Hide();
            lbl_deptoE.Hide();
            lbl_comentariosE.Hide();
            lbl_nacE.Hide();
            lbl_paisE.Hide();
            lbl_provinciaE.Hide();
            lbl_localidadE.Hide();
            lbl_calleE.Hide();
            lbl_activoE.Hide();

            // Validaciones individuales
            if (string.IsNullOrEmpty(txt_usuario.Text))
            {
                lbl_usuarioE.Text = "Debe indicar un nombre de usuario.";
                lbl_usuarioE.Show();
                errorMsg += lbl_usuarioE.Text + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txt_clave.Text))
            {
                lbl_claveE.Text = "Debe generar una contraseña.";
                lbl_claveE.Show();
                errorMsg += lbl_claveE.Text + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                lbl_nombreE.Text = "Debe ingresar el nombre del cliente.";
                lbl_nombreE.Show();
                errorMsg += lbl_nombreE.Text + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txt_apellido.Text))
            {
                lbl_apellidoE.Text = "Debe ingresar el apellido del cliente.";
                lbl_apellidoE.Show();
                errorMsg += lbl_apellidoE.Text + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txt_dni.Text))
            {
                string error = "Debe ingresar el número de DNI del cliente." + Environment.NewLine;
                lbl_dniE.Text = error;
                lbl_dniE.Show();
            }
            else if (txt_dni.Text.Length != 8 && txt_dni.Text.Length != 11)
            {
                string error = "El DNI tiene que ser de 8 o 11 dígitos." + Environment.NewLine;
                lbl_dniE.Text = error;
                lbl_dniE.Show();
            }

            if (!DateTime.TryParse(dateTime_nac.Text, out _))
            {
                lbl_nacE.Text = "Debe ingresar una fecha de nacimiento válida.";
                lbl_nacE.Show();
                errorMsg += lbl_nacE.Text + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txt_celular.Text) || !int.TryParse(txt_celular.Text, out _))
            {
                lbl_celularE.Text = "Debe ingresar un número de celular válido.";
                lbl_celularE.Show();
                errorMsg += lbl_celularE.Text + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txt_email.Text) || !txt_email.Text.Contains("@"))
            {
                lbl_emailE.Text = "Debe ingresar un correo electrónico válido.";
                lbl_emailE.Show();
                errorMsg += lbl_emailE.Text + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txt_cp.Text) || !int.TryParse(txt_cp.Text, out _))
            {
                lbl_cpE.Text = "Debe ingresar un código postal válido.";
                lbl_cpE.Show();
                errorMsg += lbl_cpE.Text + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txt_num_calle.Text) || !int.TryParse(txt_num_calle.Text, out _))
            {
                lbl_num_calleE.Text = "Debe ingresar un número de calle válido.";
                lbl_num_calleE.Show();
                errorMsg += lbl_num_calleE.Text + Environment.NewLine;
            }

            if (combo_pais.SelectedItem == null)
            {
                lbl_paisE.Text = "Debe seleccionar un país.";
                lbl_paisE.Show();
                errorMsg += lbl_paisE.Text + Environment.NewLine;
            }

            if (combo_provincia.SelectedItem == null)
            {
                lbl_provinciaE.Text = "Debe seleccionar una provincia.";
                lbl_provinciaE.Show();
                errorMsg += lbl_provinciaE.Text + Environment.NewLine;
            }

            if (combo_localidad.SelectedItem == null)
            {
                lbl_localidadE.Text = "Debe seleccionar una localidad.";
                lbl_localidadE.Show();
                errorMsg += lbl_localidadE.Text + Environment.NewLine;
            }

            if (combo_calle.SelectedItem == null)
            {
                lbl_calleE.Text = "Debe seleccionar una calle.";
                lbl_calleE.Show();
                errorMsg += lbl_calleE.Text + Environment.NewLine;
            }

            if (combo_activo.SelectedItem == null)
            {
                lbl_activoE.Text = "Debe seleccionar el estado activo/inactivo.";
                lbl_activoE.Show();
                errorMsg += lbl_activoE.Text + Environment.NewLine;
            }

            return string.IsNullOrEmpty(errorMsg);
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
