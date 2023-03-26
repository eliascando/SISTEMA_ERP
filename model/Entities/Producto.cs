namespace model.Entities
{
    public class Producto
    {
        private string codigo_producto;
        private string id_proveedor;
        private TipoProducto tipo_producto;
        private EstadoProducto estado_producto;
        private string nombre_producto;
        private string descripcion;
        private byte[] imagen_producto;
        private double costo_producto;
        private double precio_producto;
        private bool aplica_producto;
        private bool aplica_descuento;
        private double descuento_producto;
        private bool venta_peso;
        private double peso_producto;
        private int unidades_caja;
        private int stock_producto;

        public Producto()
        {

        }

        public Producto(string codigo_producto, string id_proveedor, TipoProducto tipo_producto, EstadoProducto estado_producto, string nombre_producto, string descripcion, byte[] imagen_producto, double costo_producto, double precio_producto, bool aplica_producto, bool aplica_descuento, double descuento_producto, bool venta_peso, double peso_producto, int unidades_caja, int stock_producto)
        {
            Codigo_producto = codigo_producto;
            Id_proveedor = id_proveedor;
            Tipo_producto = tipo_producto;
            Estado_producto = estado_producto;
            Nombre_producto = nombre_producto;
            Descripcion = descripcion;
            Imagen_producto = imagen_producto;
            Costo_producto = costo_producto;
            Precio_producto = precio_producto;
            Aplica_producto = aplica_producto;
            Aplica_descuento = aplica_descuento;
            Descuento_producto = descuento_producto;
            Venta_peso = venta_peso;
            Peso_producto = peso_producto;
            Unidades_caja = unidades_caja;
            Stock_producto = stock_producto;
        }

        public string Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public TipoProducto Tipo_producto { get => tipo_producto; set => tipo_producto = value; }
        public EstadoProducto Estado_producto { get => estado_producto; set => estado_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public byte[] Imagen_producto { get => imagen_producto; set => imagen_producto = value; }
        public double Costo_producto { get => costo_producto; set => costo_producto = value; }
        public double Precio_producto { get => precio_producto; set => precio_producto = value; }
        public bool Aplica_producto { get => aplica_producto; set => aplica_producto = value; }
        public bool Aplica_descuento { get => aplica_descuento; set => aplica_descuento = value; }
        public double Descuento_producto { get => descuento_producto; set => descuento_producto = value; }
        public bool Venta_peso { get => venta_peso; set => venta_peso = value; }
        public double Peso_producto { get => peso_producto; set => peso_producto = value; }
        public int Unidades_caja { get => unidades_caja; set => unidades_caja = value; }
        public int Stock_producto { get => stock_producto; set => stock_producto = value; }
    }
}