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
            var dineroLevantado = Encargado.Caja.DineroTickets();
            if(dineroLevantado == 0)
            {
                MessageBox.Show("No se registran nuevos tickets a regitrar");
                return;
            }
            Encargado.Caja.Dinero += dineroLevantado;
            txtDineroCaja.Text = $"$ {Encargado.Caja.Dinero.ToString()}";
        }

        private void btnPagoProveedores_Click(object sender, EventArgs e)
        {
            Encargado.LiquidarProveedores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConsumos formConsumos = new FormConsumos(this, Encargado);
            formConsumos.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double plata);            
            Encargado.Caja.Cobrar(plata);
            txtDineroCaja.Text = $"$ {Encargado.Caja.Dinero.ToString()}";
        }
    }
}
