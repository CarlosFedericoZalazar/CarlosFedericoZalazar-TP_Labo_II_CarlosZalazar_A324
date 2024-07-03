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
        public string Nombre { get; set; }
        public void AgregarEmpleado(Empleado empleado);

        public List<Empleado> ListarEmpleados();
        public void EliminarEmpleado(Empleado empleado);
        //public void ModificarEmpleado();
        //public void MostrarEmpleados();

        public void AgregarProveedor(Proveedor proveedor);
        public GestorMercaderia GestorMercaderia { get; set; }
        public void GestionarPedidos(ProductoComestible producto, Proveedor proveedor);
        public void GestionarPedidos(Bebida producto, Proveedor proveedor);
        public List<Menu> ModificarPrecio(Menu menu, double precio, List<Menu> listaMenu);
        public List<StockBebidas> ModificarPrecio(StockBebidas bebida, double precio, List<StockBebidas> listaMenu);
        public List<Bebida> GetBebidas();
        public List<Delivery> GetDeliverys();
        public Proveedor PagarProveedor(double montoPagar, Proveedor proveedor);
        public void LiquidarProveedores();
        public void PagarSueldo();
        public Caja Caja { get; set; }
        public void GenerarComanda(Comanda comanda);
        public double CalcularCuenta(List<Menu> listaMenu);

    }
}
