namespace model.Entities
{
    public class Usuario
    {
        private string id;
        private RolUsuario rol_usuario;
        private string user;
        private string nombre;
        private string apellido;

        public Usuario()
        {

        }

        public Usuario(string id, RolUsuario rol_usuario, string user, string nombre, string apellido)
        {
            Id = id;
            Rol_usuario = rol_usuario;
            User = user;
            Nombre = nombre;
            Apellido = apellido;
        }

        public string Id { get => id; set => id = value; }
        public RolUsuario Rol_usuario { get => rol_usuario; set => rol_usuario = value; }
        public string User { get => user; set => user = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        
    }
}