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
        public FormDespachoPedido(FormPrincipal formularioPrincipal, IEncargado encargado, List<Menu> listaMenu, Comanda comanda)
        {
            InitializeComponent();
            FormularioPrincipal = formularioPrincipal;
            Encargado = encargado;
            ListaADespachar = listaMenu;
            Comanda = comanda;
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
        }

        private void btnLlevar_Click(object sender, EventArgs e)
        {
            var delivery = (Delivery)cbDelivery.SelectedItem;

            delivery.LlevarPedido(montoTotal,Comanda);
        }
    }
}
