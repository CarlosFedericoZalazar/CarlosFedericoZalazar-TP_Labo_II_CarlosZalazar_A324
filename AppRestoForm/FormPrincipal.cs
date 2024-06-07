using AppRestoForm.FormsSalon;
using RestoApp.Clases;

namespace AppRestoForm
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Encargado encargado = new Encargado("Carlos", "Zalazar");

            FormStock pedidosForm = new FormStock(this, encargado);
            pedidosForm.Show();
            this.Hide();
        }

        private void btnSalon_Click(object sender, EventArgs e)
        {
            // HARCODEAMOS MOZOS
            List<string> mozos = new List<string> { "Lucas", "Mariano", "Carlos" };

            FormSalon formSalon = new FormSalon(5, mozos);
            formSalon.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Stock.CheckStock();
        }
    }
}
