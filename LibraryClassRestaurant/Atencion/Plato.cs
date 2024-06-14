using LibraryClassRestaurant.Mercaderia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Atencion
{
    public class Plato
    {
        public string Nombre { get; set; }

        public Dictionary<string, double> CantidadDeIngredientes { get; set; }

        public int TiempoPreparacion { get; set; }
        public Plato()
        {
        }
        public Plato(string nombre, Dictionary<string, double> dictionaryIngredientes, Dictionary<string, double>cantidadesProducto, int tiempoPreparacion)
        {
            Nombre = nombre;
            CantidadDeIngredientes = dictionaryIngredientes;
            TiempoPreparacion = tiempoPreparacion;
        }

    }
}
