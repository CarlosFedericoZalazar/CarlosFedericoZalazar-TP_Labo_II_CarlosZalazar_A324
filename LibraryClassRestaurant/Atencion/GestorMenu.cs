using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Interfaces;
using LibraryClassRestaurant.Mercaderia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryClassRestaurant.Atencion
{
    public class GestorMenu:ICocinero
    {
        public List<Plato>listaMenu = new List<Plato>();
        public bool Disponible { get; set; }

        List<StockComestible>listaStock = StockComestible.GetStockComestibles();
        private GestorMenu()
        {
            Disponible = false;
        }

        public static GestorMenu InstaciarGestorMenu()
        {
            return new GestorMenu();
        }

        public void AgregarPlato(Plato plato)
        {
            Serializador.Save<Plato>("PlatoMenu", plato);
            ActualizarEstadoMenu(plato); // HACER LAS PRUEBAS DE MENU
        }

        public void ActualizarEstadoMenu(Plato plato)
        {
            foreach (var item in plato.CantidadDeIngredientes)
            {
                foreach (var stock in listaStock)
                {
                    if (item.Key == stock.Producto)
                    {
                        if (item.Value > stock.Cantidad)
                        {
                            Disponible = true; // CORROBORAR SI ESTA BIEN
                            return;
                        }
                    }
                }
            }
            Disponible = false;
        }

    }
}
