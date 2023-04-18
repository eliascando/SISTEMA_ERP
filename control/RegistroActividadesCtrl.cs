using model.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control
{
    public class RegistroActividadesCtrl
    {
        RegistroActividadesBD registroActividades = new RegistroActividadesBD();
        public async Task RegistroInicioSesionCtrl(string id, string estado)
        {
            await registroActividades.RegistroInicioSesion(id, estado);
        }
        public async Task<DataTable> ObtenerLoginsPorUsuarioCtrl(string id)
        {
            return await registroActividades.ObtenerLoginsPorUsuario(id);
        }
    }
}
