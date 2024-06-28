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
            cbTipo.SelectedIndex = 0;
            var type = cbTipo.SelectedItem.ToString();
            if (type != null)
            {
                cbProveedor.DataSource = dictProveedores[type];
                cbProveedor.DisplayMember = "Nombre";
            }
            rbNo.Checked = true;
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

        // LA LOGICA DEL PAGO DE PROVEEDOR LA VAMOS A SACAR DE ACA


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
            bool alcohol = rbSi.Checked == true ? true : false;
            if ( (intCantidadOk || doublePrecioOk) || (intCantidadGramosOk || doublePrecioOk))
                precioPedido = cantidad * precio;
            else
                return;

            var respuesta = MessageBox.Show($"¿Confirma ingreso de registro?\n", "Confirmación", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Producto.TipoProducto type = (Producto.TipoProducto)cbTipo.SelectedItem;

                Proveedor proveedorPagado = Encargado.PagarProveedor(precioPedido, proveedorSeleccionado);
                
                if (type == TipoProducto.Bebida)
                {
                    productoBebida = new Bebida(txtProducto.Text, type, cantidad, alcohol, precioPedido, proveedorPagado);
                    Encargado.GestionarPedidos(productoBebida, proveedorSeleccionado);
                }
                else
                {
                    productoComida = new ProductoComestible(txtProducto.Text, type, cantidadGramos, precioPedido, proveedorPagado);
                    Encargado.GestionarPedidos(productoComida, proveedorSeleccionado);
                }
            }
            if (proveedorSeleccionado != null)
            {
                MessageBox.Show("PEDIDO INGRESADO LPM!");
            }            
        } 




    }
}
