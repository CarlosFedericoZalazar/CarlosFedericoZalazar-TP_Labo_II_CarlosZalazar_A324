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
        private string _nombre;
        private string _cuit;
        private string _direccion;
        private string _tipoProducto;
        private MedioPago _medioPago;
        private DiaEntrega _diaEntrega;

        public string Nombre { get=>_nombre; set=>_nombre=value; }
        public string Cuit { get => _cuit; set => _cuit = value;}
        public string Direccion { get => _direccion; set => _direccion = value;}
        public string TipoProducto {get => _tipoProducto;set => _tipoProducto = value;}
        public MedioPago MedioDePago { get => _medioPago; set => _medioPago = value; }
        public DiaEntrega DiaDeEntrega { get => _diaEntrega; set => _diaEntrega = value; }

        public Proveedor() { }
        public Proveedor(string nombre, string cuit, string tipoProducto, MedioPago medioPago, DiaEntrega diaEntrega)
        {
            _nombre = nombre;
            _cuit = cuit;
            _tipoProducto = tipoProducto;
            MedioDePago = medioPago;
            _direccion = "Avda. Siempre Viva 1064, Springfield";
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
