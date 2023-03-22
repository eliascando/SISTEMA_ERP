using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.Entities
{
    public class TipoProducto
    {
        private int id;
        private int id_categoria;
        private string nombre;

        public TipoProducto()
        {

        }

        public TipoProducto(int id, int id_categoria, string nombre)
        {
            Id = id;
            Id_categoria = id_categoria;
            Nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
