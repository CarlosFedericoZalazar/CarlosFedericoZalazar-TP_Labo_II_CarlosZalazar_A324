using AppRestoForm;
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

namespace AppRestaurante.Panel_Encargado
{
    public partial class FormPanelPedidos : Form
    {
        IEncargado _encargado;
        FormPanelEncargado _formPanelEncargado;
        public FormPanelPedidos(FormPanelEncargado formPanelEncargado, IEncargado encargado)
        {
            InitializeComponent();
            _formPanelEncargado = formPanelEncargado;
            _encargado = encargado;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FormABMProveedor formABMProveedor = new FormABMProveedor(this, _encargado);
            formABMProveedor.Show();
            this.Hide();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPedido formPedido = new FormPedido(this, _encargado);
            formPedido.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formPanelEncargado.Show();
            this.Close();
        }
    }
}
