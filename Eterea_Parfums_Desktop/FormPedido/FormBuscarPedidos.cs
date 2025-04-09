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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInicioVendedor InicioVendedor = new FormInicioVendedor();
            InicioVendedor.Show();
            this.Close();
        }

        private void btn_lista_envios_Click(object sender, EventArgs e)
        {
            FormListaDeEnvios listaDeEnvios = new FormListaDeEnvios();
            listaDeEnvios.Show();
            this.Close();
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

                dgv_resultado.Rows.Add(
                    row["numero_de_orden"].ToString(),
                    estadoTexto,
                    "Ver"
                );
            }
        }



        /*private void dgv_resultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_resultado.Columns[e.ColumnIndex].HeaderText == "Ver")
            {
                int numeroOrden = Convert.ToInt32(dgv_resultado.Rows[e.RowIndex].Cells[0].Value);
                FormDetalleOrden detalle = new FormDetalleOrden(numeroOrden);
                detalle.ShowDialog();
            }
        }*/




    }
}
