namespace model.Entities
{
    public class Usuario
    {
        private string id;
        private RolUsuario rol_usuario;
        private string usuario;
        private string nombre;
        private string apellido;

        public Usuario()
        {

        }

        public Usuario(string id, RolUsuario rol_usuario, string usuario, string nombre, string apellido)
        {
            Id = id;
            Rol_usuario = rol_usuario;
            Usuario_ = usuario;
            Nombre = nombre;
            Apellido = apellido;
        }

        public string Id { get => id; set => id = value; }
        public RolUsuario Rol_usuario { get => rol_usuario; set => rol_usuario = value; }
        public string Usuario_ { get => usuario; set => usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        
    }
}