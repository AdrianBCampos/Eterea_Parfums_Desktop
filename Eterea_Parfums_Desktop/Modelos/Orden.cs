using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eterea_Parfums_Desktop.Modelos
{
    public class Orden
    {
        public int numero_de_orden { get; set; }
        public int factura_id { get; set; }
        public string nombre_cliente { get; set; }  
        public string apellido_cliente { get; set; }    
        public long dni { get; set; }
        public string e_mail_cliente { get; set; }
        public string domicilio_de_envio { get; set; }
        public bool estado { get; set; }
        public long codigo_despacho { get; set; }

        public Orden(int numero_de_orden, int factura_id, string nombre_cliente,
            string apellido_cliente, long dni, string e_mail_cliente, string domicilio_de_envio,
            bool estado, long codigo_despacho)
        {
            this.numero_de_orden = numero_de_orden;
            this.factura_id = factura_id;
            this.nombre_cliente = nombre_cliente;
            this.apellido_cliente = apellido_cliente;
            this.dni = dni;
            this.e_mail_cliente = e_mail_cliente;
            this.domicilio_de_envio = domicilio_de_envio;
            this.estado = estado;
            this.codigo_despacho = codigo_despacho;
        }

        public Orden()
        {

        }
    }
}



