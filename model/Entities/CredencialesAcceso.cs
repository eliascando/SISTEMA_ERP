namespace model.Entities
{
    public class CredencialesAcceso
    {
        private string id_usuario;
        private string password;
        private bool usuario_activo;


        public CredencialesAcceso()
        {

        }

        public CredencialesAcceso(string id_usuario, string password, bool usuario_activo)
        {
            Id_usuario = id_usuario;
            Password = password;
            Usuario_activo = usuario_activo;
        }

        public string Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Password { get => password; set => password = value; }
        public bool Usuario_activo { get => usuario_activo; set => usuario_activo = value; }
    }
}