namespace model.Entities
{
    public class RolUsuario
    {
        private int id_rol;
        private string nombre_rol;

        public RolUsuario()
        {

        }

        public RolUsuario(int id_rol, string nombre)
        {
            Id_rol = id_rol;
            Nombre_rol = nombre;
        }

        public int Id_rol { get => id_rol; set => id_rol = value; }
        public string Nombre_rol { get => nombre_rol; set => nombre_rol = value; }
    }
}