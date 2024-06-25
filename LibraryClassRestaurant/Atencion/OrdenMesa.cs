﻿using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Interfaces;
using LibraryClassRestaurant.Mercaderia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LibraryClassRestaurant.Atencion
{
    public class OrdenMesa
    {
        public Mesa MesaAtedida{ get; set; }

        public Stack<Menu>ListaPedidosMesa { get; set; }
        public List<StockBebidas>ListaPedidoBebidas { get; set; }
        List<StockComestible> listaStock = StockComestible.GetStockComestibles();
        public Cocinero Cocinero { get; set; }
        public OrdenMesa(Mesa mesa,Stack<Menu>listaMenu, List<StockBebidas> listaPedidoBebidas, Cocinero cocinero)
        {
            MesaAtedida = mesa;
            ListaPedidosMesa = listaMenu;
            ListaPedidoBebidas = listaPedidoBebidas;
            Cocinero = cocinero;
        }

        public List<Menu> IniciarOrden()
        {
            Menu registroActualizado;
            List<Menu> menuNoDisponible = new List<Menu>();
            int cantidadPlatos = ListaPedidosMesa.Count;
            //Verificamos disponibilidad de productos
            foreach (var item in ListaPedidosMesa)
            {
                registroActualizado = Cocina.ActualizarEstadoMenu(item, listaStock);

                // Aca juntamos los platos que no estan disponibles
                if (item.Disponibilidad == Menu.StatusMenu.NoDisponible)
                {
                    menuNoDisponible.Add(item);
                }
            }
            if (menuNoDisponible.Count == 0)
            {
                Console.WriteLine("ENVIAMOS A COCINAR!");//MANDAMOS A COCINAR ABRIENDO UN HILO!
                
                Thread cocinarThread = new Thread(CocinarPlatos);                
                cocinarThread.Start(); 

            }
            return menuNoDisponible;
        }

        public string MostrarOrden(Stack<Menu>listaMenu)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Orden de la mesa {MesaAtedida.NumeroMesa}");
            foreach (var item in listaMenu)
            {
                sb.AppendLine($"Plato: {item.Plato.Nombre}");
            }
            return sb.ToString();
        }

        public static string MensajeFaltante(List<Menu> menu)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Faltan ingredientes en los siguientes platos: ");
            foreach (var item in menu)
            {
                stringBuilder.AppendLine(item.Plato.Nombre);
            }
            stringBuilder.AppendLine("Sepa Usted disculpar las molestias ocasionadas.");

            return stringBuilder.ToString();
        }


        private void CocinarPlatos(Object hola) // esta bien?
        {
            Thread.Sleep(3000);
            var cadena = Cocina.Cocinar(listaStock, ListaPedidosMesa);
            DescontarMercaderia();
            Cocinero.Mensaje("Se hizo el decuento de la mercaderia");

            Thread.Sleep(5000);
            Cocinero.Mensaje($"Platos listos para servir, MESA: {MesaAtedida}");

        }

        /*
         MAÑANA VER EL TEMA DEL DESCUENTO DE MERCADERIA   
        
        - TENGO LISTA DE PLATOS Y LISTA DE STOCK
        
        SEGUIR CON EL DECUENTO DE MERCADERIA!
         */

        public void DescontarMercaderia()
        {
            foreach (var item in ListaPedidosMesa)
            {
                foreach (var ingrediente in item.Plato.CantidadDeIngredientes)
                {
                    foreach (var stock in listaStock)
                    {
                        if (ingrediente.Key == stock.Producto)
                        {
                            stock.Cantidad -= (ingrediente.Value)/1000;
                        }
                    }
                }
            }
            StockComestible.ActualizarStock(listaStock);
        }


        public Stack<Menu> QuitarMenuRechazado(List<Menu> pedidosRechazados)
        {
            // Convertir el Stack a una lista
            List<Menu> listaTemporal = ListaPedidosMesa.ToList();

            foreach (Menu pedidoRechazado in pedidosRechazados)
            {
                listaTemporal.RemoveAll(p => p.Equals(pedidoRechazado));
            }

            // Limpiar el Stack original
            ListaPedidosMesa.Clear();

            foreach (Menu item in listaTemporal)
            {
                ListaPedidosMesa.Push(item);
            }
            return ListaPedidosMesa;
        }

    }
}
