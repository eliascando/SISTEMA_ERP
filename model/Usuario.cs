using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Usuario
    {
        private string id;
        private RolUsuario rol_usuario;
        private string nombre;
        private string apellido;
        private byte[] imagen;

        public Usuario()
        {

        }

        public Usuario(string id, RolUsuario rol_usuario, string nombre, string apellido, byte[] imagen)
        {
            Id = id;
            Rol_usuario = rol_usuario;
            Nombre = nombre;
            Apellido = apellido;
            Imagen = imagen;
        }

        public string Id { get => id; set => id = value; }
        public RolUsuario Rol_usuario { get => rol_usuario; set => rol_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
    }
}
