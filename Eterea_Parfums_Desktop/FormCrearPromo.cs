using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.ControlesDeUsuario;
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
    public partial class FormCrearPromo : Form
    {
        Dictionary<int, string> textosDescuento = new Dictionary<int, string>
        {
            { 50, "2 x 1" },
            { 40, "2da Unidad 80% Dto." },
            { 35, "2da Unidad 70% Dto." },
            { 25, "2da Unidad 50% Dto." },
            { 10, "Descuento especial del 10%" }
        };

        private List<DataGridViewRow> backupRows = new List<DataGridViewRow>();

        public FormCrearPromo()
        {
           
            InitializeComponent();
            lbl_error_tipo_promo.Visible = false;
            lbl_error_nombP.Visible = false;
            lbl_error_fecha_iniP.Visible = false;
            lbl_error_fecha_finP.Visible = false;
            lbl_error_promo_act.Visible = false;

            cargarComboBoxDescuentos();
            cargarComboBoxMarcas();
            cargarComboBoxGeneros();
            inicializarDatePickers();
            cargarPerfumes();

            combo_activo_promo.Items.Clear();
            combo_activo_promo.Items.Add("Si");
            combo_activo_promo.Items.Add("No");
            combo_activo_promo.SelectedIndex = -1;
        }

     

        private void inicializarDatePickers()
        {
            /*  // Configura valores iniciales de los DateTimePicker
              dateTime_inicio_promo.Value = DateTime.Now; // Fecha predeterminada de inicio
              dateTime_inicio_promo.MinDate = DateTime.Now; // No permite elegir fechas pasadas
              dateTime_fin_promo.MinDate = DateTime.Now.AddDays(1); // Fin debe ser al menos un día después de hoy
              dateTime_fin_promo.Value = DateTime.Now.AddDays(1); // Fecha predeterminada de fin 
            dateTime_inicio_promo.CustomFormat = " ";
            dateTime_inicio_promo.Format = DateTimePickerFormat.Custom;
            dateTime_inicio_promo.ValueChanged += dateTime_inicio_promo_ValueChanged;

            dateTime_fin_promo.CustomFormat = " ";
            dateTime_fin_promo.Format = DateTimePickerFormat.Custom;
            dateTime_fin_promo.ValueChanged += dateTime_fin_promo_ValueChanged; */

            // Configura las fechas mínimas para los DateTimePicker
            dateTime_inicio_promo.MinDate = DateTime.Now; // No permite elegir fechas pasadas
            dateTime_inicio_promo.Value = DateTime.Now;   // Fecha predeterminada de inicio

            dateTime_fin_promo.MinDate = DateTime.Now.AddDays(1); // Fin debe ser al menos un día después de hoy
            dateTime_fin_promo.Value = DateTime.Now.AddDays(1);   // Fecha predeterminada de fin

            // Configura los valores personalizados de formato
            dateTime_inicio_promo.CustomFormat = " ";
            dateTime_inicio_promo.Format = DateTimePickerFormat.Custom;
            dateTime_inicio_promo.ValueChanged += dateTime_inicio_promo_ValueChanged;

            dateTime_fin_promo.CustomFormat = " ";
            dateTime_fin_promo.Format = DateTimePickerFormat.Custom;
            dateTime_fin_promo.ValueChanged += dateTime_fin_promo_ValueChanged;
        }
    

        public void cargarComboBoxDescuentos()
        {
            combo_tipo_promo.Items.Clear(); // Limpia cualquier ítem anterior
            foreach (var item in textosDescuento)
            {
                combo_tipo_promo.Items.Add(new KeyValuePair<int, string>(item.Key, item.Value));
            }

            combo_tipo_promo.DisplayMember = "Value"; // Texto visible
            combo_tipo_promo.ValueMember = "Key";    // Valor asociado

           
        }

        private void cargarComboBoxMarcas()
        {
            // Obtener marcas desde la base de datos
            List<Marca> marcas = MarcaControlador.getAll();

            // Limpiar el ComboBox
            combo_buscar_marcaP.Items.Clear();

            // Agregar una opción para "todas las marcas"
            combo_buscar_marcaP.Items.Add(new KeyValuePair<int, string>(0, "Todas las marcas"));

            // Llenar el ComboBox con las marcas
            foreach (Marca marca in marcas)
            {
                combo_buscar_marcaP.Items.Add(new KeyValuePair<int, string>(marca.id, marca.nombre));
            }

            // Configurar DisplayMember y ValueMember
            combo_buscar_marcaP.DisplayMember = "Value";
            combo_buscar_marcaP.ValueMember = "Key";

            // Seleccionar "Todas las Marcas" por defecto
            combo_buscar_marcaP.SelectedIndex = 0;
        }

        public void cargarComboBoxGeneros()
        {
            // Obtener marcas desde la base de datos
            List<Genero> generos = GeneroControlador.getAll();

            // Limpiar el ComboBox
            combo_buscar_generoP.Items.Clear();

            // Agregar una opción para "todos los géneros"
            combo_buscar_generoP.Items.Add(new KeyValuePair<int, string>(0, "Todos los géneros"));

            // Llenar el ComboBox con los generos

            foreach (Genero genero in generos)
            {
                combo_buscar_generoP.Items.Add(new KeyValuePair<int, string>(genero.id, genero.genero));
            }

            // Configurar DisplayMember y ValueMember
            combo_buscar_generoP.DisplayMember = "Value"; 
            combo_buscar_generoP.ValueMember = "Key";   

            // Seleccionar "Todos los géneros" por defecto
            combo_buscar_generoP.SelectedIndex = 0;
        }

    


        private void dateTime_inicio_promo_ValueChanged(object sender, EventArgs e)
        {
            /*  // Establece la nueva fecha mínima para dateTime_fin_promo
              DateTime nuevaFechaMinima = dateTime_inicio_promo.Value.AddDays(1);
              dateTime_fin_promo.MinDate = nuevaFechaMinima;

              // Si la fecha de fin actual es menor a la nueva fecha mínima
              if (dateTime_fin_promo.Value < nuevaFechaMinima)
              {
                  MessageBox.Show(
                      "La fecha de fin seleccionada es inválida. Por favor, elija una fecha posterior a la fecha de inicio.",
                      "Fecha inválida",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
                  );

                  // Restablece la fecha de fin a la nueva fecha mínima
                  dateTime_fin_promo.Value = nuevaFechaMinima;
              }*/
            // Establece el formato estándar para mostrar la fecha
            dateTime_inicio_promo.Format = DateTimePickerFormat.Short;

            // Establece la nueva fecha mínima para el DateTimePicker de fin
            DateTime nuevaFechaMinima = dateTime_inicio_promo.Value.AddDays(1);
            dateTime_fin_promo.MinDate = nuevaFechaMinima;

            if (dateTime_fin_promo.Value < nuevaFechaMinima)
            {
                MessageBox.Show(
                    "La fecha de fin seleccionada es inválida. Por favor, elija una fecha posterior a la fecha de inicio.",
                    "Fecha inválida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                // Restablece la fecha de fin a la nueva fecha mínima
                dateTime_fin_promo.Value = nuevaFechaMinima;
            }
        }

        private void dateTime_fin_promo_ValueChanged(object sender, EventArgs e)
        {
            /*  // Comprueba si la fecha de fin es válida
              if (dateTime_fin_promo.Value <= dateTime_inicio_promo.Value)
              {
                  MessageBox.Show(
                      "La fecha de fin debe ser posterior a la fecha de inicio. Por favor, seleccione una fecha válida.",
                      "Advertencia de Fecha",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
                  );

                  // Restablece la fecha de fin a una fecha válida
                  dateTime_fin_promo.Value = dateTime_inicio_promo.Value.AddDays(1);
              }*/
            // Establece el formato estándar para mostrar la fecha
            dateTime_fin_promo.Format = DateTimePickerFormat.Short;
        }

        private void cargarPerfumes(int filtroMarcaP = 0, string filtroNombreP = "", int filtroGeneroP = 0)
            {
            List<Perfume> perfumes = PerfumeControlador.getAll();

            dataGrid_resultado_busqueda_perfumes.Rows.Clear();

                foreach (Perfume perfume in perfumes)
                {
                // Aplica los filtros dinámicamente

                bool coincideMarca = filtroMarcaP == 0 || perfume.marca.id == filtroMarcaP;

                bool coincideNombre = string.IsNullOrEmpty(filtroNombreP) ||
                            perfume.nombre.IndexOf(filtroNombreP, StringComparison.OrdinalIgnoreCase) >= 0;


                bool coincideGenero = filtroGeneroP == 0 || perfume.genero.id == filtroGeneroP;

                if (coincideNombre && coincideMarca && coincideGenero)

                {
                        int rowIndex = dataGrid_resultado_busqueda_perfumes.Rows.Add();

                        dataGrid_resultado_busqueda_perfumes.Rows[rowIndex].Cells[0].Value = (MarcaControlador.getById(perfume.marca.id)).nombre;
                        dataGrid_resultado_busqueda_perfumes.Rows[rowIndex].Cells[1].Value = perfume.nombre.ToString();
                        dataGrid_resultado_busqueda_perfumes.Rows[rowIndex].Cells[2].Value = perfume.presentacion_ml.ToString();
                        dataGrid_resultado_busqueda_perfumes.Rows[rowIndex].Cells[3].Value = (GeneroControlador.getById(perfume.genero.id)).genero;
                        dataGrid_resultado_busqueda_perfumes.Rows[rowIndex].Cells[5].Value = perfume.id.ToString();

                    //int genero = perfume.genero; // Obtén el id del genero


                    dataGrid_resultado_busqueda_perfumes.Rows[rowIndex].Cells[4].Value = "Agregar";
                    }

                }
            }

        private void txt_buscar_perfume_x_nombre_TextChanged(object sender, EventArgs e)
        {
            // Obtén los valores de los filtros
            int filtroMarcaP = combo_buscar_marcaP.SelectedItem != null
              ? ((KeyValuePair<int, string>)combo_buscar_marcaP.SelectedItem).Key
              : 0; // Si no hay selección, el filtro es 0 (sin filtro)

            string filtroNombreP = txt_buscar_nombP.Text.Trim();        
            
            int filtroGeneroP = combo_buscar_generoP.SelectedItem != null
                ? ((KeyValuePair<int, string>) combo_buscar_generoP.SelectedItem).Key
                : 0; // Si no hay selección, el filtro es 0 (sin filtro)

            // Actualiza el DataGridView
            cargarPerfumes(filtroMarcaP, filtroNombreP, filtroGeneroP);
        }

        private void comboBox_Marcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ID de la marca seleccionada
            var seleccion = (KeyValuePair<int, string>)combo_buscar_marcaP.SelectedItem;
            int idMarcaSeleccionada = seleccion.Key;

            // Recargar los perfumes con el filtro de marca
            cargarPerfumes(filtroNombreP: txt_buscar_nombP.Text.Trim(), filtroMarcaP: idMarcaSeleccionada, filtroGeneroP: 0);
        }

        private void combo_genero_SelectedIndexChanged(object sender, EventArgs e)
        {  
            // Obtener el ID del género seleccionado
            var seleccion = (KeyValuePair<int, string>)combo_buscar_generoP.SelectedItem;
            int idGeneroSeleccionado = seleccion.Key;

            // Recargar los perfumes con el filtro de género
            cargarPerfumes(filtroNombreP: txt_buscar_nombP.Text.Trim(), filtroMarcaP: 0, filtroGeneroP: idGeneroSeleccionado);
        }

        private void combo_tipo_promo_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_tipo_promo.SelectedItem != null)
            {
                var selectedItem = (KeyValuePair<int, string>)combo_tipo_promo.SelectedItem;
                int descuentoSeleccionado = selectedItem.Key;
                // Aquí puedes trabajar con el descuentoSeleccionado, como guardarlo en una base de datos o usarlo en la lógica de tu aplicación
            }
        }

        private void dataGrid_perfumes_agregados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verificar que la columna sea la del botón "Agregar" (por ejemplo, la última columna)
            if (e.ColumnIndex == dataGrid_resultado_busqueda_perfumes.Columns["Agregar"].Index && e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow selectedRow = dataGrid_resultado_busqueda_perfumes.Rows[e.RowIndex];
                int idPerfume = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Verificar si el perfume ya está en el dataGrid_perfumes_agregados_a_promo
                foreach (DataGridViewRow row in dataGrid_perfumes_agregados_a_promo.Rows)
                {
                    if (Convert.ToInt32(row.Cells["IdOK"].Value) == idPerfume)
                    {
                        MessageBox.Show("El perfume ya ha sido agregado a la promoción.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                // Si no está repetido, agregarlo al dataGrid_perfumes_agregados_a_promo
                int newRowIndex = dataGrid_perfumes_agregados_a_promo.Rows.Add();
                dataGrid_perfumes_agregados_a_promo.Rows[newRowIndex].Cells[0].Value = selectedRow.Cells[0].Value;
                dataGrid_perfumes_agregados_a_promo.Rows[newRowIndex].Cells[1].Value = selectedRow.Cells[1].Value;
                dataGrid_perfumes_agregados_a_promo.Rows[newRowIndex].Cells[2].Value = selectedRow.Cells[2].Value;
                dataGrid_perfumes_agregados_a_promo.Rows[newRowIndex].Cells[3].Value = selectedRow.Cells[3].Value;
                dataGrid_perfumes_agregados_a_promo.Rows[newRowIndex].Cells[4].Value = "Elimninar";
                dataGrid_perfumes_agregados_a_promo.Rows[newRowIndex].Cells[5].Value = idPerfume;

                MessageBox.Show("Perfume agregado correctamente a la promoción.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lbl_borrar_texto_Click(object sender, EventArgs e)
        {
            // Borra el texto en el TextBox de filtro por nombre
            txt_buscar_nombP.Text = "";

            // Llama al método de carga de perfumes, manteniendo los filtros actuales de marca y género
            int filtroMarcaP = (combo_buscar_marcaP.SelectedItem != null)
                ? ((KeyValuePair<int, string>)combo_buscar_marcaP.SelectedItem).Key
                : 0; // Si no hay selección de marca, se usa el filtro predeterminado (0 = todas las marcas)

            int filtroGeneroP = combo_buscar_generoP.SelectedItem != null
                ? ((KeyValuePair<int, string>)combo_buscar_generoP.SelectedItem).Key
                : 0; // Si no hay selección de género, se usa el filtro predeterminado (0 = todos los géneros)

            // Llama a cargarPerfumes con los filtros actuales de marca y género, y el filtro de nombre vacío
            cargarPerfumes(filtroMarcaP, "", filtroGeneroP);
        }

        private void btn_quitar_filtros_Click(object sender, EventArgs e)
        {
            // Restablecer los filtros a sus valores predeterminados
            combo_buscar_marcaP.SelectedIndex = 0;  // "Todas las Marcas"
            txt_buscar_nombP.Text = "";             // Nombre vacío
            combo_buscar_generoP.SelectedIndex = 0; // "Todos los Géneros"

            // Recargar el DataGridView con todos los perfumes sin aplicar filtros
            cargarPerfumes(0, "", 0);
        }

        private void limpiarMensajesError()
        {
            lbl_error_tipo_promo.Visible = false;
            lbl_error_nombP.Visible = false;
            lbl_error_fecha_iniP.Visible = false;
            lbl_error_fecha_finP.Visible = false;
            lbl_error_promo_act.Visible = false;

        }

        private bool validarPromo(out string errorMsg)
        {
            errorMsg = "";
            limpiarMensajesError();

            if (combo_tipo_promo.SelectedItem == null || string.IsNullOrEmpty(combo_tipo_promo.Text))
            {
                errorMsg += "Debes seleccionar el tipo de promoción" + Environment.NewLine;
                lbl_error_tipo_promo.Text = "Debes seleccionar el tipo de promoción";
                lbl_error_tipo_promo.Show();
            }
            else
            {
                lbl_error_tipo_promo.Visible = false;
            }

            if (string.IsNullOrEmpty(txt_nomb_promo.Text))
            {
                errorMsg += "Debes ingresar el nombre de la promoción" + Environment.NewLine;
                lbl_error_nombP.Text = "Debes ingresar el nombre de la promoción";
                lbl_error_nombP.Show();

            }
            else if (txt_nomb_promo.Text.Length > 80)
            {
                errorMsg += "El nombre no puede exceder los 80 caracteres" + Environment.NewLine;
                lbl_error_nombP.Text = "El nombre no puede exceder los 80 caracteres";
                lbl_error_nombP.Show();
            }
            else
            {

                lbl_error_nombP.Visible = false;

            }

            /*// Validar la fecha de inicio de la promoción
            if (dateTime_inicio_promo.Value.Date < DateTime.Now.Date)
            {
                errorMsg += "La fecha de inicio no puede ser anterior a la fecha actual" + Environment.NewLine;
                lbl_error_fecha_iniP.Text = "La fecha de inicio no puede ser anterior a la fecha actual";
                lbl_error_fecha_iniP.Show();
            }
            else
            {
                lbl_error_fecha_iniP.Visible = false;
            }

            // Validar la fecha de finalización de la promoción
            if (dateTime_fin_promo.Value.Date <= dateTime_inicio_promo.Value.Date)
            {
                errorMsg += "La fecha de finalización debe ser posterior a la fecha de inicio" + Environment.NewLine;
                lbl_error_fecha_finP.Text = "La fecha de finalización debe ser posterior a la fecha de inicio";
                lbl_error_fecha_finP.Show();
            }
            else
            {
                lbl_error_fecha_finP.Visible = false;
            }*/

            // Validación de la fecha de inicio
            if (dateTime_inicio_promo.Format == DateTimePickerFormat.Custom && dateTime_inicio_promo.CustomFormat == " ")
            {
                errorMsg += "Debes seleccionar una fecha de inicio para la promoción" + Environment.NewLine;
                lbl_error_fecha_iniP.Text = "Debes seleccionar una fecha de inicio";
                lbl_error_fecha_iniP.Show();
            }
            else
            {
                lbl_error_fecha_iniP.Visible = false;
            }

            // Validación de la fecha de finalización
            if (dateTime_fin_promo.Format == DateTimePickerFormat.Custom && dateTime_fin_promo.CustomFormat == " ")
            {
                errorMsg += "Debes seleccionar una fecha de finalización para la promoción" + Environment.NewLine;
                lbl_error_fecha_finP.Text = "Debes seleccionar una fecha de finalización";
                lbl_error_fecha_finP.Show();
            }
            else if (dateTime_fin_promo.Value <= dateTime_inicio_promo.Value)
            {
                errorMsg += "La fecha de finalización debe ser posterior a la fecha de inicio" + Environment.NewLine;
                lbl_error_fecha_finP.Text = "La fecha de finalización debe ser posterior a la fecha de inicio";
                lbl_error_fecha_finP.Show();
            }
            else
            {
                lbl_error_fecha_finP.Visible = false;
            }

            if (combo_activo_promo.SelectedItem == null || string.IsNullOrEmpty(combo_activo_promo.Text))
            {
                errorMsg += "Debes seleccionar si la promoción está activa" + Environment.NewLine;
                lbl_error_promo_act.Text = "Debes seleccionar si la promoción está activa";
                lbl_error_promo_act.Show();
            }
            else
            {
                lbl_error_promo_act.Visible = false;
            }


            // Devolver si hay errores o no
            return string.IsNullOrEmpty(errorMsg);
        }

        /*if (string.IsNullOrEmpty(txt_sku.Text))
        {
            errorMsg += "Debes ingresar el codigo SKU" + Environment.NewLine;
            lbl_error_sku.Text = "Debes ingresar el codigo SKU";
            lbl_error_sku.Show();
        }
        else if (txt_sku.Text.Length != 28)
        {
            errorMsg += "El codigo SKU debe tener 28 caracteres (incluidos los guiones)" + Environment.NewLine;
            lbl_error_sku.Text = "El codigo SKU debe tener 28 caracteres (incluidos los guiones)";
            lbl_error_sku.Show();
        }
        else
        {
            {
                // Definiendo el patrón regex para el formato deseado
                string patron = @"^[0-9]{3}-[A-Za-z]{1}-[0-9]{5}[A-Za-z]{2}-[0-9]{2}-[0-9]{2}-[A-Za-z]{3}-[0-9]{4}$";

                // Crear una instancia de Regex y verificar si el input coincide con el patrón
                Regex regex = new Regex(patron);
                if (regex.IsMatch(txt_sku.Text))
                {
                    lbl_error_sku.Visible = false;
                }
                else
                {
                    errorMsg += "Debe seguir este patron:'NNN-L-NNNNNLL-NN-NN-LLL-NNNN'(N=número y L=letra. Incluidos los guiones)" + Environment.NewLine;
                    lbl_error_sku.Text = "Debe seguir este patron: NNN-L-NNNNNLL-NN-NN-LLL-NNNN (donde N = número y L = letra. Incluidos los guiones)";
                    lbl_error_sku.Show();
                }


            }
        }
        if (combo_marca.SelectedItem == null || string.IsNullOrEmpty(combo_marca.Text))
        {
            errorMsg += "Debes seleccionar la marca del perfume" + Environment.NewLine;
            lbl_error_marca.Text = "Debes seleccionar la marca del perfume";
            lbl_error_marca.Show();
        }
        else
        {
            lbl_error_marca.Visible = false;
        }


        if (string.IsNullOrEmpty(txt_nombre.Text))
        {
            errorMsg += "Debes ingresar el nombre del perfume" + Environment.NewLine;
            lbl_error_nombre.Text = "Debes ingresar el nombre del perfume";
            lbl_error_nombre.Show();

        }
        else if (txt_nombre.Text.Length > 80)
        {
            errorMsg += "El nombre no puede exceder los 80 caracteres" + Environment.NewLine;
            lbl_error_nombre.Text = "El nombre no puede exceder los 80 caracteres";
            lbl_error_nombre.Show();
        }
        else
        {

            lbl_error_nombre.Visible = false;

        }

        if (combo_tipo.SelectedItem == null || string.IsNullOrEmpty(combo_tipo.Text))
        {
            errorMsg += "Debes seleccionar un tipo de perfume" + Environment.NewLine;
            lbl_error_tipo.Text = "Debes seleccionar un tipo de perfume";
            lbl_error_tipo.Show();
        }
        else
        {
            lbl_error_tipo.Visible = false;
        }

        if (combo_genero.SelectedItem == null || string.IsNullOrEmpty(combo_genero.Text))
        {
            errorMsg += "Debes seleccionar un género" + Environment.NewLine;
            lbl_error_genero.Text = "Debes seleccionar un género";
            lbl_error_genero.Show();
        }
        else
        {
            lbl_error_genero.Visible = false;
        }

        if (string.IsNullOrEmpty(txt_presentacion.Text))
        {
            errorMsg += "Debes ingresar los ml en numero" + Environment.NewLine;
            lbl_error_presentacion.Text = "Debes ingresar los ml en numero";
            lbl_error_presentacion.Show();

        }
        else
        {
            if (!int.TryParse(txt_presentacion.Text, out int result))
            {
                errorMsg += "Debes ingresar un número entero. Sólo números" + Environment.NewLine;
                lbl_error_presentacion.Text = "Debes ingresar un número entero. Sólo números";
                lbl_error_presentacion.Show();
            }
            else
            {
                lbl_error_presentacion.Visible = false;
            }
        }

        if (combo_pais.SelectedItem == null || string.IsNullOrEmpty(combo_pais.Text))
        {
            errorMsg += "Debes ingresar el nombre del perfume" + Environment.NewLine;
            lbl_error_pais.Text = "Debes ingresar el nombre del perfume";
            lbl_error_pais.Show();
        }
        else
        {
            lbl_error_pais.Visible = false;
        }

        if (combo_spray.SelectedItem == null || string.IsNullOrEmpty(combo_spray.Text))
        {
            errorMsg += "Debes indicar si viene en formato spray o no" + Environment.NewLine;
            lbl_error_spray.Text = "Debes indicar si viene en formato spray o no";
            lbl_error_spray.Show();
        }
        else
        {
            lbl_error_spray.Visible = false;
        }

        if (combo_recargable.SelectedItem == null || string.IsNullOrEmpty(combo_recargable.Text))
        {
            errorMsg += "Debes indicar si es o no recargable" + Environment.NewLine;
            lbl_error_recargable.Text = "Debes indicar si es o no recargable";
            lbl_error_recargable.Show();
        }
        else
        {
            lbl_error_recargable.Visible = false;
        }
        if (string.IsNullOrEmpty(txt_descripcion.Text))
        {
            errorMsg += "Debes ingresar la descripción del perfume" + Environment.NewLine;
            lbl_error_descripcion.Text = "Debes ingresar la descripción del perfume";
            lbl_error_descripcion.Show();

        }
        else if (txt_descripcion.Text.Length > 1100)
        {
            errorMsg += "La descripción del perfume no puede exceder los 1100 caracteres" + Environment.NewLine;
            lbl_error_descripcion.Text = "La descripción del perfume no puede exceder los 1100 caracteres";
            lbl_error_descripcion.Show();
        }
        else
        {
            {
                lbl_error_descripcion.Visible = false;
            }
        }
        if (string.IsNullOrEmpty(txt_anio.Text))
        {
            errorMsg += "Debes ingresar el año de lanzamiento del perfume" + Environment.NewLine;
            lbl_error_anio.Text = "Debes ingresar el año de lanzamiento del perfume";
            lbl_error_anio.Show();

        }
        else
        {
            if (!int.TryParse(txt_anio.Text, out int year) || year < 1900 || year > DateTime.Now.Year)
            {
                errorMsg += "Debes ingresar un año válido" + Environment.NewLine;
                lbl_error_anio.Text = "Debes ingresar un año válido";
                lbl_error_anio.Show();
            }
            else
            {
                lbl_error_anio.Visible = false;
            }
        }
        if (string.IsNullOrEmpty(txt_precio.Text))
        {
            errorMsg += "Debes ingresar un precio" + Environment.NewLine;
            lbl_error_precio.Text = "Debes ingresar un precio";
            lbl_error_precio.Show();

        }
        else
        {
            if (!double.TryParse(txt_precio.Text.Replace(",", "."), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double price) || price < 0)
            {
                errorMsg += "Debes ingresar un precio válido" + Environment.NewLine;
                lbl_error_precio.Text = "Debes ingresar un precio válido";
                lbl_error_precio.Show();
            }
            else
            {
                lbl_error_precio.Visible = false;
            }
        }

        if (combo_activo.SelectedItem == null || string.IsNullOrEmpty(combo_activo.Text))
        {
            errorMsg += "Debes indicar si el producto ingresa como activo o no" + Environment.NewLine;
            lbl_error_activo.Text = "Debes indicar si el producto ingresa como activo o no";
            lbl_error_activo.Show();
        }
        else
        {
            lbl_error_activo.Visible = false;
        }

        if (pictureBox1.Image == null)
        {
            errorMsg += "Debes cargar una Imagen" + Environment.NewLine;
            lbl_error_img1.Text = "Debes cargar una Imagen";
            lbl_error_img1.Show();

        }
        else
        {
            {
                lbl_error_img1.Visible = false;
            }
        }




        if (string.IsNullOrEmpty(errorMsg))
        {
            lbl_error_sku.Visible = false;
            lbl_error_marca.Visible = false;
            lbl_error_nombre.Visible = false;
            lbl_error_tipo.Visible = false;
            lbl_error_genero.Visible = false;
            lbl_error_presentacion.Visible = false;
            lbl_error_pais.Visible = false;
            lbl_error_spray.Visible = false;
            lbl_error_recargable.Visible = false;
            lbl_error_descripcion.Visible = false;
            lbl_error_anio.Visible = false;
            lbl_error_precio.Visible = false;
            lbl_error_activo.Visible = false;
            lbl_error_img1.Visible = false;


        }

        return string.IsNullOrEmpty(errorMsg);
    }*/

        private void crearPromo()
        {
            // Validar los datos ingresados
          /*  if (!validarPromo(out string errorMsg))
            {
                MessageBox.Show(
                    "No se pudo crear la promoción debido a los siguientes errores:\n" + errorMsg,
                    "Errores en la creación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }*/

            // Obtener los datos de los controles
            KeyValuePair<int, string> tipoPromo = (KeyValuePair<int, string>)combo_tipo_promo.SelectedItem;
            string nombrePromo = txt_nomb_promo.Text;
            DateTime fechaInicio = dateTime_inicio_promo.Value;
            DateTime fechaFin = dateTime_fin_promo.Value;
            // Convertir el estado activo en un entero (1 para activo, 0 para no activo)
            int esActiva = combo_activo_promo.SelectedItem.ToString() == "Si" ? 1 : 0;

            // Crear un objeto Promoción con los datos capturados
            Promocion nuevaPromo = new Promocion
            {
                descuento = tipoPromo.Key,
                nombre = nombrePromo,
                fecha_inicio = fechaInicio,
                fecha_fin = fechaFin,
                activo = esActiva
            };

            // Guardar la promoción (esto puede ser en una base de datos, lista, etc.)
            bool resultado = PromoControlador.crearPromocion(nuevaPromo); 

            if (resultado)
            {
                MessageBox.Show(
                    "La promoción se creó exitosamente.",
                    "Promoción creada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

              

                //limpiarFormulario(); // Limpiar los controles después de crear la promoción

                this.Close();  // Cerrar la ventana de creación

            }
            else
            {
                MessageBox.Show(
                    "Ocurrió un error al intentar crear la promoción. Por favor, inténtalo nuevamente.",
                    "Error al crear promoción",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void asignarPerfumesAPromo()
        {
            int idPromo = PromoControlador.obtenerMaxId();

            // Paso 1: Recorrer las filas del DataGridView para obtener los IDs de los perfumes
            foreach (DataGridViewRow fila in dataGrid_perfumes_agregados_a_promo.Rows)
            {
                // Verifica que la fila no sea vacía
                if (fila.Cells[5].Value != null)
                {
                    // Paso 2: Obtener el ID del perfume de la celda correspondiente
                    int idPerfume = Convert.ToInt32(fila.Cells[5].Value);

                    // Paso 3: Guardar la relación entre la promoción y el perfume en la base de datos
                    PerfumeEnPromoControlador.guardarRelacionPromoPerfume(idPromo, idPerfume);
                }
            }

        }

      


        private void limpiarFormulario()
        {
            combo_tipo_promo.SelectedIndex = -1; // Deseleccionar tipo de promoción
            txt_nomb_promo.Clear(); // Limpiar nombre
            /*// Limpia fecha de inicio
            dateTime_inicio_promo.CustomFormat = " ";
            dateTime_inicio_promo.Format = DateTimePickerFormat.Custom;
            // Limpia fecha de fin
            dateTime_fin_promo.CustomFormat = " ";
            dateTime_fin_promo.Format = DateTimePickerFormat.Custom;*/
            combo_activo_promo.SelectedIndex = -1; // Para que el combo_box vuelva a quedar vacío
            inicializarDatePickers();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }

        private void btn_crear_promo_Click(object sender, EventArgs e)
        {


           /* bool promoValidada = validarPromo(out string errorMsg);
            if (promoValidada)
            {
                crearPromo();
                asignarPerfumesAPromo();

                
            }*/
        }


        private void btn_limpiar_DataGridView_Click(object sender, EventArgs e)
        {
            // Limpia todas las filas del DataGridView
            dataGrid_resultado_busqueda_perfumes.Rows.Clear();
        }

        private void btn_recargar_DataGridView_Click(object sender, EventArgs e)
        {
            // Restablecer los filtros a sus valores predeterminados
            combo_buscar_marcaP.SelectedIndex = 0;  // "Todas las Marcas"
            txt_buscar_nombP.Text = "";             // Nombre vacío
            combo_buscar_generoP.SelectedIndex = 0; // "Todos los Géneros"

            // Recargar el DataGridView con todos los perfumes sin aplicar filtros
            cargarPerfumes(0, "", 0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que la celda clickeada sea la del botón "Eliminar"
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                // Obtener el nombre del perfume desde la fila seleccionada
                string nombrePerfume = dataGrid_perfumes_agregados_a_promo.Rows[e.RowIndex].Cells[1].Value.ToString();  // Columna 1 es el nombre del perfume
                string mililitrosPerfume = dataGrid_perfumes_agregados_a_promo.Rows[e.RowIndex].Cells[2].Value.ToString();  // Columna 2 es la cantidad de mililitros

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
                    dataGrid_perfumes_agregados_a_promo.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

      
        private void btn_agregar_todos_Click_1(object sender, EventArgs e)
        {
            // Iterar por todas las filas del dataGrid_resultado_busqueda_perfumes
            foreach (DataGridViewRow sourceRow in dataGrid_resultado_busqueda_perfumes.Rows)
            {
                // Obtener el ID del perfume de la fila actual
                int idPerfume = Convert.ToInt32(sourceRow.Cells[5].Value);

                // Verificar si el perfume ya está en el dataGrid_perfumes_agregados_a_promo
                bool perfumeYaAgregado = false;
                foreach (DataGridViewRow targetRow in dataGrid_perfumes_agregados_a_promo.Rows)
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
                    int newRowIndex = dataGrid_perfumes_agregados_a_promo.Rows.Add();
                    dataGrid_perfumes_agregados_a_promo.Rows[newRowIndex].Cells[0].Value = sourceRow.Cells[0].Value;
                    dataGrid_perfumes_agregados_a_promo.Rows[newRowIndex].Cells[1].Value = sourceRow.Cells[1].Value;
                    dataGrid_perfumes_agregados_a_promo.Rows[newRowIndex].Cells[2].Value = sourceRow.Cells[2].Value;
                    dataGrid_perfumes_agregados_a_promo.Rows[newRowIndex].Cells[3].Value = sourceRow.Cells[3].Value;
                    dataGrid_perfumes_agregados_a_promo.Rows[newRowIndex].Cells[4].Value = "Elimninar";
                    dataGrid_perfumes_agregados_a_promo.Rows[newRowIndex].Cells[5].Value = idPerfume;
                }
            }

            // Mostrar un mensaje al final del proceso
            MessageBox.Show("Todos los perfumes han sido agregados correctamente (excepto los duplicados).", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_eliminar_todos_Click(object sender, EventArgs e)
        {
            /*// Confirmar la acción con el usuario
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar todos los perfumes agregados?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario confirma, se eliminan todas las filas
            if (resultado == DialogResult.Yes)
            {
                dataGrid_perfumes_agregados_a_promo.Rows.Clear(); // Limpia todas las filas del DataGridView
                MessageBox.Show("Todos los perfumes han sido eliminados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/

          
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
                    foreach (DataGridViewRow row in dataGrid_perfumes_agregados_a_promo.Rows)
                    {
                        // Agregar la fila al respaldo (asegurarse de no agregar filas vacías)
                        if (!row.IsNewRow)
                        {
                            backupRows.Add(row);
                        }
                    }

                    // Elimina todas las filas del DataGridView
                    dataGrid_perfumes_agregados_a_promo.Rows.Clear();

                    MessageBox.Show("Todos los perfumes han sido eliminados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }

        private void btrn_deshacer_eliminacion_Click(object sender, EventArgs e)
        {
            if (backupRows.Count == 0)
            {
                MessageBox.Show("No hay datos para deshacer la eliminación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Restaurar las filas del respaldo al DataGridView
            foreach (DataGridViewRow row in backupRows)
            {
                int rowIndex = dataGrid_perfumes_agregados_a_promo.Rows.Add();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dataGrid_perfumes_agregados_a_promo.Rows[rowIndex].Cells[i].Value = row.Cells[i].Value;
                }
            }

            // Limpiar el respaldo una vez restaurado
            backupRows.Clear();

            MessageBox.Show("Se ha deshecho la eliminación de los perfumes.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}