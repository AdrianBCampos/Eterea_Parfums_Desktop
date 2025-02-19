namespace Eterea_Parfums_Desktop.Modelos
{
    public class NotaConTipoDeNota
    {
        public int id { get; set; }
        public Nota nota { get; set; }
        public TipoDeNota tipoDeNota { get; set; }

        public NotaConTipoDeNota(int id, Nota nota, TipoDeNota tipoDeNota)
        {
            this.id = id;
            this.nota = nota;
            this.tipoDeNota = tipoDeNota;
        }

        public NotaConTipoDeNota()
        {
        }
    }
}
