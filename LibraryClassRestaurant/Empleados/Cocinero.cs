using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Interfaces;
using LibraryClassRestaurant.Mercaderia;

namespace LibraryClassRestaurant.Empleados
{
    public class Cocinero : Empleado, IEmpleado, ICocinero
    {
        public delegate void Notificador(string mensaje);
        public event Notificador? AvisoCocinero;

        public StockComestible StockComestible = new StockComestible();
        public Menu GestorMenu { get; set; }
        public Cocinero() { }
        public Cocinero(string nombre, string apellido, string direccion, string telefono, double sueldoBolsillo, double sueldo, Perfil perfil) : base(nombre, apellido, direccion, telefono, sueldoBolsillo, sueldo, perfil)
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

        public void ModificarPlato(List<Menu> listaMenu)
        {
            this.GestorMenu.ModificarPlato(listaMenu);
        }

        public List<Menu> BusquedaMenuPorIngrediente(string ingrediente)
        {
            return this.GestorMenu.BusquedaMenuPorIngrediente(ingrediente);
        }

        public List<Menu> GetMenuDisponible()
        {
            return this.GestorMenu.GetMenuDisponible();
        }

        public void PepararComanda(List<Menu> listaMenu)
        {
            Stack<Menu> stackMenu = new Stack<Menu>(listaMenu);
            Thread cocinarThread = new Thread(IniciarOrden);
            cocinarThread.Start(stackMenu);
        }

        public void IniciarOrden(object obj)
        {
            Stack<Menu> stackMenu = (Stack<Menu>)obj;
            Cocina.CocinarPlatos(stackMenu, this);
            Thread.Sleep(1500);
            Mensaje("Pedido hecho, ya lo puede llevar el delivery.");
        }
    }

}
