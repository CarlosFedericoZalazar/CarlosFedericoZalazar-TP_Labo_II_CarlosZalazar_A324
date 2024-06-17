using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Mercaderia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

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

        // VERIFICAR SI HAY STOCK DE LOS PRODUCTOS PARA EL PEDIDO
        public bool VerificarPedidos() 
        {
            foreach (var item in ListaPedidosMesa)
            {
                //var itemAux = Menu.ActualizarEstadoMenu(item, listaStock);

                //if (itemAux.Disponibilidad == Menu.StatusMenu.Disponible)
                //{
                //    // TODO: VER QUE HACEMOS CON STOCK NO DISPONIBLE
                //    return false;
                //}
            }           
            
            return true;
        }

        public static List<Menu> IniciarOrden(OrdenMesa ordenMesa)
        {
            Menu registroActualizado;
            List<Menu>menuNoDisponible = new List<Menu>();
            int cantidadPlatos = ordenMesa.ListaPedidosMesa.Count;
            //Verificamos disponibilidad de productos
            foreach(var item in ordenMesa.ListaPedidosMesa)
            {
                registroActualizado = Cocina.ActualizarEstadoMenu(item, ordenMesa.listaStock);
                
                // Aca juntamos los platos que no estan disponibles
                if(item.Disponibilidad == Menu.StatusMenu.NoDisponible)
                {
                    menuNoDisponible.Add(item);
                }
            }
            if (menuNoDisponible.Count != 0)
            {
                Console.WriteLine( "ENVIAMOS A COCINAR!" );//MANDAMOS A COCINAR
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
    }
}
