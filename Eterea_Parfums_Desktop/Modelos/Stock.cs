using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Modelos
{
    internal class Stock
    {
        public Perfume perfume { get; set; }
        public Sucursal sucursal { get; set; }
        public int cantidad { get; set; }

        public Stock(Perfume perfume, Sucursal sucursal, int cantidad)
        {
            this.perfume = perfume;
            this.sucursal = sucursal;
            this.cantidad = cantidad;
        }
        public Stock() { }
    }
}
