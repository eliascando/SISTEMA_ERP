namespace model.Entities
{
    public class EstadoProducto
    {
        private int id_estado;
        private string nombre_estado;

        public EstadoProducto()
        {

        }

        public EstadoProducto(int id_estado, string nombre_estado)
        {
            Id_estado = id_estado;
            Nombre_estado = nombre_estado;
        }

        public int Id_estado { get => id_estado; set => id_estado = value; }
        public string Nombre_estado { get => nombre_estado; set => nombre_estado = value; }
    }
}