using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;

namespace Eterea_Parfums_Desktop
{
    public partial class AromaNota : Form
    {
        private List<TipoDeAroma> tipo_de_aromas;
        private List<TipoDeNota> tipo_de_notas;
        private string filtro = "";
        private Perfume perfume;
        public AromaNota()
        {
            InitializeComponent();
            cargarTipoDeAromas();
            cargarTipoDeNotas();
        }

        public AromaNota(Perfume perfume)
        {
            InitializeComponent();
            cargarTipoDeAromas();
            cargarTipoDeNotas();
            txt_nombre_perfume.Text = perfume.nombre;
            this.perfume = perfume;
            cargarDataGridViewNotasDePerfume();
            lbl_error_seleccion_aroma.Visible = false;
            lbl_error_seleccion_nota.Visible = false;
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
            //CARGAR DATAGRIDVIEW DE NOTAS DE PERFUME
            List<NotasDelPerfume> notas_del_perfume = NotasDelPerfumeControlador.getByIDPerfume(perfume.id);
            List<NotaConTipoDeNota> notas_con_tipo_de_nota = new List<NotaConTipoDeNota>();

            Nota nota = null;
            TipoDeNota tipo_de_nota = null;
           


            if (notas_del_perfume != null)
            {
                //dataGridViewNotasDelPerfume.DataSource = notas;
                foreach (NotasDelPerfume nota_del_perfume in notas_del_perfume)
                {
                    notas_con_tipo_de_nota.Add(NotaConTipoDeNotaControlador.getByID(nota_del_perfume.notaConTipoDeNota.id));

                }
            }

            if (notas_con_tipo_de_nota != null)
            {
                dataGridViewNotasDelPerfume.Rows.Clear();
                foreach (NotaConTipoDeNota nota_con_tipo_de_nota_ in notas_con_tipo_de_nota)
                {
                    nota = NotaControlador.getById(nota_con_tipo_de_nota_.nota.id);
                    tipo_de_nota = TipoDeNotaControlador.getById(nota_con_tipo_de_nota_.tipoDeNota.id);

                    int rowIndex = dataGridViewNotasDelPerfume.Rows.Add();
                    dataGridViewNotasDelPerfume.Rows[rowIndex].Cells[0].Value = tipo_de_nota.nombre_tipo_de_nota;
                    dataGridViewNotasDelPerfume.Rows[rowIndex].Cells[1].Value = nota.nombre;
                    dataGridViewNotasDelPerfume.Rows[rowIndex].Cells[2].Value = "Eliminar";
          
                }
            }
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {


            if (checkedListBoxNota.CheckedItems.Count == 0)
            {
                lbl_error_seleccion_nota.Visible = true;
            }

            if (checkedListBoxAroma.CheckedItems.Count == 0)
            {
                lbl_error_seleccion_nota.Visible = true;
            }


            var tipoDeNotaMarcado = checkedListBoxNota.Items.ToString();
            var tipoDeAromaMarcado = checkedListBoxAroma.Items.ToString();

            if (tipoDeNotaMarcado != null && tipoDeAromaMarcado != null)
            {
                Nota nota = NotaControlador.getByNombre(lbl_nota.Text);
                TipoDeNota tipoDeNota = TipoDeNotaControlador.getByNombre(tipoDeNotaMarcado);

                NotaConTipoDeNota notaConTipoDeNota = new NotaConTipoDeNota(0, nota, tipoDeNota);

                NotaConTipoDeNotaControlador.create(notaConTipoDeNota);
                
                notaConTipoDeNota = NotaConTipoDeNotaControlador.getByNotaAndTipoDeNota(notaConTipoDeNota);

                NotasDelPerfume notasDelPerfume = new NotasDelPerfume(perfume, notaConTipoDeNota);
                //fata Id
                NotasDelPerfumeControlador.create(notasDelPerfume);


                TipoDeAroma tipoDeAroma = TipoDeAromaControlador.getByNombre(tipoDeAromaMarcado);
                AromaDelPerfume aromaDelPerfume = new AromaDelPerfume(perfume, tipoDeAroma);

                AromaDelPerfumeControlador.create(aromaDelPerfume);
              
                cargarDataGridViewNotasDePerfume();





               
        }

        }
    }
}
