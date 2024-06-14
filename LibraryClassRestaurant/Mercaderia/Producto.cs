using LibraryClassRestaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Mercaderia
{
    public abstract class Producto: IProducto
    {
        public enum TipoProducto
        {
            Bebida,
            Comida
        }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Proveedor Proveedor { get; set; }
        public TipoProducto Tipo { get; set; }

        public Producto() { }
        public Producto(string nombre, TipoProducto tipo, double precio, Proveedor proveedor)
        {
            Nombre = nombre;
            Tipo = tipo;
            Precio = precio;
            Proveedor = proveedor;
        }
    }
}
