using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Modelos
{
    internal class NotasDelPerfume
    {
        Perfume perfume;
        NotaConTipoDeNota nota_con_tipo_de_nota;

        public NotasDelPerfume(Perfume perfume, NotaConTipoDeNota nota_con_tipo_de_nota)
        {
            this.perfume = perfume;
            this.nota_con_tipo_de_nota = nota_con_tipo_de_nota;
        }
        public NotasDelPerfume()
        {
        }
    }
}
