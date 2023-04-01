using System.Data.SqlClient;
using System.Configuration;
using aurora;
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
                string connectionString = ConfigurationManager.ConnectionStrings["conexionsql"].ConnectionString;
                string decryptedConnection = Aurora.DecryptConnectionString(connectionString);
                cn.ConnectionString = decryptedConnection;
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
    }
}