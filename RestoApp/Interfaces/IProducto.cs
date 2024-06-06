using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RestoApp.Clases.Producto;

namespace RestoApp.Interfaces
{
    public interface IProducto
    {
        int Id { get; set; }
        string Nombre { get; set; }
        //int Cantidad { get; set; }
        double Precio { get; set; }
        Tipo TipoProducto { get; set; }
        //int Id { get; }
    }
}
