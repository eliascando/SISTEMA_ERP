using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model.Data;
using model.Entities;

namespace control
{
    public class PersonalCtrl
    {
        PersonalBD personalBD = new PersonalBD();
        public async Task<bool> ValidarCredenciales(string usuario, string password)
        {
            CredencialesAcceso credenciales = new CredencialesAcceso();
            credenciales.Usuario = usuario;
            credenciales.Password = password;
            return await personalBD.ValidarCredenciales(credenciales);
        }
        public async Task<Boolean> RegistrarPersonalCtrl(string cedula, string nombre, string apellido, string cargo, DateTime nacimiento, string sexo, string telefono, string correo, string direccion, DateTime ingreso, string salario)
        {
            Personal personal = new Personal();
            personal.Id = cedula;
            personal.Nombre = nombre;
            personal.Apellido = apellido;
            personal.Cargo = cargo;
            personal.Fecha_nacimiento = nacimiento;
            personal.Sexo = sexo;
            personal.Telefono = telefono;
            personal.Correo = correo;
            personal.Direccion = direccion;
            personal.Fecha_ingreso = ingreso;
            personal.Salario = Double.Parse(salario);
            personal.Personal_activo = true;
            personal.Usuario_asignado = false;

            return await personalBD.RegistrarPersonal(personal);
        }
        public async Task<DataTable>ObtenerPersonalSinUsuarioCtrl()
        {
            return await personalBD.ObtenerPersonalSinUsuario();
        }
        public async Task<List<RolUsuario>> ObtenerRolesCtrl()
        {
            return await personalBD.ObtenerRoles();
        }
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
            return await personalBD.RegistrarUsuario(personal, usuarios, credenciales);
        }
    }
}