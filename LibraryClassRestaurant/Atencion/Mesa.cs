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
        public OrdenMesa Orden { get; set; }

        //List<Plato> PedidosPlatos = new List<Plato>(); // plato va a tener productos comestibles
        public double MontoTotal { get; set; }
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

        public static List<Mesa> GetMesas(int cantidadMesas)
        {
            List<Mesa> listaMesas = new List<Mesa>();
            for (int i = 0; i < cantidadMesas; i++)
            {
                Mesa mesa = new Mesa(i + 1);
                listaMesas.Add(mesa);
            }
            return listaMesas;
        }

    }
}
