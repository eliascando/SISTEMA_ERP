﻿using libraries;
using System.Data;
using model.Data;
using model.Entities;

namespace control
{
    public class PersonalCtrl
    {
        PersonalBD personalBD = new PersonalBD();
        public async Task<bool> ValidarCredenciales(string id_usuario, string password)
        {
            CredencialesAcceso credenciales = new CredencialesAcceso();
            credenciales.Id_usuario = id_usuario;
            credenciales.Password = Alquimia.Encrypt(password);
            return await personalBD.ValidarCredenciales(credenciales);
        }
        public async Task<bool> SendEmailCtrl(string id)
        {
            return await personalBD.SendEmail(id);
        }
        public bool ValidarOTPCtrl(string key, string otp)
        {
            return OTPKey.ValidateOTP(key, otp);
        }
        public async Task<Boolean> RegistrarPersonalCtrl(string cedula, string nombre, string apellido, string cargo, byte[]imagen, DateTime nacimiento, string sexo, string telefono, string correo, string direccion, DateTime ingreso, string salario)
        {
            Personal personal = new Personal();
            personal.Id_personal = cedula;
            personal.Nombre_personal = nombre;
            personal.Apellido_personal = apellido;
            personal.Cargo = cargo;
            personal.Imagen = imagen;
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
        public async Task<bool> RegistrarUsuarioCtrl(string id, string nombre_rol, string nombres, string apellidos, string usuario, string password)
        {
            Personal personal = new Personal();
            Usuario usuarios = new Usuario();
            CredencialesAcceso credenciales = new CredencialesAcceso();

            usuarios.Id = id;
            personal.Cargo = nombre_rol;
            usuarios.Nombre = nombres;
            usuarios.Apellido = apellidos;
            usuarios.User = usuario;
            credenciales.Password = Alquimia.Encrypt(password);
            credenciales.Usuario_activo = true;
            return await personalBD.RegistrarUsuario(personal, usuarios, credenciales);
        }
        public async Task<DataTable> ObtenerUsuarios()
        {
            return await personalBD.ObtenerUsuarios();
        }
        public async Task<Dictionary<string, object>> ObtenerDatosUsuariosCtrl(string id)
        {
            return await personalBD.ObtenerDatosUsuarios(id);
        }
        public async Task<bool> RegistrarGerenteCtrl(string id, string nombre, string apellido, DateTime nacimiento, string sexo, string telefono, string correo, string direccion, DateTime ingreso, string salario, byte[] imagen, string usuario, string password)
        {
            Dictionary<string, object> DatosCombinados = new Dictionary<string, object>();
            Personal personal = new Personal();
            Usuario usuarios = new Usuario();
            CredencialesAcceso credenciales = new CredencialesAcceso();

            personal.Id_personal = id;
            personal.Nombre_personal = nombre;
            personal.Apellido_personal = apellido;
            personal.Fecha_nacimiento = nacimiento;
            personal.Sexo = sexo;
            personal.Telefono = telefono;
            personal.Correo = correo;
            personal.Direccion = direccion;
            personal.Fecha_ingreso = ingreso;
            personal.Salario = Double.Parse(salario);
            personal.Imagen = imagen;
            usuarios.User = usuario;
            credenciales.Password = Alquimia.Encrypt(password);
            DatosCombinados = Alquimia.CombineObjects(personal, usuarios, credenciales);
            return await personalBD.RegistrarGerente(DatosCombinados);
        }
        public async Task<bool> ActualizarDatosUsuarioCtrl(string id, string telefono, string correo, string direccion, byte[] imagen)
        {
            Personal personal = new Personal();
            Usuario usuario = new Usuario();
            personal.Id_personal = id; 
            personal.Telefono = telefono;
            personal.Correo = correo;
            personal.Direccion = direccion;
            personal.Imagen = imagen;
            
            return await personalBD.ActualizarDatosPersonal(Alquimia.CombineObjects(personal,usuario));
        }
        public async Task<bool> CambiarCredencialesCtrl(string id, string newPassword)
        {
            CredencialesAcceso credenciales = new CredencialesAcceso();
            credenciales.Id_usuario = id;
            credenciales.Password = Alquimia.Encrypt(newPassword);

            return await personalBD.CambiarCredenciales(credenciales);
        }
        public async Task CambiarEstadoPersonal(string id, bool estado_usuario, bool estado_personal)
        {
            Personal personal = new Personal();
            CredencialesAcceso credenciales = new CredencialesAcceso();
            personal.Id_personal = id;
            personal.Personal_activo = estado_personal;
            credenciales.Usuario_activo = estado_usuario;

            await personalBD.CambiarEstadoPersonal(personal, credenciales);
        }
    }
}