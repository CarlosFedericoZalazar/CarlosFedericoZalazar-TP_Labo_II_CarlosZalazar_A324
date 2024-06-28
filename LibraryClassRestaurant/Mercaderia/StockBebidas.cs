﻿using LibraryClassRestaurant.Archivos;
using System;
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

        public double Precio{ get; set; }
        public StockBebidas(string producto, int cantidad,double precioVenta, bool alcoholica, Proveedor proveedor) : base(producto, proveedor) 
        {
            Cantidad = cantidad;
            Alcoholica = alcoholica;
            Precio = precioVenta;
        }

        public static List<StockBebidas> GetStockBebibles()
        {
            var bebidasStock = Serializador.Read<StockBebidas>("StockBebidas");
            return bebidasStock;
        }


        //    public static List<StockBebidas> GetStockBebibles()
        //{
        //    List<StockBebidas> stockBebibles = new List<StockBebidas>();
        //    var listaPedidos = PedidoBebida.GetPedidosBebidas();

        //    //ESTE CODIGO ES UNA GENIALIDAD
        //    //List<PedidoComida> pedidosEntregados = stockComestibles.Where(pedido => pedido.Estado == Pedido.EstadoPedido.Entregado).ToList();
        //    //
        //    foreach (PedidoBebida pedido in listaPedidos)
        //    {
        //        string nombreProducto = pedido.Bebida.Nombre;
        //        int cantidad = pedido.Bebida.Cantidad;
        //        double precioVenta = pedido.Bebida.PrecioDeVenta;
        //        Proveedor proveedor = pedido.Bebida.Proveedor;
        //        bool alcohol = pedido.Bebida.Alcoholica;

        //        if (pedido.Estado == Pedido.EstadoPedido.Entregado)
        //        {
        //            stockBebibles.Add(new StockBebidas(nombreProducto, cantidad, precioVenta, alcohol, proveedor));
        //        }
        //    }
        //    return stockBebibles;
        //}

        public static List<StockBebidas> RetirarBebida(List<StockBebidas> listaBebidasPedidas)
        {
            List<StockBebidas> listaStock = GetStockBebibles();

            foreach (StockBebidas stock in listaStock)
            {
                foreach (StockBebidas bebida in listaBebidasPedidas)
                {
                    if (stock.Producto == bebida.Producto && stock.Cantidad > 0)
                    {
                        stock.Cantidad -= 1;
                        listaBebidasPedidas.Remove(bebida);
                        Log.Enter($"SE RETIRO DEL STOCK BEBIBLBE: {bebida.Cantidad}, QUEDANDO: {stock.Cantidad}");
                        break;
                    }
                }
            }
            Serializador.SaveJson<StockBebidas>("StockBebidas", listaStock);            
            return listaBebidasPedidas;        
        }



    }
}
