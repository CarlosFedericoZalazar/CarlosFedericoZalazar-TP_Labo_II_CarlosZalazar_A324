using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Mercaderia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestaurante.Salon
{
    public partial class FormMesa : Form
    {
        public event EventHandler<MesaEventArgs> PedidoRealizado;

        Stack<Menu> listaMenu = new Stack<Menu>();
        List<StockBebidas> bebidaSolicitadas = new List<StockBebidas>();

        List<StockBebidas> listaBebidas = StockBebidas.GetStockBebibles();
        public Cocinero Cocinero { get; set; }
        public FormSalon FormSalon { get; set; }
        public Mesa MesaCliente { get; set; }
        public Mesero Mesero { get; set; }
        public FormMesa(FormSalon formSalon, Mesa mesa, Mesero mesero, Cocinero cocinero)
        {
            InitializeComponent();
            MesaCliente = mesa;
            FormSalon = formSalon;
            Mesero = mesero;
            Cocinero = cocinero;
        }
        private void FormMesa_Load(object sender, EventArgs e)
        {
            this.Text += $" {MesaCliente.NumeroMesa}";
            var lista = Cocinero.GetMenu();

            if (MesaCliente.Estado == Mesa.EstadoMesa.Abierta)
            {
                lblListaPedidos.Text = MesaCliente.Orden.MostrarOrdenMenu();
            }
            else
            {
                lblListaPedidos.Text = "* ";
            }
            cbMenu.DataSource = lista;
            cbBebidas.DataSource = listaBebidas;
            cbMenu.DisplayMember = "Nombre";
            cbBebidas.DisplayMember = "Producto";
        }

        private void btnPedidoCocina_Click(object sender, EventArgs e)
        {
            OrdenMesa ordenMesa = new OrdenMesa(MesaCliente, listaMenu, bebidaSolicitadas, Cocinero);

            Cocinero.Mensaje(ordenMesa.MostrarOrden(listaMenu));
            //Enviando orden a cocina

            var BebidasSinStock = Mesero.BuscarBebidas(bebidaSolicitadas);
            if (BebidasSinStock.Count > 0)
            {
                MostrarMensaje("Se han quitado las bebidas que no estan disponibles, agruegue u envie los los restantes");
                return;
            }
            var pedidosRechazados = Mesero.EnviarOrdenACocina(ordenMesa);
            if (pedidosRechazados.Count > 0)
            {
                string mensajeDeCocina = OrdenMesa.MensajeFaltante(pedidosRechazados);
                Cocinero.Mensaje(mensajeDeCocina);
                ordenMesa.ListaPedidosMesa = ordenMesa.QuitarMenuRechazado(pedidosRechazados);
                MostrarMensaje("Se han quitado los Menu que no estan disponibles, agruegue u envie los los restantes");
                lblListaPedidos.Text = ordenMesa.MostrarOrden(ordenMesa.ListaPedidosMesa);
                return;
            }
            else
            {
                // CONFIRMAMOS LA APERTURA DE MESA
                MesaCliente.Estado = Mesa.EstadoMesa.Abierta;
                MesaCliente.Orden = ordenMesa;


                // Disparar el evento cuando se realiza el pedido
                PedidoRealizado?.Invoke(this, new MesaEventArgs { Mesa = MesaCliente });

                this.Close();
                FormSalon.Show();
            }

        }
        private void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormSalon.Show();
            this.Close();
        }

        private void btnAGregar_Click(object sender, EventArgs e)
        {
            var ordenMesa = (Menu)cbMenu.SelectedItem;
            DialogResult result = MessageBox.Show($"¿Confirma {ordenMesa.Nombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                listaMenu.Push((Menu)cbMenu.SelectedItem);
                lblListaPedidos.Text += $"{ordenMesa.Nombre}\n* ";
            }
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            var bebida = (StockBebidas)cbBebidas.SelectedItem;
            DialogResult result = MessageBox.Show($"¿Confirma {bebida.Producto}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bebidaSolicitadas.Add(bebida);
                lblBebida.Text += $"{bebida.Producto}\n* ";
            }
        }

        private void btnDelPlato_Click(object sender, EventArgs e)
        {
            try
            {
                var ultimoElement = listaMenu.Peek();
                DialogResult result = MessageBox.Show($"¿Confirma eliminar {ultimoElement.Nombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    listaMenu.Pop();
                    MessageBox.Show("Registro eiminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Ocurrió un error al intentar acceder a la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

public class MesaEventArgs : EventArgs
{
    public Mesa Mesa { get; set; }
}
