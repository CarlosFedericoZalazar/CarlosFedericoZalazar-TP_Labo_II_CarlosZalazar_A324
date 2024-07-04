using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Mercaderia
{
    public abstract class Stock
    {
        public string Producto { get; set; }

        public Stock() { }
        public Stock(string producto)
        {
            Producto = producto;
        }
    }
}
