using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Mercaderia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestaurante.Caja
{
    public partial class FormConsumos : Form
    {
        public FormCaja FormCaja { get; set; }
        List<Cuenta> listaTickets = Encargado.GetTickets();
        public FormConsumos(FormCaja formCaja)
        {
            InitializeComponent();
            FormCaja = formCaja;
        }

        private void FormConsumos_Load(object sender, EventArgs e)
        {
            //dgTickets.AutoGenerateColumns = false;
            int cantidadTickets = listaTickets.Count;
            dgTickets.DataSource = listaTickets;
            dgTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //dgTickets.Columns["NroMesa"].DisplayIndex = 0;
            dgTickets.Columns["Nombre"].DisplayIndex = 1;
            dgTickets.Columns["Monto"].DisplayIndex = 2;
        }
    }
}
