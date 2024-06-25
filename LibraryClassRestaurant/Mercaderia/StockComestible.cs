﻿using LibraryClassRestaurant.Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Mercaderia
{
    public class StockComestible:Stock
    {
        private double _cantidad;
        public double Cantidad
        {
            get { return _cantidad; }
            set
            {
                
                if (value < 10) // Reemplaza 10 con el valor que desees
                {
                    Console.WriteLine("Aviso: El valor es menor al límite establecido.");
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


        // SEGUIR VIENDO ESTO!!!


        public static List<StockComestible> ComprobarPedidosEntregados()
        { 
            bool actualizacionOk = false;
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
                ActualizarStock(stock);
                stockExistente.AddRange(stock);
            }
            
            return stockExistente;
        }


        public static void ActualizarStock(List<StockComestible> StockproductoComestibles) 
        {
            Serializador.SaveJson<StockComestible>("StockComestible", StockproductoComestibles);
        }

    }
}
