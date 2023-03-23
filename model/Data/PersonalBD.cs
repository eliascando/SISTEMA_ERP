using model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using aurora;

namespace model.Data
{
    public class PersonalBD
    {
        public async Task<bool> ValidarCredenciales(CredencialesAcceso credencialesAcceso)
        {
            bool isValidUser = false;
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("ValidarCredenciales", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", credencialesAcceso.Usuario);
                    cmd.Parameters.AddWithValue("@password", Aurora.Encrypt(credencialesAcceso.Password));
                    SqlParameter esValidoParam = new SqlParameter("@EsValido", SqlDbType.Bit);
                    esValidoParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(esValidoParam);
                    SqlParameter nombreParam = new SqlParameter("@NombreCompleto", SqlDbType.NVarChar, 200);
                    nombreParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(nombreParam);
                    SqlParameter idRolParam = new SqlParameter("@IdRol", SqlDbType.Int);
                    idRolParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(idRolParam);
                    await cmd.ExecuteNonQueryAsync();

                    isValidUser = (bool)esValidoParam.Value;
                    if (isValidUser)
                    {
                        GlobalVariables.id_rol = (int)idRolParam.Value;
                        GlobalVariables.usuario = (string)nombreParam.Value;
                    }
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

            return isValidUser;
        }
        public async Task<bool> RegistrarPersonal(Personal personal)
        {
            bool registroExitoso = false;
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
                if (await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("ObtenerPersonalSinUsuario", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(personalDT);
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
            return personalDT;
        }
        public async Task<List<RolUsuario>> ObtenerRoles()
        {
            List<RolUsuario> roles = new List<RolUsuario>();
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("ObtenerRoles", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    roles.Insert(0, new RolUsuario(-1, "Elegir cargo..."));
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            roles.Add(new RolUsuario(id, nombre));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN: " + ex);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return roles;
        }
        public async Task<bool> RegistrarUsuario(Personal personal, Usuario usuario, CredencialesAcceso credenciales)
        {
            bool registroExitoso = false;
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("RegistrarUsuario", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", usuario.Id);
                    cmd.Parameters.AddWithValue("@nombre_rol", personal.Cargo);
                    cmd.Parameters.AddWithValue("@nombre_usuario", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellido_usuario", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@imagen_usuario", usuario.Imagen);
                    cmd.Parameters.AddWithValue("@usuario", credenciales.Usuario);
                    cmd.Parameters.AddWithValue("@password", Aurora.Encrypt(credenciales.Password));
                    cmd.Parameters.AddWithValue("@usuario_activo", credenciales.Usuario_activo);
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
    }
}