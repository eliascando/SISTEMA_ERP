using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Establecimiento
    {
        private string id;
        private string nombre_comercial;
        private string razon_social;
        private string ruc_emisor;
        private string direccion_matriz;
        private double iva;

        public Establecimiento()
        {

        }

        public Establecimiento(string id, string nombre_comercial, string razon_social, string ruc_emisor, string direccion_matriz, double iva)
        {
            Id = id;
            Nombre_comercial = nombre_comercial;
            Razon_social = razon_social;
            Ruc_emisor = ruc_emisor;
            Direccion_matriz = direccion_matriz;
            Iva = iva;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre_comercial { get => nombre_comercial; set => nombre_comercial = value; }
        public string Razon_social { get => razon_social; set => razon_social = value; }
        public string Ruc_emisor { get => ruc_emisor; set => ruc_emisor = value; }
        public string Direccion_matriz { get => direccion_matriz; set => direccion_matriz = value; }
        public double Iva { get => iva; set => iva = value; }
    }
}
