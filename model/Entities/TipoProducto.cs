namespace model.Entities
{
    public class TipoProducto
    {
        private int id_tipo;
        private int id_categoria;
        private string nombre_tipo;

        public TipoProducto()
        {

        }

        public TipoProducto(int id_tipo, int id_categoria, string nombre_tipo)
        {
            Id_tipo = id_tipo;
            Id_categoria = id_categoria;
            Nombre_tipo = nombre_tipo;
        }

        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nombre_tipo { get => nombre_tipo; set => nombre_tipo = value; }
    }
}