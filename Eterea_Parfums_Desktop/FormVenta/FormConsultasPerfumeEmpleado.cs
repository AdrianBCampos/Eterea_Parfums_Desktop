using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.ControlesDeUsuario;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormConsultasPerfumeEmpleado : Form
    {
        private bool escaneoHabilitado = false; // ✅ Inicialmente deshabilitado

        private Facturar_UC facturacionForm;

        private Perfume filtro = new Perfume();

        private List<Perfume> Perfumes_Completo = new List<Perfume>();
        private List<Perfume> Perfumes_Filtrado = new List<Perfume>();
        private List<Perfume> Perfumes_Paginados = new List<Perfume>();

        public List<Marca> marcas;
        public List<Genero> generos;

        private List<TipoDeAroma> aromas;

        //LA PAGINA ACTUAL
        private static int current = 0;
        private static int paginador = 2;

        //TOTAL DE PRODUCTOS
        private static int total = 0;
        private static int last_pag = 0;
        private static int current_pag = 1;

        private int? aromaIdSeleccionado = null;

        public string NumeroCaja { get; set; }


        public FormConsultasPerfumeEmpleado(Facturar_UC facturacion)
        {
            InitializeComponent();

            RegistrarClicks(this);

          

            this.VisibleChanged += FormConsultasPerfumeEmpleado_VisibleChanged;

            facturacionForm = facturacion;

            facturacionForm.DesactivarEscaner(); // ✅ Esto evita que el escáner de Facturar_UC interfiera


            foreach (DataGridViewColumn col in dataGridViewConsultas.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            this.TopMost = false;

            /*ESCALAR TAMAÑO DEL FORM
            float scaleFactor = 0.8f; // 80% del tamaño original
            this.Scale(new SizeF(scaleFactor, scaleFactor));
            this.Scale(new SizeF(Program.ScaleFactor, Program.ScaleFactor));*/


            //Ocultar campos de escaneo 
            lbl_codigoBarras.Visible = false;
            txt_scan.Visible = false;
            txt_scan.Enabled = false;

            /*// Configurar evento Click en todos los controles del formulario excepto en txt_scan y lbl_codigoBarras
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != txt_scan && ctrl != lbl_codigoBarras && ctrl != btn_escanear)
                {
                    ctrl.Click += Form_Click;
                }
            }*/


            string rutaCompletaImagen = Program.Ruta_Base + @"Diseño Logo2.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);


            CargarMarcas();
            CargarGeneros();
            CargarAromas();
            //CargarStock();
            CargarArticulos();

            //Diseño del combo box
            combo_filtro_genero.DrawMode = DrawMode.OwnerDrawFixed;
            combo_filtro_genero.DrawItem += comboBoxdiseño_DrawItem;
            combo_filtro_genero.DropDownStyle = ComboBoxStyle.DropDownList;

            combo_filtro_marca.DrawMode = DrawMode.OwnerDrawFixed;
            combo_filtro_marca.DrawItem += comboBoxdiseño_DrawItem;
            combo_filtro_marca.DropDownStyle = ComboBoxStyle.DropDownList;

            combo_filtro_articulos.DrawMode = DrawMode.OwnerDrawFixed;
            combo_filtro_articulos.DrawItem += comboBoxdiseño_DrawItem;
            combo_filtro_articulos.DropDownStyle = ComboBoxStyle.DropDownList;

            //combo_filtro_stock.DrawMode = DrawMode.OwnerDrawFixed;
            //combo_filtro_stock.DrawItem += comboBoxdiseño_DrawItem;
            //combo_filtro_stock.DropDownStyle = ComboBoxStyle.DropDownList;

            combo_filtro_aroma.DrawMode = DrawMode.OwnerDrawFixed;
            combo_filtro_aroma.DrawItem += comboBoxdiseño_DrawItem;
            combo_filtro_aroma.DropDownStyle = ComboBoxStyle.DropDownList;

            this.KeyPreview = true;

            //Perfumes_Completo = PerfumeControlador.getAll();
            //Perfumes_Filtrado = PerfumeControlador.filtrarPorNombre(filtro.nombre);
            Perfumes_Completo = PerfumeControlador.getAll();
            filtro.activo = true; // Esto asegura que al inicio solo se muestren los perfumes activos
            filtrar();

            ResetearFiltros();

        }

        private void ResetearFiltros()
        {
            filtro = new Perfume(); // Resetea el objeto filtro
            aromaIdSeleccionado = null; // Resetea aroma
            txt_filtro_nombre.Text = ""; // Limpia el textbox
            combo_filtro_marca.SelectedIndex = 0;
            combo_filtro_genero.SelectedIndex = 0;
            combo_filtro_articulos.SelectedIndex = 0;
            combo_filtro_aroma.SelectedIndex = 0;
        }

        private void FormConsultasPerfumeEmpleado_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                facturacionForm.DesactivarEscaner();

                BarcodeReceiver.OnCodigoLeido -= ProcesarCodigoLeido;
                BarcodeReceiver.OnCodigoLeido += ProcesarCodigoLeido;
            }
            else
            {
                BarcodeReceiver.OnCodigoLeido -= ProcesarCodigoLeido;
            }
        }

    
        private void FormConsultasPerfumeEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            BarcodeReceiver.OnCodigoLeido -= ProcesarCodigoLeido;
            facturacionForm.ActivarEscaner(); // Si tenés un método así
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            facturacionForm.ActivarEscaner(); // ✅ Reactivar si tenés este método
        }



        private void RegistrarClicks(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl != txt_scan && ctrl != lbl_codigoBarras && ctrl != btn_escanear)
                {
                    ctrl.Click += Form_Click;
                }

                // Llamada recursiva si el control tiene hijos
                if (ctrl.HasChildren)
                {
                    RegistrarClicks(ctrl);
                }
            }
        }




        /*private void txt_scan_TextChanged(object sender, EventArgs e)
        {
            if (!escaneoHabilitado || !txt_scan.Visible || !txt_scan.Enabled)
            {
                txt_scan.Text = ""; // Limpia si el campo no debería recibir datos
                return;
            }

            string codigo = txt_scan.Text.Trim();

            // ✅ Agregar el "0" al inicio si tiene 12 caracteres
            if (codigo.Length == 12)
            {
                codigo = "0" + codigo;
            }

            // ✅ Validar que tenga exactamente 13 caracteres ahora
            if (codigo.Length != 13)
                return;

            // Buscar el perfume por código corregido
            Perfume perfumeEncontrado = PerfumeControlador.getByCodigo(codigo);

            if (perfumeEncontrado != null)
            {
                // Mostrar el detalle
                FormVerDetallePerfume detalleForm = new FormVerDetallePerfume(perfumeEncontrado);
                detalleForm.FormClosed += (s, args) => ResetAutoConsulta();
                detalleForm.ShowDialog();
            }
            else
            {
                // Mostrar cartel de error
                FormCartelCodigoNoEncontrado cartel = new FormCartelCodigoNoEncontrado(this);
                cartel.ShowDialog();

                // ✅ Resetear el escaneo
                ResetAutoConsulta(); // o PrepararParaNuevoEscaneo()
            }
        }*/



        public void ResetAutoConsulta()
        {
            escaneoHabilitado = false;
            txt_scan.Text = "";
            txt_scan.Enabled = false;
            txt_scan.Visible = false;
            lbl_codigoBarras.Visible = false;
            btn_escanear.Visible = true;
            btn_escanear.Focus();
        }

        /* private void GuardarTextoEnArchivo(string texto)
         {
             string rutaArchivo = @"C:\Users\intersan\Desktop\TESIS\Eterea_Parfums_Desktop\Eterea_Parfums_Desktop\txt_scan.txt";
             File.WriteAllText(rutaArchivo, texto);
         }*/

       

        private void CargarMarcas()
        {
            marcas = MarcaControlador.getAll();
            combo_filtro_marca.Items.Clear();
            combo_filtro_marca.Items.Add("Todas las Marcas");
            foreach (Marca marca in marcas)
            {
                combo_filtro_marca.Items.Add(marca.nombre);
            }
            combo_filtro_marca.SelectedIndex = 0;
        }

        private void CargarGeneros()
        {
            generos = GeneroControlador.getAll();
            combo_filtro_genero.Items.Clear();
            combo_filtro_genero.Items.Add("Todos los Géneros");
            foreach (Genero genero in generos)
            {
                combo_filtro_genero.Items.Add(genero.genero);
            }
            combo_filtro_genero.SelectedIndex = 0;
        }

        private void CargarAromas()
        {
            aromas = TipoDeAromaControlador.getAll();
            combo_filtro_aroma.Items.Clear();
            combo_filtro_aroma.Items.Add("Todos los Aromas");
            foreach (TipoDeAroma aroma in aromas)
            {
                combo_filtro_aroma.Items.Add(aroma.nombre);
            }
            combo_filtro_aroma.SelectedIndex = 0;
        }

        /*private void CargarStock()
        {
            combo_filtro_stock.Items.Clear();
            combo_filtro_stock.Items.Add("Todos los Perfumes");
            combo_filtro_stock.Items.Add("Disponible");
            combo_filtro_stock.Items.Add("Sin stock");
            combo_filtro_stock.SelectedIndex = 0;  // Establece la opción por defecto
        }*/

        private void CargarArticulos()
        {
            combo_filtro_articulos.Items.Clear();
            combo_filtro_articulos.Items.Add("Perfumes a la venta");
            combo_filtro_articulos.Items.Add("Todos los Perfumes");
            combo_filtro_articulos.Items.Add("Perfumes sin stock");
            combo_filtro_articulos.SelectedIndex = 0;  // Establece la opción por defecto
        }



        private void paginar(List<Perfume> perfumeMostrar)
        {
            Perfumes_Paginados = perfumeMostrar.Skip(current).Take(paginador).ToList();
            VisualizarPerfumes(Perfumes_Paginados);
            lbl_paginacion_Info.Text = "Mostrando: " + (current + 1) + " a " + (current + Perfumes_Paginados.Count) + "  de  " + total;

            if (current_pag == 1)
            {
                btn_anterior.Hide();
            }
            else
            {
                btn_anterior.Show();
                btn_posterior.Show();
            }
            if (current_pag == last_pag)
            {
                btn_posterior.Hide();
            }
            else
            {
                btn_posterior.Show();
            }
        }



        private void VisualizarPerfumes(List<Perfume> perfumeMostrar)
        {
            dataGridViewConsultas.RowHeadersVisible = false;
            dataGridViewConsultas.Rows.Clear();

            foreach (Perfume perfume in perfumeMostrar)
            {
                int rowIndex = dataGridViewConsultas.Rows.Add();
                DataGridViewRow row = dataGridViewConsultas.Rows[rowIndex];
                row.Tag = perfume;

                // Precio y stock visual
                var stockPorPerfume = StockControlador.ObtenerTodosLosStocksPorSucursal(Program.sucursal);
                int stockDisponible = stockPorPerfume.ContainsKey(perfume.id) ? stockPorPerfume[perfume.id] : 0;
                string precioMostrado = (perfume.activo == false || stockDisponible <= 0)
                    ? "Sin Stock"
                    : perfume.precio_en_pesos.ToString("C", CultureInfo.CurrentCulture);

                // Asignar valores a celdas
                row.Cells[0].Value = perfume.nombre;
                row.Cells[1].Value = MarcaControlador.getById(perfume.marca.id).nombre;
                row.Cells[2].Value = GeneroControlador.getById(perfume.genero.id).genero;
                row.Cells[3].Value = precioMostrado;

                if (precioMostrado == "Sin Stock")
                {
                    row.Cells[3].Style.ForeColor = Color.Red;
                    row.Cells[3].Style.Font = new Font(dataGridViewConsultas.DefaultCellStyle.Font, FontStyle.Bold);
                }
                else
                {
                    row.Cells[3].Style.ForeColor = Color.Black;
                    row.Cells[3].Style.Font = dataGridViewConsultas.DefaultCellStyle.Font;
                }

                row.Cells[4].Value = "Ver";
                row.Cells[5].Value = "Agregar";
            }

            dataGridViewConsultas.ClearSelection();
            dataGridViewConsultas.CellPainting += dataGridViewConsultas_CellPainting;
        }


        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (current >= paginador)
            {
                current = current - paginador;
                current_pag = current_pag - 1;
                lbl_numero_pagina.Text = current_pag.ToString();
                paginar(Perfumes_Filtrado);
            }
        }

        private void btn_posterior_Click(object sender, EventArgs e)
        {
            if (current + paginador < total)
            {
                current += paginador;
                current_pag++;
                lbl_numero_pagina.Text = current_pag.ToString();
                paginar(Perfumes_Filtrado);
            }
        }

        private void txt_filtro_nombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_filtro_nombre.Text))
            {
                //limpiamos el filtro
                filtro.nombre = null;
                filtrar();
            }
            else
            {
                string nombreFiltrar = txt_filtro_nombre.Text.ToString().ToLower();

                filtro.nombre = nombreFiltrar;
                filtrar();
            }
        }

        private void combo_filtro_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_filtro_marca.SelectedIndex > 0)
            {
                string marcaSeleccionada = combo_filtro_marca.SelectedItem.ToString();
                Marca marca = MarcaControlador.getByName(marcaSeleccionada);
                if (marca != null)
                {
                    filtro.marca = marca;
                    filtrar();
                }
            }
            else
            {
                filtro.marca = null;
                filtrar();
            }
        }

        private void combo_filtro_genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_filtro_genero.SelectedIndex > 0)
            {
                string generoSeleccionado = combo_filtro_genero.SelectedItem.ToString();
                Genero genero = GeneroControlador.getByName(generoSeleccionado);
                if (genero != null)
                {
                    filtro.genero = genero;
                    filtrar();
                }
            }
            else
            {
                filtro.genero = null;
                filtrar();
            }
        }

        private void combo_filtro_articulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_filtro_articulos.SelectedIndex == 0) // Perfumes a la venta
            {
                filtro.activo = true;
            }
            else if (combo_filtro_articulos.SelectedIndex == 1) // Todos los perfumes
            {
                filtro.activo = null; // No filtramos por activo
            }
            else if (combo_filtro_articulos.SelectedIndex == 2) // Perfumes sin stock
            {
                filtro.activo = null; // No filtramos por activo, el control lo hace VisualizarPerfumes
            }

            filtrar();
        }


        private void combo_filtro_aroma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_filtro_aroma.SelectedIndex > 0)
            {
                string aromaSeleccionado = combo_filtro_aroma.SelectedItem.ToString();
                TipoDeAroma aroma = TipoDeAromaControlador.getByNombre(aromaSeleccionado);
                if (aroma != null)
                {
                    aromaIdSeleccionado = aroma.id;
                    filtrar();
                }
            }
            else
            {
                aromaIdSeleccionado = null;
                filtrar();
            }

        }






        private void filtrar()
        {
            Perfumes_Filtrado = Perfumes_Completo;

            // Filtros por marca
            if (filtro.marca != null)
                Perfumes_Filtrado = Perfumes_Filtrado.Where(x => x.marca.id == filtro.marca.id).ToList();

            // Filtros por género
            if (filtro.genero != null)
                Perfumes_Filtrado = Perfumes_Filtrado.Where(x => x.genero.id == filtro.genero.id).ToList();

            // Filtro por estado activo
            if (filtro.activo.HasValue)
                Perfumes_Filtrado = Perfumes_Filtrado.Where(x => x.activo == filtro.activo).ToList();

            // Filtro por nombre (filtro.nombre ya es lowercase)
            if (!string.IsNullOrEmpty(filtro.nombre))
                Perfumes_Filtrado = Perfumes_Filtrado.Where(x => x.nombre.ToLower().Contains(filtro.nombre)).ToList();

            // Filtro por aroma
            if (aromaIdSeleccionado != null)
            {
                List<int> perfumesConAroma = AromaDelPerfumeControlador.getPerfumeIdsPorAroma(aromaIdSeleccionado.Value);
                Perfumes_Filtrado = Perfumes_Filtrado.Where(p => perfumesConAroma.Contains(p.id)).ToList();
            }

            // 🔥 Filtro por stock y estado de "a la venta" según combo
            var stockPorPerfume = StockControlador.ObtenerTodosLosStocksPorSucursal(Program.sucursal);
            switch (combo_filtro_articulos.SelectedIndex)
            {
                case 0: // Perfumes a la venta
                    Perfumes_Filtrado = Perfumes_Filtrado.Where(p => p.activo == true && stockPorPerfume.ContainsKey(p.id) && stockPorPerfume[p.id] > 0).ToList();
                    break;
                case 1: // Todos los perfumes (ya está)
                    break;
                case 2: // Sin stock
                    Perfumes_Filtrado = Perfumes_Filtrado.Where(p => p.activo == false || !stockPorPerfume.ContainsKey(p.id) || stockPorPerfume[p.id] <= 0).ToList();
                    break;
            }

            // Paginación
            total = Perfumes_Filtrado.Count;
            last_pag = (int)Math.Ceiling((double)total / paginador);
            current = 0;
            current_pag = 1;
            paginar(Perfumes_Filtrado);
            lbl_numero_pagina.Text = current_pag.ToString();
        }


        private void dataGridViewConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0 && e.ColumnIndex == 4) // Verifica que se haga clic en la columna correcta
            {
                DataGridViewRow row = dataGridViewConsultas.Rows[e.RowIndex];
                Perfume perfumeSeleccionado = row.Tag as Perfume;

                if (perfumeSeleccionado == null)
                    return;


                // Crear la ventana de detalles
                FormVerDetallePerfume detallesForm = new FormVerDetallePerfume(perfumeSeleccionado);
                detallesForm.Owner = this; // Hace que se muestre sobre FormInicioAutoconsulta

                // Deshabilitar FormInicioAutoconsulta para evitar interacciones
                this.Enabled = false;

                // Asegurar que FormDetallePerfume siempre quede por delante
                detallesForm.TopMost = true; // Lo pone en la parte superior
                detallesForm.Show();
                //detallesForm.TopMost = false; // Restablece su estado para evitar bloqueos
                detallesForm.BringToFront(); // Lo trae al frente

                // Restaurar FormInicioAutoconsulta al cerrar FormDetallePerfume
                detallesForm.FormClosing += (s, args) => this.Enabled = true;
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                int rowIndex = e.RowIndex;
                Perfume perfumeSeleccionado = Perfumes_Paginados[rowIndex];
                completarFactura(perfumeSeleccionado);
                facturacionForm.ActualizarTotales();
                this.Close();

            }
        }

        private void completarFactura(Perfume perfumeSeleccionado)
        {
            // Buscar si el perfume ya está en la factura
            DataGridViewRow existingRow = null;

            foreach (DataGridViewRow row in facturacionForm.GetFacturaDataGrid().Rows)
            {
                if (row.Cells["Nombre_Perfume"].Value != null && row.Cells["Nombre_Perfume"].Value.ToString() == perfumeSeleccionado.nombre)
                {
                    existingRow = row;
                    break;
                }
            }

            if (existingRow != null)
            {
                // Si el perfume ya está en la factura, incrementar la cantidad
                int cantidad = Convert.ToInt32(existingRow.Cells["Cantidad"].Value);
                existingRow.Cells["Cantidad"].Value = cantidad + 1;

                // Multiplicar el precio unitario por la cantidad para obtener el nuevo subtotal
                float precioUnitario = float.Parse(existingRow.Cells["Precio_Unitario"].Value.ToString());
                float nuevoSubtotal = precioUnitario * int.Parse(existingRow.Cells["Cantidad"].Value.ToString());
                existingRow.Cells[7].Value = nuevoSubtotal;
                /*PerfumeEnPromoControlador promoController = new PerfumeEnPromoControlador();
                int descuentoPorcentaje = promoController.ObtenerMayorDescuentoPorPerfume(perfumeSeleccionado.id);
                decimal descuentoMonto = (precioUnitario * Convert.ToDecimal(descuentoPorcentaje)) / 100;
                facturacionForm.GetFacturaDataGrid().Rows[rowIndex].Cells["Descuento"].Value = descuentoMonto;
                
                // Recalcular el total y otros valores necesarios

                /*   totalFactura();
                   CalcularImporteRecargo(float.Parse(txt_subtotal.Text), float.Parse(txt_recargo.Text));
                   desc();
                   sumaFinal(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text), float.Parse(txt_monto_descuento.Text));
                   */
            }
            else
            {
                // Si el perfume no está en la factura, agregar una nueva fila
                int rowIndex = facturacionForm.GetFacturaDataGrid().Rows.Add();
                facturacionForm.GetFacturaDataGrid().Rows[rowIndex].Cells[0].Value = perfumeSeleccionado.id.ToString();
                facturacionForm.GetFacturaDataGrid().Rows[rowIndex].Cells["Nombre_Perfume"].Value = perfumeSeleccionado.nombre.ToString();
                facturacionForm.GetFacturaDataGrid().Rows[rowIndex].Cells["Cantidad"].Value = 1;
                facturacionForm.GetFacturaDataGrid().Rows[rowIndex].Cells[2].Value = "➕";
                facturacionForm.GetFacturaDataGrid().Rows[rowIndex].Cells[3].Value = "➖";
                facturacionForm.GetFacturaDataGrid().Rows[rowIndex].Cells["Precio_Unitario"].Value = perfumeSeleccionado.precio_en_pesos.ToString();
                PerfumeEnPromoControlador promoController = new PerfumeEnPromoControlador();
                int descuentoPorcentaje = promoController.obtenerMayorDescuentoPorPerfume(perfumeSeleccionado.id) ?? 0;
                decimal precioUnitario = Convert.ToDecimal(perfumeSeleccionado.precio_en_pesos);
                decimal descuentoMonto = ((precioUnitario * descuentoPorcentaje) / 100);
                facturacionForm.GetFacturaDataGrid().Rows[rowIndex].Cells["Descuento"].Value = descuentoMonto;
                facturacionForm.GetFacturaDataGrid().Rows[rowIndex].Cells["Tot"].Value = perfumeSeleccionado.precio_en_pesos.ToString();
                facturacionForm.GetFacturaDataGrid().Rows[rowIndex].Cells["Eliminar"].Value = "Eliminar";
                facturacionForm.descuentoUnitario();

                /*   // Recalcular el total y otros valores necesarios
                   totalFactura();
                   CalcularImporteRecargo(float.Parse(txt_subtotal.Text), float.Parse(txt_recargo.Text));
                   desc();
                   sumaFinal(float.Parse(txt_subtotal.Text), float.Parse(txt_monto_recargo.Text), float.Parse(txt_monto_descuento.Text));
              */
            }
        }



        //Diseño del boton del datagridview
        private void dataGridViewConsultas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridViewConsultas.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                e.Handled = true;
                e.PaintBackground(e.CellBounds, true);

                // Crear un rectángulo para el botón
                Rectangle buttonRect = e.CellBounds;
                buttonRect.Inflate(-2, -2); // Reducir tamaño para dar efecto de borde

                // Definir colores personalizados
                Color buttonColor = Color.FromArgb(228, 137, 164); // Color de fondo del botón
                Color textColor = Color.FromArgb(250, 236, 239); // Color del texto

                using (SolidBrush brush = new SolidBrush(buttonColor))
                {
                    e.Graphics.FillRectangle(brush, buttonRect);
                }

                // Dibujar el texto del botón
                TextRenderer.DrawText(e.Graphics, (string)e.Value, e.CellStyle.Font, buttonRect, textColor,
                                      TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
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



        private void ProcesarCodigoLeido(string codigo)
        {
            if (!this.Visible || !escaneoHabilitado || string.IsNullOrWhiteSpace(codigo))
                return;

            // ✅ Solo aceptamos códigos de 12 o 13 caracteres
            if (codigo.Length == 12)
                codigo = "0" + codigo;
            else if (codigo.Length != 13)
                return;

            if (InvokeRequired)
            {
                Invoke(new Action(() => ProcesarCodigoLeido(codigo)));
                return;
            }

          

            // Buscar perfume directamente
            var perfume = PerfumeControlador.getByCodigo(codigo);

            if (perfume != null)
            {
                escaneoHabilitado = false;
                ResetAutoConsulta(); // ✅ Oculta todo

                var detalle = new FormVerDetallePerfume(perfume);
                detalle.FormClosed += (s, e) =>
                
                ResetAutoConsulta();
                detalle.ShowDialog();

            }
            else
            {
                escaneoHabilitado = false;
                ResetAutoConsulta(); // ✅ Oculta todo

                var cartel = new FormCartelCodigoNoEncontrado(this);
                cartel.ShowDialog();
            }
        }


        private void btn_escanear_Click(object sender, EventArgs e)
        {
            /* Escanear escanear = new Escanear();
             escanear.Show();
             this.Hide();*/
            escaneoHabilitado = true;
            txt_scan.Text = "";


            // Ocultar el botón y mostrar el TextBox
            btn_escanear.Visible = false;
            txt_scan.Visible = true;
            txt_scan.Enabled = true;
            txt_scan.Focus(); // Poner el cursor en el TextBox
            lbl_codigoBarras.Visible = true;
            this.TopMost = false;  // Restaurar el estado normal de TopMost

            BarcodeReceiver.OnCodigoLeido -= ProcesarCodigoLeido;
            BarcodeReceiver.OnCodigoLeido += ProcesarCodigoLeido;


        }

        public void PrepararParaNuevoEscaneo()
        {
            escaneoHabilitado = false;  // Primero aseguro que está limpio
           
            txt_scan.Text = "";
            txt_scan.Enabled = false;
            txt_scan.Visible = false;
            lbl_codigoBarras.Visible = false;
            btn_escanear.Visible = true;
            btn_escanear.Focus(); // Opcional, si querés que quede seleccionado el botón
        }

        /*private void MostrarCartelCodigoNoEncontrado()
        {
            using (var cartel = new FormCartelCodigoNoEncontrado())
            {
                if (cartel.ShowDialog() == DialogResult.OK)
                {
                    if (cartel.Eleccion == FormCartelCodigoNoEncontrado.Resultado.IngresarManual)
                    {
                        // Abro FormEscanear
                        FormIngresoCodigoManual formEscanear = new FormIngresoCodigoManual(this);
                        formEscanear.ShowDialog();
                    }
                    else if (cartel.Eleccion == FormCartelCodigoNoEncontrado.Resultado.ReintentarEscaneo)
                    {
                        PrepararParaNuevoEscaneo(); // Método que limpia y habilita nuevamente escaneo
                    }
                }
            }
        }*/

        private void Form_Click(object sender, EventArgs e)
        {
            if (escaneoHabilitado)
            {
                ResetAutoConsulta();
            }
        }



        /*public void MostrarErrorCodigo()
        {
            MessageBox.Show("Error al leer el código de barras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }*/

        public void RestaurarUI()
        {
            // ✅ Desactivar escaneo
            escaneoHabilitado = false;

            btn_escanear.Visible = true;  // Mostrar botón Escanear
            txt_scan.Visible = false;     // Ocultar txt_scan
            lbl_codigoBarras.Visible = false;  // Ocultar lbl_codigoBarras
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
