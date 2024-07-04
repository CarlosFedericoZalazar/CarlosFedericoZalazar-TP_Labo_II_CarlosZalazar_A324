using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Interfaces;
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
using AppRestaurante.ValidateForms;
using static LibraryClassRestaurant.Mercaderia.Producto;
using LibraryClassRestaurant.Empleados;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace AppRestaurante.Panel_Encargado
{
    public partial class FormPedido : Form
    {
        public IEncargado Encargado { get; set; }

        public FormPanelPedidos FormPanelPedidos { get; set; }

        Dictionary<string, List<Proveedor>> dictProveedores = new Dictionary<string, List<Proveedor>>();
        public FormPedido(FormPanelPedidos formPanelPedidos, IEncargado encargado)
        {
            InitializeComponent();
            FormPanelPedidos = formPanelPedidos;
            Encargado = encargado;
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            CargarDiccionarioProveedores();
            cbTipo.DataSource = Enum.GetValues(typeof(Producto.TipoProducto));
            cbTipo.SelectedIndex = 1;
            var type = cbTipo.SelectedItem.ToString();
            if (type != null)
            {
                cbProveedor.DataSource = dictProveedores[type];
                cbProveedor.DisplayMember = "Nombre";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormPanelPedidos.Show();
            this.Close();
        }

        private void cbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            Producto.TipoProducto type = (Producto.TipoProducto)cbTipo.SelectedItem;

            string tipoString = type.ToString();
            int cantidadRegistros = dictProveedores[tipoString].Count;
            cbProveedor.DataSource = dictProveedores[tipoString];
            foreach (Producto.TipoProducto item in Enum.GetValues(typeof(Producto.TipoProducto)))
            {
                if (type == item)
                {
                    lblPrecio.Text = "PRECIO (x Unidad)";
                    break;
                }
                else
                {
                    lblPrecio.Text = "PRECIO (x Kilo)";
                    break;
                }
            }
        }

        private void CargarDiccionarioProveedores()
        {
            List<Proveedor> listProveedores = new List<Proveedor>();
            listProveedores = Proveedor.GetProveedores();

            foreach (Proveedor proveedor in listProveedores)
            {
                string tipo = proveedor.TipoProducto;
                if (!dictProveedores.ContainsKey(tipo))
                {
                    dictProveedores[tipo] = new List<Proveedor>();
                }
                dictProveedores[tipo].Add(proveedor);
            }
            int numero = dictProveedores.Count;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidateForms.Validate.VerificarTextBoxesLlenos(this))
            {
                return;
            }

            CrearProducto();
        }

        private void CrearProducto()
        {
            Bebida productoBebida = new Bebida();
            ProductoComestible productoComida = new ProductoComestible();

            Proveedor proveedorSeleccionado = (Proveedor)cbProveedor.SelectedItem;

            double precio;
            double precioPedido;
            bool intCantidadOk = int.TryParse(txtCantidad.Text, out int cantidad);
            bool intCantidadGramosOk = double.TryParse(txtCantidad.Text, out double cantidadGramos);
            bool doublePrecioOk = double.TryParse(txtPrecio.Text, out precio);
            //bool alcohol = rbSi.Checked == true ? true : false;
            bool alcohol = false;
            if ((intCantidadOk || doublePrecioOk) || (intCantidadGramosOk || doublePrecioOk))
                precioPedido = cantidad * precio;
            else
                return;

            var respuesta = MessageBox.Show($"¿Confirma ingreso de registro?\n", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Producto.TipoProducto type = (Producto.TipoProducto)cbTipo.SelectedItem;
                var producto = cbProducto.SelectedItem as string;
                Proveedor proveedorPagado = Encargado.PagarProveedor(precioPedido, proveedorSeleccionado);
                if (producto == null)
                {
                    MessageBox.Show("Seleccione un producto");
                    return;
                }

                if (type == TipoProducto.Bebida)
                {
                    productoBebida = new Bebida(producto, type, cantidad, alcohol, precioPedido, proveedorPagado);
                    Encargado.GestionarPedidos(productoBebida, proveedorSeleccionado);
                }
                else
                {
                    productoComida = new ProductoComestible(producto, type, cantidadGramos, precioPedido, proveedorPagado);
                    Encargado.GestionarPedidos(productoComida, proveedorSeleccionado);
                }
            }
            if (proveedorSeleccionado != null)
            {
                MessageBox.Show("PEDIDO INGRESADO LPM!");
            }
        }

        private void cbProveedor_SelectedValueChanged(object sender, EventArgs e)
        {
            var proveedor = cbProveedor.SelectedItem as Proveedor;
            if (proveedor != null)
            {
                var dictionarySelected = proveedor.ProductosOfrecidos;
                CargarComboProductos(dictionarySelected);
                cbProducto.SelectedIndex = 0;
            }
        }

        private void CargarComboProductos(List<Dictionary<string, double>> listaProductos)
        {
            cbProducto.Items.Clear();
            foreach (var producto in listaProductos)
            {
                foreach (var nombre in producto)
                {
                    cbProducto.Items.Add(nombre.Key);
                }
            }
        }

        private void cbProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            var producto = cbProducto.SelectedItem as string;
            if (producto != null)
            {
                var proveedor = cbProveedor.SelectedItem as Proveedor;
                if (proveedor != null)
                {
                    var dictionarySelected = proveedor.ProductosOfrecidos;
                    foreach (var productoDic in dictionarySelected)
                    {
                        foreach (var nombre in productoDic)
                        {
                            if (nombre.Key == producto)
                            {
                                txtPrecio.Text = nombre.Value.ToString();
                            }
                        }
                    }
                }
            }
        }


        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int cantidad))
            {
                var precioFinal = cantidad * double.Parse(txtPrecio.Text);
                txtAPagar.Text = precioFinal.ToString();
            }
            else
            {
                txtAPagar.Text = "0";
            }

        }
    }
}
