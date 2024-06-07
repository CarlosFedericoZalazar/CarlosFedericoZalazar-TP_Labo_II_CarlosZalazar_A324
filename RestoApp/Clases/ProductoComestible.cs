using RestoApp.Files;
using RestoApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.Clases
{
    public class ProductoComestible : Producto, IProducto
    {
        private double _cantidad;

        public ProductoComestible(string nombre, double cantidad, Tipo tipo, double precio) : base(nombre, tipo, precio)
        {
            Cantidad = cantidad;
        }

        public ProductoComestible() { }
        public double Cantidad { get =>_cantidad; set => _cantidad = value; }


        public static ProductoComestible ProductoComestibleById(int id)
        {
            var lista = ReadProducto();
            foreach (var item in lista)
            {
                if (item.Id == id)
                    return item;
            }
            throw new MyExceptions.ProductoNoEncontradoException($"Producto con ID {id} no encontrado.");

        }
        public static List<ProductoComestible> ReadProducto()
        {
            return Serializador.Archivo.ReadJson<ProductoComestible>("ProductoComestible").ToList();
        }
    }
}
