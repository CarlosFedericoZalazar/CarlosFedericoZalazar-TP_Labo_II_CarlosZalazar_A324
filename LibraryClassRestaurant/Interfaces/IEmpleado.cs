using LibraryClassRestaurant.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Interfaces
{
    public interface IEmpleado
    {
        public string Nombre { get; }
        public string Apellido { get; }
        public string Direccion { get; }
        public string Telefono { get; }
        public double Sueldo { get; }
        

    }
}
