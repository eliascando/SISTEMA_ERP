using System.Data;
using System.Data.SqlClient;

namespace model.Data
{
    public class RegistroActividadesBD
    {
        public async Task RegistroInicioSesion(string id, string estado)
        {
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("RegistrarLogin", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", id);
                    cmd.Parameters.AddWithValue("@fechayhora", DateTime.Now);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
        }
        public async Task<DataTable> ObtenerLoginsPorUsuario(string id)
        {
            DataTable loginsDT = new DataTable();
            try
            {
                var cmd = new SqlCommand("ObtenerLogins", ConexionBD.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", id);
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(loginsDT);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return loginsDT;
        }
    }
}