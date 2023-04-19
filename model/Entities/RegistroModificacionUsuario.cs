using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.Entities
{
    public class RegistroModificacionUsuario
    {
        private int id_registro_modificacion;
        private string id_usuario_modificado;
        private string id_usuario_responsable;
        private DateTime fechayhora;
        private string detalle_modificacion;

        public RegistroModificacionUsuario()
        {

        }

        public RegistroModificacionUsuario(int id_registro_modificacion, string id_usuario_modificado, string id_usuario_responsable, DateTime fechayhora, string detalle_modificacion)
        {
            Id_registro_modificacion = id_registro_modificacion;
            Id_usuario_modificado = id_usuario_modificado;
            Id_usuario_responsable = id_usuario_responsable;
            Fechayhora = fechayhora;
            Detalle_modificacion = detalle_modificacion;
        }

        public int Id_registro_modificacion { get => id_registro_modificacion; set => id_registro_modificacion = value; }
        public string Id_usuario_modificado { get => id_usuario_modificado; set => id_usuario_modificado = value; }
        public string Id_usuario_responsable { get => id_usuario_responsable; set => id_usuario_responsable = value; }
        public DateTime Fechayhora { get => fechayhora; set => fechayhora = value; }
        public string Detalle_modificacion { get => detalle_modificacion; set => detalle_modificacion = value; }
    }
}
