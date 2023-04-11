namespace model.Entities
{
    public class OrdenCompra
    {
        private string numero_orden;
        private string id_proveedor;
        private string id_establecimiento;
        private string id_usuario;
        private DateTime fechayhora;
        private double subtotal;
        private double descuento_total;
        private double iva_total;
        private double valor_total;

        public OrdenCompra()
        {

        }

        public OrdenCompra(string numero_orden, string id_proveedor, string id_establecimiento, string id_usuario, DateTime fechayhora, double subtotal, double descuento_total, double iva_total, double valor_total)
        {
            Numero_orden = numero_orden;
            Id_proveedor = id_proveedor;
            Id_establecimiento = id_establecimiento;
            Id_usuario = id_usuario;
            Fechayhora = fechayhora;
            Subtotal = subtotal;
            Descuento_total = descuento_total;
            Iva_total = iva_total;
            Valor_total = valor_total;
        }

        public string Numero_orden { get => numero_orden; set => numero_orden = value; }
        public string Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Id_establecimiento { get => id_establecimiento; set => id_establecimiento = value; }
        public string Id_usuario { get => id_usuario; set => id_usuario = value; }
        public DateTime Fechayhora { get => fechayhora; set => fechayhora = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Descuento_total { get => descuento_total; set => descuento_total = value; }
        public double Iva_total { get => iva_total; set => iva_total = value; }
        public double Valor_total { get => valor_total; set => valor_total = value; }
    }
}