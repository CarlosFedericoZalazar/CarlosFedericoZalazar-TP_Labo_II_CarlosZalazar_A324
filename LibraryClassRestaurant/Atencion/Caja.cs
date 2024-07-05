using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Mercaderia;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassRestaurant.Atencion
{
    public class Caja
    {
        public enum Concepto
        {
            PagoAProveedor,
            PagoDeCliente,
            PagoAEmpleado,
        }
        public double Dinero { get; set; }
        public DateTime Fecha { get; set; }
        public Cuenta.MedioPago MedioPago { get; set; }
        public Caja() { }
        public Caja(double dineroCaja)
        {
            DateTime Fecha = DateTime.Now;
            Dinero = dineroCaja;
        }
        public Caja(double dineroCaja, Cuenta.MedioPago medioPago) : this(dineroCaja)
        {
            MedioPago= medioPago;
        }
        public static string Cuenta(OrdenMesa orden)
        {
            double sumaTotal = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var item in orden.ListaPedidosMesa)
            {
                sb.AppendLine($"Producto: {item.Nombre} Precio: {item.Precio}");
                sumaTotal += item.Precio;
            }
            foreach(var item in orden.ListaPedidoBebidas)
            {
                sb.AppendLine($"Producto: {item.Producto} Precio: {item.Precio}");
                sumaTotal += item.Precio;
            }
            sb.AppendLine($"Total a pagar: {sumaTotal}");
            return sb.ToString();
        }

        public static Caja ObtenerDineroCaja()
        {
            var caja = Serializador.ReadJsonSimple<Caja>("DineroCaja");
            if (caja == null)
            {
                caja = new Caja(10000);
            }
            return caja;
        }

        public void Cobrar(double dinero) 
        {
            this.Dinero += dinero;
            GuardarDineroCaja(this);
        }

        private static void GuardarDineroCaja(Caja caja)
        {
            Serializador.SaveJsonSimple<Caja>("DineroCaja", caja);
        }
        public static void RegistrarTicket(Cuenta cuenta)
        {
            Serializador.Save<Cuenta>("Tickets", cuenta);
        }

        public static List<Cuenta> GetTickets()
        {
            return Serializador.Read<Cuenta>("Tickets");
        }

        public Proveedor Pagar(double montoAPagar, Proveedor proveedor) 
        {
            double dineroAuxiliar = this.Dinero;

            if (dineroAuxiliar - montoAPagar >= 0)
            {
                Log.Enter($"PAGO A PROVEEDOR: {proveedor.Nombre}, MONTO PAGADO: ${montoAPagar}");
                this.Dinero -= montoAPagar;
                proveedor.DineroACobrar = 0;
            }
            else
            { 
                double dineroFaltante = montoAPagar - dineroAuxiliar;
                proveedor.DineroACobrar = dineroFaltante;
                this.Dinero = 0;
            }
            GuardarDineroCaja(this);

            return proveedor;
        }

        // VER LA LOGICA DE QUIN VENDIO MAS AQUI...
        public double DineroTickets()
        {
            var listaTickets = Serializador.Read<Cuenta>("Tickets");
            double total = 0;
            foreach (Cuenta item in listaTickets)
            {
                if (!item.Levantado)
                { 
                    total += item.Monto;
                    item.Levantado = true;                    
                }
            }
            ActualizarTickets(listaTickets);
            return total;
        }

        private void ActualizarTickets(List<Cuenta> listaTickets)
        {
            Serializador.SaveJson<Cuenta>("Tickets", listaTickets);
        }

        public bool PagarSueldoEmpleado(double sueldo)
        {
            bool pagoOk= false;
            if (this.Dinero - sueldo >= 0)
            {
                this.Dinero -= sueldo;
                pagoOk = true;
                GuardarDineroCaja(this);
            }
            return pagoOk;
        }

        public List<Cuenta> ConsumoPorEmpleados(List<Cuenta> listaTickets, string empleado)
        {
            List<Cuenta> ticketsEmpleado = new List<Cuenta>();
            foreach (var item in listaTickets)
            {
                if (item.Perfil.ToString() == empleado)
                {
                    ticketsEmpleado.Add(item);
                }
            }
            return ticketsEmpleado;
        }

        public List<Cuenta> ConsumoPorMedioPago(List<Cuenta> listaTickets, string medioPago)
        {
            List<Cuenta> ticketsEmpleado = new List<Cuenta>();
            foreach (var item in listaTickets)
            {
                if (item.MedioPagoCuenta.ToString() == medioPago)
                {
                    ticketsEmpleado.Add(item);
                }
            }
            return ticketsEmpleado;
        }

        public Dictionary<string, int> TopVentasEmpleados(List<Cuenta>listaTickets) 
        {
            Dictionary<string, int> contadorEmpleados = new Dictionary<string, int>();

            foreach (var item in listaTickets)
            {
                if(item.Cobrado == true && item.Levantado == true)
                {
                    if(contadorEmpleados.ContainsKey(item.Nombre))
                    {
                        contadorEmpleados[item.Nombre] += 1;
                    }
                    else
                    {
                        contadorEmpleados.Add(item.Nombre, 1);
                    }
                }
            }
            var empleadosOrdenados = contadorEmpleados.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value); ;
            return empleadosOrdenados;            
        }
        
    }
}
