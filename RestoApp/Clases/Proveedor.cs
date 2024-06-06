using RestoApp.Files;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestoApp.Clases
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
        private static int _idProveedor = 1000;
        private string _nombre;
        private string _cuit;
        private string _direccion;
        private string _tipoProducto;
        private string _medioPago;
        private string _diaEntrega;
        private string _email;

        public Proveedor(string nombre, string cuit, string tipoProducto, string medioPago, string diaEntrega)
        {
            _nombre = nombre;
            _cuit = cuit;
            TipoProducto = tipoProducto;
            MedioDePago = medioPago;
            _direccion = "Avda. Siempre Viva 1064, Springfield";
            _email = $"{nombre}@gmail.com.ar";
            _diaEntrega = diaEntrega;
            _idProveedor++;
        }
        public Proveedor() { }
        public int Id { get => _idProveedor; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string MedioDePago { get =>_medioPago; set => _medioPago = value; }
        public string TipoProducto { get =>_tipoProducto; set =>_tipoProducto = value; }
        public string DiaDeEntrega { get => _diaEntrega; set => _diaEntrega = value; }

        public static string CuitGenerate ()
        {
            Random random = new Random();
            string cuit = "30-";
            for (int i = 0; i < 8; i++)
            {
                cuit += random.Next(0, 9).ToString();
            }
            return cuit;
        }

        public static void Save(Proveedor proveedor)
        {
            List<Proveedor> lista = new List<Proveedor>();
            try 
            {
                lista = Serializador.Archivo.ReadJson<Proveedor>($"proveedor{proveedor.TipoProducto}").ToList();
            
            }catch (Exception ex) 
            {
                lista = new List<Proveedor>();
            }
            lista.Add(proveedor);           

            Console.WriteLine(lista.Count);
            Serializador.Archivo.SaveJson<Proveedor>($"proveedor{proveedor.TipoProducto}", lista);
           
        }

    }
}
