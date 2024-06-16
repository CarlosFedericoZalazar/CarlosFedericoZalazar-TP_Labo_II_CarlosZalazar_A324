using LibraryClassRestaurant.Mercaderia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Atencion
{
    public class Mesa
    {
        public int NumeroMesa { get; set; }
        public EstadoMesa Estado { get; set; }

        List<Bebida> Pedidos = new List<Bebida>();
        //List<Plato> PedidosPlatos = new List<Plato>(); // plato va a tener productos comestibles

        public enum EstadoMesa
        {
            Abierta,
            Cerrada
        }
        public Mesa()
        {
        }
        public Mesa(int numeroMesa)
        {
            NumeroMesa = numeroMesa;
            Estado = EstadoMesa.Cerrada;
        }
    }
}
