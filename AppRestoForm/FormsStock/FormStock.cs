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
    public partial class StockForm : Form
    {
        FormPrincipal formPrincipal;
        IGenerarPedidos encargado;
        public StockForm(FormPrincipal formPrincipal, IGenerarPedidos encargado)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.encargado = encargado;
        }

        private void btnHacerPedido_Click(object sender, EventArgs e)
        {
           
            Encargado encargado = new Encargado("Carlos","Zalazar");
            FormHacerPedido formularioHacerPedido = new FormHacerPedido(encargado);
            formularioHacerPedido.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
