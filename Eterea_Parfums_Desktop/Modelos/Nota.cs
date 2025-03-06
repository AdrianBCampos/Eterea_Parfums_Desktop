namespace Eterea_Parfums_Desktop.Modelos
{
    public class Nota
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Nota(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public Nota()
        {
        }
    }
}
