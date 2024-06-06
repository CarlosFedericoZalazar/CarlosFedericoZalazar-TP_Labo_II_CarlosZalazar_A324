using RestoApp.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.ClasesSalon
{
    public class Plato
    {
        public enum Estado
        {
            Pedido,
            Hecho,
            SinStock
        }
        public string _nombre;
        public Dictionary<string, double> ingredientesPlato = new Dictionary<string, double>();
        
        double costo;
        public string NombrePlato { get=>_nombre; set=>_nombre=value; }
        public Dictionary<string, double> Ingredientes { get=> ingredientesPlato; set=> ingredientesPlato=value; }
        public double Costo { get; set; }

        private Estado EstadoPlato;
        public Plato() { }
        public Plato(string nombre, Dictionary<string, double> dictIngredientes, double costo)
        {
            _nombre = nombre;
            ingredientesPlato = new Dictionary<string, double>(dictIngredientes);
            Costo = costo;
            EstadoPlato = Estado.Pedido;
        }
    }
}
