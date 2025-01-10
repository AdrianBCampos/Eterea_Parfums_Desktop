using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Modelos
{
    internal class Empleado
    {
        public int id { get; set; }
        public String usuario { get; set; }
        public String clave { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String rol { get; set; }
    

     public Empleado(int id, string usuario, string clave, string nombre, string apellido, string rol)
        {
            this.id = id;
            this.usuario = usuario;
            this.clave = clave;
            this.nombre = nombre;
            this.apellido = apellido;
            this.rol = rol;
        }

        public Empleado()
        {

        }
    }
}
