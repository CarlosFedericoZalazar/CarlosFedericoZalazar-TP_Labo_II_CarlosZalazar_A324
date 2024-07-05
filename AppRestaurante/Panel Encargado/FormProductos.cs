using LibraryClassRestaurant.Archivos;
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
using static LibraryClassRestaurant.Mercaderia.Producto;

namespace AppRestaurante.Panel_Encargado
{
    public partial class FormProductos : Form
    {
        public FormABMProveedor FormularioProveedor { get; set; }
        Dictionary<string, List<Proveedor>> dictProveedores = new Dictionary<string, List<Proveedor>>();

        public FormProductos(FormABMProveedor formularioProveedor)
        {
            InitializeComponent();
            FormularioProveedor = formularioProveedor;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            CargarDiccionarioProveedores();

            cbTipoProducto.DataSource = Enum.GetValues(typeof(Producto.TipoProducto));
            //cbTipoProducto.Items.AddRange(Enum.GetNames(typeof(Producto.TipoProducto)));
            cbTipoProducto.SelectedIndex = 0;
            cbTipoProducto.SelectedIndex = 1;
            var type = cbTipoProducto.SelectedItem.ToString();
            if (type != null)
            {
                cbProveedor.DataSource = dictProveedores[type];
                cbProveedor.DisplayMember = "Nombre";
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

        private void cbTipoProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            Producto.TipoProducto type = (Producto.TipoProducto)cbTipoProducto.SelectedItem;

            string tipoString = type.ToString();
            int cantidadRegistros = dictProveedores[tipoString].Count;
            cbProveedor.DataSource = dictProveedores[tipoString];
            foreach (Producto.TipoProducto item in Enum.GetValues(typeof(Producto.TipoProducto)))
            {
                if (type == item)
                {
                    //lblUnidKilos.Text = "Unidades";
                    //gbAlcohol.Enabled = true;
                    break;
                }
                else
                {
                    //lblUnidKilos.Text = "Kilos";
                    //gbAlcohol.Enabled = false;
                    break;
                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> producto = new Dictionary<string, double>();

            var proveedorSeleccionado = (Proveedor)cbProveedor.SelectedItem;
            if (string.IsNullOrEmpty(txtNombreProducto.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string nombreProducto = txtNombreProducto.Text;
            bool precioOk = double.TryParse(txtPrecio.Text, out double precio);
            if (!precioOk || precio < 0)
            {
                MessageBox.Show("Verifique los valores ingresados como Precio. Son Invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            producto.Add(nombreProducto, precio);
            proveedorSeleccionado.ProductosOfrecidos.Add(producto);

            DialogResult result = MessageBox.Show("¿Confirma el ingreso del producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Producto ingresado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Proveedor.Save(proveedorSeleccionado);
            }

            result = MessageBox.Show("¿Desea Cargar otro Producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            {
                cbTipoProducto.SelectedIndex = 1;
                cbTipoProducto.Focus();
                txtNombreProducto.Clear();
                txtPrecio.Clear();
            }
            else
            {
                FormularioProveedor.Show();
                this.Close();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Confirma que desea salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FormularioProveedor.Show();
                this.Close();
            }
        }
    }
}
