using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Personal : Persona
    {
        private string cargo;
        private DateOnly fecha_nacimiento;
        private string sexo;
        private DateOnly fecha_ingreso;
        private double salario;
        private bool personal_activo;

        public Personal()
        {

        }

        public Personal(string cargo, DateOnly fecha_nacimiento, string sexo, DateOnly fecha_ingreso, double salario, bool personal_activo)
        {
            Cargo = cargo;
            Fecha_nacimiento = fecha_nacimiento;
            Sexo = sexo;
            Fecha_ingreso = fecha_ingreso;
            Salario = salario;
            Personal_activo = personal_activo;
        }

        public string Cargo { get => cargo; set => cargo = value; }
        public DateOnly Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateOnly Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public double Salario { get => salario; set => salario = value; }
        public bool Personal_activo { get => personal_activo; set => personal_activo = value; }
    }
}
