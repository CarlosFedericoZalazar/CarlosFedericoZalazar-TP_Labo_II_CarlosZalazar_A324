using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryClassRestaurant.Empleados.Empleado;

namespace LibraryClassRestaurant.Mercaderia
{
    public abstract class Pedido
    {
        public enum EstadoPedido
        {
            Pendiente,
            Entregado,
            finalizado
        }
        public DateTime FechaPedido { get; set; }
        public EstadoPedido Estado { get; set; }
        public Pedido() { }
        public Pedido(DateTime fecha)
        {
            FechaPedido = fecha;
            Estado = EstadoPedido.Entregado; // Por defecto, cambiar a Pendiente cuando modifique el codigo
        }

    }
}
