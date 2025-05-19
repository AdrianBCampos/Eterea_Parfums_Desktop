using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.ControlesDeUsuario.PrepararEnvios;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario
{
    public partial class BuscarPedidos_UC : UserControl
    {
        public BuscarPedidos_UC()
        {
            InitializeComponent();

            lbl_orden_error.Visible = false;

            string rutaCompletaImagen = Program.Ruta_Base + @"LogoEterea.png";
            img_logo.Image = Image.FromFile(rutaCompletaImagen);

            dgv_resultado.SelectionChanged += (s, e) => ActualizarTextoBotonPrepararEnvio();
           
            txt_orden_n.KeyDown += Txt_orden_n_KeyDown;

            this.Cursor = Cursors.Default;
            this.UseWaitCursor = false;


        }

        private void btn_buscar_orden_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_orden_n.Text, out int numeroOrden))
            {
                MessageBox.Show("Ingrese un número de orden válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OrdenControlador controlador = new OrdenControlador();
            DataTable resultado = controlador.BuscarOrdenPorNumero(numeroOrden);

            dgv_resultado.Rows.Clear();

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
                MessageBox.Show("Ingrese un número de orden y realice la búsqueda.");
                return;
            }

            int numeroOrden = Convert.ToInt32(dgv_resultado.SelectedRows[0].Cells[0].Value);
            string estadoTexto = dgv_resultado.SelectedRows[0].Cells[1].Value?.ToString();
            int estado = estadoTexto == "Para despachar" ? 1 : 0;

            PrepararEnvios_UC prepararEnviosFiltradoUC = new PrepararEnvios_UC(numeroOrden, estado, true, true);
            Control parentContainer = this.Parent;

            if (parentContainer != null)
            {
                parentContainer.Controls.Clear();
                prepararEnviosFiltradoUC.Dock = DockStyle.Fill;
                parentContainer.Controls.Add(prepararEnviosFiltradoUC);
            }
        }

        private void Txt_orden_n_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_buscar_orden.PerformClick();
                e.SuppressKeyPress = true; // evita el 'ding' del Enter
            }
        }




    }
}
