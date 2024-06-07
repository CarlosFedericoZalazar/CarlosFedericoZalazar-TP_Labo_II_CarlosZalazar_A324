using RestoApp.Clases;
using RestoApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestoForm
{
    public partial class FormStock : Form
    {
        FormPrincipal formPrincipal;
        IGenerarPedidos encargado;
        public FormStock(FormPrincipal formPrincipal, IGenerarPedidos encargado)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.encargado = encargado;
        }

        private void btnHacerPedido_Click(object sender, EventArgs e)
        {
            FormHacerPedido formularioHacerPedido = new FormHacerPedido(encargado, this);
            formularioHacerPedido.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStockDisponible formStockDisponible = new FormStockDisponible();
            formStockDisponible.ShowDialog();
        }
    }
}
