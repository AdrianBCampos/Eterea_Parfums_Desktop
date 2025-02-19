namespace Eterea_Parfums_Desktop.Modelos
{
    public class Localidad
    {

        public int id { get; set; }
        public string nombre { get; set; }

        public Localidad(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;

        }

        public Localidad()
        {

        }
    }
}