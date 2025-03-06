namespace Eterea_Parfums_Desktop.Modelos
{
    public class Genero
    {
        public int id { get; set; }
        public string genero { get; set; }

        public Genero(int id, string genero)
        {
            this.id = id;
            this.genero = genero;
        }

        public Genero()
        {

        }
    }
}