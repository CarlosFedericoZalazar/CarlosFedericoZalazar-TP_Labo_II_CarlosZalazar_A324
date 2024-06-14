using LibraryClassRestaurant.Mercaderia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Interfaces
{
    public interface IProducto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Proveedor Proveedor { get; set; }
        public Producto.TipoProducto Tipo { get; set; }

    }
}
