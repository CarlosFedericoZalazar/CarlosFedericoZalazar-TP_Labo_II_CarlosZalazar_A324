using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Mercaderia
{
    public class GestorMercaderia
    {
        private GestorMercaderia() { }

        public static GestorMercaderia InstanciarGestorMercaderia()
        {
            return new GestorMercaderia();
        }

        public void GestionarPedidos(ProductoComestible producto)
        {
            PedidoComida pedido = PedidoComida.CrearPedidoComida(DateTime.Now, producto);
            Serializador.Save<PedidoComida>("PedidoComida", pedido);
        }

        public void GestionarPedidos(Bebida producto)
        {
            PedidoBebida pedido = PedidoBebida.CrearPedidoBebida(DateTime.Now, producto);
            
            Serializador.Save<PedidoBebida>("PedidoBebida", pedido);
        }
    }
}
