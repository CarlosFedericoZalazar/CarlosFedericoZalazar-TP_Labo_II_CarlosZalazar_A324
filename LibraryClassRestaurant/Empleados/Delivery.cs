﻿using System;
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

        public void RegistrarPedido(double monto, Comanda comanda, Cuenta.MedioPago medioPago)
        {
            Cuenta cuenta = new Cuenta(0, medioPago, this.Profile, this.NombreCompleto, monto);
            if (medioPago == Cuenta.MedioPago.NoPago) 
            {
                Log.Enter($"PEDIDO NO PAGADO LLEVADO AL DOMICILIO A: {comanda.DireccionCliente.ToUpper()} por {this.Nombre}");
                cuenta.Cobrado = false;
            }
            else
            {
                cuenta.Cobrado = true;
                Log.Enter($"PEDIDO LLEVADO AL DOMICILIO A: {comanda.DireccionCliente.ToUpper()} por {this.Nombre} con un monto de {monto}");
            }
            Caja.RegistrarTicket(cuenta);

        }

    }
}
