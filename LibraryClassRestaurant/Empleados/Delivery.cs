using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClassRestaurant.Interfaces;

namespace LibraryClassRestaurant.Empleados
{
    public class Delivery : Empleado, IEmpleado
    {
        public Delivery(string nombre, string apellido, string direccion, string telefono, double sueldoBolsillo,double sueldo, Perfil perfil) : base(nombre, apellido, direccion, telefono, sueldoBolsillo, sueldo, perfil)
        {
        }
        public Delivery() { }

    }
}
