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
        public int dni { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public String celular { get; set; }
        public String e_mail { get; set; }
        public int pais_id { get; set; }
        public int provincia_id { get; set; }
        public int localidad_id { get; set; }
        public int codigo_postal { get; set; }
        public int calle_id { get; set; }
        public int numeracion_calle { get; set; }
        public String piso { get; set; }
        public String departamento { get; set; }
        public String comentarios_domicilio { get; set; }
        public int sucursal_id { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public int sueldo { get; set; }
        public int activo { get; set; }
        public String rol { get; set; }


        public Empleado(int id, string usuario, string clave, string nombre, string apellido, int dni, DateTime fecha_nacimiento, string celular, string e_mail, 
            int pais_id, int provincia_id, int localidad_id, int codigo_postal, int calle_id, int numeracion_calle, string piso, string departamento,
            string comentarios_domicilio, int sucursal_id, DateTime fecha_ingreso, int sueldo, int activo, string rol)
        {
            this.id = id;
            this.usuario = usuario;
            this.clave = clave;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fecha_nacimiento = fecha_nacimiento;
            this.celular = celular;
            this.e_mail = e_mail;
            this.pais_id = pais_id;
            this.provincia_id = provincia_id;
            this.localidad_id = localidad_id;
            this.codigo_postal = codigo_postal;
            this.calle_id = calle_id;
            this.numeracion_calle = numeracion_calle;
            this.piso = piso;
            this.departamento = departamento;
            this.comentarios_domicilio = comentarios_domicilio;
            this.sucursal_id = sucursal_id;
            this.fecha_ingreso = fecha_ingreso;
            this.sueldo = sueldo;
            this.activo = activo;
            this.rol = rol;
        }

        public Empleado()
        {

        }
    }
}
