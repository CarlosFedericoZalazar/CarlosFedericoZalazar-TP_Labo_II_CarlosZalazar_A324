using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Mercaderia
{
    public class Bebida:Producto, IProducto
    {
        int _cantidad;
        bool _alcoholica;
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public bool Alcoholica { get => _alcoholica; set => _alcoholica = value; }
        public Bebida() { } 
        public Bebida(string nombre, TipoProducto tipo, int cantidad, bool alcohol, double precio, Proveedor proveedor) : base(nombre, tipo, precio, proveedor)
        {
            Cantidad = cantidad;
            Alcoholica = alcohol;
        }



    }
}
