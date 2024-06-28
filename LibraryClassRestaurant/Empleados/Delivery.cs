using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Interfaces;

namespace LibraryClassRestaurant.Empleados
{
    public class Delivery : Empleado, IEmpleado
    {
        public Delivery(string nombre, string apellido, string direccion, string telefono, double sueldoBolsillo,double sueldo, Perfil perfil) : base(nombre, apellido, direccion, telefono, sueldoBolsillo, sueldo, perfil)
        {
        }
        public Delivery() { }

        public void LlevarPedido(double monto, Comanda comanda)
        {
                Cuenta cuenta = new Cuenta(0, Cuenta.MedioPago.Efectivo, this.Profile, this.Nombre, monto);
                Caja.RegistrarTicket(cuenta);
                Log.Enter($"PEDIDO LLEVADO AL DOMICILIO A: {comanda.DireccionCliente.ToUpper()} por {this.Nombre} con un monto de {monto}");

        }

    }
}
