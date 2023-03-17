using model;

namespace control
{
    public class Class1
    {
        
        public async Task ejemplo()
        {
            Producto producto = new Producto();
            await ConexionBD.AbrirConexionAsync();
            producto.Nombre = "";
            producto.Tipo.Nombre = "";
            Usuario usuario = new Usuario();
            usuario.Rol_usuario.Id = 1;
        }
        
    }
}