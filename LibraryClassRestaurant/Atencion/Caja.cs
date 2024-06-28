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
            PagoProveedor,
            PagoCliente
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

        public void Cobrar(double dinero, Concepto concepto = Concepto.PagoCliente) 
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

        public Proveedor Pagar(double montoAPagar, Proveedor proveedor) 
        {
            double dineroAuxiliar = this.Dinero;

            if (dineroAuxiliar - montoAPagar >= 0)
            {
                this.Dinero -= montoAPagar;
            }
            else
            { 
                double dineroFaltante = montoAPagar - dineroAuxiliar;
                proveedor.DineroACobrar = dineroFaltante;
                this.Dinero = 0;
            }
            this.ConceptoOperacion = Concepto.PagoProveedor;
            GuardarDineroCaja(this);

            return proveedor;
        }


    }
}
