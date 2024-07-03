using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Interfaces;
using LibraryClassRestaurant.Mercaderia;

namespace LibraryClassRestaurant.Empleados
{
    public class Mesero: Empleado, IEmpleado
    {
        public Mesero() { }
        public Mesero(string nombre, string apellido, string direccion, string telefono,double sueldoBolsillo, double sueldo, Perfil perfil) : base(nombre, apellido, direccion, telefono, sueldoBolsillo, sueldo, perfil)
        {
        }
        public List<Menu> EnviarOrdenACocina(OrdenMesa ordenMesa)
        {
            var PedidoRechazazdo = ordenMesa.IniciarOrden();
            return PedidoRechazazdo;
        }

        public void CerrarMesa(Mesa mesa, Cuenta.MedioPago medioPago, double monto)
        {
            Cuenta cuenta = new Cuenta(mesa.NumeroMesa, medioPago, this.Profile ,this.Nombre, monto);
            Caja.RegistrarTicket(cuenta); 
            Log.Enter($"Mesa {mesa.NumeroMesa} cerrada por {this.Nombre} con un monto de {monto}");
        }

        public List<StockBebidas> BuscarBebidas(List<StockBebidas> listaBebidasSolicitadas)
        {
            var bebidasSinStock = StockBebidas.RetirarBebida(listaBebidasSolicitadas);
            if(bebidasSinStock.Count > 0)
            { 
                string stringBebidaSinStock = "";
                foreach (var bebida in bebidasSinStock)
                { 
                    stringBebidaSinStock += $"{bebida.Producto} ";
                }

                Log.Enter($"NO SE PUDIERON RETIRAR LA\\S BEBIDA\\S: {stringBebidaSinStock}");
            }
            return bebidasSinStock;
        }

        public static List<Mesero>CargarMeseros()
        {   
            var listaEmpleados = Encargado.ObtenerEmpleados();
            List<Mesero> listaMesetosTurno = new List<Mesero>();

            foreach (var item in listaEmpleados)
            {
                if (item.Profile == Empleado.Perfil.Mesero)
                {
                    var mesero = FabricaEmpleado.CrearEmpleado(item.Profile, item.Nombre, item.Apellido, item.Direccion, item.Telefono, item.SueldoBolsillo, item.Sueldo);
                    listaMesetosTurno.Add((Mesero)mesero);
                }
            }
            return listaMesetosTurno;
        }

    }
}
