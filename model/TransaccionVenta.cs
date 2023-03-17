using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class TransaccionVenta
    {
        private int id_transaccion_venta;
        private string numero_factura;
        private int cantidad_producto_vendido;
        private double valor_producto_vendido;
        private DateTime fechayhora;

        public TransaccionVenta()
        {

        }

        public TransaccionVenta(int id_transaccion_venta, string numero_factura, int cantidad_producto_vendido, double valor_producto_vendido, DateTime fechayhora)
        {
            Id_transaccion_venta = id_transaccion_venta;
            Numero_factura = numero_factura;
            Cantidad_producto_vendido = cantidad_producto_vendido;
            Valor_producto_vendido = valor_producto_vendido;
            Fechayhora = fechayhora;
        }

        public int Id_transaccion_venta { get => id_transaccion_venta; set => id_transaccion_venta = value; }
        public string Numero_factura { get => numero_factura; set => numero_factura = value; }
        public int Cantidad_producto_vendido { get => cantidad_producto_vendido; set => cantidad_producto_vendido = value; }
        public double Valor_producto_vendido { get => valor_producto_vendido; set => valor_producto_vendido = value; }
        public DateTime Fechayhora { get => fechayhora; set => fechayhora = value; }
    }
}
