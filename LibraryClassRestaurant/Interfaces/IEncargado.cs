using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Mercaderia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Interfaces
{
    public interface IEncargado
    {
        public void AgregarEmpleado(Empleado empleado);
        //public void EliminarEmpleado();
        //public void ModificarEmpleado();
        //public void MostrarEmpleados();

        public void AgregarProveedor(Proveedor proveedor);
        public GestorMercaderia GestorMercaderia { get; set; }
        public void GestionarPedidos(ProductoComestible producto, Proveedor proveedor);
        public void GestionarPedidos(Bebida producto, Proveedor proveedor);
        public List<Menu> ModificarPrecio(Menu menu, double precio, List<Menu> listaMenu);
    }
}
