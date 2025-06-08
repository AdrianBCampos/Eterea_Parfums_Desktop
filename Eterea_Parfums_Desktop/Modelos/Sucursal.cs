namespace Eterea_Parfums_Desktop.Modelos
{
    public class Sucursal
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Pais pais_id { get; set; }
        public Provincia provincia_id { get; set; }
        public Localidad localidad_id { get; set; }
        public int codigo_postal { get; set; }
        public Calle calle_id { get; set; }
        public int numeracion_calle { get; set; }
        public bool? activo { get; set; }


        public Sucursal(int id, string nombre, Pais pais_id, Provincia provincia_id, Localidad localidad_id,
            int codigo_postal, Calle calle_id, int numeracion_calle, bool? activo)
        {
            this.id = id;
            this.nombre = nombre;
            this.pais_id = pais_id;
            this.provincia_id = provincia_id;
            this.localidad_id = localidad_id;
            this.codigo_postal = codigo_postal;
            this.calle_id = calle_id;
            this.numeracion_calle = numeracion_calle;
            this.activo = activo;

        }

        public Sucursal()
        {

        }
    }
}
