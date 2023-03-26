namespace model.Entities
{
    public class CategoriaProducto
    {
        private int id_categoria;
        private string nombre_categoria;

        public CategoriaProducto()
        {

        }

        public CategoriaProducto(int id_categoria, string nombre_categoria)
        {
            Id_categoria = id_categoria;
            Nombre_categoria = nombre_categoria;
        }

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nombre_categoria { get => nombre_categoria; set => nombre_categoria = value; }
    }
}
