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
        public delegate void Notificador(string mensaje);
        public event Notificador ?AvisoCocinero;

        public Menu GestorMenu { get; set; }
        public Cocinero() { }
        public Cocinero(string nombre, string apellido, string direccion, string telefono, double sueldo, Perfil perfil) : base(nombre, apellido, direccion, telefono, sueldo, perfil)
        {
            GestorMenu = Menu.InstaciarMenu();
        }

        public void AgregarPlato(Plato plato) 
        {
            this.GestorMenu.AgregarPlato(plato);
        }

        public List<Menu> GetMenu()
        {
            return this.GestorMenu.GetMenu();
        }

        public void Mensaje(string mensaje)
        {
            AvisoCocinero?.Invoke(mensaje);
        }

        public void QuitarPlato(Menu menu)
        {
            this.GestorMenu.QuitarPlato(menu);
        }

    }

}
