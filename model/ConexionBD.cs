using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace model
{
    public class ConexionBD
    {
        private static readonly string ConnectionString = "Data Source=.;Initial Catalog=SISTEMA_ERP;Integrated Security=True";
        public static async Task<bool> AbrirConexionAsync()
        {
            try
            {
                using SqlConnection cn = new SqlConnection(ConnectionString);
                await cn.OpenAsync();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN!: " + ex.Message);
                return false;
            }
        }
        public static async Task CerrarConexionAsync()
        {
            try
            {
                using SqlConnection cn = new SqlConnection(ConnectionString);
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    await cn.CloseAsync();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN!: " + ex.Message);
            }
        }
    }
}
