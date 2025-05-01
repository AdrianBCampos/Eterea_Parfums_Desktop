using System;

namespace Eterea_Parfums_Desktop.Modelos
{
    public class Cliente
    {
        public int id { get; set; }
        public String usuario { get; set; }
        public String clave { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public long dni { get; set; }
        public String condicion_frente_al_iva { get; set; }
        public DateTime? fecha_nacimiento { get; set; }
        public String celular { get; set; }
        public String e_mail { get; set; }
        public Pais pais_id { get; set; }
        public Provincia provincia_id { get; set; }
        public Localidad localidad_id { get; set; }
        public int? codigo_postal { get; set; }
        public Calle calle_id { get; set; }
        public int? numeracion_calle { get; set; }
        public String piso { get; set; }
        public String departamento { get; set; }
        public String comentarios_domicilio { get; set; }

        public int activo { get; set; }
        public String rol { get; set; }

        public Cliente(int id, string usuario, string clave, string nombre, string apellido, long dni, string condicion_frente_al_iva, DateTime fecha_nacimiento,
            string celular, string e_mail, Pais pais_id, Provincia provincia_id, Localidad localidad_id, int codigo_postal, Calle calle_id,
            int numeracion_calle, string piso, string departamento, string comentarios_domicilio,
             int activo, string rol)
        {
            this.id = id;
            this.usuario = usuario;
            this.clave = clave;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.condicion_frente_al_iva = condicion_frente_al_iva;
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

            this.activo = activo;
            this.rol = rol;
        }
        public Cliente()
        {

        }

        public Cliente(int id, int activo)
        {
            this.id = id;
            this.activo = activo;
        }

    }
}
