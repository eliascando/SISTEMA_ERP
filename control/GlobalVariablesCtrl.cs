﻿using model;
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
        public static string ObtenerIdUsuario()
        {
            return GlobalVariables.id_usuario;
        }
        public static void AsignarIdUsuario(string id_usuario)
        {
            GlobalVariables.id_usuario = id_usuario;
        }
    }
}
