using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Mercaderia;
using System;
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
        public Concepto ConceptoOperacion { get; set; }

        public Caja(double dineroCaja)
        {
            DateTime Fecha = DateTime.Now;
            double Dinero = dineroCaja;
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
                Console.WriteLine(item.Precio);
                sumaTotal += item.Precio;
            }
            sb.AppendLine($"Total a pagar: {sumaTotal}");
            return sb.ToString();
        }

        public static Caja ObtenerDineroCaja()
        {
            var listaCaja = Serializador.Read<Caja>("DineroCaja");
            if (listaCaja.Count > 0)
            {
                return listaCaja[listaCaja.Count - 1];
            }
            return new Caja(0);
        }

        public void Cobrar(double dinero, Concepto concepto = Concepto.PagoDeCliente) 
        {
            this.ConceptoOperacion = concepto;
            this.Dinero += dinero;
            GuardarDineroCaja(this);
        }

        private static void GuardarDineroCaja(Caja caja)
        {
            Serializador.Save<Caja>("DineroCaja", caja);
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
            }
            else
            { 
                double dineroFaltante = montoAPagar - dineroAuxiliar;
                proveedor.DineroACobrar = dineroFaltante;
                this.Dinero = 0;
            }
            this.ConceptoOperacion = Concepto.PagoAProveedor;
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
                if (!item.Cobrado)
                { 
                    total += item.Monto;
                    item.Cobrado = true;                    
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
                this.ConceptoOperacion = Concepto.PagoAEmpleado;
                pagoOk = true;
                GuardarDineroCaja(this);
            }
            return pagoOk;
        }

    }
}
