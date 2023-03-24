using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.CodeDom;

namespace model.Entities
{
    public class Personal
    {
        private string id;
        private string nombre_personal;
        private string apellido_personal;
        private string telefono;
        private string correo;
        private string direccion;
        private string cargo;
        private DateTime fecha_nacimiento;
        private string sexo;
        private DateTime fecha_ingreso;
        private double salario;
        private bool personal_activo;
        private bool usuario_asignado;

        public Personal()
        {

        }

        public Personal(string id, string nombre_personal, string apellido_personal, string telefono, string correo, string direccion, string cargo, DateTime fecha_nacimiento, string sexo, DateTime fecha_ingreso, double salario, bool personal_activo, bool usuario_asignado)
        {
            Id = id;
            Nombre_personal = nombre_personal;
            Apellido_personal = apellido_personal;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
            Cargo = cargo;
            Fecha_nacimiento = fecha_nacimiento;
            Sexo = sexo;
            Fecha_ingreso = fecha_ingreso;
            Salario = salario;
            Personal_activo = personal_activo;
            Usuario_asignado = usuario_asignado;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre_personal { get => nombre_personal; set => nombre_personal = value; }
        public string Apellido_personal { get => apellido_personal; set => apellido_personal = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public double Salario { get => salario; set => salario = value; }
        public bool Personal_activo { get => personal_activo; set => personal_activo = value; }
        public bool Usuario_asignado { get => usuario_asignado; set => usuario_asignado = value; }
    }
}
