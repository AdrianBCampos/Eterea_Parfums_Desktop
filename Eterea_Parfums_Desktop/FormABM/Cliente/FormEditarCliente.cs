using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormEditarCliente : Form
    {
        int id_editar;

        public List<Pais> paises;
        public List<Provincia> provincias;
        public List<Localidad> localidades;
        public List<Calle> calles;

        

        //SOBRECARGAR EL CONSTRUCTOR PARA INICIAR EL FORM CON LA INFO CARGADA, PARA EDITAR
        public FormEditarCliente(Cliente cliente)
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

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
                if (pais.id != 1)
                    combo_pais.Items.Add(pais.nombre.ToString());
            }

            provincias = ProvinciaControlador.getAll();
            combo_provincia.Items.Clear();
            List<string> nombresProvincias = provincias.Select(p => p.nombre).ToList();
            CargarComboConOpciones(combo_provincia, nombresProvincias);


            localidades = LocalidadControlador.getAll();
            combo_localidad.Items.Clear();
            foreach (Localidad localidad in localidades)
            {
                if (localidad.id != 1)
                    combo_localidad.Items.Add(localidad.nombre.ToString());
            }

            calles = CalleControlador.getAll();
            combo_calle.Items.Clear();
            foreach (Calle calle in calles)
            {
                if (calle.id != 1)
                    combo_calle.Items.Add(calle.nombre.ToString());
            }

            id_editar = cliente.id;

            txt_usuario.Text = cliente.usuario.ToString();
            txt_clave.Hide();
            txt_nombre.Text = cliente.nombre.ToString();
            txt_apellido.Text = cliente.apellido.ToString();
            txt_dni.Text = cliente.dni.ToString();
            combo_con_iva.Text = cliente.condicion_frente_al_iva.ToString();
            dateTime_nac.Text = cliente.fecha_nacimiento?.ToString() ?? ""; // Si es null, asigna una cadena vacía
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
            richTextBox_comentario.Text = cliente.comentarios_domicilio ?? ""; // Si es null, asigna una cadena vacía
            //txt_num_calle.Text = cliente.numeracion_calle.ToString();
            //txt_piso.Text = cliente.piso.ToString();
            //txt_depto.Text = cliente.departamento.ToString();
            //txt_comentarios.Text = cliente.comentarios_domicilio.ToString();

            combo_activo.Items.Clear();
            combo_activo.Items.Add("Activo");
            combo_activo.Items.Add("Inactivo");

            if (cliente.activo == true)
            {
                combo_activo.SelectedItem = "Activo";
            }
            else
            {
                combo_activo.SelectedItem = "Inactivo";
            }

            combo_con_iva.Items.Clear();
            combo_con_iva.Items.Add("Consumidor Final");
            combo_con_iva.Items.Add("Responsable Inscripto");
            combo_con_iva.Items.Add("Exento");
            combo_con_iva.Items.Add("Monotributista");

            //Diseño del combo box
            combo_activo.DrawMode = DrawMode.OwnerDrawFixed;
            combo_activo.DrawItem += comboBoxdiseño_DrawItem;
            combo_activo.DropDownStyle = ComboBoxStyle.DropDownList;

            combo_con_iva.DrawMode = DrawMode.OwnerDrawFixed;
            combo_con_iva.DrawItem += comboBoxdiseño_DrawItem;
            combo_con_iva.DropDownStyle = ComboBoxStyle.DropDownList;

            combo_calle.DrawMode = DrawMode.OwnerDrawFixed;
            combo_calle.DrawItem += comboBoxdiseño_DrawItem;
            combo_calle.DropDownStyle = ComboBoxStyle.DropDownList;

            combo_pais.DrawMode = DrawMode.OwnerDrawFixed;
            combo_pais.DrawItem += comboBoxdiseño_DrawItem;
            combo_pais.DropDownStyle = ComboBoxStyle.DropDownList;

            combo_provincia.DrawMode = DrawMode.OwnerDrawFixed;
            combo_provincia.DrawItem += comboBoxdiseño_DrawItem;
            combo_provincia.DropDownStyle = ComboBoxStyle.DropDownList;

            combo_localidad.DrawMode = DrawMode.OwnerDrawFixed;
            combo_localidad.DrawItem += comboBoxdiseño_DrawItem;
            combo_localidad.DropDownStyle = ComboBoxStyle.DropDownList;

            // Asignar eventos a los comboBox
            combo_pais.SelectedIndexChanged += combo_pais_SelectedIndexChanged;
            combo_provincia.SelectedIndexChanged += combo_provincia_SelectedIndexChanged;
            combo_localidad.SelectedIndexChanged += combo_localidad_SelectedIndexChanged;

            //Asignar evento al txt_dni
            txt_dni.TextChanged += txt_dni_TextChanged;

        }

        private void CargarComboConOpciones(ComboBox combo, List<string> opciones)
        {
            combo.Items.Clear();
            combo.SelectedIndex = -1;

            if (opciones != null && opciones.Count > 0)
            {
                combo.Items.AddRange(opciones.ToArray());
                combo.Enabled = true;
            }
            else
            {
                combo.Items.Add(""); // una fila vacía, visible
                combo.SelectedIndex = 0;
                combo.Enabled = true; // o false si querés bloquearlo
            }
        }


        private void combo_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_provincia.Items.Clear();
            combo_localidad.Items.Clear();
            combo_calle.Items.Clear();

            string nombrePaisSeleccionado = combo_pais.SelectedItem?.ToString();
            Pais paisSeleccionado = paises.FirstOrDefault(p => p.nombre == nombrePaisSeleccionado);
            if (paisSeleccionado != null)
            {
                // Nuevo método que busca provincias por pais_id
                var provinciasRelacionadas = ProvinciaControlador.getProvinciasPorPaisId(paisSeleccionado.id);
                provincias = provinciasRelacionadas;

                foreach (var provincia in provincias)
                {
                    combo_provincia.Items.Add(provincia.nombre);
                }
            }
        }


        private void combo_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_localidad.Items.Clear();
            combo_calle.Items.Clear();

            string nombreProvinciaSeleccionada = combo_provincia.SelectedItem.ToString();
            Provincia provinciaSeleccionada = provincias.FirstOrDefault(p => p.nombre == nombreProvinciaSeleccionada);

            if (provinciaSeleccionada != null)
            {
                // Llamás al nuevo método que obtiene localidades directamente por provincia_id
                var localidadesRelacionadas = LocalidadControlador.getLocalidadesPorProvinciaId(provinciaSeleccionada.id);
                localidades = localidadesRelacionadas;

                foreach (var localidad in localidades)
                {
                    combo_localidad.Items.Add(localidad.nombre);
                }
            }
        }


        private void combo_localidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_calle.Items.Clear();

            string nombreLocalidadSeleccionada = combo_localidad.SelectedItem.ToString();
            Localidad localidadSeleccionada = localidades.FirstOrDefault(l => l.nombre == nombreLocalidadSeleccionada);

            if (localidadSeleccionada != null)
            {
                // Ahora se busca directamente en la tabla "calle" filtrando por localidad_id
                var callesRelacionadas = CalleControlador.getCallesPorLocalidadId(localidadSeleccionada.id);
                calles = callesRelacionadas;

                combo_calle.Items.Clear(); // recomendable limpiar antes
                foreach (var calle in calles)
                {
                    combo_calle.Items.Add(calle.nombre);
                }
            }
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {
            string dni = txt_dni.Text.Trim();

            if (dni.Length == 8 && long.TryParse(dni, out _))
            {
                combo_con_iva.Items.Clear();
                combo_con_iva.Items.Add("Consumidor Final");
                combo_con_iva.SelectedIndex = 0;
                combo_con_iva.Enabled = false;
                lbl_dniE.Hide();
            }
            else if (dni.Length == 11 && long.TryParse(dni, out _))
            {
                if (!CuitValido(dni))
                {
                    lbl_dniE.Text = "CUIT inválido (falló verificación).";
                    lbl_dniE.Show();
                    combo_con_iva.Enabled = false;
                    combo_con_iva.Items.Clear();
                    return;
                }

                combo_con_iva.Items.Clear();
                combo_con_iva.Items.Add("Responsable Inscripto");
                combo_con_iva.Items.Add("Exento");
                combo_con_iva.Items.Add("Monotributista");
                combo_con_iva.SelectedIndex = 0;
                combo_con_iva.Enabled = true;
                lbl_dniE.Hide();
            }
            else
            {
                combo_con_iva.Items.Clear();
                combo_con_iva.Enabled = false;
                lbl_dniE.Hide();
            }
        }


        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string errorMsg;
            if (validarDatosCliente(out errorMsg))
            {
                editar();
            }
            else
            {

            }
        }

        private void editar()
        {
            bool activo = combo_activo.SelectedItem.ToString() == "Activo";
            string rol = "cliente";

            // Validaciones seguras con TryParse
            if (!long.TryParse(txt_dni.Text, out long dniNumerico))
            {
                MessageBox.Show("El DNI o CUIT ingresado no es válido.");
                return;
            }

            if (txt_dni.Text.Length != 8 && txt_dni.Text.Length != 11)
            {
                MessageBox.Show("El DNI debe tener 8 dígitos o el CUIT 11 dígitos.");
                return;
            }

            if (!int.TryParse(txt_cp.Text, out int codigoPostal))
            {
                MessageBox.Show("El código postal ingresado no es válido.");
                return;
            }

            if (!int.TryParse(txt_num_calle.Text, out int numeroCalle))
            {
                MessageBox.Show("El número de calle ingresado no es válido.");
                return;
            }

            if (!DateTime.TryParse(dateTime_nac.Text, out DateTime fechaNacimiento))
            {
                MessageBox.Show("La fecha de nacimiento ingresada no es válida.");
                return;
            }

            // Obtener datos relacionados
            Pais pais = PaisControlador.getByName(combo_pais.SelectedItem.ToString());
            Provincia provincia = ProvinciaControlador.getByName(combo_provincia.SelectedItem.ToString());
            Localidad ciudad = LocalidadControlador.getByName(combo_localidad.SelectedItem.ToString());
            Calle calle = CalleControlador.getByName(combo_calle.SelectedItem.ToString());

            // Crear objeto Cliente de forma segura
            Cliente cliente = new Cliente(id_editar, txt_usuario.Text, txt_clave.Text, txt_nombre.Text, txt_apellido.Text,
               dniNumerico, combo_con_iva.Text, fechaNacimiento, txt_celular.Text, txt_email.Text,
               pais, provincia, ciudad, codigoPostal, calle, numeroCalle,
               txt_piso.Text, txt_depto.Text, richTextBox_comentario.Text,
               activo, rol);

            // Guardar cliente
            if (ClienteControlador.editarCliente(cliente))
            {
                this.DialogResult = DialogResult.OK;
            }
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

            // Usuario
            if (string.IsNullOrEmpty(txt_usuario.Text))
            {
                lbl_usuarioE.Text = "Debe indicar un nombre de usuario.";
                lbl_usuarioE.Show();
                errorMsg += lbl_usuarioE.Text + Environment.NewLine;
            }
            else if (txt_usuario.Text.Length < 3 || txt_usuario.Text.Length > 45)
            {
                lbl_usuarioE.Text = "El usuario debe tener entre 3 y 45 caracteres.";
                lbl_usuarioE.Show();
                errorMsg += lbl_usuarioE.Text + Environment.NewLine;
            }
            else if (ClienteControlador.ExisteUsuario(txt_usuario.Text))
            {
                lbl_usuarioE.Text = "Ya existe un cliente con ese nombre de usuario.";
                lbl_usuarioE.Show();
                errorMsg += lbl_usuarioE.Text + Environment.NewLine;
            }

           
            // Nombre
            if (string.IsNullOrEmpty(txt_nombre.Text) || txt_nombre.Text.Length < 2 || txt_nombre.Text.Length > 45)
            {
                lbl_nombreE.Text = "El nombre debe tener entre 2 y 45 caracteres.";
                lbl_nombreE.Show();
                errorMsg += lbl_nombreE.Text + Environment.NewLine;
            }

            // Apellido
            if (string.IsNullOrEmpty(txt_apellido.Text) || txt_apellido.Text.Length < 2 || txt_apellido.Text.Length > 45)
            {
                lbl_apellidoE.Text = "El apellido debe tener entre 2 y 45 caracteres.";
                lbl_apellidoE.Show();
                errorMsg += lbl_apellidoE.Text + Environment.NewLine;
            }

            // DNI
            if (string.IsNullOrEmpty(txt_dni.Text))
            {
                lbl_dniE.Text = "Debe ingresar el número de DNI del cliente.";
                lbl_dniE.Show();
                errorMsg += lbl_dniE.Text + Environment.NewLine;
            }
            else if (txt_dni.Text.Length != 8 && txt_dni.Text.Length != 11)
            {
                lbl_dniE.Text = "El DNI debe tener 8 o 11 dígitos.";
                lbl_dniE.Show();
                errorMsg += lbl_dniE.Text + Environment.NewLine;
            }
            else
            {
                var idExistente = ClienteControlador.BuscarIdPorDni(txt_dni.Text);
                if (idExistente != null)
                {
                    lbl_dniE.Text = "Ya existe un cliente con ese DNI.";
                    lbl_dniE.Show();
                    errorMsg += lbl_dniE.Text + Environment.NewLine;
                }
            }

            // Condición IVA
            if (combo_con_iva.SelectedItem == null)
            {
                lbl_cond_ivaE.Text = "Debe seleccionar una condición de IVA.";
                lbl_cond_ivaE.Show();
                errorMsg += lbl_cond_ivaE.Text + Environment.NewLine;
            }

            // Fecha de nacimiento
            if (!DateTime.TryParse(dateTime_nac.Text, out DateTime fecha))
            {
                lbl_nacE.Text = "Debe ingresar una fecha de nacimiento válida.";
                lbl_nacE.Show();
                errorMsg += lbl_nacE.Text + Environment.NewLine;
            }
            else
            {
                DateTime hoy = DateTime.Today;

                if (fecha > hoy)
                {
                    lbl_nacE.Text = "La fecha de nacimiento no puede ser futura.";
                    lbl_nacE.Show();
                    errorMsg += lbl_nacE.Text + Environment.NewLine;
                }
                else
                {
                    int edad = hoy.Year - fecha.Year;
                    if (fecha.Date > hoy.AddYears(-edad)) edad--;

                    if (edad < 18)
                    {
                        lbl_nacE.Text = "El cliente debe tener al menos 18 años.";
                        lbl_nacE.Show();
                        errorMsg += lbl_nacE.Text + Environment.NewLine;
                    }
                }
            }

            // Celular
            if (string.IsNullOrEmpty(txt_celular.Text) || !long.TryParse(txt_celular.Text, out long celular) ||
                txt_celular.Text.Length < 10 || txt_celular.Text.Length > 13)
            {
                lbl_celularE.Text = "El celular debe tener entre 10 y 13 dígitos numéricos.";
                lbl_celularE.Show();
                errorMsg += lbl_celularE.Text + Environment.NewLine;
            }

            // Email
            if (string.IsNullOrEmpty(txt_email.Text) ||
                !System.Text.RegularExpressions.Regex.IsMatch(txt_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lbl_emailE.Text = "Debe ingresar un correo electrónico válido.";
                lbl_emailE.Show();
                errorMsg += lbl_emailE.Text + Environment.NewLine;
            }
            else if (ClienteControlador.ExisteEmail(txt_email.Text))
            {
                lbl_emailE.Text = "Ya existe un cliente registrado con ese correo electrónico.";
                lbl_emailE.Show();
                errorMsg += lbl_emailE.Text + Environment.NewLine;
            }

            // Código Postal
            if (string.IsNullOrEmpty(txt_cp.Text) || !int.TryParse(txt_cp.Text, out _))
            {
                lbl_cpE.Text = "Debe ingresar un código postal válido.";
                lbl_cpE.Show();
                errorMsg += lbl_cpE.Text + Environment.NewLine;
            }

            // País
            if (combo_pais.SelectedItem == null)
            {
                lbl_paisE.Text = "Debe seleccionar un país.";
                lbl_paisE.Show();
                errorMsg += lbl_paisE.Text + Environment.NewLine;
            }

            // Provincia
            if (combo_provincia.SelectedItem == null)
            {
                lbl_provinciaE.Text = "Debe seleccionar una provincia.";
                lbl_provinciaE.Show();
                errorMsg += lbl_provinciaE.Text + Environment.NewLine;
            }

            // Localidad
            if (combo_localidad.SelectedItem == null)
            {
                lbl_localidadE.Text = "Debe seleccionar una localidad.";
                lbl_localidadE.Show();
                errorMsg += lbl_localidadE.Text + Environment.NewLine;
            }

            // Calle
            if (combo_calle.SelectedItem == null)
            {
                lbl_calleE.Text = "Debe seleccionar una calle.";
                lbl_calleE.Show();
                errorMsg += lbl_calleE.Text + Environment.NewLine;
            }

            // Número de calle
            if (string.IsNullOrEmpty(txt_num_calle.Text) || !int.TryParse(txt_num_calle.Text, out _))
            {
                lbl_num_calleE.Text = "Debe ingresar un número de calle válido.";
                lbl_num_calleE.Show();
                errorMsg += lbl_num_calleE.Text + Environment.NewLine;
            }

            // Estado activo/inactivo
            if (combo_activo.SelectedItem == null)
            {
                lbl_activoE.Text = "Debe seleccionar el estado activo/inactivo.";
                lbl_activoE.Show();
                errorMsg += lbl_activoE.Text + Environment.NewLine;
            }

            // Piso y depto (opcionales)
            if (!string.IsNullOrEmpty(txt_piso.Text) && txt_piso.Text.Length > 10)
            {
                lbl_pisoE.Text = "El campo 'piso' es demasiado largo.";
                lbl_pisoE.Show();
                errorMsg += lbl_pisoE.Text + Environment.NewLine;
            }

            if (!string.IsNullOrEmpty(txt_depto.Text) && txt_depto.Text.Length > 10)
            {
                lbl_deptoE.Text = "El campo 'depto' es demasiado largo.";
                lbl_deptoE.Show();
                errorMsg += lbl_deptoE.Text + Environment.NewLine;
            }

            // Retorna true si no hay errores
            return string.IsNullOrEmpty(errorMsg);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CuitValido(string cuit)
        {
            if (string.IsNullOrWhiteSpace(cuit) || cuit.Length != 11 || !long.TryParse(cuit, out _))
                return false;

            int[] pesos = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                suma += int.Parse(cuit[i].ToString()) * pesos[i];
            }

            int resto = suma % 11;
            int digitoVerificador = resto == 0 ? 0 : (resto == 1 ? 9 : 11 - resto);

            return digitoVerificador == int.Parse(cuit[10].ToString());
        }

    }
}
