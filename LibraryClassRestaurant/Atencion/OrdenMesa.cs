using LibraryClassRestaurant.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Atencion
{
    public class OrdenMesa
    {
        public int NumeroMesa { get; set; }

        public Stack<Menu>ListaPedisMesa { get; set; }

        public OrdenMesa(int numeroMesa,Stack<Menu>listaMenu)
        {
            NumeroMesa = numeroMesa;
            ListaPedisMesa = listaMenu;
        }

        public string MostrarOrden(Stack<Menu>listaMenu)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Orden de la mesa {NumeroMesa}");
            foreach (var item in listaMenu)
            {
                sb.AppendLine($"Plato: {item.Plato.Nombre} Precio: {item.Plato.TiempoPreparacion}");
            }
            return sb.ToString();
        }
    }
}
