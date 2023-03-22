using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.Entities
{
    public class EstadoProducto
    {
        private int id_estado;
        private string nombre;

        public EstadoProducto()
        {

        }

        public EstadoProducto(int id_estado, string nombre)
        {
            Id_estado = id_estado;
            Nombre = nombre;
        }

        public int Id_estado { get => id_estado; set => id_estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
