using RestoApp.Files;
using RestoApp.Interfaces;
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
            Unidades = unidades;
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
            Stock registroStock=new Stock();
            string diaSemana = ObtenerDiaSemana();

            // Buscamos todos los pedidos del jason pedidos.json
            var pedidos = Pedido.ReadPedido();
            foreach (var item in pedidos) 
            {
                var aux = item.Proveedor.MedioDePago;
                if (item.EstadoPedido == Pedido.Estado.Pendiente) 
                {
                    if (diaSemana == item.Proveedor.DiaDeEntrega.ToLower())
                    {   
                        foreach(Producto.Tipo tipo in Enum.GetValues(typeof(Producto.Tipo)))
                        {
                            if (Producto.Tipo.Comida == tipo)
                            {
                                try
                                { 
                                    var producto = ProductoComestible.ProductoComestibleById(item.IdProducto);
                                    registroStock = new Stock(producto.Nombre, producto.Cantidad);                     
                                }
                                catch (MyExceptions.ProductoNoEncontradoException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            else
                            {
                                try
                                {
                                    var producto = ProductoBebible.ProductoBebibleById(item.IdProducto);
                                    registroStock = new Stock(producto.Nombre, producto.Cantidad);
                                }
                                catch (MyExceptions.ProductoNoEncontradoException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            Save(registroStock);
                        }    
                        item.EstadoPedido=Pedido.Estado.Recibido;
                        Pedido.Save(item);
                    }
                }
            }
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
            Serializador.Save<Stock>(stock, "Stock");
        }

        public static List<Stock> ReadStock()
        {
            return Serializador.Archivo.ReadJson<Stock>("Stock").ToList();
        }
    }
}
