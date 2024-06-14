using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Mercaderia
{
    public class ProductoComestible: Producto, IProducto
    {
        double _cantidad;
        public double Cantidad { get => _cantidad; set => _cantidad = value; }
        public ProductoComestible() { }
        public ProductoComestible(string nombre, TipoProducto tipo, double cantidad,double precio, Proveedor proveedor) : base(nombre, tipo, precio, proveedor)
        {
            Cantidad = cantidad;
        }

    }
}
