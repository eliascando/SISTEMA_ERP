using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;

namespace model
{
    public class CredencialesAcceso
    {
        private string id_usuario;
        private string usuario;
        private string password;
        private bool usuario_activo;
    

        public CredencialesAcceso()
        {

        }

        public CredencialesAcceso(string id_usuario, string usuario, string password, bool usuario_activo)
        {
            Id_usuario = id_usuario;
            Usuario = usuario;
            Password = password;
            Usuario_activo = usuario_activo;
        }

        public string Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public bool Usuario_activo { get => usuario_activo; set => usuario_activo = value; }

        public String EncriptarPassword(String password)
        {
            string hashedpassword;
            using (var sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                hashedpassword = Convert.ToBase64String(hash);
            }
            return hashedpassword;
        }
        public async Task<bool> ValidarCredenciales(CredencialesAcceso credencialesAcceso)
        {
            bool isValidUser = false;
            try
            {
                if(await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("ValidarCredenciales",ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", credencialesAcceso.id_usuario);
                    cmd.Parameters.AddWithValue("@password",EncriptarPassword(credencialesAcceso.password));
                    SqlParameter esValidoParam = new SqlParameter("@EsValido", SqlDbType.Bit);
                    esValidoParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(esValidoParam);
                    SqlParameter idRolParam = new SqlParameter("@IdRol", SqlDbType.Int);
                    idRolParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(idRolParam);
                    await cmd.ExecuteNonQueryAsync();
                    
                    isValidUser = (bool)esValidoParam.Value;    
                    if (isValidUser)
                    {
                        MessageBox.Show("Credenciales Válidas!");
                        GlobalVariables.id_rol = (int)idRolParam.Value;
                    }
                    else
                    {
                        MessageBox.Show("Credenciales No Válidas!");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR!: Conexión a la base de datos");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN!: " + ex);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            
            return isValidUser; 
        }

    }
}
