using LibraryClassRestaurant.Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static LibraryClassRestaurant.Mercaderia.Proveedor;

namespace LibraryClassRestaurant.Mercaderia
{
    public class Proveedor
    {
        public enum MedioPago
        {
            Contado,
            Transferencia,
            Tarjeta
        }
        public enum DiaEntrega
        {
            Lunes,
            Martes,
            Miércoles,
            Jueves,
            Viernes
        }

        public enum EstadoCuenta
        {
            AlDia,
            Deuda
        }          

        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public string Direccion { get; set; }
        public string TipoProducto { get; set; }
        public MedioPago MedioDePago { get; set; }
        public DiaEntrega DiaDeEntrega { get; set; }
        public EstadoCuenta Estado { get; set; }
        public double DineroACobrar { get; set; }
        public List<Dictionary<string, double>> ProductosOfrecidos { get; set; }

        public Proveedor() { }
        public Proveedor(string nombre, string cuit, string tipoProducto, MedioPago medioPago, DiaEntrega diaEntrega)
        {
            Nombre = nombre;
            Cuit = cuit;
            TipoProducto = tipoProducto;
            MedioDePago = medioPago;
            Direccion = "Avda. Siempre Viva 1064, Springfield";
            DiaDeEntrega = diaEntrega;
            Estado = EstadoCuenta.AlDia;
            ProductosOfrecidos = new List<Dictionary<string, double>>();
        }

        public static string CuitGenerate()
        {
            Random random = new Random();
            string cuit = "30-";
            for (int i = 0; i < 8; i++)
            {
                cuit += random.Next(0, 9).ToString();
            }
            return cuit;
        }
        public static List<Proveedor>GetProveedores() 
        {
            return Serializador.Read<Proveedor>("Proveedor");
        }
        public static void Save(Proveedor proveedor) 
        {
            var proveedores = GetProveedores();
            foreach (var item in proveedores)
            {
                if (item.Cuit == proveedor.Cuit)
                {
                    var indice = proveedores.IndexOf(item);
                    proveedores[indice] = proveedor;
                    Log.Enter($"Se modificó el proveedor {proveedor.Nombre}");
                    //Log.Enter($"Se modificó el proveedor, producto {proveedor.ProductosOfrecidos[-1].Keys}");
                    break;    
                }
            }
            Serializador.SaveJson<Proveedor>("Proveedor", proveedores);
        }
    }
}
