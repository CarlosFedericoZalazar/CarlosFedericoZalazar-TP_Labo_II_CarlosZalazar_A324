using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Interfaces;
using LibraryClassRestaurant.Mercaderia;

namespace LibraryClassRestaurant.Empleados
{
    public class Encargado: Empleado, IEmpleado, IEncargado
    {
        private GestorMercaderia _gestorMercaderia = InstanciarManejadorPedido();
        public GestorMercaderia GestorMercaderia { get => _gestorMercaderia; set => _gestorMercaderia = value; }
        const string PATH_EMPLEADOS = "Empleados";
        public Encargado() { }
        public Encargado(string nombre, string apellido, string direccion, string telefono, double sueldo, Perfil perfil) : base(nombre, apellido, direccion, telefono, sueldo, perfil)
        {
        }

        public Encargado(Empleado empleado)
        {
            this.Nombre = empleado.Nombre;
            this.Apellido = empleado.Apellido;
            this.Direccion = empleado.Direccion;
            this.Telefono = empleado.Telefono;
            this.Sueldo = empleado.Sueldo;
            this.Profile = empleado.Profile;
            this.EstadoEmpleado = empleado.EstadoEmpleado;
        }

        public static GestorMercaderia InstanciarManejadorPedido()
        {
            return GestorMercaderia.InstanciarGestorMercaderia();
        }

        public void AgregarProveedor(Proveedor proveedor)
        {            
            Serializador.Save<Proveedor>("Proveedor", proveedor);
        }
        public void AgregarEmpleado(Empleado empleado) 
        {
            Serializador.Save<Empleado>("Empleados", empleado);
        }

        public static List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            empleados = Serializador.Read<Empleado>(PATH_EMPLEADOS);
            return empleados;
        }

        public static List<T> ListarMeserosActivos<T>()where T:Empleado,IEmpleado
        {
            List<Empleado> listaEmpleados = ObtenerEmpleados();
            List<T> listaEmpleadoActivo = new List<T>();
            foreach (Empleado item in listaEmpleados)
            {
                if (item.Profile == Empleado.Perfil.Mesero && item.EstadoEmpleado == Empleado.Estado.Activo)
                {
                    var mesero = FabricaEmpleado.CrearEmpleado(item.Profile, item.Nombre, item.Apellido, item.Direccion, item.Telefono, item.Sueldo);
                    listaEmpleadoActivo.Add((T)mesero);
                }
            }
            return listaEmpleadoActivo;
        }

        public void GestionarPedidos(ProductoComestible producto, Proveedor proveedor)
        { 
            GestorMercaderia.GestionarPedidos(producto);
        }

        public void GestionarPedidos(Bebida producto, Proveedor proveedor)
        {
            GestorMercaderia.GestionarPedidos(producto);
        }


    }
}
