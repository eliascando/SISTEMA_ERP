using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.CodeDom;

namespace model
{
    public class Personal
    {
        private string id;
        private string nombre;
        private string apellido;
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

        public Personal(string id, string nombre, string apellido, string telefono, string correo, string direccion, string cargo, DateTime fecha_nacimiento, string sexo, DateTime fecha_ingreso, double salario, bool personal_activo, bool usuario_asignado)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
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
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
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

        public async Task<bool> RegistrarPersonal(Personal personal)
        {
            bool registroExitoso=false;
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("RegistrarPersonal", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cedula", personal.Id);
                    cmd.Parameters.AddWithValue("@nombre_personal", personal.Nombre);
                    cmd.Parameters.AddWithValue("@apellido_personal", personal.Apellido);
                    cmd.Parameters.AddWithValue("@cargo_personal", personal.Cargo);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento", personal.Fecha_nacimiento);
                    cmd.Parameters.AddWithValue("@sexo", personal.Sexo);
                    cmd.Parameters.AddWithValue("@telefono_personal", personal.Telefono);
                    cmd.Parameters.AddWithValue("@correo_personal", personal.Correo);
                    cmd.Parameters.AddWithValue("@direccion_personal", personal.Direccion);
                    cmd.Parameters.AddWithValue("@fecha_ingreso", personal.Fecha_ingreso);
                    cmd.Parameters.AddWithValue("@salario_mensual", personal.Salario);
                    cmd.Parameters.AddWithValue("@personal_activo", personal.Personal_activo);
                    cmd.Parameters.AddWithValue("@usuario_asignado", personal.Usuario_asignado);
                    SqlParameter registroExitosoParam = new SqlParameter("@RegistroExitoso", SqlDbType.Bit);
                    registroExitosoParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(registroExitosoParam);
                    await cmd.ExecuteNonQueryAsync();
                    
                    registroExitoso = (bool)registroExitosoParam.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN!: " + ex);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return registroExitoso;
        }
        public async Task<DataTable> ObtenerPersonalSinUsuario()
        {
            DataTable personalDT = new DataTable();
            try
            {
                //personalDT.Columns.Add("ID");
                //personalDT.Columns.Add("Nombres");
                //personalDT.Columns.Add("Apellidos");
                if(await ConexionBD.AbrirConexionAsync())
                {                   
                    var cmd = new SqlCommand("ObtenerPersonalSinUsuario", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(personalDT);
                }

            }catch(Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN!: " + ex);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return personalDT;
        }
    }
}
