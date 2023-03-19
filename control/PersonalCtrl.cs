using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
namespace control
{
    public class PersonalCtrl
    {
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

            return await personal.RegistrarPersonal(personal);
        }
    }
}
