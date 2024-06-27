using LibraryClassRestaurant.Atencion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Interfaces
{
    public interface ICocinero
    {
        public void AgregarPlato(Plato plato);
        public List<Menu> GetMenu();
        public void Mensaje(string mensaje);

        public List<Menu> BusquedaMenuPorIngrediente(string ingrediente);
    }
}
