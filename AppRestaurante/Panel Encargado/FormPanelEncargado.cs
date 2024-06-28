using AppRestaurante.Caja;
using AppRestaurante.Panel_Encargado;
using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Interfaces;
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
    public partial class FormPanelEncargado : Form
    {
        public IEncargado Encargado { get; set; }
        public ICocinero Cocinero { get; set; }
        public Caja Caja { get; set; }

        FormPrincipal formPrincipal;
        public FormPanelEncargado(FormPrincipal formPrincipal, IEncargado encargado, ICocinero cocinero)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            Encargado = encargado;
            Cocinero = cocinero;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPanelPedidos formPanelPedidos = new FormPanelPedidos(this, Encargado);
            formPanelPedidos.Show();
            this.Hide();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGestionarEmpleado_Click(object sender, EventArgs e)
        {
            FormABMEmpleado formABMEmpleado = new FormABMEmpleado(this);
            formABMEmpleado.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formPrincipal.Show();
            this.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FormStock formStock = new FormStock();
            formStock.Show();
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            FormPrecios formPrecios = new FormPrecios(this, Encargado, Cocinero);
            formPrecios.Show();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            FormCaja formCaja = new FormCaja(Encargado);
            formCaja.Show();
        }
    }
}
