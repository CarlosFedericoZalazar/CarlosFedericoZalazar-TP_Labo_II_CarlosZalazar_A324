using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Interfaces;

namespace LibraryClassRestaurant.Empleados
{
    public class Cocinero:Empleado, IEmpleado, ICocinero
    {
        private GestorMenu GestorMenu { get; set; }
        public Cocinero() { }
        public Cocinero(string nombre, string apellido, string direccion, string telefono, double sueldo, Perfil perfil) : base(nombre, apellido, direccion, telefono, sueldo, perfil)
        {
            GestorMenu = GestorMenu.InstaciarGestorMenu();
        }

        public void AgregarPlato(Plato plato) 
        {
            this.GestorMenu.AgregarPlato(plato);
        }


    }

}
