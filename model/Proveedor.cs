using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Proveedor
    {
        private string id;
        private string nombre;
        private string telefono;
        private string correo;
        private string direccion;
        private DateOnly fecha_ingreso;
        private bool proveedor_activo;

        public Proveedor()
        {

        }

        public Proveedor(string id, string nombre, string telefono, string correo, string direccion, DateOnly fecha_ingreso, bool proveedor_activo)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
            Fecha_ingreso = fecha_ingreso;
            Proveedor_activo = proveedor_activo;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateOnly Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public bool Proveedor_activo { get => proveedor_activo; set => proveedor_activo = value; }

        public async Task RegistrarUsuario(Proveedor proveedor)
        {
            try
            {
                if (await ConexionBD.AbrirConexionAsync())
                {

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                await ConexionBD.CerrarConexionAsync();
            }
        }
    }
}
