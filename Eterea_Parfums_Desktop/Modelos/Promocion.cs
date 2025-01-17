using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Modelos
{
    internal class Promocion
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public int descuento { get; set; }
        public int activo { get; set; }

        public Promocion(int id, string nombre, DateTime fecha_inicio, DateTime fecha_fin, int descuento, int activo)
        {
            this.id = id;
            this.nombre = nombre;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
            this.descuento = descuento;
            this.activo = activo;

        }

        public Promocion()
        {

        }
    }
}
