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
            Tarjeta,
            NoPago
        }


        public int NroMesa { get; set; }
        public MedioPago MedioPagoCuenta { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }

        public Empleado.Perfil Perfil { get; set; }

        public double Monto { get; set; }

        public bool Levantado { get; set; }
        public bool Cobrado { get; set; }
        public Cuenta() { }
        public Cuenta(int nroMesa, MedioPago medioPago, Empleado.Perfil perfil, string nombre, double monto)
        {
            NroMesa = nroMesa;
            MedioPagoCuenta = medioPago;
            Nombre = nombre;
            Perfil = perfil;
            Monto = monto;
            Fecha = DateTime.Now;
            Levantado= false;
            Cobrado = false;
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
