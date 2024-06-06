using RestoApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.Clases
{
    public class ProductoBebible:Producto, IBebible
    {
        bool _alcoholico;

        private int _cantidad;
        public bool Alcoholica { get=>_alcoholico; set=> _alcoholico=value; }
        public int Cantidad { get=>_cantidad; set=>_cantidad=value; }
        public ProductoBebible(string nombre, int cantidad, Tipo tipo, double precio, bool alcoholico) : base(nombre, tipo, precio)
        {
            _cantidad=cantidad;
            _alcoholico = alcoholico;
        }

        public ProductoBebible() { }


    }
}
