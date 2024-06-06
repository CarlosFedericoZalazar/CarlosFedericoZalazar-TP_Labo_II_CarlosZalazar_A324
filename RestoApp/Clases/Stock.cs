using RestoApp.Files;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RestoApp.Clases
{
    public class Stock
    {
        private string _producto; 
        double _cantidad;
        int _unidades;
        public Stock() { }
        public Stock(string producto, double cantidad)
        {
            _producto = producto;
            _cantidad = cantidad;
        }

        public Stock(string producto, int unidades)
        {
            _producto = producto;
            _unidades = unidades;
        }

        public string NombreProducto { get=>_producto; set=>_producto=value; }
        public double CantidadProducto { get =>_cantidad; set =>_cantidad = value; }
        public int Unidades { get => _unidades; set => _unidades = value; }
        public void prueba()
        {
            foreach (Producto.Tipo tipo in Enum.GetValues(typeof(Producto.Tipo)))
            {
                Console.WriteLine(tipo);
            }
        }

        public static void CheckStock()
        {
            var productosComestibles = Pedido.ReadPedido();
            string diaSemana = ObtenerDiaSemana();
            foreach (var item in productosComestibles) 
            {
                var aux = item.Proveedor.MedioDePago;
                if (item.EstadoPedido == Pedido.Estado.Pendiente) 
                {
                    if (diaSemana == item.Proveedor.DiaDeEntrega.ToLower()) 
                    {
                        ProductoComestible producto = Producto.ProductoById(item.IdProducto);
                        item.EstadoPedido = Pedido.Estado.Recibido;
                        // VER USO DE HILOS ACA...
                        //
                        Stock stock = new Stock(producto.Nombre,producto.Cantidad);
                        Save(stock);
                    }
                }
            }
            Pedido.Save(productosComestibles);
        }
        private static string ObtenerDiaSemana() 
        {
            DateTime fechaActual = DateTime.Now;

            DayOfWeek diaDeLaSemana = fechaActual.DayOfWeek;

            string[] diasEnEspanol = { "domingo", "lunes", "martes", "miércoles", "jueves", "viernes", "sábado" };

            return diasEnEspanol[(int)diaDeLaSemana];
        }

        private static void Save(Stock stock) 
        {
            List<Stock> nuevoStock = ReadStock();
            nuevoStock.Add(stock);
            Save(nuevoStock);
        }
        public static void Save(List<Stock> listaStock)
        {
            Serializador.Archivo.SaveJson<Stock>("Stock_Comestible", listaStock);
        }
        public static List<Stock> ReadStock()
        {
            return Serializador.Archivo.ReadJson<Stock>("Stock_Comestible").ToList();
        }



    }
}
