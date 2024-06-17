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

        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public string Direccion { get; set; }
        public string TipoProducto { get; set; }
        public MedioPago MedioDePago { get; set; }
        public DiaEntrega DiaDeEntrega { get; set; }

        public Proveedor() { }
        public Proveedor(string nombre, string cuit, string tipoProducto, MedioPago medioPago, DiaEntrega diaEntrega)
        {
            Nombre = nombre;
            Cuit = cuit;
            TipoProducto = tipoProducto;
            MedioDePago = medioPago;
            Direccion = "Avda. Siempre Viva 1064, Springfield";
            DiaDeEntrega = diaEntrega;
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
            //Serializador.Save<Proveedor>("Proveedores", proveedor);
        }
    }
}
