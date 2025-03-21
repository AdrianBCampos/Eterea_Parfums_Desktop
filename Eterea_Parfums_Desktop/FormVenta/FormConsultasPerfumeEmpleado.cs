using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormConsultasPerfumeEmpleado : Form
    {

        private FormFacturacion facturacionForm;

        private static Perfume filtro = new Perfume();

        private List<Perfume> Perfumes_Completo = new List<Perfume>();
        private List<Perfume> Perfumes_Filtrado = new List<Perfume>();
        private List<Perfume> Perfumes_Paginados = new List<Perfume>();

        public List<Marca> marcas;
        public List<Genero> generos;

        //LA PAGINA ACTUAL
        private static int current = 0;
        private static int paginador = 5;

        //TOTAL DE PRODUCTOS
        private static int total = 0;
        private static int last_pag = 0;
        private static int current_pag = 1;

        public string NumeroCaja { get; set; }
        public FormConsultasPerfumeEmpleado(FormFacturacion facturacion)
        {
            InitializeComponent();

            facturacionForm = facturacion;

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);

            txt_nombre_empleado.Text = Program.logueado.nombre + " " + Program.logueado.apellido;
            txt_numero_caja.Text = " ";

            Perfumes_Completo = PerfumeControlador.getAll();
            Perfumes_Filtrado = PerfumeControlador.filtrarPorNombre(filtro.nombre);

            total = Perfumes_Completo.Count;
            last_pag = (int)Math.Ceiling((double)total / paginador);
            lbl_numero_pagina.Text = current_pag.ToString();
            paginar(Perfumes_Completo);
            CargarMarcas();
            CargarGeneros();
            //this.facturacionForm = facturacionForm;
        }

        private void ConsultasPerfumeEmpleado_Load(object sender, EventArgs e)
        {
            txt_numero_caja.Text = NumeroCaja;
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
            dataGridViewConsultas.Rows.Clear();
            foreach (Perfume perfume in perfumeMostrar)
            {
                if (perfume.activo == 1)
                {
                    int rowIndex = dataGridViewConsultas.Rows.Add();

                    //dataGridViewConsultas.Rows[rowIndex].Cells[0].Value = perfume.sku.ToString();
                    dataGridViewConsultas.Rows[rowIndex].Cells[0].Value = perfume.nombre.ToString();
                    dataGridViewConsultas.Rows[rowIndex].Cells[1].Value = (MarcaControlador.getById(perfume.marca.id)).nombre;
                    dataGridViewConsultas.Rows[rowIndex].Cells[2].Value = (GeneroControlador.getById(perfume.genero.id)).genero;
                    dataGridViewConsultas.Rows[rowIndex].Cells[3].Value = perfume.precio_en_pesos.ToString("C", CultureInfo.CurrentCulture);
                    dataGridViewConsultas.Rows[rowIndex].Cells[4].Value = "Ver";
                    dataGridViewConsultas.Rows[rowIndex].Cells[5].Value = "Agregar";
                }
            }
        }

        private void btn_anterior_Click_1(object sender, EventArgs e)
        {
            if (current >= paginador)
            {
                current = current - paginador;
                current_pag = current_pag - 1;
                lbl_numero_pagina.Text = current_pag.ToString();
                paginar(Perfumes_Filtrado);
            }
        }

        private void btn_posterior_Click_1(object sender, EventArgs e)
        {
            if (current >= paginador)
            {
                current = current + paginador;
                current_pag = current_pag + 1;
                lbl_numero_pagina.Text = current_pag.ToString();
                paginar(Perfumes_Filtrado);
            }
        }

        private void txt_filtro_nombre_TextChanged_1(object sender, EventArgs e)
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

        private void combo_filtro_marca_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void combo_filtro_genero_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void dataGridViewConsultas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                int rowIndex = e.RowIndex;
                Perfume perfumeSeleccionado = Perfumes_Paginados[rowIndex];

                FormVerDetallePerfume detallesForm = new FormVerDetallePerfume(perfumeSeleccionado);
                detallesForm.Show();
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
                int descuentoPorcentaje = promoController.obtenerMayorDescuentoPorPerfume(perfumeSeleccionado.id);
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

        private void btn_facturacion_Click(object sender, EventArgs e)
        {
            FormFacturacion facturacion = new FormFacturacion();
            //facturacion.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //NumeroDeCaja numeroDeCaja = new NumeroDeCaja();
            //numeroDeCaja.Show();
            this.Close();
        }


    }
}
