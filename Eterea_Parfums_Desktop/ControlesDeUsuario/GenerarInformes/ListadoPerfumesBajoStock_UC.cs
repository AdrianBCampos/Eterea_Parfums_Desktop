using Eterea_Parfums_Desktop.Controladores;
using Eterea_Parfums_Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eterea_Parfums_Desktop.ControlesDeUsuario.GenerarInformes
{
    public partial class ListadoPerfumesBajoStock_UC : UserControl
    {
        private int idSucursal;
        public ListadoPerfumesBajoStock_UC(int idSucursal)
        {
            InitializeComponent();

            this.idSucursal = idSucursal;

            CargarDatos();
            
        }
        private void CargarDatos()
        {
            dataGridViewPerfumes.Rows.Clear();

            var perfumes = PerfumeControlador.getAll(); // devuelve List<Perfume>
            var stocks = StockControlador.getAll()
                .Where(s => s.sucursal != null && s.sucursal.id == idSucursal)
                .ToList(); // List<Stock> de la sucursal actual

            foreach (var stock in stocks)
            {
                var perfume = perfumes.FirstOrDefault(p => p.id == stock.perfume.id);
                if (perfume == null) continue;

                int cantidadStock = stock.cantidad;
                bool? activo = perfume.activo;

                bool incluir =
                    (cantidadStock > 0 && cantidadStock <= 5) ||
                    (cantidadStock == 0 && (
                        (activo ?? false) || // si es null, lo tratamos como false
                        (!activo.GetValueOrDefault() && perfume.fecha_baja.HasValue && perfume.fecha_baja.Value >= DateTime.Now.AddDays(-30))
                    ));

                if (incluir)
                {
                    string marca = perfume.marca != null ? MarcaControlador.getById(perfume.marca.id)?.nombre ?? "Sin marca" : "Sin marca";
                    string tipo = perfume.tipo_de_perfume != null ? TipoDePerfumeControlador.getById(perfume.tipo_de_perfume.id)?.tipo_de_perfume ?? "Sin tipo" : "Sin tipo";
                    string genero = perfume.genero != null ? GeneroControlador.getById(perfume.genero.id)?.genero ?? "Sin género" : "Sin género";

                    dataGridViewPerfumes.Rows.Add(
                        perfume.codigo,
                        marca,
                        perfume.nombre,
                        tipo,
                        genero,
                        $"{perfume.presentacion_ml} ml",
                        perfume.precio_en_pesos.ToString("C"),
                        cantidadStock
                    );


                }
            }
        }

    }
}
