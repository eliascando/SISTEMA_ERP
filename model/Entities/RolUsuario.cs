using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace model.Entities
{
    public class RolUsuario
    {
        private int id;
        private string nombre;

        public RolUsuario()
        {

        }

        public RolUsuario(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
