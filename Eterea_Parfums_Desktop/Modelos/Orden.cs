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
        public int num_factura { get; set; }
        public string nombre_cliente { get; set; }  
        public string apellido_cliente { get; set; }    
        public int dni { get; set; }
        public string e_mail_cliente { get; set; }
        public string domicilio_de_envio { get; set; }
        public bool estado { get; set; }
        public long codigo_despacho { get; set; }

        public Orden(int numero_de_orden, int num_factura, string nombre_cliente,
            string apellido_cliente, int dni, string e_mail_cliente, string domicilio_de_envio,
            bool estado, long codigo_despacho)
        {
            this.numero_de_orden = numero_de_orden;
            this.num_factura = num_factura;
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



