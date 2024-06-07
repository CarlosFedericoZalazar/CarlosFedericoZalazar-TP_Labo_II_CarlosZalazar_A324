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
using static RestoApp.Clases.Producto;
using static RestoApp.Clases.Proveedor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace AppRestoForm
{
    public partial class FormHacerPedido : Form
    {
        FormStock formulalrioStock;
        IGenerarPedidos encargado;
        Dictionary<string, List<Proveedor>> dictProveedores = new Dictionary<string, List<Proveedor>>();
        List<IProducto> productos = new List<IProducto>();
        public FormHacerPedido(IGenerarPedidos encargado, FormStock formulalrioHacerPedido)
        {
            InitializeComponent();
            this.encargado = encargado;
            this.formulalrioStock = formulalrioHacerPedido;
        }

        private void HacerPedidoForm_Load(object sender, EventArgs e)
        {
            rbNo.Checked = true;
        }

        private void CargarDiccionarioProveedores()
        {
            foreach (string nombre in Enum.GetNames(typeof(Tipo)))
            {
                dictProveedores[nombre] = Serializador.Archivo.ReadJson<Proveedor>($"proveedor{nombre}").ToList();
            }
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Producto.Tipo type = (Producto.Tipo)cbTipo.SelectedItem;

            string tipoString = type.ToString();
            cbProveedor.DataSource = dictProveedores[tipoString];
            foreach (Producto.Tipo item in Enum.GetValues(typeof(Producto.Tipo)))
            {
                if (type == item)
                {
                    lblUnidKilos.Text = "Unidades";
                    gbAlcohol.Enabled = true;
                    break;
                }
                else
                {
                    lblUnidKilos.Text = "Kilos";
                    gbAlcohol.Enabled = false;
                    break;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Validations.VerificarTextBoxesLlenos(this))
            {
                return;
            }
            bool alcohol = rbSi.Checked == true ? true : false;
            InstanciaPedidos();
        }

        private void InstanciaPedidos()
        {
            IProducto producto;
            Proveedor proveedorSeleccionado = (Proveedor)cbProveedor.SelectedItem;
            DialogResult respuesta;
            double precio;
            double precioPedido;
            int cantidad;
            bool intCantidadOk = int.TryParse(txtCantidad.Text, out cantidad);
            bool doublePrecioOk = double.TryParse(txtPrecio.Text, out precio);

            if (!intCantidadOk || !doublePrecioOk)
                return;
            else
                precioPedido = cantidad * precio;

            Producto.Tipo type = (Producto.Tipo)cbTipo.SelectedItem;
            if (type == Tipo.Bebida)
            {
                producto = new ProductoBebible(txtProducto.Text, Convert.ToInt32(txtCantidad.Text), type, precioPedido, rbSi.Checked);
                productos.Add(producto);
            }
            else
            {
                producto = new ProductoComestible(txtProducto.Text, Convert.ToInt32(txtCantidad.Text), type, precioPedido);
                productos.Add(producto);
            }
            respuesta = MessageBox.Show($"¿Confirma ingreso de registro?\n{MostrarPedido(producto)}", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                if (proveedorSeleccionado != null)
                {
                    encargado.GestionarPedido(producto, cantidad, proveedorSeleccionado);
                    MessageBox.Show("PEDIDO INGRESADO LPM!");
                }
            }
        }

        private string MostrarPedido(IProducto producto)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"PRODUCTO: {producto.Nombre}");
            sb.AppendLine($"TIPO: {producto.TipoProducto.ToString()}");
            sb.AppendLine($"COSTO DEL PEDIDO: ${producto.Precio}");
            return sb.ToString();
        }

        private void btnAddProveedor_Click(object sender, EventArgs e)
        {
            var tipoProveedor = cbTipo.SelectedItem.ToString();
            if (tipoProveedor != null)
            {
                FormAddProveedor formularioNuevoProveedor = new FormAddProveedor(tipoProveedor, encargado, this);
                formularioNuevoProveedor.Show();
                this.Hide();

            }
        }

        private void FormHacerPedido_Activated(object sender, EventArgs e)
        {
            CargarDiccionarioProveedores();
            cbProveedor.DataSource = Serializador.Archivo.ReadJson<Proveedor>("proveedor");
            cbProveedor.DisplayMember = "Nombre";
            cbTipo.DataSource = Enum.GetValues(typeof(Producto.Tipo));
            cbTipo.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formulalrioStock.Show();
            this.Close();
        }
    }
}
