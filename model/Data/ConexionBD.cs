using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

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
                cn.ConnectionString = connectionString;
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
