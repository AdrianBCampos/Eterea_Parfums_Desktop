using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Modelos
{
    internal class AromaDelPerfume
    {
        public Perfume perfume { get; set; }
        public TipoDeAroma tipoDeAroma { get; set; }

        public AromaDelPerfume(Perfume perfume, TipoDeAroma tipoDeAroma)
        {
            this.perfume = perfume;
            this.tipoDeAroma = tipoDeAroma;
        }

        public AromaDelPerfume()
        {
        }
    }
}
