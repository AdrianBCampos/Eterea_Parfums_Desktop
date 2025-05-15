using System.Collections.Generic;

namespace Eterea_Parfums_Desktop.Modelos
{
    public class Perfume
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public Marca marca { get; set; }
        public string nombre { get; set; }
        public TipoDePerfume tipo_de_perfume { get; set; }
        public Genero genero { get; set; }
        public int presentacion_ml { get; set; }
        public Pais pais { get; set; }
        public bool spray { get; set; }
        public bool recargable { get; set; }
        public string descripcion { get; set; }
        public int anio_de_lanzamiento { get; set; }
        public double precio_en_pesos { get; set; }
        public bool? activo { get; set; }
        public string imagen1 { get; set; }
        public string imagen2 { get; set; }


        public Perfume(int id, string codigo, Marca marca, string nombre, TipoDePerfume tipo_de_perfume
            , Genero genero, int presentacion_ml, Pais pais, bool spray, bool recargable, string descripcion,
            int anio_de_lanzamiento, double precio_en_pesos, bool? activo, string imagen1, string imagen2)
        {
            this.id = id;
            this.codigo = codigo;
            this.marca = marca;
            this.nombre = nombre;
            this.tipo_de_perfume = tipo_de_perfume;
            this.genero = genero;
            this.presentacion_ml = presentacion_ml;
            this.pais = pais;
            this.spray = spray;
            this.recargable = recargable;
            this.descripcion = descripcion;
            this.anio_de_lanzamiento = anio_de_lanzamiento;
            this.precio_en_pesos = precio_en_pesos;
            this.activo = activo;
            this.imagen1 = imagen1;
            this.imagen2 = imagen2;
        }

        public Perfume()
        {

        }

        public Perfume(int id)
        {
            this.id = id;
        }

        public Perfume(int id, bool? activo)
        {
            this.id = id;
            this.activo = activo;
        }
    }
}
