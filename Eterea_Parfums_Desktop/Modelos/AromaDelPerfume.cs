using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Modelos
{
    internal class AromaDelPerfume
    {
        Perfume perfume;
        TipoDeNota tipoDeNota;

        public AromaDelPerfume(Perfume perfume, TipoDeNota tipoDeNota)
        {
            this.perfume = perfume;
            this.tipoDeNota = tipoDeNota;
        }

        public AromaDelPerfume()
        {
        }
    }
}
