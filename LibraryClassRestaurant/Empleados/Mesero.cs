﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Interfaces;

namespace LibraryClassRestaurant.Empleados
{
    public class Mesero: Empleado, IEmpleado
    {
        public Mesero() { }
        public Mesero(string nombre, string apellido, string direccion, string telefono, double sueldo, Perfil perfil) : base(nombre, apellido, direccion, telefono, sueldo, perfil)
        {
        }
        public List<Menu> EnviarOrdenACocina(OrdenMesa ordenMesa)
        {
            var PedidoRechazazdo = ordenMesa.IniciarOrden();
            //var PedidoRechazazdo = OrdenMesa.IniciarOrden(ordenMesa);
            return PedidoRechazazdo;

        }

    }
}
