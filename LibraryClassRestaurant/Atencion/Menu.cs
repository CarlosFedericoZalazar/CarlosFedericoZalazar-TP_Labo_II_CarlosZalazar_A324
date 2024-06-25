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
            //Menu registroActualizado = ActualizarEstadoMenu(nuevoPlatoenMenu, lista);
            //Mensaje(registroActualizado.MensajeStatus);
            Serializador.Save<Menu>("Menu", nuevoPlatoenMenu);
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
        //public static Menu ActualizarEstadoMenu(Menu nuevoPlato, List<StockComestible> listaStock)
        //{
        //    StringBuilder informeProducto = new StringBuilder();
        //    bool ingredienteDisponible = true;

        //    foreach (var item in nuevoPlato.Plato.CantidadDeIngredientes)
        //    {
        //        ingredienteDisponible = false; // Asumimos que el ingrediente no está disponible hasta que se demuestre lo contrario

        //        foreach (var stock in listaStock)
        //        {
        //            if (item.Key == stock.Producto)
        //            {
        //                ingredienteDisponible = true; // Ingrediente encontrado en stock

        //                informeProducto.AppendLine($"Ingrediente {item.Key} OK");

        //                if (item.Value < stock.Cantidad)
        //                {
        //                    nuevoPlato.Disponibilidad = StatusMenu.Disponible; // CORROBORAR SI ESTA BIEN
        //                    informeProducto.AppendLine($"Cantidad de {item.Key} OK");
        //                }
        //                else
        //                {
        //                    informeProducto.AppendLine($"Cantidad de {item.Key} INSUFICIENTE");
        //                }
        //                break; // Salimos del loop de stock una vez que encontramos el ingrediente
        //            }
        //        }

        //        if (!ingredienteDisponible)
        //        {
        //            informeProducto.AppendLine($"Ingrediente {item.Key} NO DISPONIBLE");
        //        }
        //    }

        //    nuevoPlato.MensajeStatus = informeProducto.ToString();
        //    nuevoPlato.Disponibilidad = StatusMenu.NoDisponible;

        //    return nuevoPlato;
        //}

        public void Mensaje(string mensaje)
        {
            AvisoMenu?.Invoke(mensaje);
        }
    }
}