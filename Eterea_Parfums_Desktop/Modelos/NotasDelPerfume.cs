namespace Eterea_Parfums_Desktop.Modelos
{
    public class NotasDelPerfume
    {
        public Perfume perfume { get; set; }
        public NotaConTipoDeNota notaConTipoDeNota { get; set; }

        public NotasDelPerfume(Perfume perfume, NotaConTipoDeNota notaConTipoDeNota)
        {
            this.perfume = perfume;
            this.notaConTipoDeNota = notaConTipoDeNota;
        }

        public NotasDelPerfume()
        {
        }
    }
}
