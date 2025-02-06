using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.ControlesDeUsuario;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop
{
    public partial class AromaNota : Form
    {
        private List<TipoDeAroma> tipo_de_aromas;
        private List<TipoDeNota> tipo_de_notas;
        private string filtro = "";
        private Perfume perfume;
        private List<NotasDelPerfume> notas_del_perfume;
        private List<NotaConTipoDeNota> notas_con_tipo_de_nota;
        private Productos formProducto;
        private PerfumesUC perfumesUC;
        public AromaNota()
        {
            InitializeComponent();
            cargarTipoDeAromas();
            cargarTipoDeNotas();
        }

        public AromaNota(Perfume perfume, Productos formProducto, PerfumesUC perfumesUC)
        {
            InitializeComponent();
            this.formProducto = formProducto;
            this.perfumesUC = perfumesUC;
            cargarTipoDeAromas();
            cargarTipoDeNotas();
            txt_nombre_perfume.Text = perfume.nombre;
            this.perfume = perfume;
            cargarDataGridViewNotasDePerfume();
            lbl_error_seleccion_aroma.Visible = false;
            lbl_error_seleccion_nota.Visible = false;
            this.formProducto = formProducto;
            lbl_nota.Text = "";
        }

        private void cargarTipoDeAromas()
        {
            tipo_de_aromas = TipoDeAromaControlador.getAll();
            if (tipo_de_aromas != null)
            {
                foreach (TipoDeAroma tipo_de_aroma in tipo_de_aromas)
                {
                    checkedListBoxAroma.Items.Add(tipo_de_aroma.nombre);
                }
            }
        }

        private void cargarTipoDeNotas()
        {
            tipo_de_notas = TipoDeNotaControlador.getAll();
            if (tipo_de_notas != null)
            {
                foreach (TipoDeNota tipo_de_nota in tipo_de_notas)
                {
                    checkedListBoxNota.Items.Add(tipo_de_nota.nombre_tipo_de_nota);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //FILTRAR POR NOMBRE
            if (string.IsNullOrEmpty(txt_nota.Text))
            {
                //lIMPIAMOS EL FILTRO
                filtro = null;
                filtrar();
            }
            else
            {
                String nombreFiltrar = txt_nota.Text.ToString().ToLower();
                filtro = nombreFiltrar;
                filtrar();
            }
        }

        private void filtrar()
        {
            List<Nota> notas = NotaControlador.getAll();
            List<Nota> notas_filtradas;
            if (filtro != null)
            {
                // Filtrar las notas según el nombre
                notas_filtradas = notas.Where(x => x.nombre.ToLower().Contains(filtro)).ToList();

                if (notas_filtradas.Count > 0)
                {
                    lbl_nota.Text = notas_filtradas.First().nombre;
                }
                else
                {
                    lbl_nota.Text = "No se encontraron notas que coincidan.";
                }
            }
            else
            {
                // Si no hay filtro, vaciar el label
                lbl_nota.Text = "";
            }
        }

        private void cargarDataGridViewNotasDePerfume()
        {        
            Nota nota = null;
            TipoDeNota tipo_de_nota = null;

            if (notas_con_tipo_de_nota != null)
            {
                dataGridViewNotasDelPerfume.Rows.Clear();
                foreach (NotaConTipoDeNota nota_con_tipo_de_nota_ in notas_con_tipo_de_nota)
                {
                    nota = NotaControlador.getById(nota_con_tipo_de_nota_.nota.id);
                    tipo_de_nota = TipoDeNotaControlador.getById(nota_con_tipo_de_nota_.tipoDeNota.id);

                    int rowIndex = dataGridViewNotasDelPerfume.Rows.Add();
                    dataGridViewNotasDelPerfume.Rows[rowIndex].Cells[0].Value = nota_con_tipo_de_nota_.id;
                    dataGridViewNotasDelPerfume.Rows[rowIndex].Cells[1].Value = nota_con_tipo_de_nota_.tipoDeNota.nombre_tipo_de_nota;
                    dataGridViewNotasDelPerfume.Rows[rowIndex].Cells[2].Value = nota_con_tipo_de_nota_.nota.nombre;
                    dataGridViewNotasDelPerfume.Rows[rowIndex].Cells[3].Value = "Eliminar";

                }
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
             string nombre_tipoDeNota_marcado = null;
             string nombre_nota = null;


            if (checkedListBoxNota.CheckedItems.Count == 0)
            {
                lbl_error_seleccion_nota.Text = "Debe marcar un tipo de nota";
                lbl_error_seleccion_nota.Visible = true;
                return;
            }
            else if (!(checkedListBoxNota.CheckedItems.Count == 1))
            {
                lbl_error_seleccion_nota.Text = "marcar un solo tipo de nota";
                lbl_error_seleccion_nota.Visible = true;
                return;
            }
            else if (checkedListBoxNota.CheckedItems.Count > 1)
            {
                lbl_error_seleccion_nota.Text = "marcar un solo tipo de nota";
                lbl_error_seleccion_nota.Visible = true;
                return;
            }
            else if (!(string.IsNullOrEmpty(lbl_nota.Text)))
            {

                nombre_nota = lbl_nota.Text;
                nombre_tipoDeNota_marcado = checkedListBoxNota.CheckedItems[0].ToString();

                Nota nota = NotaControlador.getByNombre(nombre_nota);
                TipoDeNota tipoDeNota = TipoDeNotaControlador.getByNombre(nombre_tipoDeNota_marcado);

                //Busco en la base de datos si exite nota con tipo de nota
                NotaConTipoDeNota notaConTipoDeNota = NotaConTipoDeNotaControlador.getByNotaAndTipoDeNota(nota, tipoDeNota);


                NotasDelPerfume notasDelPerfume = new NotasDelPerfume(perfume, notaConTipoDeNota);


                if (notas_con_tipo_de_nota == null)
                {
                    notas_con_tipo_de_nota = new List<NotaConTipoDeNota>();
                }

                if (notas_del_perfume == null)
                {
                    notas_del_perfume = new List<NotasDelPerfume>();
                }

                if (notas_con_tipo_de_nota.Any(x => x.id == notaConTipoDeNota.id))
                {
                    Console.WriteLine("Nota con tipo de nota id: " + notaConTipoDeNota.id);
                    lbl_error_seleccion_nota.Text = "Esta convinacion ya fue agregada";
                    lbl_error_seleccion_nota.Visible = true;

                }
                else
                {
                    lbl_error_seleccion_nota.Visible = false;
                    notas_con_tipo_de_nota.Add(notaConTipoDeNota);
                    notas_del_perfume.Add(notasDelPerfume);
                    MessageBox.Show("Se ha guardado la nota y el tipo de nota del perfume correctamente");
                }
               

                cargarDataGridViewNotasDePerfume();

            }
            else
            {
                lbl_error_seleccion_nota.Text = "Debe ingresar una nota";
                lbl_error_seleccion_nota.Visible = true;
                return;
            }

         }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {

            if (checkedListBoxAroma.CheckedItems.Count == 0)
            {
                lbl_error_seleccion_aroma.Text = "Debe marcar al menos un tipo de aroma";
                lbl_error_seleccion_aroma.Visible = true;
                return;
            }
            //Guardo la nueva imagen
            formProducto.guardarNuevaImg();
            //Actualizar el perfume con los datos que se han modificado
            perfume = formProducto.crear();
            PerfumeControlador.create(perfume);

            var listaDeAromasMarcados = checkedListBoxAroma.CheckedItems;
   
            foreach (var item in listaDeAromasMarcados)
            {
                var tipoDeAromaMarcado = item.ToString();
                TipoDeAroma tipoDeAroma = TipoDeAromaControlador.getByNombre(tipoDeAromaMarcado);
                AromaDelPerfume aromaDelPerfume = new AromaDelPerfume(perfume, tipoDeAroma);
                AromaDelPerfumeControlador.create(aromaDelPerfume);
            }

            if (notas_del_perfume != null)
            {
                foreach (NotasDelPerfume notasDelPerfume in notas_del_perfume)
                {
                    NotasDelPerfumeControlador.create(notasDelPerfume);
                }
            }


            MessageBox.Show("Se registro perfume con aromas y notas del perfume correctamente");
            this.Close();
            perfumesUC.cargarPerfumes();

        }

        private void dataGridViewNotasDelPerfume_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int id = int.Parse(dataGridViewNotasDelPerfume.Rows[e.RowIndex].Cells[0].Value.ToString());
     
            if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                //ELIMINAMOS
                notas_con_tipo_de_nota = notas_con_tipo_de_nota.Where(x => x.id != id).ToList();
                notas_del_perfume = notas_del_perfume.Where(x => x.notaConTipoDeNota.id != id).ToList();
                cargarDataGridViewNotasDePerfume();
                MessageBox.Show("Se ha eliminado la nota con el tipo de nota del perfume correctamente");
            }
        }

        private void checkedListBoxNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si hay algún elemento seleccionado
            if (checkedListBoxNota.SelectedIndex != -1)
            {
                // Desmarcar todos los elementos antes de marcar el nuevo
                for (int i = 0; i < checkedListBoxNota.Items.Count; i++)
                {
                    if (i != checkedListBoxNota.SelectedIndex) // Evita desmarcar el que acaba de ser seleccionado
                    {
                        checkedListBoxNota.SetItemChecked(i, false);
                    }
                }

                // Obtener el último elemento marcado
                string ultimoMarcado = checkedListBoxNota.SelectedItem.ToString();
                lbl_tipo_de_nota.Text = ultimoMarcado;
            }
            else
            {
                lbl_tipo_de_nota.Text = "No hay elementos seleccionados.";
            }
        }

        private void btn_x_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            formProducto.Show();
        }
    }
}
