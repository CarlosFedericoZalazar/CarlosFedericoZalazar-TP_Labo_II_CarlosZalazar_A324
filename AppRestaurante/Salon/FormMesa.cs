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
        Stack<Menu> listaMenu = new Stack<Menu>();

        List<StockBebidas> listaBebidas = StockBebidas.GetStockBebibles();
        public Cocinero Cocinero { get; set; }
        public FormSalon FormSalon { get; set; }
        public Mesa Mesa { get; set; }
        public Mesero Mesero { get; set; }
        public FormMesa(FormSalon formSalon, Mesa mesa, Mesero mesero, Cocinero cocinero)
        {
            InitializeComponent();
            Mesa = mesa;
            FormSalon = formSalon;
            Mesero = mesero;
            Cocinero = cocinero;
        }
        private void FormMesa_Load(object sender, EventArgs e)
        {
            this.Text += $" {Mesa.NumeroMesa}";
            var lista = Cocinero.GetMenu();

            
            cbMenu.DataSource = lista;
            cbBebidas.DataSource = listaBebidas;

            cbMenu.DisplayMember = "Nombre";
            cbBebidas.DisplayMember = "Producto";
        }

        private void btnPedidoCocina_Click(object sender, EventArgs e)
        {
            OrdenMesa ordenMesa = new OrdenMesa(Mesa, listaMenu, listaBebidas, Cocinero);
            Cocinero.Mensaje(ordenMesa.MostrarOrden(listaMenu));
            //Enviando orden a cocina
            var pedidosRechazados = Mesero.EnviarOrdenACocina(ordenMesa);
            if (pedidosRechazados.Count > 0)
            { 
                
                string mensajeDeCocina = OrdenMesa.MensajeFaltante(pedidosRechazados);
                Cocinero.Mensaje(mensajeDeCocina);
                //MessageBox.Show("No se pudo realizar el pedido, verifique los productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //Task task = Task.Run(async () =>
            //{
            //    try
            //    {
            //        // Simulación de una operación asincrónica
            //        await Task.Delay(10000);
            //        // Necesitamos asegurar que el siguiente código se ejecute en el hilo de la UI
            //        this.Invoke((Action)(() => MostrarMensaje("Pedido Realizado en la Cocina")));
            //    }
            //    catch (Exception ex)
            //    {
            //        this.Invoke((Action)(() => MostrarMensaje(ex.Message)));
            //    }
            //});
            //this.Hide();
            //FormSalon.Show();

        }

        private void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
                // Lógica si el usuario confirma
                listaMenu.Push((Menu)cbMenu.SelectedItem);
                MessageBox.Show("Registro ingresado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
