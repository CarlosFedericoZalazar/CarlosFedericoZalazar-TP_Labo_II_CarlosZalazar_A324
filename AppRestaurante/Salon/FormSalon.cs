using AppRestoForm;
using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestaurante.Salon
{
    public partial class FormSalon : Form
    {
        public event EventHandler<MesaEventArgs> InicializarMesa;
        public FormPrincipal FormPrincipal { get; set; }
        public Cocinero Cocinero { get; set; }
        public List<Mesa> ListaMesas { get; set; }

        public IEncargado EncargadoTurno { get; set; }

        List<Empleado> listaMeseros = new List<Empleado>();

        public int CantidadMesas { get; set; }
        public FormSalon(FormPrincipal formPrincipal, List<Mesa> listaMesas, IEncargado encargado,Cocinero cocinero)
        {
            InitializeComponent();
            FormPrincipal = formPrincipal;
            ListaMesas = listaMesas;
            EncargadoTurno = encargado;
            Cocinero = cocinero;
        }

        private void FormSalon_Load(object sender, EventArgs e)
        {
            BindingList<Mesa> listaMesas = new BindingList<Mesa>(ListaMesas);
            var listaMeseros = Encargado.ListarMeserosActivos<Mesero>();
            lblEncargado.Text += $" {EncargadoTurno.Nombre}";
            cbMeseros.DataSource = listaMeseros;
            cbMeseros.DisplayMember = "Nombre";
            cbMesas.DataSource = listaMesas;
            cbMesas.DisplayMember = "NumeroMesa";
            cbMesas.Font = new Font("Arial", 18, FontStyle.Bold);
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Mesero mesero = (Mesero)cbMeseros.SelectedItem;
            var mesa = (Mesa)cbMesas.SelectedItem;

            if (mesa.Estado == Mesa.EstadoMesa.Abierta)
            {
                mesa.Estado = Mesa.EstadoMesa.Abierta;
                string mensaje = LibraryClassRestaurant.Atencion.Caja.Cuenta(mesa.Orden);
                DialogResult result = MessageBox.Show($"¿Desea pagar la cuenta? \n {mensaje}", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FormPagarCuenta formPagarCuenta = new FormPagarCuenta(EncargadoTurno, mesero, mesa);
                    formPagarCuenta.ShowDialog();

                    InicializarMesa+= FormMesa_PedidoRealizado;
                    RestaurarMesa(mesa);
                    return;
                }
                else
                {
                    return;
                }
                
            }

            FormMesa formMesa = new FormMesa(this, (Mesa)cbMesas.SelectedItem, mesero, Cocinero);
            formMesa.PedidoRealizado += FormMesa_PedidoRealizado;
            formMesa.Show();
            this.Hide();
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            FormPrincipal.Show();
            this.Close();
        }

        private void cbMesas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbMesas.SelectedItem != null)
            {
                Mesa mesa = (Mesa)cbMesas.SelectedItem;
                if (mesa.Estado == Mesa.EstadoMesa.Abierta)
                {
                    lblStatus.Text = Mesa.EstadoMesa.Abierta.ToString();
                    btnPedido.Text = "CERRAR MESA";
                }
                else
                {
                    lblStatus.Text = "";
                    btnPedido.Text = "HACER PEDIDO";
                }
            }
        }
        private void FormMesa_PedidoRealizado(object sender, MesaEventArgs e)
        {
            // Actualizar la lista de mesas en el ComboBox
            cbMesas.DataSource = null;
            cbMesas.DataSource = ListaMesas;
            cbMesas.DisplayMember = "NumeroMesa";

            // Opcional: seleccionar la mesa actualizada
            cbMesas.SelectedItem = e.Mesa;

            // Actualizar el estado de la mesa
            if (e.Mesa.Estado == Mesa.EstadoMesa.Abierta)
            {
                lblStatus.Text = Mesa.EstadoMesa.Abierta.ToString();
            }
            else
            {
                lblStatus.Text = "";
            }
        }

        private void RestaurarMesa(Mesa mesaA)
        {
            Mesa mesa = new Mesa(mesaA.NumeroMesa);
            mesa.Estado = Mesa.EstadoMesa.Cerrada;
            int indice = ListaMesas.IndexOf(mesaA);
            ListaMesas[indice] = mesa;
            InicializarMesa?.Invoke(this, new MesaEventArgs { Mesa = mesa });
        }
    }
}
