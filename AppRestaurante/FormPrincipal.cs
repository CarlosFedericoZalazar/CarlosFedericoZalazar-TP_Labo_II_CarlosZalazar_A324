
using AppRestaurante.Cocina;
using AppRestaurante.Salon;
using AppRestaurante.EntregasDelivery;
using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Interfaces;
using LibraryClassRestaurant.Mercaderia;


namespace AppRestoForm
{
    public partial class FormPrincipal : Form
    {
        Cocinero cocinero = new Cocinero("Carlos", "Gonzalez", "Roca 33", "", 0, 230000, Empleado.Perfil.Cocinero);

        Encargado encargado = new Encargado("Alberto", "Mellino", "Roca 33", "", 0, 230000, Empleado.Perfil.Encargado);
        Caja caja = Caja.ObtenerDineroCaja();

        List<Mesa> listaMesas = Mesa.GetMesas(10);
        public FormPrincipal()
        {
            InitializeComponent();
            Log.Enter("INICIO DEL PROGRAMA");
        }

        private void btnPanelEncargado_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();

            FormPanelEncargado formPanelEncargado = new FormPanelEncargado(this, encargado, cocinero);
            formPanelEncargado.Show();
            this.Hide();
        }

        private void btnSalon_Click(object sender, EventArgs e)
        {
            FormSalon formSalon = new FormSalon(this, listaMesas, encargado, cocinero);
            formSalon.Show();
            this.Hide();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Inicializa el cocinero y suscribe al evento
            //Cocinero cocinero = new Cocinero("Carlos", "Gonzalez", "Roca 33", "", 230000, Empleado.Perfil.Cocinero);
            cocinero.AvisoCocinero += Mensaje_Evento;
            cocinero.GestorMenu.AvisoMenu += Mensaje_Evento;
            encargado.AvisoEncargado += Mensaje_Evento;
  
            encargado.Caja = caja;
        }

        private void btnCocina_Click(object sender, EventArgs e)
        {
            FormCocina formABMCartaRestaurant = new FormCocina(this, cocinero);
            formABMCartaRestaurant.Show();
            this.Hide();
        }

        private void Mensaje_Evento(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            Log.Enter($"{encargado.NombreCompleto}: TOMANDO PEDIDO TELELFONICO");
            FormPedidoTelefonico formPedidoTelefonico = new FormPedidoTelefonico(this, encargado, cocinero);
            formPedidoTelefonico.Show();
            this.Hide();
        }
    }
}
