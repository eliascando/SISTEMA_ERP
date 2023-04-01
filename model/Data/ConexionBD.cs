using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace model.Data
{
    public class ConexionBD
    {
        public static SqlConnection cn;
        public static async Task<bool> AbrirConexionAsync()
        {
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = DecryptConnectionString(ConfigurationManager.ConnectionStrings["conexionsql"].ConnectionString);
                await cn.OpenAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN!: " + ex.Message);
                return false;
            }
        }
        public static async Task CerrarConexionAsync()
        {
            try
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    await cn.CloseAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN!: " + ex.Message);
            }
        }
        internal static string DecryptConnectionString(string connectionString)
        {
            string encryptionKey = "elin";
            connectionString = connectionString.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(connectionString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    connectionString = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return connectionString;
        }
    }
}