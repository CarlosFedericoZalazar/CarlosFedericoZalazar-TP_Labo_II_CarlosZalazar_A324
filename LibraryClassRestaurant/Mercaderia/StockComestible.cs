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
        public StockComestible(string producto, double cantidad):base(producto)
        {
            Cantidad = cantidad;
        }

        public static List<StockComestible> StockearUltimosPedidosRealizados()
        {
            bool actualizacionOk = false;
            List<StockComestible> stockComestibles = new List<StockComestible>();

            var listaPedidos = PedidoComida.GetPedidosComestibles();
            
            foreach (PedidoComida pedido in listaPedidos)
            {
                string nombreProducto = pedido.Comida.Nombre;
                double cantidad = pedido.Comida.Cantidad;

                if (pedido.Estado == Pedido.EstadoPedido.Entregado)
                {
                    stockComestibles.Add(new StockComestible(nombreProducto, cantidad));
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
            List<StockComestible> stock = StockearUltimosPedidosRealizados();
            List<StockComestible> stockAmpliado = new List<StockComestible>();

            if (stockExistente.Count == 0)
            {
                stockAmpliado.AddRange(stock);
            }
            else
            {
                // Copiar el stock existente a stockAmpliado
                stockAmpliado.AddRange(stockExistente);

                // Actualizar el stockAmpliado con el nuevo stock
                foreach (var itemNuevo in stock)
                {
                    bool match = false;

                    for (int i = 0; i < stockAmpliado.Count; i++)
                    {
                        if (stockAmpliado[i] == itemNuevo)
                        {
                            stockAmpliado[i].Cantidad += itemNuevo.Cantidad;
                            match = true;
                            break;
                        }
                    }

                    if (!match)
                    {
                        stockAmpliado.Add(itemNuevo);
                    }
                }
            }

            ActualizarStock(stockAmpliado);
            return stockAmpliado;
        }

        //USAMOS SOBRECARGA DE OPERADORES PARA COMPARAR STOCKS
        public static bool operator ==(StockComestible stock1, StockComestible stock2)
        {
            return stock1.Producto == stock2.Producto;
        }
        public static bool operator !=(StockComestible stock1, StockComestible stock2)
        {
            return !(stock1 == stock2);
        }

        public static void ActualizarStock(List<StockComestible> StockproductoComestibles)
        {
            Serializador.SaveJson<StockComestible>("StockComestible", StockproductoComestibles);
        }
    }
}
