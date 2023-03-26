namespace model.Entities
{
    internal class FormaPago
    {
        private int id;
        private string nombre;
        private double valor_total;
        private double valor_cambio;

        public FormaPago()
        {

        }

        public FormaPago(int id, string nombre, double valor_total, double valor_cambio)
        {
            Id = id;
            Nombre = nombre;
            Valor_total = valor_total;
            Valor_cambio = valor_cambio;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Valor_total { get => valor_total; set => valor_total = value; }
        public double Valor_cambio { get => valor_cambio; set => valor_cambio = value; }
    }
}