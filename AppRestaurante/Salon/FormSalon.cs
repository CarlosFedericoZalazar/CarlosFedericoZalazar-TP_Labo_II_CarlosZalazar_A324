using AppRestoForm;
using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Empleados;
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
        FormPrincipal formPrincipal;
        List<Empleado> listaMeseros = new List<Empleado>();
        List<Mesa> listaMesas = new List<Mesa>();
        public int CantidadMesas { get; set; }
        public FormSalon(FormPrincipal formPrincipal, int cantidadMesas)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            CantidadMesas = cantidadMesas;
        }

        private void FormSalon_Load(object sender, EventArgs e)
        {
            InstanciarMesas();
            var listaMeseros = Encargado.ListarMeserosActivos<Mesero>();
            cbMeseros.DataSource = listaMeseros;
            cbMeseros.DisplayMember = "Nombre";
            cbMesas.DataSource = listaMesas;
            cbMesas.DisplayMember = "NumeroMesa";
            cbMesas.Font = new Font("Arial", 18, FontStyle.Bold);
        }

        private void InstanciarMesas()
        {
            for (int i = 0; i < CantidadMesas; i++)
            {
                Mesa mesa = new Mesa();
                mesa.NumeroMesa = i + 1;
                listaMesas.Add(mesa);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMesa formMesa = new FormMesa(this, (Mesa)cbMesas.SelectedItem);
            formMesa.Show();
            this.Hide();
        }
    }
}
