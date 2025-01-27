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
    public partial class FormEditarEmpleado : Form
    {

        /*  string situacion;

          int id_eliminar;
        */

        int id_editar;

        public List<Pais> paises;
        public List<Provincia> provincias;
        public List<Localidad> localidades;
        public List<Calle> calles;
        public List<Sucursal> sucursales;
        public FormEditarEmpleado()
        {
            InitializeComponent();


            lbl_usuarioE.Hide();
            lbl_claveE.Hide();
            lbl_nombreE.Hide();
            lbl_apellidoE.Hide();
            lbl_dniE.Hide();
            lbl_nacE.Hide();
            lbl_celularE.Hide();
            lbl_e_mailE.Hide();
            lbl_paisE.Hide();
            lbl_provinciaE.Hide();
            lbl_localidadE.Hide();
            lbl_cpE.Hide();
            lbl_calleE.Hide();
            lbl_num_calleE.Hide();
            lbl_pisoE.Hide();
            lbl_departamentoE.Hide();
            lbl_comentarios_domicilioE.Hide();
            lbl_sucursalE.Hide();
            lbl_ingE.Hide();
            lbl_sueldoE.Hide();
            lbl_activoE.Hide();
            lbl_rolE.Hide();

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

            sucursales = SucursalControlador.getAll();
            combo_sucursal.Items.Clear();
            foreach (Sucursal sucursal in sucursales)
            {
                combo_sucursal.Items.Add(sucursal.nombre.ToString());
            }


            combo_activo.Items.Clear();
            combo_activo.Items.Add("Activo");
            combo_activo.Items.Add("Inactivo");

            combo_rol.Items.Clear();
            combo_rol.Items.Add("admin");
            combo_rol.Items.Add("vendedor");

        //    situacion = "Edicion";

    }

// ------------------------------------------------------------------------------------------------------------------------
        //SOBRECARGAR EL CONSTRUCTOR PARA INICIAR EL FORM CON LA INFO CARGADA, PARA EDITAR
        public FormEditarEmpleado(Empleado empleado)
        {
            InitializeComponent();

            lbl_usuarioE.Hide();
            lbl_claveE.Hide();
            lbl_nombreE.Hide();
            lbl_apellidoE.Hide();
            lbl_dniE.Hide();
            lbl_nacE.Hide();
            lbl_celularE.Hide();
            lbl_e_mailE.Hide();
            lbl_paisE.Hide();
            lbl_provinciaE.Hide();
            lbl_localidadE.Hide();
            lbl_cpE.Hide();
            lbl_calleE.Hide();
            lbl_num_calleE.Hide();
            lbl_pisoE.Hide();
            lbl_departamentoE.Hide();
            lbl_comentarios_domicilioE.Hide();
            lbl_sucursalE.Hide();
            lbl_ingE.Hide();
            lbl_sueldoE.Hide();
            lbl_activoE.Hide();
            lbl_rolE.Hide();


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

            sucursales = SucursalControlador.getAll();
            combo_sucursal.Items.Clear();
            foreach (Sucursal sucursal in sucursales)
            {
                combo_sucursal.Items.Add(sucursal.nombre.ToString());
            }


            label4.Hide();


            id_editar = empleado.id;

            txt_usuario.Text = empleado.usuario.ToString();
            txt_contraseña.Hide();
            txt_nombre.Text = empleado.nombre.ToString();
            txt_apellido.Text = empleado.apellido.ToString();
            txt_dni.Text = empleado.dni.ToString();
            dateTime_nac.Text = empleado.fecha_nacimiento.ToString();


            txt_celular.Text = empleado.celular.ToString();
            txt_e_mail.Text = empleado.e_mail.ToString();
            combo_pais.SelectedItem = empleado.pais_id.nombre.ToString();
            combo_provincia.SelectedItem = empleado.provincia_id.nombre.ToString();
            combo_localidad.SelectedItem = empleado.localidad_id.nombre.ToString();
            txt_cp.Text = empleado.codigo_postal.ToString();
            combo_calle.SelectedItem = empleado.calle_id.nombre.ToString();
            txt_num_calle.Text = empleado.numeracion_calle.ToString();
            txt_piso.Text = empleado.piso.ToString();
            txt_departamento.Text = empleado.departamento.ToString();
            txt_comentarios_domicilio.Text = empleado.comentarios_domicilio.ToString();


            combo_sucursal.Text = empleado.sucursal_id.nombre.ToString();
            dateTime_ing.Text = empleado.fecha_ingreso.ToString();
            txt_sueldo.Text = empleado.sueldo.ToString();


            combo_activo.Items.Clear();
            combo_activo.Items.Add("Activo");
            combo_activo.Items.Add("Inactivo");

            if (empleado.activo == 1)
            {
                combo_activo.SelectedItem = "Activo";
            }
            else
            {
                combo_activo.SelectedItem = "Inactivo";
            }

            combo_rol.Items.Clear();
            combo_rol.Items.Add("admin");
            combo_rol.Items.Add("vendedor");

            if (empleado.rol == "admin")
            {
                combo_rol.SelectedItem = "admin";
            }
            else
            {
                combo_rol.SelectedItem = "vendedor";
            }


        //   situacion = "Edicion";

            label1.Text = "Editar Vendedor";
            btn_crear.Text = "Editar";

        }

        private void editar()
        {
            int activo = 1;
            if (combo_activo.SelectedItem.ToString() == "Inactivo")
            {
                activo = 0;
            }

            String rol = "vendedor";
            if (combo_rol.SelectedItem.ToString() == "Admin")
            {
                rol = "admin";
            }

            Pais pais = PaisControlador.getByName(combo_pais.SelectedItem.ToString());
            Provincia provincia = ProvinciaControlador.getByName(combo_provincia.SelectedItem.ToString());
            Localidad localidad = LocalidadControlador.getByName(combo_localidad.SelectedItem.ToString());
            Calle calle = CalleControlador.getByName(combo_calle.SelectedItem.ToString());
            Sucursal sucursal = SucursalControlador.getByName(combo_sucursal.SelectedItem.ToString());

            Empleado empleado = new Empleado(id_editar, txt_usuario.Text, txt_contraseña.Text, txt_nombre.Text, txt_apellido.Text,
                int.Parse(txt_dni.Text), DateTime.Parse(dateTime_nac.Text), txt_celular.Text, txt_e_mail.Text,
                pais, provincia, localidad, int.Parse(txt_cp.Text), calle, int.Parse(txt_num_calle.Text),
                txt_piso.Text, txt_departamento.Text, txt_comentarios_domicilio.Text,
                 sucursal, DateTime.Parse(dateTime_ing.Text), int.Parse(txt_sueldo.Text), activo, rol);

            if (EmpleadoControlador.editarEmpleado(empleado))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool validarDatosEmpleado(out string errorMsg)
        {
            errorMsg = string.Empty;

            // Ocultar etiquetas de error
            lbl_usuarioE.Hide();
            lbl_claveE.Hide();
            lbl_nombreE.Hide();
            lbl_apellidoE.Hide();
            lbl_dniE.Hide();
            lbl_nacE.Hide();
            lbl_celularE.Hide();
            lbl_e_mailE.Hide();
            lbl_paisE.Hide();
            lbl_provinciaE.Hide();
            lbl_localidadE.Hide();
            lbl_cpE.Hide();
            lbl_calleE.Hide();
            lbl_num_calleE.Hide();
            lbl_pisoE.Hide();
            lbl_departamentoE.Hide();
            lbl_comentarios_domicilioE.Hide();
            lbl_sucursalE.Hide();
            lbl_ingE.Hide();
            lbl_sueldoE.Hide();
            lbl_activoE.Hide();
            lbl_rolE.Hide();

            // Validaciones individuales
            if (string.IsNullOrEmpty(txt_usuario.Text))
            {
                lbl_usuarioE.Text = "Debe indicar un nombre de usuario.";
                lbl_usuarioE.Show();
                errorMsg += lbl_usuarioE.Text + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txt_contraseña.Text))
            {
                lbl_claveE.Text = "Debe generar una contraseña.";
                lbl_claveE.Show();
                errorMsg += lbl_claveE.Text + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                lbl_nombreE.Text = "Debe ingresar el nombre del usuario.";
                lbl_nombreE.Show();
                errorMsg += lbl_nombreE.Text + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txt_apellido.Text))
            {
                lbl_apellidoE.Text = "Debe ingresar el apellido del usuario.";
                lbl_apellidoE.Show();
                errorMsg += lbl_apellidoE.Text + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txt_dni.Text))
            {
                string error = "Debe ingresar el número de DNI del usuario." + Environment.NewLine;
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

            if (string.IsNullOrEmpty(txt_e_mail.Text) || !txt_e_mail.Text.Contains("@"))
            {
                lbl_e_mailE.Text = "Debe ingresar un correo electrónico válido.";
                lbl_e_mailE.Show();
                errorMsg += lbl_e_mailE.Text + Environment.NewLine;
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

            if (string.IsNullOrEmpty(txt_cp.Text) || !int.TryParse(txt_cp.Text, out _))
            {
                lbl_cpE.Text = "Debe ingresar un código postal válido.";
                lbl_cpE.Show();
                errorMsg += lbl_cpE.Text + Environment.NewLine;
            }

            if (combo_calle.SelectedItem == null)
            {
                lbl_calleE.Text = "Debe seleccionar una calle.";
                lbl_calleE.Show();
                errorMsg += lbl_calleE.Text + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txt_num_calle.Text) || !int.TryParse(txt_num_calle.Text, out _))
            {
                lbl_num_calleE.Text = "Debe ingresar un número de calle válido.";
                lbl_num_calleE.Show();
                errorMsg += lbl_num_calleE.Text + Environment.NewLine;
            }

            /*        if (string.IsNullOrEmpty(txt_piso.Text) || !int.TryParse(txt_piso.Text, out _))
                {
                    lbl_pisoE.Text = "Debe ingresar un piso valido.";
                    lbl_pisoE.Show();
                    errorMsg += lbl_pisoE.Text + Environment.NewLine;
                } */

            /*    if (string.IsNullOrEmpty(txt_departamento.Text))
            {
                lbl_departamentoE.Text = "Debe ingresar un piso valido.";
                lbl_departamentoE.Show();
                errorMsg += lbl_departamentoE.Text + Environment.NewLine;
            } */

            if (combo_sucursal.SelectedItem == null)
            {
                lbl_sucursalE.Text = "Debe seleccionar una sucursal.";
                lbl_sucursalE.Show();
                errorMsg += lbl_sucursalE.Text + Environment.NewLine;
            }

            if (!DateTime.TryParse(dateTime_ing.Text, out _))
            {
                lbl_ingE.Text = "Debe ingresar una fecha de ingreso válida.";
                lbl_ingE.Show();
                errorMsg += lbl_ingE.Text + Environment.NewLine;
            }

            if (string.IsNullOrEmpty(txt_sueldo.Text) || !int.TryParse(txt_sueldo.Text, out _))
            {
                lbl_sueldoE.Text = "Debe ingresar un sueldo válido.";
                lbl_sueldoE.Show();
                errorMsg += lbl_sueldoE.Text + Environment.NewLine;
            }

            if (combo_activo.SelectedItem == null)
            {
                lbl_activoE.Text = "Debe seleccionar el estado activo/inactivo.";
                lbl_activoE.Show();
                errorMsg += lbl_activoE.Text + Environment.NewLine;
            }

            if (combo_rol.SelectedItem == null)
            {
                lbl_rolE.Text = "Debe seleccionar un rol válido.";
                lbl_rolE.Show();
                errorMsg += lbl_rolE.Text + Environment.NewLine;
            }

            return string.IsNullOrEmpty(errorMsg);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_crear_Click_1(object sender, EventArgs e)
        {
            string errorMsg;

            if (validarDatosEmpleado(out errorMsg))
            {
                editar();
            }
            else
            {

            }
        }

        private void FormEditarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }


    }
}
