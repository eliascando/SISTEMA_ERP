using model.Entities;
using System.Data;
using System.Data.SqlClient;

namespace model.Data
{
    public class RegistroActividadesBD
    {
        public async Task RegistroInicioSesion(RegistroInicioSesion inicioSesion)
        {
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("RegistrarLogin", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", inicioSesion.Id_usuario);
                    cmd.Parameters.AddWithValue("@fechayhora", inicioSesion.Fechayhora);
                    cmd.Parameters.AddWithValue("@estado", inicioSesion.Estado_inicio_sesion);
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
        public async Task RegistroModificacionUsuario(RegistroModificacionUsuario modificacionUsuario)
        {
            try
            {
                if(await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("RegistrarModificacionUsuario", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario_modificado", modificacionUsuario.Id_usuario_modificado);
                    cmd.Parameters.AddWithValue("@id_usuario_responsable", modificacionUsuario.Id_usuario_responsable);
                    cmd.Parameters.AddWithValue("@fechayhora", modificacionUsuario.Fechayhora);
                    cmd.Parameters.AddWithValue("@detalle_modificacion", modificacionUsuario.Detalle_modificacion);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch(Exception ex)
            {
                throw new Exception (ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
        }
        public async Task<DataTable> ObtenerModificacionesPorUsuario(string id)
        {
            DataTable modificacionesDT = new DataTable();
            try
            {
                var cmd = new SqlCommand("ObtenerModificaciones", ConexionBD.cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_usuario", id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(modificacionesDT);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return modificacionesDT;
        }
    }
}