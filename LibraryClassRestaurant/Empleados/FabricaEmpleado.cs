using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Empleados
{
    public class FabricaEmpleado
    {
        public static Empleado CrearEmpleado(Empleado.Perfil perfil, string nombre, string apellido, string direccion, string telefono, double sueldo)
        {
            switch (perfil)
            {
                case Empleado.Perfil.Mesero:
                    return new Mesero(nombre, apellido, direccion, telefono, sueldo, perfil);
                case Empleado.Perfil.Cocinero:
                    return new Cocinero(nombre, apellido, direccion, telefono, sueldo, perfil);
                case Empleado.Perfil.Delivery:
                    return new Delivery(nombre, apellido, direccion, telefono, sueldo, perfil);
                case Empleado.Perfil.Encargado:
                    return new Encargado(nombre, apellido, direccion, telefono, sueldo, perfil);
                default:
                    throw new ArgumentException("Perfil de empleado no válido");
            }
        }
    }
}
