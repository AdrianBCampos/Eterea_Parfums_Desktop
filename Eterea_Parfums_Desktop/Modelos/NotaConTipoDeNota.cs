using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Modelos
{
    internal class NotaConTipoDeNota
    {
        public int id { get; set; }
        public Nota nota { get; set; }
        public TipoDeNota tipoDeNota { get; set; }

        public NotaConTipoDeNota(int id, Nota nota, TipoDeNota tipoDeNota)
        {
            this.id = id;
            this.nota = nota;
            this.tipoDeNota = tipoDeNota;
        }

        public NotaConTipoDeNota()
        {
        }
    }
}
