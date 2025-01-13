using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Modelos
{
    internal class TipoDePerfume
    {
        public int id { get; set; }
        public string tipo_de_perfume { get; set; }

        public TipoDePerfume(int id, string tipo_de_perfume)
        {
            this.id = id;
            this.tipo_de_perfume = tipo_de_perfume;
        }
        public TipoDePerfume()
        {

        }
    }
}
