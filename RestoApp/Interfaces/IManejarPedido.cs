using RestoApp.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.Interfaces
{
    public interface IManejarPedido
    {
        string GestionarPedido(IProducto producto, int cantidad, Proveedor proveedor);
        void OrdenarBebida(IProducto product, int quantity, Proveedor proveedor);
        void OrdenarComida(IProducto product, int quantity, Proveedor proveedor);
    }
}
