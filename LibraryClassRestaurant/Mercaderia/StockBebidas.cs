﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Mercaderia
{
    public class StockBebidas:Stock
    {
        List<PedidoBebida> stockBebibles = new List<PedidoBebida>();
        public StockBebidas() { }
        public int Cantidad { get; set; }
        public bool Alcoholica { get; set; }
        public StockBebidas(string producto, int cantidad, bool alcoholica, Proveedor proveedor) : base(producto, proveedor) 
        {
            Cantidad = cantidad;
            Alcoholica = alcoholica;
        }

        public static List<StockBebidas> GetStockBebibles()
        {
            List<StockBebidas> stockBebibles = new List<StockBebidas>();
            var listaPedidos = PedidoBebida.GetPedidosBebidas();

            //ESTE CODIGO ES UNA GENIALIDAD
            //List<PedidoComida> pedidosEntregados = stockComestibles.Where(pedido => pedido.Estado == Pedido.EstadoPedido.Entregado).ToList();
            //
            foreach (PedidoBebida pedido in listaPedidos)
            {
                string nombreProducto = pedido.Bebida.Nombre;
                int cantidad = pedido.Bebida.Cantidad;
                Proveedor proveedor = pedido.Bebida.Proveedor;
                bool alcohol = pedido.Bebida.Alcoholica;

                if (pedido.Estado == Pedido.EstadoPedido.Entregado)
                {
                    stockBebibles.Add(new StockBebidas(nombreProducto, cantidad, alcohol, proveedor));
                }
            }
            return stockBebibles;
        }
    }
}