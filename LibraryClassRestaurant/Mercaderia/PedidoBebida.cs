using LibraryClassRestaurant.Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Mercaderia
{
    public class PedidoBebida:Pedido
    {
        private Bebida bebida;
        public PedidoBebida() { }
        public PedidoBebida(DateTime fecha, Bebida bebida) : base(fecha)
        {
            this.bebida = bebida;
        }
        public Bebida Bebida { get => bebida; set => bebida = value; }

        public static PedidoBebida CrearPedidoBebida(DateTime fecha, Bebida bebida)
        {
            return new PedidoBebida(fecha, bebida);
        }

        public static List<PedidoBebida> GetPedidosBebidas()
        {
            var pedidos = Serializador.Read<PedidoBebida>("PedidoBebida");
            //return Serializador.Read<PedidoBebida>("PedidoBebida");
            return pedidos;
        }

    }
}
