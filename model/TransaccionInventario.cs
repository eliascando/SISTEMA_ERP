using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class TransaccionInventario
    {
        private int id_transaccion_inventario;
        private string codigo_producto;
        private string id_usuario;
        private DateTime fechayhora;
        private int stock_total;
        private double peso_total;
        private string descripcion_actividad;

        public TransaccionInventario()
        {

        }

        public TransaccionInventario(int id_transaccion_inventario, string codigo_producto, string id_usuario, DateTime fechayhora, int stock_total, double peso_total, string descripcion_actividad)
        {
            Id_transaccion_inventario = id_transaccion_inventario;
            Codigo_producto = codigo_producto;
            Id_usuario = id_usuario;
            Fechayhora = fechayhora;
            Stock_total = stock_total;
            Peso_total = peso_total;
            Descripcion_actividad = descripcion_actividad;
        }

        public int Id_transaccion_inventario { get => id_transaccion_inventario; set => id_transaccion_inventario = value; }
        public string Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Id_usuario { get => id_usuario; set => id_usuario = value; }
        public DateTime Fechayhora { get => fechayhora; set => fechayhora = value; }
        public int Stock_total { get => stock_total; set => stock_total = value; }
        public double Peso_total { get => peso_total; set => peso_total = value; }
        public string Descripcion_actividad { get => descripcion_actividad; set => descripcion_actividad = value; }
    }
}
