using LibraryClassRestaurant.Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Mercaderia
{
    public class PedidoComida : Pedido 
    {
        private ProductoComestible comida;
        public PedidoComida() { }

        public PedidoComida(DateTime fecha, ProductoComestible bebida) : base(fecha)
        {
            this.comida = bebida;
        }
        public ProductoComestible Comida { get => comida; set => comida = value; }

        public static PedidoComida CrearPedidoComida(DateTime fecha, Producto comida)
        {
            return new PedidoComida(fecha, (ProductoComestible)comida);
        }

        public static List<PedidoComida> GetPedidosComestibles()
        {
            return Serializador.Read<PedidoComida>("PedidoComida");
        }
    }
}
