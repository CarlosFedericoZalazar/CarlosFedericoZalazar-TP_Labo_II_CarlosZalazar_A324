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
using static LibraryClassRestaurant.Mercaderia.Proveedor;
using static AppRestaurante.ValidateForms.Validate;
using LibraryClassRestaurant.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace AppRestaurante.Panel_Encargado
{
    public partial class FormAltaProveedor : Form
    {
        FormABMProveedor _formABMProveedor;
        IEncargado _encargado;
        public FormAltaProveedor(FormABMProveedor formABMProveedor, IEncargado encargado)
        {
            InitializeComponent();
            _formABMProveedor = formABMProveedor;
            _encargado = encargado;
        }

        private void FormAltaProveedor_Load(object sender, EventArgs e)
        {
            cbMedioPago.DataSource = Enum.GetValues(typeof(Proveedor.MedioPago));
            //cbMedioPago.Items.AddRange(Enum.GetNames(typeof(Proveedor.MedioPago)));
            cbMedioPago.SelectedIndex = 0;

            cbDiaEntrega.DataSource = Enum.GetValues(typeof(Proveedor.DiaEntrega));
            //cbDiaEntrega.Items.AddRange(Enum.GetNames(typeof(Proveedor.DiaEntrega)));
            cbDiaEntrega.SelectedIndex = 0;

            cbTipoProducto.DataSource = Enum.GetValues(typeof(Producto.TipoProducto));
            //cbTipoProducto.Items.AddRange(Enum.GetNames(typeof(Producto.TipoProducto)));
            cbTipoProducto.SelectedIndex = 0;

            txtCuit.Text = Proveedor.CuitGenerate();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MedioPago medioPago = (MedioPago)cbMedioPago.SelectedItem;
            var diaEntrega = (DiaEntrega)cbDiaEntrega.SelectedItem;
            var tipoProducto = (Producto.TipoProducto)cbTipoProducto.SelectedItem;

            if (VerificarTextBoxesLlenos(this))
            {
                string nombreProveedor = txtNombre.Text;
                string cuit = txtCuit.Text;

                Proveedor proveedor = new Proveedor(nombreProveedor, cuit, tipoProducto.ToString(), medioPago, diaEntrega);
                DialogResult resultado = MessageBox.Show("¿Confirma el ingreso del registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resultado == DialogResult.Yes)
                {
                    _encargado.AgregarProveedor(proveedor);
                    MessageBox.Show("Proveedor ingresado con éxito", "Proveedor ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _formABMProveedor.Show();
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
                _formABMProveedor.Show();
            }
        }
    }
}
