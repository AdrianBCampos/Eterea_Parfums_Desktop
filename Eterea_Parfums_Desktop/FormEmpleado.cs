using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eterea_Parfums_Desktop.Modelos;
using Eterea_Parfums_Desktop.Controladores;

namespace Eterea_Parfums_Desktop
{
    public partial class FormEmpleado : Form
    {

        public List<Pais> paises;
        public List<Provincia> provincias;
        public List<Localidad> localidades;
        public List<Calle> calles;
        public List<Sucursal> sucursales;


        public FormEmpleado()
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
            combo_rol.Items.Add("Admin");
            combo_rol.Items.Add("Vendedor");

            //situacion = "Creacion";
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado(
                0,
                txt_usuario.Text,
                txt_contraseña.Text,
                txt_nombre.Text,
                txt_apellido.Text,
                txt_dni.Text,
                dateTime_nac.Text,
                txt_celular.Text,
                txt_e_mail.Text,
                combo_pais.SelectedItem,
                combo_provincia.SelectedItem,
                combo_localidad.SelectedItem,
                txt_cp.Text,
                combo_calle.SelectedItem,
                txt_num_calle.Text,
                txt_piso.Text,
                txt_departamento.Text,
                txt_comentarios_domicilio.Text,
                combo_sucursal.SelectedItem,
                dateTime_ing.Text,
                txt_sueldo.Text,
                combo_activo.SelectedItem,
                combo_rol.SelectedItem
                );


        }




        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
