using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            GlobalVariables.encryptionKey = key;
        }
        public static string ObtenerKeyEncryption()
        {
            return GlobalVariables.encryptionKey;
        }
    }
}
