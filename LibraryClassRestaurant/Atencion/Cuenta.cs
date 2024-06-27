using LibraryClassRestaurant.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Atencion
{
    public class Cuenta
    {
        public enum MedioPago
        {
            Efectivo,
            Tarjeta
        }
        public int NroMesa { get; set; }
        public MedioPago MedioPagoCuenta { get; set; }
        public DateTime Fecha { get; set; }
        public string Mesero { get; set; }

        public double Monto { get; set; }
        public Cuenta() { }
        public Cuenta(int nroMesa, MedioPago medioPago, string mesero, double monto)
        {
            NroMesa = nroMesa;
            MedioPagoCuenta = medioPago;
            Mesero = mesero;
            Monto = monto;
            Fecha = DateTime.Now;
        }

        //public static string Cobrar(Mesa mesa, MedioPago medioPago)
        //{
        //    double total = 0;
        //    foreach (var item in mesa.Orden)
        //    {
        //        total += item.Precio;
        //    }
        //    string mensaje = $"El total a pagar es: {total}";
        //    return mensaje;
        //}
    }
}
