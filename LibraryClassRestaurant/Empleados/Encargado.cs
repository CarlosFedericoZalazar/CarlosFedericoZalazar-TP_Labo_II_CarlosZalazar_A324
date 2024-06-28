﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Interfaces;
using LibraryClassRestaurant.Mercaderia;

namespace LibraryClassRestaurant.Empleados
{
    public class Encargado : Empleado, IEmpleado, IEncargado
    {
        public delegate void Notificador(string mensaje);
        public event Notificador? AvisoEncargado;
        public Caja Caja { get; set; }

        private GestorMercaderia _gestorMercaderia = InstanciarManejadorPedido();
        public GestorMercaderia GestorMercaderia { get => _gestorMercaderia; set => _gestorMercaderia = value; }
        const string PATH_EMPLEADOS = "Empleados";
        public Encargado() { }
        public Encargado(string nombre, string apellido, string direccion, string telefono, double sueldoBolsillo,double sueldo, Perfil perfil) : base(nombre, apellido, direccion, telefono, sueldoBolsillo, sueldo, perfil)
        {
        }

        public void Mensaje(string mensaje)
        {
            AvisoEncargado?.Invoke(mensaje);
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

        public List<Empleado> ListarEmpleados()
        {
            return ObtenerEmpleados();
        }

        public static List<T> ListarMeserosActivos<T>() where T : Empleado, IEmpleado
        {
            List<Empleado> listaEmpleados = ObtenerEmpleados();
            List<T> listaEmpleadoActivo = new List<T>();
            foreach (Empleado item in listaEmpleados)
            {
                if (item.Profile == Empleado.Perfil.Mesero && item.EstadoEmpleado == Empleado.Estado.Activo)
                {
                    var mesero = FabricaEmpleado.CrearEmpleado(item.Profile, item.Nombre, item.Apellido, item.Direccion, item.Telefono, item.SueldoBolsillo, item.Sueldo);
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

        public List<Menu> ModificarPrecio(Menu menu, double precio, List<Menu> listaMenu)
        {
            Menu auxiliar = new Menu();
            foreach (var item in listaMenu)
            {
                if (item.Nombre == menu.Nombre)
                {
                    item.Precio = precio;
                    break;
                }
            }
            Serializador.SaveJson<Menu>("Menu", listaMenu);
            return listaMenu;
        }

        public List<StockBebidas> ModificarPrecio(StockBebidas bebida, double precio, List<StockBebidas> listaMenu)
        {
            List<PedidoBebida> listaBebidas = PedidoBebida.GetPedidosBebidas();

            foreach (var item in listaBebidas)
            {
                if (item.Bebida.Nombre == bebida.Producto)
                {
                    item.Bebida.PrecioDeVenta = precio;
                    break;
                }
            }
            Serializador.SaveJson<PedidoBebida>("PedidoBebida", listaBebidas);
            return StockBebidas.GetStockBebibles();
        }

        public List<Bebida> GetBebidas()
        {
            List<Bebida> listaBebidas = new List<Bebida>();
            listaBebidas = Serializador.Read<Bebida>("PedidoBebida");
            return listaBebidas;
        }

        public void CobrarMesa(Mesa mesa, Caja caja)
        {
            string mensaje = Caja.Cuenta(mesa.Orden);
            double monto = mesa.MontoTotalMesa();

            caja.Dinero += monto;
            Console.WriteLine(mensaje);
        }

        public Proveedor PagarProveedor(double montoPagar, Proveedor proveedor)
        {
            var proveedorActualizado = this.Caja.Pagar(montoPagar, proveedor);
            if (proveedorActualizado.DineroACobrar > 0)
            {
                proveedorActualizado.Estado = Proveedor.EstadoCuenta.Deuda;
            }
            return proveedorActualizado;
        } 

        public static void RegistrarTicket(Cuenta cuenta)
        {
            Caja.RegistrarTicket(cuenta);
        }

        public void PagarSueldo()
        {
            var listaOrdenadaEmpleados = GenerandoPrioridadPago();
            int pagosRealizados = 0;
            Log.Enter("PAGO A EMPLEADOS");
            foreach (var empleado in listaOrdenadaEmpleados)
            {
                bool pagoOk = this.Caja.PagarSueldoEmpleado(empleado.Sueldo);
                if (!pagoOk)
                {
                    Mensaje("No hay mas dinero en la caja para el pago a Emplpleados");
                    Log.Enter("DINERO INSUFICIENTE PARA EL PAGO A EMPLEADOS");
                    break;
                }
                else 
                {
                    empleado.SueldoBolsillo+=empleado.Sueldo;
                    pagosRealizados++;
                }
                if (pagosRealizados == listaOrdenadaEmpleados.Count)
                {
                    Mensaje("Se han pagado todos los sueldos de los empleados");
                    Log.Enter("PAGO A EMPLEADOS REALIZADO");
                }
            }
            Log.Enter("ACTUALIZACION DE EMPLEADOS");
            Serializador.SaveJson<Empleado>("Empleados", listaOrdenadaEmpleados);
        }

        private List<Empleado> GenerandoPrioridadPago()
        {
            var listaEmpleados = ObtenerEmpleados();
            List<Empleado>listaOrdenada = new List<Empleado>();
            foreach(Empleado.Perfil item in Enum.GetValues(typeof(Empleado.Perfil)))
            {
                string cadena = "";
                var empleados = CargarPerfilEmpleado<Empleado>(listaEmpleados, item);
                foreach (var empleado in empleados)
                {
                    listaOrdenada.Add(empleado);
                    Console.WriteLine(empleado.Nombre + " " + empleado.Sueldo);
                }
                Console.WriteLine(cadena);
            }
            return listaOrdenada;
        }

        private List<T> CargarPerfilEmpleado<T>(List<Empleado> listaEmpleados, Empleado.Perfil perfilEmpleado)
        {
            List<T> empleados = new List<T>();

            foreach (var item in listaEmpleados)
            {
                if (item.Profile == perfilEmpleado)
                {
                    var empleadoCreado = FabricaEmpleado.CrearEmpleado(item.Profile, item.Nombre, item.Apellido, item.Direccion, item.Telefono,item.SueldoBolsillo, item.Sueldo);
                    empleados.Add((T)(object)empleadoCreado);
                }
            }

            return empleados;
        }

        public static void AlertarEncargado(string mensaje) 
        {
            Encargado encargado = new Encargado();
            encargado.Mensaje(mensaje);
        }



    }
}
