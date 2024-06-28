using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Mercaderia
{
    public class StockComestible : Stock
    {
        const double STOCK_MINIMO = 30;
        private double _cantidad;
        public double Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value < STOCK_MINIMO) // Reemplaza 10 con el valor que desees
                {
                    Log.Enter("Aviso: El valor es menor al límite establecido.");
                }
                if (value % 10 == 1)
                {
                    _cantidad = Math.Round(value, 3);
                }
                else
                {
                    _cantidad = value;
                }
            }
        }
        public StockComestible() { }
        public StockComestible(string producto, double cantidad, Proveedor proveedor) : base(producto, proveedor)
        {
            Cantidad = cantidad;
        }
        public static List<StockComestible> ComprobarPedidosEntregados()
        {
            bool actualizacionOk = false;
            List<StockComestible> stockComestibles = new List<StockComestible>();

            var listaPedidos = PedidoComida.GetPedidosComestibles();

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
                    pedido.Estado = Pedido.EstadoPedido.finalizado;
                    actualizacionOk = true;
                }
            }
            if (actualizacionOk)
            {
                PedidoComida.GuardarPedidoComida(listaPedidos);
            }
            return stockComestibles;
        }

        public static List<StockComestible> GetStockComestibles()
        {
            List<StockComestible> stockExistente = Serializador.Read<StockComestible>("StockComestible");
            List<StockComestible> stock = ComprobarPedidosEntregados();
            if (stock.Count != 0)
            {
                stockExistente.AddRange(stock);
                ActualizarStock(stockExistente);
            }

            return stockExistente;
        }

        public static void ActualizarStock(List<StockComestible> StockproductoComestibles)
        {
            Serializador.SaveJson<StockComestible>("StockComestible", StockproductoComestibles);
        }


    }
}
