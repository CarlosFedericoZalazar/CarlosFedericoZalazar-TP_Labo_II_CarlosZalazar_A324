using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Atencion
{
    public static class Caja
    {
        public static string Cuenta(OrdenMesa orden) 
        {
            double sumaTotal = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var item in orden.ListaPedidosMesa)
            {
                sb.AppendLine($"Producto: {item.Nombre} Precio: {item.Precio}");
                Console.WriteLine(item.Precio);
                sumaTotal += item.Precio;
            }
            sb.AppendLine($"Total a pagar: {sumaTotal}");
            return sb.ToString();

        }


    }
}
