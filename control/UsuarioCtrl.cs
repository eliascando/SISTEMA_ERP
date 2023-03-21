using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace control
{
    public class UsuarioCtrl
    {
        public async Task<bool> RegistrarUsuarioCrl(string id, string nombre_rol, string nombres, string apellidos, byte[] imagen, string usuario, string password)
        {
            Personal personal = new Personal();
            Usuario usuarios = new Usuario();
            CredencialesAcceso credenciales = new CredencialesAcceso();

            usuarios.Id = id;
            personal.Cargo = nombre_rol;
            usuarios.Nombre = nombres;
            usuarios.Apellido = apellidos;
            usuarios.Imagen = imagen;
            credenciales.Usuario = usuario;
            credenciales.Password = password;
            credenciales.Usuario_activo = true;
            return await usuarios.RegistrarUsuario(personal, usuarios, credenciales);
        }
    }
}
