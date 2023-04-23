using model;

namespace control
{
    public class GlobalVariablesCtrl
    {
        public static void AsignarUsuario(string n_usuario)
        {
            GlobalVariables.usuario = n_usuario;
        }
        public static void AsignarIdRol(int id)
        {
            GlobalVariables.id_rol = id;
        }
        public static string ObtenerUsuario()
        {
            return GlobalVariables.usuario;
        }
        public static int ObtenerIdRol()
        {
            return GlobalVariables.id_rol;
        }
        public static void AsignarKeyEncryption(string key)
        {
            GlobalVariables.encryptionKey = key.Trim();
        }
        public static string ObtenerKeyEncryption()
        {
            return GlobalVariables.encryptionKey;
        }
        public static void AsignarCurrentCounter(long counter)
        {
            GlobalVariables.currentCounter = counter;
        }
        public static long ObtenerCurrentCounter()
        {
            return GlobalVariables.currentCounter;
        }
        public static string ObtenerIdUsuarioLogin()
        {
            return GlobalVariables.id_usuario_login;
        }
        public static void AsignarIdUsuarioLogin(string id_usuario)
        {
            GlobalVariables.id_usuario_login = id_usuario;
        }
        public static string ObtenerIdUsuarioValidator()
        {
            return GlobalVariables.id_usuario_validator;
        }
        public static void AsignarIdUsuarioValidator(string id_usuario)
        {
            GlobalVariables.id_usuario_validator = id_usuario;
        }
        public static void AsignarParentForm(Form form)
        {
            GlobalVariables.parentForm = form;
        }
        public static Form ObtenerParentForm()
        {
            return GlobalVariables.parentForm;
        }
        public static string ObtenerSexo()
        {
            return GlobalVariables.sexUser;
        }
    }
}