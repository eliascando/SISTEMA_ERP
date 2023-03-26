namespace model.Entities
{
    public class Cliente
    {
        private string id_cliente;
        private string nombre_cliente;
        private string apellido_cliente;
        private string telefono_cliente;
        private string correo_cliente;
        private string direccion_cliente;

        public Cliente()
        {

        }
        public Cliente(string id_cliente, string nombre_cliente, string apellido_cliente, string telefono_cliente, string correo_cliente, string direccion_cliente)
        {
            Id_cliente = id_cliente;
            Nombre_cliente = nombre_cliente;
            Apellido_cliente = apellido_cliente;
            Telefono_cliente = telefono_cliente;
            Correo_cliente = correo_cliente;
            Direccion_cliente = direccion_cliente;
        }

        public string Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nombre_cliente { get => nombre_cliente; set => nombre_cliente = value; }
        public string Apellido_cliente { get => apellido_cliente; set => apellido_cliente = value; }
        public string Telefono_cliente { get => telefono_cliente; set => telefono_cliente = value; }
        public string Correo_cliente { get => correo_cliente; set => correo_cliente = value; }
        public string Direccion_cliente { get => direccion_cliente; set => direccion_cliente = value; }
    }
}