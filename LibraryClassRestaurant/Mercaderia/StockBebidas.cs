using LibraryClassRestaurant.Archivos;
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
        public StockBebidas(string producto, int cantidad,double precioVenta, bool alcoholica) : base(producto) 
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
                        //listaBebidasPedidas.Remove(bebida);
                        Log.Enter($"SE RETIRO DEL STOCK BEBIBLE: {bebida.Cantidad}, QUEDANDO: {stock.Cantidad}");
                        break;
                    }
                    if(stock.Cantidad == 0)
                    {
                        listaBebidasPedidas.Remove(bebida);
                        Log.Enter($"NO HAY STOCK DE: {stock.Producto}");
                    }
                    
                }
            }
            Serializador.SaveJson<StockBebidas>("StockBebidas", listaStock);            
            return listaBebidasPedidas;        
        }
        public static void GenerarStockBebidas(Bebida producto)
        {
            StockBebidas nuevoStock = new StockBebidas();
            nuevoStock.Producto = producto.Nombre;
            nuevoStock.Cantidad = producto.Cantidad;
            nuevoStock.Precio = producto.PrecioDeVenta;
            nuevoStock.Alcoholica = producto.Alcoholica;
            ActualizarStockBebible(nuevoStock);
        }
        private static void ActualizarStockBebible(StockBebidas nuevoStock)
        {
            List<StockBebidas> bebidasStock = Serializador.Read<StockBebidas>("StockBebidas");

            if (bebidasStock.Count == 0)
            {
                bebidasStock.Add(nuevoStock);
            }
            else
            {
                bool productoEncontrado = false;

                for (int i = 0; i < bebidasStock.Count; i++)
                {
                    if (bebidasStock[i].Producto == nuevoStock.Producto)
                    {
                        bebidasStock[i].Cantidad += nuevoStock.Cantidad;
                        productoEncontrado = true;
                        break;
                    }
                }

                if (!productoEncontrado)
                {
                    bebidasStock.Add(nuevoStock);
                }
            }

            GuardarStockBebidas(bebidasStock);
        }

        public static void GuardarStockBebidas(StockBebidas nuevoStock)
        {
            Serializador.Save<StockBebidas>("StockBebidas", nuevoStock);
        }

        public static void GuardarStockBebidas(List<StockBebidas> listaStock)
        {
            Serializador.SaveJson<StockBebidas>("StockBebidas", listaStock);
        }



    }
}
