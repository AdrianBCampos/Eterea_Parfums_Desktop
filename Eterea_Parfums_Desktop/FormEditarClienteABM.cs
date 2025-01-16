using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormEditarClienteABM : Form
    {
        int id_editar;

        public List<Pais> paises;
        public List<Provincia> provincias;
        public List<Localidad> localidades;
        public List<Calle> calles;

        public FormEditarClienteABM()
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
        }

        //SOBRECARGAR EL CONSTRUCTOR PARA INICIAR EL FORM CON LA INFO CARGADA, PARA EDITAR
        public FormEditarClienteABM(Cliente cliente)
        {
            InitializeComponent();

            lbl_usuarioE.Hide();
            lbl_nombreE.Hide();
            lbl_claveE.Hide();
            lbl_clave.Hide();
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

            id_editar = cliente.id;

            txt_usuario.Text = cliente.usuario.ToString();
            txt_clave.Hide();
            txt_nombre.Text = cliente.nombre.ToString();
            txt_apellido.Text = cliente.apellido.ToString();
            txt_dni.Text = cliente.dni.ToString();
            txt_cond_iva.Text = cliente.condicion_frente_al_iva.ToString();
            dateTime_nac.Text = cliente.fecha_nacimiento?.ToString("1900-01-01") ?? ""; // Si es null, asigna una cadena vacía
            //dateTime_nac.Text = cliente.fecha_nacimiento.ToString();
            txt_celular.Text = cliente.celular.ToString();
            txt_email.Text = cliente.e_mail.ToString();
            combo_pais.SelectedItem = cliente.pais_id.nombre.ToString();
            combo_provincia.SelectedItem = cliente.provincia_id.nombre.ToString();
            combo_localidad.SelectedItem = cliente.localidad_id.nombre.ToString();
            txt_cp.Text = cliente.codigo_postal?.ToString() ?? ""; // Si es null, asigna una cadena vacía
            //txt_cp.Text = cliente.codigo_postal.ToString();
            combo_calle.SelectedItem = cliente.calle_id.nombre.ToString();
            txt_num_calle.Text = cliente.numeracion_calle?.ToString() ?? ""; // Si es null, asigna una cadena vacía
            txt_piso.Text = cliente.piso ?? ""; // Si es null, asigna una cadena vacía
            txt_depto.Text = cliente.departamento ?? ""; // Si es null, asigna una cadena vacía
            txt_comentarios.Text = cliente.comentarios_domicilio ?? ""; // Si es null, asigna una cadena vacía
            //txt_num_calle.Text = cliente.numeracion_calle.ToString();
            //txt_piso.Text = cliente.piso.ToString();
            //txt_depto.Text = cliente.departamento.ToString();
            //txt_comentarios.Text = cliente.comentarios_domicilio.ToString();

            combo_activo.Items.Clear();
            combo_activo.Items.Add("Activo");
            combo_activo.Items.Add("Inactivo");

            if (cliente.activo == 1)
            {
                combo_activo.SelectedItem = "Activo";
            }
            else
            {
                combo_activo.SelectedItem = "Inactivo";
            }
            
        }

        private void btn_editar_cliente_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void editar()
        {
            int activo = 1;
            if (combo_activo.SelectedItem.ToString() == "Inactivo")
            {
                activo = 0;
            }

            string rol = "cliente";

            Pais pais = PaisControlador.getByName(combo_pais.SelectedItem.ToString());
            Provincia provincia = ProvinciaControlador.getByName(combo_provincia.SelectedItem.ToString());
            Localidad ciudad = LocalidadControlador.getByName(combo_localidad.SelectedItem.ToString());
            Calle calle = CalleControlador.getByName(combo_calle.SelectedItem.ToString());


            Cliente cliente = new Cliente(id_editar, txt_usuario.Text, txt_clave.Text, txt_nombre.Text, txt_apellido.Text,
               int.Parse(txt_dni.Text), txt_cond_iva.Text, DateTime.Parse(dateTime_nac.Text), txt_celular.Text, txt_email.Text,
               pais, provincia, ciudad, int.Parse(txt_cp.Text), calle, int.Parse(txt_num_calle.Text),
               txt_piso.Text, txt_depto.Text, txt_comentarios.Text,
                activo, rol);

            if (ClienteControlador.editarCliente(cliente))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
