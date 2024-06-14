using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Mercaderia
{
    public class StockComestible:Stock
    {
        public double Cantidad { get; set; }
        public StockComestible() { }
        public StockComestible(string producto, double cantidad, Proveedor proveedor) : base(producto, proveedor)
        {
            Cantidad = cantidad;            
        }
        public static List<StockComestible> GetStockComestibles()
        {
            List<StockComestible>stockComestibles = new List<StockComestible>();

            var listaPedidos = PedidoComida.GetPedidosComestibles();
            List<PedidoComida> pedidosEntregados = new List<PedidoComida>();
            //ESTE CODIGO ES UNA GENIALIDAD
            //List<PedidoComida> pedidosEntregados = stockComestibles.Where(pedido => pedido.Estado == Pedido.EstadoPedido.Entregado).ToList();
            //
            foreach (PedidoComida pedido in listaPedidos)
            {
                string nombreProducto = pedido.Comida.Nombre;
                double cantidad = pedido.Comida.Cantidad;
                Proveedor proveedor = pedido.Comida.Proveedor;

                if (pedido.Estado == Pedido.EstadoPedido.Entregado)
                {
                    stockComestibles.Add(new StockComestible(nombreProducto, cantidad, proveedor));
                }
            }            
            return stockComestibles;
        }

    }
}
