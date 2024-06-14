
using AppRestaurante.Cocina;
using AppRestaurante.Salon;
using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Interfaces;
using LibraryClassRestaurant.Mercaderia;

namespace AppRestoForm
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnPanelEncargado_Click(object sender, EventArgs e)
        {
            Encargado encargado = new Encargado();

            Delivery delivery = new Delivery();

            FormPanelEncargado formPanelEncargado = new FormPanelEncargado(this, encargado);
            formPanelEncargado.Show();
            this.Hide();
        }

        private void btnSalon_Click(object sender, EventArgs e)
        {
            // LOGICA PARA MOSTRAR EL FORMULARIO DE SALON
            FormSalon formSalon = new FormSalon(this, 10);
            formSalon.Show();
            this.Hide();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCocina_Click(object sender, EventArgs e)
        {

            Cocinero cocinero = new Cocinero("Carlos", "Gonzalez", "Roca 33", "", 230000, Empleado.Perfil.Cocinero);

            FormCocina formABMCartaRestaurant = new FormCocina(this, cocinero);
            formABMCartaRestaurant.Show();
            this.Hide();
        }
    }
}
