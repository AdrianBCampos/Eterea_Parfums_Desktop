namespace Eterea_Parfums_Desktop.Modelos
{
    public class Pais
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Pais(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;

        }

        public Pais()
        {

        }
    }
}