namespace Eterea_Parfums_Desktop.Modelos
{
    public class TipoDePerfume
    {
        public int id { get; set; }
        public string tipo_de_perfume { get; set; }

        public TipoDePerfume(int id, string tipo_de_perfume)
        {
            this.id = id;
            this.tipo_de_perfume = tipo_de_perfume;
        }
        public TipoDePerfume()
        {

        }
    }
}
