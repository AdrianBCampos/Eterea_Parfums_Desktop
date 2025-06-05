using System;

namespace Eterea_Parfums_Desktop.Modelos
{
    internal class Factura
    {
        public int id { get; set; } 
        public DateTime fecha { get; set; }
        public Sucursal sucursal_id { get; set; }
        public Empleado empleado_id { get; set; }
        public Cliente cliente_id { get; set; }
        public String forma_de_pago { get; set; }
        public double precio_total { get; set; }
        public double recargo_tarjeta { get; set; }
        public double descuento { get; set; }
        public int numero_de_caja { get; set; }
        public String tipo_de_consumidor { get; set; }
        public String origen { get; set; }
        public String factura_pdf { get; set; }
        public string num_factura { get; set; }
        public string tipo_de_factura { get; set; }

        public Factura(int id, DateTime fecha, Sucursal sucursal, Empleado empleado, Cliente cliente, string forma_de_pago,
            double precio_total, double recargo_tarjeta, double descuento, int numero_de_caja,
            string tipo_de_consumidor, string origen, string factura_pdf, string num_factura, string tipo_de_factura)
        {
            this.id = id;
            this.fecha = fecha;
            this.sucursal_id = sucursal;
            this.empleado_id = empleado;
            this.cliente_id = cliente;
            this.forma_de_pago = forma_de_pago;
            this.precio_total = precio_total;
            this.recargo_tarjeta = recargo_tarjeta;
            this.descuento = descuento;
            this.numero_de_caja = numero_de_caja;
            this.tipo_de_consumidor = tipo_de_consumidor;
            this.origen = origen;
            this.factura_pdf = factura_pdf;
            this.num_factura = num_factura;
            this.tipo_de_factura = tipo_de_factura;
        }

        public Factura()
        {

        }
    }
}
