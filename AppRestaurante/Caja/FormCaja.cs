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
    using LibraryClassRestaurant.Atencion;
    using LibraryClassRestaurant.Interfaces;

    public partial class FormCaja : Form
    {
        public IEncargado Encargado { get; set; }
        public FormCaja(IEncargado encargado)
        {
            InitializeComponent();
            Encargado = encargado;
        }

        private void FormCaja_Load(object sender, EventArgs e)
        {
            var caja = Encargado.Caja;
            txtDineroCaja.Text = $"$ {Encargado.Caja.Dinero.ToString()}";
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            Encargado.PagarSueldo();
            txtDineroCaja.Text = $"$ {Encargado.Caja.Dinero.ToString()}";
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            Encargado.Caja.Dinero += Encargado.Caja.DineroTickets();
            txtDineroCaja.Text = Encargado.Caja.Dinero.ToString();
        }

        private void btnPagoProveedores_Click(object sender, EventArgs e)
        {
            Encargado.LiquidarProveedores();
        }
    }
}
