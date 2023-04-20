using model.Entities;
using System.Data;
using System.Data.SqlClient;

namespace model.Data
{
    public class RegistroActividadesBD
    {
        /// <summary>
        /// Registra la información de inicio de sesión de un usuario en la base de datos.
        /// </summary>
        /// <param name="inicioSesion">Objeto de tipo RegistroInicioSesion que contiene la información de inicio de sesión del usuario.</param>
        /// <returns>Una tarea asincrónica que representa la ejecución del registro de inicio de sesión en la base de datos.</returns>
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

        /// <summary>
        /// Obtiene los registros de inicio de sesión de un usuario específico desde la base de datos en forma de DataTable.
        /// </summary>
        /// <param name="id">ID del usuario del cual se obtendrán los registros de inicio de sesión.</param>
        /// <returns>Un objeto DataTable que contiene los registros de inicio de sesión del usuario.</returns>
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

        /// <summary>
        /// Registra una modificación de usuario en la base de datos.
        /// </summary>
        /// <param name="modificacionUsuario">Objeto de tipo RegistroModificacionUsuario que contiene los datos de la modificación de usuario.</param>
        /// <returns>Tarea asincrónica que representa la finalización de la operación.</returns>
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

        /// <summary>
        /// Obtiene las modificaciones de usuario asociadas a un usuario específico de la base de datos.
        /// </summary>
        /// <param name="id">ID del usuario para el cual se obtienen las modificaciones.</param>
        /// <returns>Un objeto de tipo DataTable que contiene los datos de las modificaciones de usuario.</returns>
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