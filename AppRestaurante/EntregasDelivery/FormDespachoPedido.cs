using AppRestoForm;
using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestaurante.EntregasDelivery
{
    public partial class FormDespachoPedido : Form
    {

        FormPrincipal FormularioPrincipal { get; set; }
        IEncargado Encargado { get; set; }
        public List<Menu> ListaADespachar { get; set; }
        double montoTotal = 0;
        public Comanda Comanda { get; set; }

        public Cuenta.MedioPago MedioPagoPedido { get; set; }
        public FormDespachoPedido(FormPrincipal formularioPrincipal, IEncargado encargado, List<Menu> listaMenu, Comanda comanda, Cuenta.MedioPago medioPagoPedido)
        {
            InitializeComponent();
            FormularioPrincipal = formularioPrincipal;
            Encargado = encargado;
            ListaADespachar = listaMenu;
            Comanda = comanda;
            MedioPagoPedido = medioPagoPedido;
        }

        private void FormDespachoPedido_Load(object sender, EventArgs e)
        {
            var ListaDeliverys = Encargado.GetDeliverys();
            montoTotal = Encargado.CalcularCuenta(ListaADespachar);
            cbDelivery.DataSource = ListaDeliverys;
            cbDelivery.DisplayMember = "Nombre";
            CultureInfo culturaAR = new CultureInfo("es-AR");
            string formatoMonedaAR = montoTotal.ToString("C", culturaAR);
            txtCosto.Text += $" {formatoMonedaAR}";
            if (MedioPagoPedido != Cuenta.MedioPago.Efectivo)
            {
                btnNoPagado.Visible = false;
                btnLlevar.Location = new System.Drawing.Point(156, 125);
            }
        }

        private void btnLlevar_Click(object sender, EventArgs e)
        {
            RegistrarPedido(montoTotal, MedioPagoPedido);
        }

        private void btnNoPagado_Click(object sender, EventArgs e)
        {
            RegistrarPedido(montoTotal * (-1), Cuenta.MedioPago.NoPago);
        }

        private void RegistrarPedido(double monto, Cuenta.MedioPago medioPago) 
        {
            var delivery = (Delivery)cbDelivery.SelectedItem;

            delivery.RegistrarPedido(monto, Comanda, medioPago);

            FormularioPrincipal.Show();
            this.Close();
        }
    }
}
