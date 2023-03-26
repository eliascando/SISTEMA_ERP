namespace model.Entities
{
    public class Proveedor
    {
        private string id_proveedor;
        private string nombre_proveedor;
        private string telefono_proveedor;
        private string correo_proveedor;
        private string direccion_proveedor;
        private DateTime fecha_ingreso_proveedor;
        private bool proveedor_activo;

        public Proveedor()
        {

        }

        public Proveedor(string id_proveedor, string nombre_proveedor, string telefono_proveedor, string correo_proveedor, string direccion_proveedor, DateTime fecha_ingreso_proveedor, bool proveedor_activo)
        {
            Id_proveedor = id_proveedor;
            Nombre_proveedor = nombre_proveedor;
            Telefono_proveedor = telefono_proveedor;
            Correo_proveedor = correo_proveedor;
            Direccion_proveedor = direccion_proveedor;
            Fecha_ingreso_proveedor = fecha_ingreso_proveedor;
            Proveedor_activo = proveedor_activo;
        }

        public string Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Nombre_proveedor { get => nombre_proveedor; set => nombre_proveedor = value; }
        public string Telefono_proveedor { get => telefono_proveedor; set => telefono_proveedor = value; }
        public string Correo_proveedor { get => correo_proveedor; set => correo_proveedor = value; }
        public string Direccion_proveedor { get => direccion_proveedor; set => direccion_proveedor = value; }
        public DateTime Fecha_ingreso_proveedor { get => fecha_ingreso_proveedor; set => fecha_ingreso_proveedor = value; }
        public bool Proveedor_activo { get => proveedor_activo; set => proveedor_activo = value; }
    }
}