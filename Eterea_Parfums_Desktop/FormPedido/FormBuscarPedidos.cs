using Eterea_Parfums_Desktop.Controladores;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class FormBuscarPedidos : Form
    {
        public FormBuscarPedidos()
        {
            InitializeComponent();

            lbl_orden_error.Visible = false;

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);

            dgv_resultado.SelectionChanged += (s, e) => ActualizarTextoBotonPrepararEnvio();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInicioVendedor InicioVendedor = new FormInicioVendedor();
            InicioVendedor.Show();
            this.Close();
        }

        /*private void btn_lista_envios_Click(object sender, EventArgs e)
        {
            FormListaDeEnvios listaDeEnvios = new FormListaDeEnvios();
            listaDeEnvios.Show();
            this.Close();
        }*/

        private void btn_buscar_orden_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_orden_n.Text, out int numeroOrden))
            {
                MessageBox.Show("Ingrese un número de orden válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OrdenControlador controlador = new OrdenControlador();
            DataTable resultado = controlador.BuscarOrdenPorNumero(numeroOrden);

            dgv_resultado.Rows.Clear(); // limpiar contenido anterior

            if (resultado.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró la orden indicada.");
                return;
            }


            foreach (DataRow row in resultado.Rows)
            {
                int estado = Convert.ToInt32(row["estado"]);
                string estadoTexto = estado == 1 ? "Para despachar" : "Ya despachada";
                string fechaCompra = Convert.ToDateTime(row["fecha_compra"]).ToShortDateString();

                dgv_resultado.Rows.Add(
                    row["numero_de_orden"].ToString(),
                    estadoTexto,
                    fechaCompra
                );
            }
            ActualizarTextoBotonPrepararEnvio();
        }

        private void ActualizarTextoBotonPrepararEnvio()
        {
            if (dgv_resultado.SelectedRows.Count == 0)
            {
                btn_preparar_envio.Text = "Ver detalles";
                return;
            }

            // La columna del estado es la columna 1 (índice 1), según tu código
            string estadoTexto = dgv_resultado.SelectedRows[0].Cells[1].Value?.ToString();

            if (estadoTexto == "Para despachar")
            {
                btn_preparar_envio.Text = "VER DETALLES / PREPARAR ENVIO";
            }
            else
            {
                btn_preparar_envio.Text = "VER DETALLES";
            }
        }



        private void btn_preparar_envio_Click(object sender, EventArgs e)
        {
                if (dgv_resultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una orden de la lista.");
                    return;
                }

                int numeroOrden = Convert.ToInt32(dgv_resultado.SelectedRows[0].Cells[0].Value);
                string estadoTexto = dgv_resultado.SelectedRows[0].Cells[1].Value?.ToString();
                int estado = estadoTexto == "Para despachar" ? 1 : 0;

                FormListaDeEnvios listaFiltrada = new FormListaDeEnvios(numeroOrden, estado, true);
                listaFiltrada.Show();
                this.Hide();
        }








       





    }
}
