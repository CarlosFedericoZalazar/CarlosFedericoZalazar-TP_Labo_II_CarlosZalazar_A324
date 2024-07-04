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
    public partial class FormABMProveedor : Form
    {
        IEncargado _encargado;
        FormPanelPedidos _formPanelPedidos;
        public FormABMProveedor(FormPanelPedidos formPanelPedidos, IEncargado encargado)
        {
            InitializeComponent();
            _encargado = encargado;
            _formPanelPedidos = formPanelPedidos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAltaProveedor formAltaProveedor = new FormAltaProveedor(this, _encargado);
            formAltaProveedor.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formPanelPedidos.Show();
            this.Close();
        }

        private void btnGestorProducto_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos(this);
            formProductos.Show();
            this.Hide();
        }
    }
}
