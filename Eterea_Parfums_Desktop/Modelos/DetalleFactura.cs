namespace Eterea_Parfums_Desktop.Modelos
{
    internal class DetalleFactura
    {
        public Factura factura { get; set; }
        public Perfume perfume { get; set; }
        public int cantidad { get; set; }
        public double precio_unitario { get; set; }

        public Promocion promocion { get; set; }

        public DetalleFactura(Factura factura, Perfume perfume, int cantidad, double precio_unitario, Promocion promocion)
        {
            this.factura = factura;
            this.perfume = perfume;
            this.cantidad = cantidad;
            this.precio_unitario = precio_unitario;
            this.promocion = promocion;
        }

        public DetalleFactura()
        {
        }
    }
}
