namespace model.Entities
{
    public class DetalleFactura
    {
        private int id_detalle;
        private string numero_factura;
        private string codigo_producto;
        private int cantidad_producto;
        private double precio_unitario;
        private double iva_producto;
        private double descuento_producto;
        private double total_producto;

        public DetalleFactura()
        {

        }

        public DetalleFactura(int id_detalle, string numero_factura, string codigo_producto, int cantidad_producto, double precio_unitario, double iva_producto, double descuento_producto, double total_producto)
        {
            Id_detalle = id_detalle;
            Numero_factura = numero_factura;
            Codigo_producto = codigo_producto;
            Cantidad_producto = cantidad_producto;
            Precio_unitario = precio_unitario;
            Iva_producto = iva_producto;
            Descuento_producto = descuento_producto;
            Total_producto = total_producto;
        }

        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public string Numero_factura { get => numero_factura; set => numero_factura = value; }
        public string Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public int Cantidad_producto { get => cantidad_producto; set => cantidad_producto = value; }
        public double Precio_unitario { get => precio_unitario; set => precio_unitario = value; }
        public double Iva_producto { get => iva_producto; set => iva_producto = value; }
        public double Descuento_producto { get => descuento_producto; set => descuento_producto = value; }
        public double Total_producto { get => total_producto; set => total_producto = value; }
    }
}