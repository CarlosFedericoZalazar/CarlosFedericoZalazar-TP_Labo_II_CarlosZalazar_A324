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
            var seleccionPago = (Cuenta.MedioPago)cbMedioPago.SelectedItem;

            if (seleccionPago == Cuenta.MedioPago.NoPago)
            {
                var result = MessageBox.Show("¿Está seguro de que desea confirmar el NO PAGO de la cuenta?", "Confirmar NO PAGO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    cbMedioPago.Focus();
                    return;
                }
            }

            Mesero.CerrarMesa(MesaCliente, seleccionPago, montoTotal);

            //EncargadoTurno.Caja.Cobrar(cuenta.Monto);
            this.Close();
        }

        private void cbMedioPago_SelectedValueChanged(object sender, EventArgs e)
        {
            var Seleccion = (Cuenta.MedioPago)cbMedioPago.SelectedItem;

            if (Seleccion == Cuenta.MedioPago.NoPago)
            {
                if(montoTotal > 0)
                {
                    montoTotal *= -1;
                    btnPagar.Text = "CONFIRMAR";
                }                
            }
            else
            {
                if (montoTotal < 0)
                {
                    montoTotal *= -1;
                    btnPagar.Text = "PAGAR";
                }
            }
        }
    }
}
