using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.Entities
{
    public class Factura
    {
        private string numero_factura;
        private string id_cliente;
        private string id_establecimiento;
        private string id_usuario;
        private int id_forma_pago;
        private DateTime fechayhora;
        private double subtotal;
        private double descuento_total;
        private double iva_total;
        private double valor_total;

        public Factura()
        {

        }

        public Factura(string numero_factura, string id_cliente, string id_establecimiento, string id_usuario, int id_forma_pago, DateTime fechayhora, double subtotal, double descuento_total, double iva_total, double valor_total)
        {
            Numero_factura = numero_factura;
            Id_cliente = id_cliente;
            Id_establecimiento = id_establecimiento;
            Id_usuario = id_usuario;
            Id_forma_pago = id_forma_pago;
            Fechayhora = fechayhora;
            Subtotal = subtotal;
            Descuento_total = descuento_total;
            Iva_total = iva_total;
            Valor_total = valor_total;
        }

        public string Numero_factura { get => numero_factura; set => numero_factura = value; }
        public string Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Id_establecimiento { get => id_establecimiento; set => id_establecimiento = value; }
        public string Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_forma_pago { get => id_forma_pago; set => id_forma_pago = value; }
        public DateTime Fechayhora { get => fechayhora; set => fechayhora = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Descuento_total { get => descuento_total; set => descuento_total = value; }
        public double Iva_total { get => iva_total; set => iva_total = value; }
        public double Valor_total { get => valor_total; set => valor_total = value; }
    }
}
