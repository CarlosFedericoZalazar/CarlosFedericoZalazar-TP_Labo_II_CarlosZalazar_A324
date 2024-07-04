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
