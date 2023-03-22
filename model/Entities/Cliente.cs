using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.Entities
{
    public class Cliente
    {
        private string id;
        private string nombre;
        private string apellido;
        private string telefono;
        private string correo;
        private string direccion;

        public Cliente()
        {

        }
        public Cliente(string id, string nombre, string apellido, string telefono, string correo, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
