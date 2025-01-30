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




        //Inicializar los DatePickers

        private void inicializarDatePickers()
        {
           
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






        //Cargar descuentos en el combo_box

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




        //Cargar marcas en el combo_box

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





        //Cargar generos en el combo_box

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





        //Método para activar restricciones en el datePicker de la fecha de inicio

        private void dateTime_inicio_promo_ValueChanged(object sender, EventArgs e)
        {
          
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







        //Método para activar restricciones en el datePicker de la fecha de fin

        private void dateTime_fin_promo_ValueChanged(object sender, EventArgs e)
        {
            
            // Establece el formato estándar para mostrar la fecha
            dateTime_fin_promo.Format = DateTimePickerFormat.Short;
        }






        //Método para cargar los datos en el dataGridView de la busqueda de perfumes


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





        //Método para aplicar el filtro por nombre a la busqueda de perfumes cada vez que se detecte un cambio en el text_box

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





        //Método para aplicar el filtro por marca a la busqueda de perfumes cada vez que se detecte un cambio en el combo_box

        private void comboBox_Marcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ID de la marca seleccionada
            var seleccion = (KeyValuePair<int, string>)combo_buscar_marcaP.SelectedItem;
            int idMarcaSeleccionada = seleccion.Key;

            // Recargar los perfumes con el filtro de marca
            cargarPerfumes(filtroNombreP: txt_buscar_nombP.Text.Trim(), filtroMarcaP: idMarcaSeleccionada, filtroGeneroP: 0);
        }




        //Método para aplicar el filtro por genero a la busqueda de perfumes cada vez que se detecte un cambio en el combo_box

        private void combo_genero_SelectedIndexChanged(object sender, EventArgs e)
        {  
            // Obtener el ID del género seleccionado
            var seleccion = (KeyValuePair<int, string>)combo_buscar_generoP.SelectedItem;
            int idGeneroSeleccionado = seleccion.Key;

            // Recargar los perfumes con el filtro de género
            cargarPerfumes(filtroNombreP: txt_buscar_nombP.Text.Trim(), filtroMarcaP: 0, filtroGeneroP: idGeneroSeleccionado);
        }






        //Método para detectar cambios en el combo_box de tipo de promoción

        private void combo_tipo_promo_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_tipo_promo.SelectedItem != null)
            {
                var selectedItem = (KeyValuePair<int, string>)combo_tipo_promo.SelectedItem;
                int descuentoSeleccionado = selectedItem.Key;
                // Aquí puedes trabajar con el descuentoSeleccionado, como guardarlo en una base de datos o usarlo en la lógica de tu aplicación
            }
        }



        //Acción del botón "Agregar" del dataGridView de resultado de busqueda de perfumes

        private void dataGrid_perfumes_agregados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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




        //Acción del botón para borrar el texto del text_box de busqueda por nombre de perfume

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





        //Acción del botón para quitar todos los filtros de la busqueda

        private void btn_quitar_filtros_Click(object sender, EventArgs e)
        {
            // Restablecer los filtros a sus valores predeterminados
            combo_buscar_marcaP.SelectedIndex = 0;  // "Todas las Marcas"
            txt_buscar_nombP.Text = "";             // Nombre vacío
            combo_buscar_generoP.SelectedIndex = 0; // "Todos los Géneros"

            // Recargar el DataGridView con todos los perfumes sin aplicar filtros
            cargarPerfumes(0, "", 0);
        }





        //Método para limpiar los mensajes de error

        private void limpiarMensajesError()
        {
            lbl_error_tipo_promo.Visible = false;
            lbl_error_nombP.Visible = false;
            lbl_error_fecha_iniP.Visible = false;
            lbl_error_fecha_finP.Visible = false;
            lbl_error_promo_act.Visible = false;

        }






        //Método para validar los campos a completar en la edición de la promoción

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





        //Método que ejecuta las acciones para crear la promoción (llama a PromoControlador.crearPromo(promoEditada))

        private void crearPromo()
        {
            // Validar los datos ingresados
           /* if (!validarPromo(out string errorMsg))
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

            if (PromoControlador.crearPromocion(nuevaPromo)) 
            {
                this.DialogResult = DialogResult.OK;
            }

            MessageBox.Show(
                   "La promoción se creó exitosamente.",
                   "Promoción creada",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
               );

        }





        //Método para relacionar la promoción con los perfumes en los que aplica el descuento (llama a PerfumeEnPromoControlador.guardarRelacionPromoPerfume(idPromo, idPerfume))

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
            bool promoValidada = validarPromo(out string errorMsg);
            if (promoValidada)
            {
                crearPromo();
                asignarPerfumesAPromo();
            }
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