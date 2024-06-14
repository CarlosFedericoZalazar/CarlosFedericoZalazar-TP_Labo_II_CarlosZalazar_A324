using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClassRestaurant.Interfaces;

namespace LibraryClassRestaurant.Empleados
{
    public class Delivery : Empleado, IEmpleado
    {
        public Delivery(string nombre, string apellido, string direccion, string telefono, double sueldo, Perfil perfil) : base(nombre, apellido, direccion, telefono, sueldo, perfil)
        {
        }
        public Delivery() { }

        public Delivery(Empleado empleado)
        {
            this.Nombre = empleado.Nombre;
            this.Apellido = empleado.Apellido;
            this.Direccion = empleado.Direccion;
            this.Telefono = empleado.Telefono;
            this.Sueldo = empleado.Sueldo;
            this.Profile = empleado.Profile;
            this.EstadoEmpleado = empleado.EstadoEmpleado;
        }

    }
}
