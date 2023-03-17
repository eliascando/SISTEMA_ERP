using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class CategoriaProducto
    {
        private int id;
        private string nombre;

        public CategoriaProducto()
        {

        }

        public CategoriaProducto(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
