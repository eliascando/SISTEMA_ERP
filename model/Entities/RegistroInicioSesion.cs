namespace model.Entities
{
    public class RegistroInicioSesion
    {
        private int id_registro_inicio_sesion;
        private string id_usuario;
        private DateTime fechayhora;
        private string estado_inicio_sesion;

        public RegistroInicioSesion()
        {

        }

        public RegistroInicioSesion(int id_registro_inicio_sesion, string id_usuario, DateTime fechayhora, string estado_inicio_sesion)
        {
            Id_registro_inicio_sesion = id_registro_inicio_sesion;
            Id_usuario = id_usuario;
            Fechayhora = fechayhora;
            Estado_inicio_sesion = estado_inicio_sesion;
        }

        public int Id_registro_inicio_sesion { get => id_registro_inicio_sesion; set => id_registro_inicio_sesion = value; }
        public string Id_usuario { get => id_usuario; set => id_usuario = value; }
        public DateTime Fechayhora { get => fechayhora; set => fechayhora = value; }
        public string Estado_inicio_sesion { get => estado_inicio_sesion; set => estado_inicio_sesion = value; }
    }
}