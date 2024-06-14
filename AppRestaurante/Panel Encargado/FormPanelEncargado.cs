using AppRestaurante.Panel_Encargado;
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
        IEncargado _encargado;
        FormPrincipal formPrincipal;
        public FormPanelEncargado(FormPrincipal formPrincipal, IEncargado encargado)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            _encargado = encargado;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPanelPedidos formPanelPedidos = new FormPanelPedidos(this, _encargado);
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


    }
}
