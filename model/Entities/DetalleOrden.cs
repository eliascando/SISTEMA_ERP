namespace model.Entities
{
    public class DetalleOrden
    {
        private int id_orden;
        private string numero_orden;
        private string codigo_producto;
        private int cantidad_producto;
        private double costo_unitario;
        private double iva_producto;
        private double descuento_producto;
        private double total_producto;

        public DetalleOrden()
        {

        }

        public DetalleOrden(int id_orden, string numero_orden, string codigo_producto, int cantidad_producto, double costo_unitario, double iva_producto, double descuento_producto, double total_producto)
        {
            Id_orden = id_orden;
            Numero_orden = numero_orden;
            Codigo_producto = codigo_producto;
            Cantidad_producto = cantidad_producto;
            Costo_unitario = costo_unitario;
            Iva_producto = iva_producto;
            Descuento_producto = descuento_producto;
            Total_producto = total_producto;
        }

        public int Id_orden { get => id_orden; set => id_orden = value; }
        public string Numero_orden { get => numero_orden; set => numero_orden = value; }
        public string Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public int Cantidad_producto { get => cantidad_producto; set => cantidad_producto = value; }
        public double Costo_unitario { get => costo_unitario; set => costo_unitario = value; }
        public double Iva_producto { get => iva_producto; set => iva_producto = value; }
        public double Descuento_producto { get => descuento_producto; set => descuento_producto = value; }
        public double Total_producto { get => total_producto; set => total_producto = value; }
    }
}