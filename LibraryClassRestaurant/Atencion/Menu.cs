using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Interfaces;
using LibraryClassRestaurant.Mercaderia;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryClassRestaurant.Atencion
{
    public class Menu : ICocinero
    {
        public delegate void Notificador(string mensaje);
        public event Notificador? AvisoMenu;
        public enum StatusMenu
        {
            NoDisponible,
            Disponible
        }
        public string Nombre { get; set; }
        public List<Plato> listaMenu = new List<Plato>();
        public StatusMenu Disponibilidad { get; set; }
        public string MensajeStatus { get; set; }
        public Plato Plato { get; set; }
        public double Precio { get; set; }

        public Menu()
        {
        }

        private Menu(Plato plato, StatusMenu disponible, string mensajeStatus = "")
        {
            Nombre = plato.Nombre;
            Plato = plato;
            Disponibilidad = disponible;
            MensajeStatus = mensajeStatus;
            Precio = 0;
        }
        public static Menu InstaciarMenu()
        {
            return new Menu();
        }

        public static Menu CrearGestorMenu(Plato plato, StatusMenu disponible)
        {
            return new Menu(plato, disponible);
        }

        public void AgregarPlato(Plato plato)
        {
            Menu nuevoPlatoenMenu = CrearGestorMenu(plato, StatusMenu.Disponible);
            Serializador.Save<Menu>("Menu", nuevoPlatoenMenu);
        }

        public void QuitarPlato(Menu menu)
        {            
            List<Menu> listaMenu = GetMenu();

            foreach (var item in listaMenu)
            {
                if (item.Nombre == menu.Nombre)
                {
                    listaMenu.Remove(item);
                    break;
                }
            }
            int contador = listaMenu.Count;
            Serializador.SaveJson<Menu>("Menu", listaMenu);
        }

        public void ModificarPlato(List<Menu>listaMenu)
        {
            Serializador.SaveJson<Menu>("Menu", listaMenu); 
        }
        public static List<Menu>CargarMenuDisponible()
        {
            List<Menu> listaMenu = Serializador.Read<Menu>("Menu");
            List<Menu> listaDisponible = new List<Menu>();

            foreach (var item in listaMenu)
            {
                if (item.Disponibilidad == StatusMenu.Disponible)
                {
                    listaDisponible.Add(item);
                }
            }
            return listaDisponible;
        }

        public List<Menu> GetMenu() 
        {
            return Serializador.Read<Menu>("Menu");
        }        

        public void Mensaje(string mensaje)
        {
            AvisoMenu?.Invoke(mensaje);
        }

        public List<Menu> BusquedaMenuPorIngrediente(string ingrediente) 
        {
            var listaMenu = GetMenu();
            List<Menu> listaAuxiliar = new List<Menu>();

            foreach (var item in listaMenu)
            {
                foreach (var itemPlato in item.Plato.CantidadDeIngredientes)
                {
                    if (itemPlato.Key == ingrediente)
                    {
                        listaAuxiliar.Add(item);
                        break;
                    }
                }
            }
            return listaAuxiliar;
        }

        public List<Menu> GetMenuDisponible()
        {
            List<Menu> listaMenu = GetMenu();
            List<Menu> listaMenuDisponible = new List<Menu>();

            foreach (Menu item in listaMenu)
            {
                var itemActualizzado = Cocina.ActualizarEstadoMenu(item);
                if (itemActualizzado.Disponibilidad == StatusMenu.Disponible)
                {
                    listaMenuDisponible.Add(item);
                }
            }
            return listaMenuDisponible;

        }
    }
}