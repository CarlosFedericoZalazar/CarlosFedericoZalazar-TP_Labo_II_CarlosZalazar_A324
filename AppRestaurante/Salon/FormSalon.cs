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
        public FormPrincipal FormPrincipal { get; set; }
        public Cocinero Cocinero { get; set; }

        List<Empleado> listaMeseros = new List<Empleado>();
        List<Mesa> listaMesas = new List<Mesa>();
        public int CantidadMesas { get; set; }
        public FormSalon(FormPrincipal formPrincipal, int cantidadMesas, Cocinero cocinero)
        {
            InitializeComponent();
            FormPrincipal = formPrincipal;
            CantidadMesas = cantidadMesas;
            Cocinero = cocinero;
        }

        private void FormSalon_Load(object sender, EventArgs e)
        {
            InstanciarMesas();
            BindingList<Mesa> listaMesas = new BindingList<Mesa>(this.listaMesas);
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
                Mesa mesa = new Mesa(i + 1);
                listaMesas.Add(mesa);
            }
            var hola = listaMesas;

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Mesero mesero = (Mesero)cbMeseros.SelectedItem;
            FormMesa formMesa = new FormMesa(this, (Mesa)cbMesas.SelectedItem, mesero, Cocinero);
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
            if(cbMesas.SelectedItem != null)
            {
                Mesa mesa = (Mesa)cbMesas.SelectedItem;
                if(mesa.Estado == Mesa.EstadoMesa.Abierta)
                {
                    lblStatus.Text=Mesa.EstadoMesa.Abierta.ToString();
                    
                }
                else
                {
                    lblStatus.Text = "";
                }
            }
        }
    }
}
