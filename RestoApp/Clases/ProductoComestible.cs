using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.Clases
{
    public class ProductoComestible : Producto
    {
        private double _cantidad;

        public ProductoComestible(string nombre, double cantidad, Tipo tipo, double precio) : base(nombre, tipo, precio)
        {
            _cantidad = cantidad;
        }

        public ProductoComestible() { }
        public double Cantidad { get =>_cantidad; set => _cantidad = value; }
    }
}
