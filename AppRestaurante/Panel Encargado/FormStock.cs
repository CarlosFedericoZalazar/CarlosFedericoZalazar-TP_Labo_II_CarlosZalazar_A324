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
using static LibraryClassRestaurant.Empleados.Empleado;

namespace AppRestaurante.Panel_Encargado
{
    public partial class FormStock : Form
    {
        List<StockBebidas>stockBebidas = StockBebidas.GetStockBebibles();
        List<StockComestible> stockComestibles = StockComestible.GetStockComestibles();
        public FormStock()
        {
            InitializeComponent();
        }


        private void FormStock_Load(object sender, EventArgs e)
        {
            cbTipoStock.DataSource = Enum.GetValues(typeof(Producto.TipoProducto));
            CargarDataGred();
            //AjustarAnchoDataGred();
            lblStockBebidas.Text += stockBebidas.Count.ToString();
            lblStockComida.Text += stockComestibles.Count.ToString();
            dgStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStock.Columns["Alcoholica"].Visible = false;
            dgStock.Columns["Proveedor"].Visible = false;

            dgStock.Columns["Producto"].DisplayIndex = 0;
            dgStock.Columns["Cantidad"].DisplayIndex = 1;

        }

        void CargarDataGred()
        {
            dgStock.AutoGenerateColumns = false;
        }

        private void cbTipoStock_SelectedValueChanged(object sender, EventArgs e)
        {
            Producto.TipoProducto tipoProducto = (Producto.TipoProducto)cbTipoStock.SelectedItem;

            if (tipoProducto == Producto.TipoProducto.Bebida)
            {
                dgStock.DataSource = stockBebidas;
                lblCantidad.Text = "CANTIDAD (Unidades) ";
            }
            else
            {
                dgStock.DataSource = stockComestibles;
                lblCantidad.Text = "CANTIDAD (Kilogramos) ";
            }
        }

        public void AjustarAnchoDataGred()
        {
            int totalWidth = dgStock.RowHeadersWidth;

            foreach (DataGridViewColumn column in dgStock.Columns)
            {
                totalWidth += column.Width;
            }

            // Establecer el ancho del control al totalWidth calculado
            dgStock.Width = totalWidth;
        }
    }
}
