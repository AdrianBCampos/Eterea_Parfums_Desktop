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
        public AromaNota()
        {
            InitializeComponent();
            cargarTipoDeAromas();
            cargarTipoDeNotas();
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
