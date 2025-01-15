using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Modelos
{
    public class TipoDeNota
    {
        public int id { get; set; }
        public string nombre_tipo_de_nota { get; set; }

        public TipoDeNota(int id, string nombre_tipo_de_nota)
        {
            this.id = id;
            this.nombre_tipo_de_nota = nombre_tipo_de_nota;
        }

        public TipoDeNota()
        {
        }

    }
}
