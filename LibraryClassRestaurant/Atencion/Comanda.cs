using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Atencion
{
    public class Comanda
    {
        public string NombreCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public List<Menu> ListaMenu { get; set; }
        public Comanda()
        {
        }
        public Comanda(string nombreCliente, string direccionCliente, string telefonoCliente, List<Menu> listaMenu)
        {
            NombreCliente = nombreCliente;
            DireccionCliente = direccionCliente;
            TelefonoCliente = telefonoCliente;
            ListaMenu = listaMenu;
        }

    }
}
