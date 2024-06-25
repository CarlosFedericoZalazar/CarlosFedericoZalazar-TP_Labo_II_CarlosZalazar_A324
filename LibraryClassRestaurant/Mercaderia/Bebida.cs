using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Mercaderia
{    public class Bebida:Producto, IProducto
    {
        public int Cantidad { get; set; }
        public bool Alcoholica { get; set; }
        public double PrecioDeVenta { get; set; }

        public Bebida() { } 
        public Bebida(string nombre, TipoProducto tipo, int cantidad, bool alcohol, double precio, Proveedor proveedor) : base(nombre, tipo, precio, proveedor)
        {
            Cantidad = cantidad;
            Alcoholica = alcohol;
            PrecioDeVenta = 0;
        }
    }
}
