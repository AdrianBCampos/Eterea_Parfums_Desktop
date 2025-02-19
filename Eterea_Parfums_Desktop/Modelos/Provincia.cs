namespace Eterea_Parfums_Desktop.Modelos
{
    public class Provincia
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Provincia(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;

        }

        public Provincia()
        {

        }
    }
}