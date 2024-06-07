using RestoApp.Files;
using RestoApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.Clases
{
    public class ProductoBebible:Producto, IProducto
    {
        bool _alcoholico;

        private int _cantidad;
        public bool Alcoholica { get=>_alcoholico; set=> _alcoholico=value; }
        public int Cantidad { get=>_cantidad; set=>_cantidad=value; }
        public ProductoBebible(string nombre, int cantidad, Tipo tipo, double precio, bool alcoholico) : base(nombre, tipo, precio)
        {
            Cantidad = cantidad;
            _alcoholico = alcoholico;
        }

        public ProductoBebible() { }

        public static ProductoComestible ProductoBebibleById(int id)
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
            return Serializador.Archivo.ReadJson<ProductoComestible>("ProductoBebible").ToList();
        }


    }
}
