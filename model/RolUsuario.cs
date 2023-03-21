using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace model
{
    public class RolUsuario
    {
        private int id;
        private string nombre;

        public RolUsuario()
        {

        }

        public RolUsuario(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public async Task<List<RolUsuario>> ObtenerRoles()
        {
            List<RolUsuario> roles = new List<RolUsuario>();
            try
            {
                if(await ConexionBD.AbrirConexionAsync())
                {
                    var cmd = new SqlCommand("ObtenerRoles", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    roles.Insert(0, new RolUsuario(-1, "Elegir cargo..."));
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while(await reader.ReadAsync())
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            roles.Add(new RolUsuario(id, nombre));
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR DE EXCEPCIÓN: " + ex);
            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
            return roles;
        }
    }
}
