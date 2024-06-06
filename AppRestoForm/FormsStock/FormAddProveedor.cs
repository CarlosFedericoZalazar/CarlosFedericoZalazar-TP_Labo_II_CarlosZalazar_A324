using RestoApp.Clases;
using RestoApp.Files;
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
    public partial class FormAddProveedor : Form
    {
        private string _tipo;
        IGenerarPedidos _encargado;
        FormHacerPedido _formularioPedido;
        public FormAddProveedor(string tipo, IGenerarPedidos encargado, FormHacerPedido formularioPedido)
        {
            InitializeComponent();
            _tipo = tipo;
            _encargado = encargado;
            _formularioPedido = formularioPedido;
        }

        private void FormAddProveedor_Load(object sender, EventArgs e)
        {
            this.Text = $"NUEVO PROVEEDOR - {_tipo.ToUpper()}";
            cbMedioPago.Items.AddRange(Enum.GetNames(typeof(Proveedor.MedioPago)));
            cbMedioPago.SelectedIndex = 0;

            cbDiaEntrega.Items.AddRange(Enum.GetNames(typeof(Proveedor.DiaEntrega)));
            cbDiaEntrega.SelectedIndex = 0;

            txtCuit.Text = Proveedor.CuitGenerate();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var medioPago = cbMedioPago.SelectedItem.ToString();
            var diaEntrega = cbDiaEntrega.SelectedItem.ToString();

            if (Validations.VerificarTextBoxesLlenos(this))
            {
                string nombreProveedor = txtNombre.Text;
                string cuit = txtCuit.Text;               

                if (medioPago != null && diaEntrega != null)
                {
                    Proveedor proveedor = new Proveedor(nombreProveedor, cuit, _tipo, medioPago, diaEntrega);
                    Proveedor.Save(proveedor);                    
                }
            }
            _formularioPedido.Show();
            this.Close();
        }
    }
}
