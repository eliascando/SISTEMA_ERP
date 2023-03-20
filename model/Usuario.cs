using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace model
{
    public class Usuario
    {
        private string id;
        private RolUsuario rol_usuario;
        private string nombre;
        private string apellido;
        private byte[] imagen;

        public Usuario()
        {

        }

        public Usuario(string id, RolUsuario rol_usuario, string nombre, string apellido, byte[] imagen)
        {
            Id = id;
            Rol_usuario = rol_usuario;
            Nombre = nombre;
            Apellido = apellido;
            Imagen = imagen;
        }

        public string Id { get => id; set => id = value; }
        public RolUsuario Rol_usuario { get => rol_usuario; set => rol_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }

        public async Task<bool> RegistrarUsuario(Usuario usuario, CredencialesAcceso credenciales)
        {
            bool registroExitoso = false;
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("RegistrarUsuario", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_usuario", usuario.Id);
                    cmd.Parameters.AddWithValue("@id_rol_usuario", usuario.rol_usuario.Id);
                    cmd.Parameters.AddWithValue("@nombre_usuario", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellido_usuario", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@imagen_usuario", usuario.Imagen);
                    cmd.Parameters.AddWithValue("@usuario", credenciales.Usuario);
                    cmd.Parameters.AddWithValue("@password",CredencialesAcceso.EncriptarPassword(credenciales.Password));
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
