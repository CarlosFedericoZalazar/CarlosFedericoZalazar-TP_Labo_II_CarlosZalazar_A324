using LibraryClassRestaurant.Archivos;
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

namespace AppRestaurante.Salon
{
    public partial class FormMesa : Form
    {
        List<Plato> listaMenu = Serializador.Read<Plato>("Plato");


        public FormSalon FormSalon { get; set; }
        public Mesa Mesa { get; set; }
        public FormMesa(FormSalon formSalon, Mesa mesa)
        {
            InitializeComponent();
            Mesa = mesa;
            FormSalon = formSalon;
        }

        private void FormMesa_Load(object sender, EventArgs e)
        {
            this.Text += $" {Mesa.NumeroMesa}";
            int cantidad = listaMenu.Count;

            cbMenu.DataSource = listaMenu;

            cbMenu.DisplayMember = "Nombre";
        }

        private void btnPedidoCocina_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(async () =>
            {
                try
                {
                    // Simulación de una operación asincrónica
                    await Task.Delay(10000);
                    // Necesitamos asegurar que el siguiente código se ejecute en el hilo de la UI
                    this.Invoke((Action)(() => MostrarMensaje("Pedido Realizado en la Cocina")));
                }
                catch (Exception ex)
                {
                    this.Invoke((Action)(() => MostrarMensaje(ex.Message)));
                }
            });
            this.Hide();
            FormSalon.Show();

        }

        private void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
