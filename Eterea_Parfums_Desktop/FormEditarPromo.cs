using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.ControlesDeUsuario;
using Eterea_Parfums_Desktop.DTOs;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormEditarPromo : Form
    {
        int id_editar;

        Dictionary<int, string> textosDescuento = new Dictionary<int, string>
        {
            { 50, "2 x 1" },
            { 40, "2da Unidad 80% Dto." },
            { 35, "2da Unidad 70% Dto." },
            { 25, "2da Unidad 50% Dto." },
            { 10, "Descuento especial del 10%" }
        };

        private List<DataGridViewRow> backupRows = new List<DataGridViewRow>();
        public void cargarComboBoxDescuentos()
        {
            combo_tipo_promo_edit.Items.Clear(); // Limpia cualquier ítem anterior
            foreach (var item in textosDescuento)
            {
                combo_tipo_promo_edit.Items.Add(new KeyValuePair<int, string>(item.Key, item.Value));
            }

            combo_tipo_promo_edit.DisplayMember = "Value"; // Texto visible
            combo_tipo_promo_edit.ValueMember = "Key";    // Valor asociado


        }

        //SOBRECARGAR EL CONSTRUCTOR PARA INICIAR EL FORM CON LA INFO CARGADA, PARA EDITAR
        public FormEditarPromo(Promocion promo)
        {
            InitializeComponent();

            // Ocultar etiquetas de error
            lbl_error_tipo_promo_edit.Visible = false;
            lbl_error_nomb_edit.Visible = false;
            lbl_error_fecha_ini_edit.Visible = false;
            lbl_error_fecha_fin_edit.Visible = false;
            lbl_error_promo_act_edit.Visible = false;

            // Llamar a los métodos de carga de datos
            cargarComboBoxDescuentos();
            cargarComboBoxMarcas();
            cargarComboBoxGeneros();
            inicializarDatePickers();
            cargarPerfumes();

            //btn_limpiar_DataFridView_Click(object sender, EventArgs e);

            // Asignar el id de la promo al campo interno id_editar
            id_editar = promo.id;

            List<PerfumeDTO> perfumes = new List<PerfumeDTO>();
            // Llamada al método que carga los perfumes por idPromo
            PerfumeEnPromoControlador controladorPerfume = new PerfumeEnPromoControlador();
            perfumes = controladorPerfume.CargarPerfumesPorIdPromocion(id_editar);

            cargarPerfumesDePromo(perfumes);


            // Cargar el combo box para activo
            combo_activo_promo_edit.Items.Clear();
            combo_activo_promo_edit.Items.Add("Si");
            combo_activo_promo_edit.Items.Add("No");
            combo_activo_promo_edit.SelectedIndex = -1;

            // Obtener la promoción desde la base de datos
            //Promocion promo = PromoControlador.obtenerPorId(idPromo);

         

            /* // Asignar el descuento correspondiente al texto
             int descuento = promo.descuento; // Valor numérico del descuento obtenido de la BD
             if (textosDescuento.TryGetValue(descuento, out string textoDescuento))
             {
                 // Encontramos el KeyValuePair correspondiente
                 var selectedItem = textosDescuento.FirstOrDefault(x => x.Value == textoDescuento);
                 combo_tipo_promo_edit.SelectedItem = selectedItem; // Asignamos el KeyValuePair completo
             }
             else
             {
                 MessageBox.Show("El valor del descuento no tiene un texto asociado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }*/

            // Asignar el descuento correspondiente al texto
            int descuento = promo.descuento; // Valor numérico del descuento obtenido de la BD
            if (textosDescuento.TryGetValue(descuento, out string textoDescuento))
            {
                // Encontramos el KeyValuePair correspondiente
                var selectedItem = combo_tipo_promo_edit.Items
                    .Cast<KeyValuePair<int, string>>()
                    .FirstOrDefault(x => x.Key == descuento);

                if (!selectedItem.Equals(default(KeyValuePair<int, string>)))
                {
                    combo_tipo_promo_edit.SelectedItem = selectedItem; // Asignamos el KeyValuePair completo
                }
                else
                {
                    MessageBox.Show("No se encontró un elemento coincidente en el ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El valor del descuento no tiene un texto asociado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Asignar los valores de la promoción a los controles del formulario
            txt_nomb_promo_edit.Text = promo.nombre;
            dateTime_inicio_promo_edit.Value = promo.fecha_inicio;
            dateTime_fin_promo_edit.Value = promo.fecha_fin;

            // Establecer si la promoción está activa
            if (promo.activo == 1)
            {
                combo_activo_promo_edit.SelectedItem = "Si";
            }
            else
            {
                combo_activo_promo_edit.SelectedItem = "No";
            }
        }






        private void inicializarDatePickers()
        {
            // Configura las fechas mínimas para los DateTimePicker
            dateTime_inicio_promo_edit.MinDate = DateTime.Now; // No permite elegir fechas pasadas
            dateTime_inicio_promo_edit.Value = DateTime.Now;   // Fecha predeterminada de inicio

            dateTime_fin_promo_edit.MinDate = DateTime.Now.AddDays(1); // Fin debe ser al menos un día después de hoy
            dateTime_fin_promo_edit.Value = DateTime.Now.AddDays(1);   // Fecha predeterminada de fin

            // Configura los valores personalizados de formato
            dateTime_inicio_promo_edit.CustomFormat = " ";
            dateTime_inicio_promo_edit.Format = DateTimePickerFormat.Custom;
            dateTime_inicio_promo_edit.ValueChanged += dateTime_inicio_promo_ValueChanged;

            dateTime_fin_promo_edit.CustomFormat = " ";
            dateTime_fin_promo_edit.Format = DateTimePickerFormat.Custom;
            dateTime_fin_promo_edit.ValueChanged += dateTime_fin_promo_ValueChanged;

        }




        private void cargarComboBoxMarcas()
        {
            // Obtener marcas desde la base de datos
            List<Marca> marcas = MarcaControlador.getAll();

            // Limpiar el ComboBox
            combo_buscar_marca_edit.Items.Clear();

            // Agregar una opción para "todas las marcas"
            combo_buscar_marca_edit.Items.Add(new KeyValuePair<int, string>(0, "Todas las marcas"));

            // Llenar el ComboBox con las marcas
            foreach (Marca marca in marcas)
            {
                combo_buscar_marca_edit.Items.Add(new KeyValuePair<int, string>(marca.id, marca.nombre));
            }

            // Configurar DisplayMember y ValueMember
            combo_buscar_marca_edit.DisplayMember = "Value";
            combo_buscar_marca_edit.ValueMember = "Key";

            // Seleccionar "Todas las Marcas" por defecto
            combo_buscar_marca_edit.SelectedIndex = 0;
        }

        public void cargarComboBoxGeneros()
        {
            // Obtener marcas desde la base de datos
            List<Genero> generos = GeneroControlador.getAll();

            // Limpiar el ComboBox
            combo_buscar_genero_edit.Items.Clear();

            // Agregar una opción para "todos los géneros"
            combo_buscar_genero_edit.Items.Add(new KeyValuePair<int, string>(0, "Todos los géneros"));

            // Llenar el ComboBox con los generos

            foreach (Genero genero in generos)
            {
                combo_buscar_genero_edit.Items.Add(new KeyValuePair<int, string>(genero.id, genero.genero));
            }

            // Configurar DisplayMember y ValueMember
            combo_buscar_genero_edit.DisplayMember = "Value";
            combo_buscar_genero_edit.ValueMember = "Key";

            // Seleccionar "Todos los géneros" por defecto
            combo_buscar_genero_edit.SelectedIndex = 0;
        }




        private void dateTime_inicio_promo_ValueChanged(object sender, EventArgs e)
        {
            // Establece el formato estándar para mostrar la fecha
            dateTime_inicio_promo_edit.Format = DateTimePickerFormat.Short;

            // Establece la nueva fecha mínima para el DateTimePicker de fin
            DateTime nuevaFechaMinima = dateTime_inicio_promo_edit.Value.AddDays(1);
            dateTime_fin_promo_edit.MinDate = nuevaFechaMinima;

            if (dateTime_fin_promo_edit.Value < nuevaFechaMinima)
            {
                MessageBox.Show(
                    "La fecha de fin seleccionada es inválida. Por favor, elija una fecha posterior a la fecha de inicio.",
                    "Fecha inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                // Restablece la fecha de fin a la nueva fecha mínima
                dateTime_fin_promo_edit.Value = nuevaFechaMinima;
            }
        }

        private void dateTime_fin_promo_ValueChanged(object sender, EventArgs e)
        {
            // Establece el formato estándar para mostrar la fecha
            dateTime_fin_promo_edit.Format = DateTimePickerFormat.Short;
        }

        private void cargarPerfumes(int filtroMarcaP = 0, string filtroNombreP = "", int filtroGeneroP = 0)
        {
            List<Perfume> perfumesCompleto = PerfumeControlador.getAll();

            dataGrid_resultado_busqueda_perfumes_edit.Rows.Clear();

            foreach (Perfume perfume in perfumesCompleto)
            {
                // Aplica los filtros dinámicamente

                bool coincideMarca = filtroMarcaP == 0 || perfume.marca.id == filtroMarcaP;

                bool coincideNombre = string.IsNullOrEmpty(filtroNombreP) ||
                            perfume.nombre.IndexOf(filtroNombreP, StringComparison.OrdinalIgnoreCase) >= 0;


                bool coincideGenero = filtroGeneroP == 0 || perfume.genero.id == filtroGeneroP;

                if (coincideNombre && coincideMarca && coincideGenero)

                {
                    int rowIndex = dataGrid_resultado_busqueda_perfumes_edit.Rows.Add();

                    dataGrid_resultado_busqueda_perfumes_edit.Rows[rowIndex].Cells[0].Value = (MarcaControlador.getById(perfume.marca.id)).nombre;
                    dataGrid_resultado_busqueda_perfumes_edit.Rows[rowIndex].Cells[1].Value = perfume.nombre.ToString();
                    dataGrid_resultado_busqueda_perfumes_edit.Rows[rowIndex].Cells[2].Value = perfume.presentacion_ml.ToString();
                    dataGrid_resultado_busqueda_perfumes_edit.Rows[rowIndex].Cells[3].Value = (GeneroControlador.getById(perfume.genero.id)).genero;
                    dataGrid_resultado_busqueda_perfumes_edit.Rows[rowIndex].Cells[5].Value = perfume.id.ToString();

                    //int genero = perfume.genero; // Obtén el id del genero


                    dataGrid_resultado_busqueda_perfumes_edit.Rows[rowIndex].Cells[4].Value = "Agregar";
                }

            }
        }

        private void cargarPerfumesDePromo(List<PerfumeDTO> perfumes)
        {
            try
            {
                // Verificar que la lista de perfumes tiene datos
                if (perfumes != null && perfumes.Count > 0)
                {
                    // Limpiar las filas previas del DataGridView
                    dataGrid_perfumes_agregados_a_promo_edit.Rows.Clear();

                    // Recorrer la lista de perfumes
                    foreach (var perfume in perfumes)
                    {
                        // Crear una nueva fila
                        int rowIndex = dataGrid_perfumes_agregados_a_promo_edit.Rows.Add();

                        // Asignar valores a las celdas de la fila
                        dataGrid_perfumes_agregados_a_promo_edit.Rows[rowIndex].Cells[0].Value = perfume.marca;
                        dataGrid_perfumes_agregados_a_promo_edit.Rows[rowIndex].Cells[1].Value = perfume.nombre;
                        dataGrid_perfumes_agregados_a_promo_edit.Rows[rowIndex].Cells[2].Value = perfume.mililitros;
                        dataGrid_perfumes_agregados_a_promo_edit.Rows[rowIndex].Cells[3].Value = perfume.genero;
                        dataGrid_perfumes_agregados_a_promo_edit.Rows[rowIndex].Cells[4].Value = "Eliminar"; // Texto del botón
                        dataGrid_perfumes_agregados_a_promo_edit.Rows[rowIndex].Cells[5].Value = perfume.id; // ID del perfume
                    }
                }
                else
                {
                    // Si no hay perfumes, mostrar mensaje
                    MessageBox.Show("No se han encontrado perfumes para esta promoción.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los perfumes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_buscar_perfume_x_nombre_TextChanged(object sender, EventArgs e)
        {
            // Obtén los valores de los filtros
            int filtroMarcaP = combo_buscar_marca_edit.SelectedItem != null
              ? ((KeyValuePair<int, string>)combo_buscar_marca_edit.SelectedItem).Key
              : 0; // Si no hay selección, el filtro es 0 (sin filtro)

            string filtroNombreP = txt_buscar_nomb_edit.Text.Trim();

            int filtroGeneroP = combo_buscar_genero_edit.SelectedItem != null
                ? ((KeyValuePair<int, string>)combo_buscar_genero_edit.SelectedItem).Key
                : 0; // Si no hay selección, el filtro es 0 (sin filtro)

            // Actualiza el DataGridView
            cargarPerfumes(filtroMarcaP, filtroNombreP, filtroGeneroP);
        }

        private void comboBox_Marcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ID de la marca seleccionada
            var seleccion = (KeyValuePair<int, string>)combo_buscar_marca_edit.SelectedItem;
            int idMarcaSeleccionada = seleccion.Key;

            // Recargar los perfumes con el filtro de marca
            cargarPerfumes(filtroNombreP: txt_buscar_nomb_edit.Text.Trim(), filtroMarcaP: idMarcaSeleccionada, filtroGeneroP: 0);
        }

        private void combo_genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ID del género seleccionado
            var seleccion = (KeyValuePair<int, string>)combo_buscar_genero_edit.SelectedItem;
            int idGeneroSeleccionado = seleccion.Key;

            // Recargar los perfumes con el filtro de género
            cargarPerfumes(filtroNombreP: txt_buscar_nomb_edit.Text.Trim(), filtroMarcaP: 0, filtroGeneroP: idGeneroSeleccionado);
        }

        private void combo_tipo_promo_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_tipo_promo_edit.SelectedItem != null)
            {
                var selectedItem = (KeyValuePair<int, string>)combo_tipo_promo_edit.SelectedItem;
                int descuentoSeleccionado = selectedItem.Key;
                // Se puede trabajar con el descuentoSeleccionado, como guardarlo en una base de datos o usarlo en la lógica de la aplicación
            }
        }



        /* private void dataGrid_perfumes_agregados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
         {

             // Verifica que la celda clickeada sea la del botón "Eliminar"
             if (e.ColumnIndex == 4 && e.RowIndex >= 0)
             {
                 // Obtener el nombre del perfume desde la fila seleccionada
                 string nombrePerfume = dataGrid_resultado_busqueda_perfumes_edit.Rows[e.RowIndex].Cells[1].Value.ToString();  // Columna 1 es el nombre del perfume
                 string mililitrosPerfume = dataGrid_resultado_busqueda_perfumes_edit.Rows[e.RowIndex].Cells[2].Value.ToString();  // Columna 2 es la cantidad de mililitros

                 // Confirmación de eliminación
                 DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de que deseas eliminar el perfume '{nombrePerfume}'de '{mililitrosPerfume}'ml del listado?",
                     "Confirmar eliminación",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question
                 );

                 if (resultado == DialogResult.Yes)
                 {
                     // Elimina la fila seleccionada del DataGridView
                     dataGrid_resultado_busqueda_perfumes_edit.Rows.RemoveAt(e.RowIndex);
                 }
             }
         }*/


        /*private void btn_recargar_DataGridView_Click(object sender, EventArgs e)
        {
            // Restablecer los filtros a sus valores predeterminados
            combo_buscar_marca_edit.SelectedIndex = 0;  // "Todas las Marcas"
            txt_buscar_nomb_edit.Text = "";             // Nombre vacío
            combo_buscar_genero_edit.SelectedIndex = 0; // "Todos los Géneros"

            // Recargar el DataGridView con todos los perfumes sin aplicar filtros
            cargarPerfumes(0, "", 0);
        }*/

        private void btn_quitar_filtros_Click(object sender, EventArgs e)
        {
            // Restablecer los filtros a sus valores predeterminados
            combo_buscar_marca_edit.SelectedIndex = 0;  // "Todas las Marcas"
            txt_buscar_nomb_edit.Text = "";             // Nombre vacío
            combo_buscar_genero_edit.SelectedIndex = 0; // "Todos los Géneros"

            // Recargar el DataGridView con todos los perfumes sin aplicar filtros
            cargarPerfumes(0, "", 0);
        }

        private void lbl_borrar_texto_Click(object sender, EventArgs e)
        {
            // Borra el texto en el TextBox de filtro por nombre
            txt_buscar_nomb_edit.Text = "";

            // Llama al método de carga de perfumes, manteniendo los filtros actuales de marca y género
            int filtroMarcaP = (combo_buscar_marca_edit.SelectedItem != null)
                ? ((KeyValuePair<int, string>)combo_buscar_marca_edit.SelectedItem).Key
                : 0; // Si no hay selección de marca, se usa el filtro predeterminado (0 = todas las marcas)

            int filtroGeneroP = combo_buscar_genero_edit.SelectedItem != null
                ? ((KeyValuePair<int, string>)combo_buscar_genero_edit.SelectedItem).Key
                : 0; // Si no hay selección de género, se usa el filtro predeterminado (0 = todos los géneros)

            // Llama a cargarPerfumes con los filtros actuales de marca y género, y el filtro de nombre vacío
            cargarPerfumes(filtroMarcaP, "", filtroGeneroP);
        }

        private void btn_x_cerrar_ventana_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }

        private void btn_agregar_todos_edit_Click(object sender, EventArgs e)
        {
            // Iterar por todas las filas del dataGrid_resultado_busqueda_perfumes
            foreach (DataGridViewRow sourceRow in dataGrid_resultado_busqueda_perfumes_edit.Rows)
            {
                // Obtener el ID del perfume de la fila actual
                int idPerfume = Convert.ToInt32(sourceRow.Cells[5].Value);

                // Verificar si el perfume ya está en el dataGrid_perfumes_agregados_a_promo
                bool perfumeYaAgregado = false;
                foreach (DataGridViewRow targetRow in dataGrid_perfumes_agregados_a_promo_edit.Rows)
                {
                    if (Convert.ToInt32(targetRow.Cells[5].Value) == idPerfume)
                    {
                        perfumeYaAgregado = true;
                        break; // Si el perfume ya está agregado, no seguimos buscando
                    }
                }

                // Si el perfume no está agregado, lo agregamos al dataGrid_perfumes_agregados_a_promo
                if (!perfumeYaAgregado)
                {
                    int newRowIndex = dataGrid_perfumes_agregados_a_promo_edit.Rows.Add();
                    dataGrid_perfumes_agregados_a_promo_edit.Rows[newRowIndex].Cells[0].Value = sourceRow.Cells[0].Value;
                    dataGrid_perfumes_agregados_a_promo_edit.Rows[newRowIndex].Cells[1].Value = sourceRow.Cells[1].Value;
                    dataGrid_perfumes_agregados_a_promo_edit.Rows[newRowIndex].Cells[2].Value = sourceRow.Cells[2].Value;
                    dataGrid_perfumes_agregados_a_promo_edit.Rows[newRowIndex].Cells[3].Value = sourceRow.Cells[3].Value;
                    dataGrid_perfumes_agregados_a_promo_edit.Rows[newRowIndex].Cells[4].Value = "Elimninar";
                    dataGrid_perfumes_agregados_a_promo_edit.Rows[newRowIndex].Cells[5].Value = idPerfume;
                }
            }

            // Mostrar un mensaje al final del proceso
            MessageBox.Show("Todos los perfumes han sido agregados correctamente (excepto los duplicados).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_editar_promo_Click(object sender, EventArgs e)
        {
            string errorMsg;
            if (validarPromoEdit(out errorMsg))
            {
                editarPromo();
            }
            else
            {

            }
          
        }

        private void limpiarMensajesErrorEdit()
        {
            lbl_error_tipo_promo_edit.Visible = false;
            lbl_error_nomb_edit.Visible = false;
            lbl_error_fecha_ini_edit.Visible = false;
            lbl_error_fecha_fin_edit.Visible = false;
            lbl_error_promo_act_edit.Visible = false;

        }

        private bool validarPromoEdit(out string errorMsg)
        {
            errorMsg = "";
            limpiarMensajesErrorEdit();

            if (combo_tipo_promo_edit.SelectedItem == null || string.IsNullOrEmpty(combo_tipo_promo_edit.Text))
            {
                errorMsg += "Debes seleccionar el tipo de promoción" + Environment.NewLine;
                lbl_error_tipo_promo_edit.Text = "Debes seleccionar el tipo de promoción";
                lbl_error_tipo_promo_edit.Show();
            }
            else
            {
                lbl_error_tipo_promo_edit.Visible = false;
            }

            if (string.IsNullOrEmpty(txt_nomb_promo_edit.Text))
            {
                errorMsg += "Debes ingresar el nombre de la promoción" + Environment.NewLine;
                lbl_error_nomb_edit.Text = "Debes ingresar el nombre de la promoción";
                lbl_error_nomb_edit.Show();

            }
            else if (txt_nomb_promo_edit.Text.Length > 80)
            {
                errorMsg += "El nombre no puede exceder los 80 caracteres" + Environment.NewLine;
                lbl_error_nomb_edit.Text = "El nombre no puede exceder los 80 caracteres";
                lbl_error_nomb_edit.Show();
            }
            else
            {

                lbl_error_nomb_edit.Visible = false;

            }

          

            // Validación de la fecha de inicio
            if (dateTime_inicio_promo_edit.Format == DateTimePickerFormat.Custom && dateTime_inicio_promo_edit.CustomFormat == " ")
            {
                errorMsg += "Debes seleccionar una fecha de inicio para la promoción" + Environment.NewLine;
                lbl_error_fecha_ini_edit.Text = "Debes seleccionar una fecha de inicio";
                lbl_error_fecha_ini_edit.Show();
            }
            else
            {
                lbl_error_fecha_ini_edit.Visible = false;
            }

            // Validación de la fecha de finalización
            if (dateTime_fin_promo_edit.Format == DateTimePickerFormat.Custom && dateTime_fin_promo_edit.CustomFormat == " ")
            {
                errorMsg += "Debes seleccionar una fecha de finalización para la promoción" + Environment.NewLine;
                lbl_error_fecha_fin_edit.Text = "Debes seleccionar una fecha de finalización";
                lbl_error_fecha_fin_edit.Show();
            }
            else if (dateTime_fin_promo_edit.Value <= dateTime_inicio_promo_edit.Value)
            {
                errorMsg += "La fecha de finalización debe ser posterior a la fecha de inicio" + Environment.NewLine;
                lbl_error_fecha_fin_edit.Text = "La fecha de finalización debe ser posterior a la fecha de inicio";
                lbl_error_fecha_fin_edit.Show();
            }
            else
            {
                lbl_error_fecha_fin_edit.Visible = false;
            }

            if (combo_activo_promo_edit.SelectedItem == null || string.IsNullOrEmpty(combo_activo_promo_edit.Text))
            {
                errorMsg += "Debes seleccionar si la promoción está activa" + Environment.NewLine;
                lbl_error_promo_act_edit.Text = "Debes seleccionar si la promoción está activa";
                lbl_error_promo_act_edit.Show();
            }
            else
            {
                lbl_error_promo_act_edit.Show();
                lbl_error_promo_act_edit.Show();
                lbl_error_promo_act_edit.Show();
                lbl_error_promo_act_edit.Visible = false;
            }


            // Devolver si hay errores o no
            return string.IsNullOrEmpty(errorMsg);
        }


        private void editarPromo()
        {
            // ID de la promoción que se está editando
            int idPromo = id_editar;

            // Obtener la clave del descuento seleccionada (clave del diccionario)
            var seleccionTipoPromo = (KeyValuePair<int, string>)combo_tipo_promo_edit.SelectedItem;
            int descuentoClave = seleccionTipoPromo.Key; // La clave que se debe guardar en la base de datos

            // Obtener el valor de "Activo" (1 si está activo, 0 si no)
            int activo = combo_activo_promo_edit.SelectedIndex == 0 ? 1 : 0; // 0 = No activo, 1 = Activo


            // Confirmar con el usuario
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas editar esta promoción?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No)
                return;

            //Se crea el objeto de la promoción a editar

            Promocion promoEditada = new Promocion(id_editar, txt_nomb_promo_edit.Text, dateTime_inicio_promo_edit.Value, dateTime_fin_promo_edit.Value, descuentoClave, activo);

            if (PromoControlador.editarPromo(promoEditada))
            {
                this.DialogResult = DialogResult.OK;
            }

            PromoControlador.editarPromo(promoEditada);
            agregarPerfumesAPromocion();
            limpiarFormulario(); // Limpiar los controles después de crear la promoción*/


        }

            /*  try
            {
                DB_Controller.connection.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    list.Add(new Promocion(r.GetInt32(0), r.GetString(1), r.GetDateTime(2), r.GetDateTime(3), r.GetInt32(4), r.GetInt32(5)));

                }
                r.Close();
                DB_Controller.connection.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Hay un error en la query: " + e.Message);
            }
            return list;

        }*/

            // Conexión a la base de datos

            //eliminarRegistrosPromoPerfumes(int id_promo)

            /* using (SqlConnection connection = new SqlConnection(DB_Controller.connectionString))
             {
                 connection.Open();
                 SqlTransaction transaction = connection.BeginTransaction();

                 try
                 {
                     // 1. Borrar registros de perfumes_en_promo para la promoción actual
                     string deleteQuery = "DELETE FROM dbo.perfumes_en_promo WHERE promocion_id = @id_editar";
                     using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection, transaction))
                     {
                         deleteCmd.Parameters.AddWithValue("@id_editar", id_editar);
                         deleteCmd.ExecuteNonQuery();
                     }*/






            /* 2. Actualizar los datos de la promoción en dbo.promocion
            string updateQuery = @"
                UPDATE dbo.promocion
                SET nombre = @nombre,
                    fecha_inicio = @fechaInicio,
                    fecha_fin = @fechaFin,
                    descuento = @descuento,
                    activo = @activo
                WHERE id = @id_editar";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@nombre", txt_nomb_promo_edit.Text);
                        updateCmd.Parameters.AddWithValue("@fechaInicio", dateTime_inicio_promo_edit.Value);
                        updateCmd.Parameters.AddWithValue("@fechaFin", dateTime_fin_promo_edit.Value);
                        updateCmd.Parameters.AddWithValue("@descuento", descuentoClave);
                        updateCmd.Parameters.AddWithValue("@activo", activo); // 1 para activo, 0 para no activo
                        updateCmd.Parameters.AddWithValue("@id_editar", id_editar);
                        updateCmd.ExecuteNonQuery();
                    }

           // 3. Insertar los perfumes de dataGrid_perfumes_agregados_a_promo_edit en dbo.perfumes_en_promo
            string insertQuery = @"
                INSERT INTO dbo.perfumes_en_promo (perfume_id, promocion_id)
                VALUES (@perfumeId, @promoId)";
            using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection, transaction))
            {
                foreach (DataGridViewRow row in dataGrid_perfumes_agregados_a_promo_edit.Rows)
                {
                    if (!row.IsNewRow) // Ignorar filas vacías
                    {
                        int perfumeId = Convert.ToInt32(row.Cells[5].Value); // Suponiendo que la columna "Id" contiene el perfume_id
                        insertCmd.Parameters.Clear();
                        insertCmd.Parameters.AddWithValue("@perfumeId", perfumeId);
                        insertCmd.Parameters.AddWithValue("@promoId", id_editar);
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
        }
                    Confirmar la transacción
                    transaction.Commit();
                    MessageBox.Show("Promoción editada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    // Revertir la transacción en caso de error
                    transaction.Rollback();
                    MessageBox.Show($"Error al editar la promoción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            limpiarFormulario(); // Limpiar los controles después de crear la promoción*/


            private void agregarPerfumesAPromocion()
        {
            // Crear una lista para almacenar los IDs de los perfumes
            List<int> perfumeIds = new List<int>();

            // Recorrer las filas del DataGridView para extraer los IDs de perfumes
            foreach (DataGridViewRow row in dataGrid_perfumes_agregados_a_promo_edit.Rows)
            {
                if (!row.IsNewRow) // Ignorar filas vacías
                {
                    int perfumeId = Convert.ToInt32(row.Cells[5].Value); // Suponiendo que la columna "Id" contiene el perfume_id
                    perfumeIds.Add(perfumeId);
                }
            }

            // Llamar al método del controlador para insertar los registros
            try
            {
                if (PromoControlador.agregarRegistrosPromoPerfumes(id_editar, perfumeIds))
                {
                    MessageBox.Show("Registros de perfumes agregados exitosamente a la promoción.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar los perfumes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarFormulario()
        {
            combo_tipo_promo_edit.SelectedIndex = -1; // Deseleccionar tipo de promoción
            txt_nomb_promo_edit.Clear(); // Limpiar nombre
            /*// Limpia fecha de inicio
            dateTime_inicio_promo.CustomFormat = " ";
            dateTime_inicio_promo.Format = DateTimePickerFormat.Custom;
            // Limpia fecha de fin
            dateTime_fin_promo.CustomFormat = " ";
            dateTime_fin_promo.Format = DateTimePickerFormat.Custom;*/
            combo_activo_promo_edit.SelectedIndex = -1; // Para que el combo_box vuelva a quedar vacío
            inicializarDatePickers();
        }

        private void dataGrid_perfumes_agregados_a_promo_edit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que la celda clickeada sea la del botón "Eliminar"
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                // Obtener el nombre del perfume desde la fila seleccionada
                string nombrePerfume = dataGrid_perfumes_agregados_a_promo_edit.Rows[e.RowIndex].Cells[1].Value.ToString();  // Columna 1 es el nombre del perfume
                string mililitrosPerfume = dataGrid_perfumes_agregados_a_promo_edit.Rows[e.RowIndex].Cells[2].Value.ToString();  // Columna 2 es la cantidad de mililitros

                // Confirmación de eliminación
                DialogResult resultado = MessageBox.Show(
                   $"¿Estás seguro de que deseas eliminar el perfume '{nombrePerfume}'de '{mililitrosPerfume}'ml del listado?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    // Elimina la fila seleccionada del DataGridView
                    dataGrid_perfumes_agregados_a_promo_edit.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btn_eliminar_todos_edit_Click(object sender, EventArgs e)
        {
            // Confirmar la acción con el usuario
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar todos los perfumes agregados?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                // Realiza un respaldo de las filas actuales
                backupRows.Clear(); // Limpiar el respaldo anterior
                foreach (DataGridViewRow row in dataGrid_perfumes_agregados_a_promo_edit.Rows)
                {
                    // Agregar la fila al respaldo (asegurarse de no agregar filas vacías)
                    if (!row.IsNewRow)
                    {
                        backupRows.Add(row);
                    }
                }

                // Elimina todas las filas del DataGridView
                dataGrid_perfumes_agregados_a_promo_edit.Rows.Clear();

                MessageBox.Show("Todos los perfumes han sido eliminados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btrn_deshacer_eliminacion_edit_Click(object sender, EventArgs e)
        {
            if (backupRows.Count == 0)
            {
                MessageBox.Show("No hay datos para deshacer la eliminación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Restaurar las filas del respaldo al DataGridView
            foreach (DataGridViewRow row in backupRows)
            {
                int rowIndex = dataGrid_perfumes_agregados_a_promo_edit.Rows.Add();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dataGrid_perfumes_agregados_a_promo_edit.Rows[rowIndex].Cells[i].Value = row.Cells[i].Value;
                }
            }
        }

        private void dataGrid_resultado_busqueda_perfumes_edit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la columna sea la del botón "Agregar" (por ejemplo, la última columna)
            if (e.ColumnIndex == dataGrid_resultado_busqueda_perfumes_edit.Columns[4].Index && e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow selectedRow = dataGrid_resultado_busqueda_perfumes_edit.Rows[e.RowIndex];
                int idPerfume = Convert.ToInt32(selectedRow.Cells[5].Value);

                // Verificar si el perfume ya está en el dataGrid_perfumes_agregados_a_promo
                foreach (DataGridViewRow row in dataGrid_perfumes_agregados_a_promo_edit.Rows)
                {
                    if (Convert.ToInt32(row.Cells[5].Value) == idPerfume)
                    {
                        MessageBox.Show("El perfume ya ha sido agregado a la promoción.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                // Si no está repetido, agregarlo al dataGrid_perfumes_agregados_a_promo
                int newRowIndex = dataGrid_perfumes_agregados_a_promo_edit.Rows.Add();
                dataGrid_perfumes_agregados_a_promo_edit.Rows[newRowIndex].Cells[0].Value = selectedRow.Cells[0].Value;
                dataGrid_perfumes_agregados_a_promo_edit.Rows[newRowIndex].Cells[1].Value = selectedRow.Cells[1].Value;
                dataGrid_perfumes_agregados_a_promo_edit.Rows[newRowIndex].Cells[2].Value = selectedRow.Cells[2].Value;
                dataGrid_perfumes_agregados_a_promo_edit.Rows[newRowIndex].Cells[3].Value = selectedRow.Cells[3].Value;
                dataGrid_perfumes_agregados_a_promo_edit.Rows[newRowIndex].Cells[4].Value = "Elimninar";
                dataGrid_perfumes_agregados_a_promo_edit.Rows[newRowIndex].Cells[5].Value = idPerfume;

                MessageBox.Show("Perfume agregado correctamente a la promoción.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }


}
