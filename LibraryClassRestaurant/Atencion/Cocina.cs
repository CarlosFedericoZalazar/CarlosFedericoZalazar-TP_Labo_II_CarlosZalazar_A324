using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Mercaderia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static LibraryClassRestaurant.Atencion.Menu;


namespace LibraryClassRestaurant.Atencion
{
    public static class Cocina
    {
        private static List<StockComestible> listaStock = StockComestible.GetStockComestibles();
        /// <summary>
        /// VERIFICA SI HAY STOCK DE LOS PRODUCTOS PARA EL PEDIDO
        /// </summary>
        /// <param name="nuevoPlato"></param>
        /// <param name="listaStock"></param>
        /// <returns name="nuevoPlato"></returns>
        public static Menu ActualizarEstadoMenu(Menu nuevoPlato)
        {
            StringBuilder informeProducto = new StringBuilder();
            bool ingredienteDisponible = true;
            bool cantidadDisponibleOk = true;

            int match = 0;
            int cantidadIngredientes = nuevoPlato.Plato.CantidadDeIngredientes.Count;
            foreach (var item in nuevoPlato.Plato.CantidadDeIngredientes)
            {
                foreach (var stock in listaStock)
                {
                    ingredienteDisponible = IngredienteOk(item.Key, stock.Producto);

                    if (ingredienteDisponible) 
                    {
                        cantidadDisponibleOk = CantidadDisponibleOk(item.Value, stock.Cantidad);
                        if (!cantidadDisponibleOk)
                        {
                            informeProducto.AppendLine($"Cantidad de {item.Key} INSUFICIENTE");
                        }
                    }

                    if (ingredienteDisponible && cantidadDisponibleOk)
                    {
                        match++;
                        informeProducto.AppendLine($"Ingrediente {item.Key} OK");
                        informeProducto.AppendLine($"Cantidad de {item.Key} OK");
                        break;
                    }
                }
                if (!ingredienteDisponible)
                {
                    informeProducto.AppendLine($"Ingrediente {item.Key} NO DISPONIBLE");
                }
            }     
            if (match == cantidadIngredientes)
            {
                nuevoPlato.Disponibilidad = StatusMenu.Disponible;
            }
            else
            {
                nuevoPlato.Disponibilidad = StatusMenu.NoDisponible;
            }
            nuevoPlato.MensajeStatus = informeProducto.ToString();
            return nuevoPlato;
        }

        private static bool IngredienteOk(string producto, string productoStock)
        {
            bool productoOk = false;
            if (producto == productoStock)
            {
                productoOk = true;
            }
            return productoOk;
        }

        private static bool CantidadDisponibleOk(double cantidad, double cantidadStock)
        {
            bool cantidadOk = false;
            double cantidadGramosAKilos = cantidad / 1000;
            if (cantidadGramosAKilos < cantidadStock)
            {
                cantidadOk = true;
            }
            return cantidadOk;
        }

        public static void CocinarPlatos(Stack<Menu> ListaPedidosMesa, Cocinero cocinero) // esta bien?
        {
            Thread.Sleep(3000);
            DescontarMercaderia(listaStock, ListaPedidosMesa);
            cocinero.Mensaje("Se hizo el descuento de la mercaderia");
            Thread.Sleep(5000);
        }

        public static void DescontarMercaderia(List<StockComestible> listaStock, Stack<Menu> ListaPedidosMesa) // esta bien?
        {
            foreach (var item in ListaPedidosMesa)
            {
                foreach (var ingrediente in item.Plato.CantidadDeIngredientes)
                {
                    foreach (var stock in listaStock)
                    {
                        if (ingrediente.Key == stock.Producto)
                        {
                            stock.Cantidad -= (ingrediente.Value) / 1000;
                        }
                    }
                }
            }
            StockComestible.ActualizarStock(listaStock);            
        }

    }
}
