using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control
{
    public class CredencialesAccesoCtrl
    {
        public async Task<bool> ValidarCredenciales(string usuario, string password)
        {
            CredencialesAcceso credenciales = new CredencialesAcceso();
            credenciales.Usuario = usuario;
            credenciales.Password = password;
            return await credenciales.ValidarCredenciales(credenciales);
        }
    }
}
