using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.DTOs
{
    public class HistorialCajaDTO
    {
        public int NumeroCaja { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string Empleado { get; set; }
        public string Usuario { get; set; } // para abrir luego el FormEmpleado

    }
}
