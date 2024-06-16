using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Atencion
{
    public class Cocina
    {
        public Mesa RecibirPedido(Mesa mesa)
        {
            // Simulación de una operación asincrónica
            Task.Delay(10000);
            return mesa;
        }

        private void DescontarMercaderia(Mesa mesa)
        {
        }
    }
}
