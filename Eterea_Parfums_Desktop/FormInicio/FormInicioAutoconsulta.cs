using Eterea_Parfums_Desktop.Controladores;
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
    public partial class FormInicioAutoconsulta : Form
    {
        private bool escaneoHabilitado = false; // ✅ Inicialmente deshabilitado


        private BarcodeReceiver barcodeReceiver;

        private static Perfume filtro = new Perfume();

        private List<Perfume> Perfumes_Completo = new List<Perfume>();
        private List<Perfume> Perfumes_Filtrado = new List<Perfume>();
        private List<Perfume> Perfumes_Paginados = new List<Perfume>();

        public List<Marca> marcas;
        public List<Genero> generos;

        //LA PAGINA ACTUAL
        private static int current = 0;
        private static int paginador = 10;

        //TOTAL DE PRODUCTOS
        private static int total = 0;
        private static int last_pag = 0;
        private static int current_pag = 1;

        //private BarcodeScannerWatcher watcher;




        public FormInicioAutoconsulta()
        {
            InitializeComponent();

            barcodeReceiver = new BarcodeReceiver();
            barcodeReceiver.StartServer(); // Inicia el servidor TCP

            //Ocultar campos de escaneo 
            lbl_codigoBarras.Visible = false;
            txt_scan.Visible = false;

            // Configurar evento Click en todos los controles del formulario excepto en txt_scan y lbl_codigoBarras
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl != txt_scan && ctrl != lbl_codigoBarras && ctrl != btn_escanear)
                {
                    ctrl.Click += Form_Click;
                }
            }


            string rutaCompletaImagen = Program.Ruta_Base + @"Diseño Logo2.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);

            Perfumes_Completo = PerfumeControlador.getAll();
            Perfumes_Filtrado = PerfumeControlador.filtrarPorNombre(filtro.nombre);

            total = Perfumes_Completo.Count;
            last_pag = (int)Math.Ceiling((double)total / paginador);
            lbl_numero_pagina.Text = current_pag.ToString();
            paginar(Perfumes_Completo);
            CargarMarcas();
            CargarGeneros();

            this.KeyPreview = true;



            //Diseño del combo box
            combo_filtro_genero.DrawMode = DrawMode.OwnerDrawFixed;
            combo_filtro_genero.DrawItem += comboBoxdiseño_DrawItem;
            combo_filtro_genero.DropDownStyle = ComboBoxStyle.DropDownList;

            combo_filtro_marca.DrawMode = DrawMode.OwnerDrawFixed;
            combo_filtro_marca.DrawItem += comboBoxdiseño_DrawItem;
            combo_filtro_marca.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txt_scan_TextChanged(object sender, EventArgs e)
        {
            if (!escaneoHabilitado)
            {
                // ✅ Si el escaneo no está habilitado, limpiamos el TextBox y salimos del método
                txt_scan.Clear();
                return;
            }
            if (!string.IsNullOrEmpty(txt_scan.Text))
            {
                GuardarTextoEnArchivo(txt_scan.Text);

                // Usar BeginInvoke para ejecutar el evento KeyPress en el hilo principal
                this.BeginInvoke(new Action(() =>
                {
                    txt_scan_KeyPress(txt_scan, new KeyPressEventArgs((char)Keys.Enter));
                }));
            }
        }



        private void GuardarTextoEnArchivo(string texto)
        {
            string rutaArchivo = @"C:\Users\intersan\Desktop\TESIS\Eterea_Parfums_Desktop\Eterea_Parfums_Desktop\txt_scan.txt";
            File.WriteAllText(rutaArchivo, texto);
        }

        private void InicioAutoConsultas_KeyDown_1(object sender, KeyEventArgs e)
        {
            // Detectar si se presionan las teclas Ctrl + L
            if (e.Control && e.KeyCode == Keys.L)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
                return; // Importante: evitar que siga evaluando otras teclas después de ocultar el formulario
            }

            // Detectar si se presionan las teclas Ctrl + X
            if (e.Control && e.KeyCode == Keys.X)
            {
                DialogResult result = MessageBox.Show(
                    "¿Está seguro que desea cerrar la aplicación?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }





        private void CargarMarcas()
        {
            marcas = MarcaControlador.getAll();
            combo_filtro_marca.Items.Clear();
            combo_filtro_marca.Items.Add("Todas las marcas");
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
            combo_filtro_genero.Items.Add("Todos los generos");
            foreach (Genero genero in generos)
            {
                combo_filtro_genero.Items.Add(genero.genero);
            }
            combo_filtro_genero.SelectedIndex = 0;
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
            //Ocultas la primera columna de la tabla (es una columna de seleccion de fila)
            dataGridViewConsultas.RowHeadersVisible = false;

            dataGridViewConsultas.Rows.Clear();
            foreach (Perfume perfume in perfumeMostrar)
            {
                if (perfume.activo == 1)
                {
                    int rowIndex = dataGridViewConsultas.Rows.Add();

                    dataGridViewConsultas.Rows[rowIndex].Cells[0].Value = perfume.nombre.ToString();
                    dataGridViewConsultas.Rows[rowIndex].Cells[1].Value = (MarcaControlador.getById(perfume.marca.id)).nombre;
                    dataGridViewConsultas.Rows[rowIndex].Cells[2].Value = (GeneroControlador.getById(perfume.genero.id)).genero;
                    dataGridViewConsultas.Rows[rowIndex].Cells[3].Value = perfume.precio_en_pesos.ToString("C", CultureInfo.CurrentCulture);
                    dataGridViewConsultas.Rows[rowIndex].Cells[4].Value = "Ver";
                }
                dataGridViewConsultas.CellPainting += dataGridViewConsultas_CellPainting;
            }
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
            if (current >= paginador)
            {
                current = current + paginador;
                current_pag = current_pag + 1;
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

        private void filtrar()
        {
            Perfumes_Filtrado = Perfumes_Completo;

            if (filtro.marca != null)
            {
                Perfumes_Filtrado = Perfumes_Filtrado.Where(x => x.marca.id == filtro.marca.id).ToList();
            }

            if (filtro.genero != null)
            {
                Perfumes_Filtrado = Perfumes_Filtrado.Where(x => x.genero.id == filtro.genero.id).ToList();
            }


            if (filtro.nombre != null)
            {
                Perfumes_Filtrado = Perfumes_Filtrado.Where(x => x.nombre.ToLower().Contains(filtro.nombre)).ToList();
                //Perfumes_Filtrado = PerfumeController.filtrarPorNombre(filtro.nombre);
            }

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

            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                int rowIndex = e.RowIndex;
                Perfume perfumeSeleccionado = Perfumes_Paginados[rowIndex];

                FormVerDetallePerfume detallesForm = new FormVerDetallePerfume(perfumeSeleccionado);
                detallesForm.Show();
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

        private void btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_escanear_Click(object sender, EventArgs e)
        {
            /* Escanear escanear = new Escanear();
             escanear.Show();
             this.Hide();*/
            escaneoHabilitado = true;

            // Ocultar el botón y mostrar el TextBox
            btn_escanear.Visible = false;
            txt_scan.Visible = true;
            txt_scan.Focus(); // Poner el cursor en el TextBox
            lbl_codigoBarras.Visible = true;
        }

        // Evento para capturar el código escaneado
        private void txt_scan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                string codigoBarras = txt_scan.Text.Trim();

                if (!string.IsNullOrEmpty(codigoBarras))
                {
                    txt_scan.Enabled = false;

                    Perfume perfumeEncontrado = PerfumeControlador.getByCodigo(codigoBarras);

                    if (perfumeEncontrado != null)
                    {
                        FormVerDetallePerfume formDetalle = new FormVerDetallePerfume(perfumeEncontrado);
                        formDetalle.ShowDialog(); // Bloquea la ejecución hasta que se cierre

                        // Cuando se cierra VerDetallePerfume, se vuelve a mostrar el botón Escanear
                        btn_escanear.Visible = true;
                        txt_scan.Visible = false;
                        lbl_codigoBarras.Visible = false;
                    }
                    else
                    {
                        FormEscanear formEscanear = new FormEscanear(this);
                        formEscanear.ShowDialog();
                    }
                }
                else
                {
                    FormEscanear formEscanear = new FormEscanear(this);
                    formEscanear.ShowDialog();
                }

                txt_scan.Clear();
                txt_scan.Enabled = true;
                txt_scan.Focus();
                escaneoHabilitado = false;
            }
        }


        public void SimularIngresoTeclado(string barcode)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)(() =>
                {
                    txt_scan.Text = barcode;
                    SendKeys.SendWait("{ENTER}"); // Enviar Enter automáticamente
                }));
            }
            else
            {
                txt_scan.Text = barcode;
                SendKeys.SendWait("{ENTER}");
            }
        }


        public bool IsFocused()
        {
            return txt_scan.Focused;
        }



        private void Form_Click(object sender, EventArgs e)
        {
            // Si txt_scan está visible y se hace clic fuera de él, oculta los controles de escaneo
            if (txt_scan.Visible)
            {
                RestaurarUI();
            }
        }



        public void MostrarErrorCodigo()
        {
            MessageBox.Show("Error al leer el código de barras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void RestaurarUI()
        {
            // ✅ Desactivar escaneo
            escaneoHabilitado = false;

            btn_escanear.Visible = true;  // Mostrar botón Escanear
            txt_scan.Visible = false;     // Ocultar txt_scan
            lbl_codigoBarras.Visible = false;  // Ocultar lbl_codigoBarras
        }


    }
}
