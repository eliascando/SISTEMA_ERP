using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace control
{
    public class RolUsuarioCtrl
    {
        public async Task<List<RolUsuario>>ObtenerRolesCtrl()
        {
            RolUsuario rolUsuario = new RolUsuario();
            return await rolUsuario.ObtenerRoles();
        }
    }
}
