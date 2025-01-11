using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Modelos
{
    internal class Calle
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Calle(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;

        }

        public Calle()
        {

        }
    }
}