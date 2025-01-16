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


            id_editar = 3;
                //empleado.id;

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
        private void btn_crear_Click(object sender, EventArgs e)
        {

       /*     if (situacion == "Creacion")
            {
                crear();
            }
            if (situacion == "Edicion")
            {
       */
                editar();
            this.Hide();
            /*     }
                 if (situacion == "Eliminar")
                 {
                     eliminar();
                 }
            */


        }
        /*
        private void crear()
        {
            // ACA ANTES DE EJECUTAR CUALQUIER COSA, TIENEN QUE HACERSE LAS VALIDACIONES...

            int activo = 1;
            if (combo_activo.SelectedItem.ToString() == "Inactivo")
            {
                activo = 0;
            }

            string rol = "vendedor"; // Valor por defecto
            if (combo_rol.SelectedItem.ToString() == "admin")
            {
                rol = "admin";
            }


            Pais pais = PaisControlador.getByName(combo_pais.SelectedItem.ToString());
            Provincia provincia = ProvinciaControlador.getByName(combo_provincia.SelectedItem.ToString());
            Localidad localidad = LocalidadControlador.getByName(combo_localidad.SelectedItem.ToString());
            Calle calle = CalleControlador.getByName(combo_calle.SelectedItem.ToString());
            Sucursal sucursal = SucursalControlador.getByName(combo_sucursal.SelectedItem.ToString());


            Empleado empleado = new Empleado(0, txt_usuario.Text, txt_contraseña.Text, txt_nombre.Text, txt_apellido.Text,
                int.Parse(txt_dni.Text), DateTime.Parse(dateTime_nac.Text), txt_celular.Text, txt_e_mail.Text,
                pais, provincia, localidad, int.Parse(txt_cp.Text), calle, int.Parse(txt_num_calle.Text),
                txt_piso.Text, txt_departamento.Text, txt_comentarios_domicilio.Text,
                sucursal, DateTime.Parse(dateTime_ing.Text), int.Parse(txt_sueldo.Text), activo, rol);

            if (EmpleadoControlador.crearEmpleado(empleado))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        */
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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
        private void eliminar()
        {

            int activo = 0;




            Empleado empleado = new Empleado(id_eliminar, activo);


            if (EmpleadoControlador.eliminarEmpleado(id_eliminar))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        */

    }
}
