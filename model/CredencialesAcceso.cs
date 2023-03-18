using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

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

                    isValidUser = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR!: " + ex);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            
            return isValidUser; 
        }

    }
}
