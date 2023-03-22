using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.Entities
{
    public class Producto
    {
        private string codigo;
        private string id_proveedor;
        private TipoProducto tipo;
        private EstadoProducto estado;
        private string nombre;
        private string descripcion;
        private byte[] imagen;
        private double costo;
        private double precio;
        private bool aplica_iva;
        private bool aplica_descuento;
        private double descuento;
        private bool venta_peso;
        private double peso;
        private int unidades_caja;
        private int stock_producto;

        public Producto()
        {

        }

        public Producto(string codigo, string id_proveedor, TipoProducto tipo, EstadoProducto estado, string nombre, string descripcion, byte[] imagen, double costo, double precio, bool aplica_iva, bool aplica_descuento, double descuento, bool venta_peso, double peso, int unidades_caja, int stock_producto)
        {
            Codigo = codigo;
            Id_proveedor = id_proveedor;
            Tipo = tipo;
            Estado = estado;
            Nombre = nombre;
            Descripcion = descripcion;
            Imagen = imagen;
            Costo = costo;
            Precio = precio;
            Aplica_iva = aplica_iva;
            Aplica_descuento = aplica_descuento;
            Descuento = descuento;
            Venta_peso = venta_peso;
            Peso = peso;
            Unidades_caja = unidades_caja;
            Stock_producto = stock_producto;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public TipoProducto Tipo { get => tipo; set => tipo = value; }
        public EstadoProducto Estado { get => estado; set => estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
        public double Costo { get => costo; set => costo = value; }
        public double Precio { get => precio; set => precio = value; }
        public bool Aplica_iva { get => aplica_iva; set => aplica_iva = value; }
        public bool Aplica_descuento { get => aplica_descuento; set => aplica_descuento = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public bool Venta_peso { get => venta_peso; set => venta_peso = value; }
        public double Peso { get => peso; set => peso = value; }
        public int Unidades_caja { get => unidades_caja; set => unidades_caja = value; }
        public int Stock_producto { get => stock_producto; set => stock_producto = value; }
    }
}
