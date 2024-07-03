using AppRestoForm;
using AppRestaurante.ValidateForms;
using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Interfaces;
using static LibraryClassRestaurant.Atencion.Cocina;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestaurante.EntregasDelivery
{
    using AppRestaurante.ValidateForms;
    public partial class FormPedidoTelefonico : Form
    {

        public FormPrincipal FormularioPrincipal { get; set; }
        public Cocinero Cocinero { get; set; }
        public IEncargado Encargado { get; set; }
        List<Menu> menuSeleccionado = new List<Menu>();
        public FormPedidoTelefonico(FormPrincipal formPrincipal, IEncargado encargado, Cocinero cocinero)
        {
            InitializeComponent();
            FormularioPrincipal = formPrincipal;
            Encargado = encargado;
            Cocinero = cocinero;
        }

        private void FormPedidoTelefonico_Load(object sender, EventArgs e)
        {
            var lista = Cocinero.GetMenuDisponible();
            cbMenu.DataSource = lista;
            cbMenu.DisplayMember = "Nombre";

        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Comanda comanda = new Comanda();
            DialogResult result = MessageBox.Show("¿Confirma el pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool txtBoxOk = ValidateForms.Validate.VerificarTextBoxesLlenos(this);
                if (txtBoxOk && menuSeleccionado.Count > 0)
                {
                    comanda = GenerarComanda();
                    Encargado.GenerarComanda(comanda);
                    if (menuSeleccionado.Count == 0)
                    {
                        MessageBox.Show("No hay platos seleccionados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    Log.Enter($"ENCARGADO: {Encargado.Nombre} SE GENERA COMANDA: CLIENTE {txtNombre.Text}, DIRECCION: {txtDireccion}");
                    Cocinero.PepararComanda(menuSeleccionado);

                    FormDespachoPedido formDespachoPedido = new FormDespachoPedido(FormularioPrincipal, Encargado, menuSeleccionado, comanda);
                    formDespachoPedido.Show();
                    this.Close();

                }

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Pedido no confirmado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Comanda GenerarComanda()
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            return new Comanda(nombre, direccion, telefono, menuSeleccionado);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Agregar al pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            var menu = (Menu)cbMenu.SelectedItem;

            if (result == DialogResult.Yes)
            {
                menuSeleccionado.Add(menu);
            }
            else
            {
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormularioPrincipal.Show();
            this.Close();
        }
    }
}




//public static void CocinarPlatos(Stack<Menu> ListaPedidosMesa, Cocinero cocinero) // esta bien?
//{
//    bool cocinarPlatoOk = false;
//    Thread.Sleep(3000);
//    DescontarMercaderia(listaStock, ListaPedidosMesa);
//    cocinero.Mensaje("Se hizo el descuento de la mercaderia");
//    Thread.Sleep(5000);
//}
