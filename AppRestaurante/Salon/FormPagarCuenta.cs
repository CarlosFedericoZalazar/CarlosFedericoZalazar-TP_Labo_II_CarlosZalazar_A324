using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Atencion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using LibraryClassRestaurant.Interfaces;

namespace AppRestaurante.Salon
{
    public partial class FormPagarCuenta : Form
    {
        public IEncargado EncargadoTurno { get; set; }
        public Mesero Mesero { get; set; }
        public Mesa MesaCliente { get; set; }

        double montoTotal = 0;

        public FormPagarCuenta(IEncargado encargado, Mesero mesero, Mesa mesa)
        {
            InitializeComponent();
            EncargadoTurno = encargado;
            Mesero = mesero;
            MesaCliente = mesa;
        }

        private void FormPagarCuenta_Load(object sender, EventArgs e)
        {
            this.Text += $" {MesaCliente.NumeroMesa} - ATENDIDA POR: {Mesero.Nombre}";
            cbMedioPago.DataSource = Enum.GetValues(typeof(Cuenta.MedioPago));
            montoTotal = MesaCliente.MontoTotalMesa();

            CultureInfo culturaAR = new CultureInfo("es-AR");
            string formatoMonedaAR = montoTotal.ToString("C", culturaAR);
            lblMonto.Text += $" {formatoMonedaAR}";
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = Mesero.CerrarMesa(MesaCliente, (Cuenta.MedioPago)cbMedioPago.SelectedItem, montoTotal );
            Encargado.RegistrarTicket(cuenta);
            EncargadoTurno.Caja.Cobrar(cuenta.Monto);
            this.Close();
        }
    }
}
