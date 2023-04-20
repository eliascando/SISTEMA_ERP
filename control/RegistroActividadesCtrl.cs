using model.Data;
using model.Entities;
using System.Data;

namespace control
{
    public class RegistroActividadesCtrl
    {
        RegistroActividadesBD registroActividades = new RegistroActividadesBD();
        public async Task RegistroInicioSesionCtrl(string id, string estado)
        {
            RegistroInicioSesion inicioSesion = new RegistroInicioSesion();
            inicioSesion.Id_usuario = id;
            inicioSesion.Estado_inicio_sesion = estado;
            inicioSesion.Fechayhora = DateTime.Now;

            await registroActividades.RegistroInicioSesion(inicioSesion);
        }
        public async Task<DataTable> ObtenerLoginsPorUsuarioCtrl(string id)
        {
            return await registroActividades.ObtenerLoginsPorUsuario(id);
        }
        public async Task RegistroModificacionUsuarioCtrl(string usuario_modificado, string usuario_responsable, string detalle)
        {
            RegistroModificacionUsuario modificacionUsuario = new RegistroModificacionUsuario();
            modificacionUsuario.Id_usuario_modificado = usuario_modificado;
            modificacionUsuario.Id_usuario_responsable = usuario_responsable;
            modificacionUsuario.Detalle_modificacion = detalle;
            modificacionUsuario.Fechayhora = DateTime.Now;

            await registroActividades.RegistroModificacionUsuario(modificacionUsuario);
        }
        public async Task<DataTable> ObtenerModificacionesPorUsuarioCtrl(string id)
        {
            return await registroActividades.ObtenerModificacionesPorUsuario(id);
        }
    }
}