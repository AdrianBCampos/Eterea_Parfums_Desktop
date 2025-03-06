using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop
{
    public partial class VerNotasPerfume : Form
    {
        private Perfume perfume;
        public VerNotasPerfume(Perfume perfume)
        {
            InitializeComponent();
            cargarDataGridViewNotasDePerfume();
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
                    dataGridViewNotasDelPerfume.Rows[rowIndex].Cells[0].Value = nota_con_tipo_de_nota_.id;
                    dataGridViewNotasDelPerfume.Rows[rowIndex].Cells[1].Value = tipo_de_nota.nombre_tipo_de_nota;
                    dataGridViewNotasDelPerfume.Rows[rowIndex].Cells[2].Value = nota.nombre;                   
                }
            }
        }
    }
}
