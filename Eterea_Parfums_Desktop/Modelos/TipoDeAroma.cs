namespace Eterea_Parfums_Desktop.Modelos
{
    internal class TipoDeAroma
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public TipoDeAroma(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public TipoDeAroma()
        {
        }
    }
}
