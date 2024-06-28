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

namespace AppRestaurante.Panel_Encargado
{
    public partial class FormStock : Form
    {
        List<StockBebidas> stockBebidas = StockBebidas.GetStockBebibles();
        List<StockComestible> stockComestibles = StockComestible.GetStockComestibles();

        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            // Configuración inicial del formulario y carga de datos
            cbTipoProducto.DataSource = Enum.GetValues(typeof(Producto.TipoProducto));
            CargarDataGred();
            lblStockBebidas.Text += stockBebidas.Count.ToString();
            lblStockComida.Text += stockComestibles.Count.ToString();
            dgStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgStock.Columns["Alcoholica"].Visible = false;
            dgStock.Columns["Proveedor"].Visible = false;

            dgStock.Columns["Precio"].Visible = false; // ver aca
            dgStock.Columns["Producto"].DisplayIndex = 0;
            dgStock.Columns["Cantidad"].DisplayIndex = 1;
            
        }

        private void CargarDataGred()
        {            
            dgStock.AutoGenerateColumns = false;
        }

        private void cbTipoStock_SelectedValueChanged(object sender, EventArgs e)
        {
            Producto.TipoProducto tipoProducto = (Producto.TipoProducto)cbTipoProducto.SelectedItem;

            if (tipoProducto == Producto.TipoProducto.Bebida)
            {
                dgStock.DataSource = stockBebidas;
            }
            else
            {
                dgStock.DataSource = stockComestibles;
            }
        }

        private void DgStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Formatear la columna "Cantidad" del DataGridView
            if (dgStock.Columns[e.ColumnIndex].Name == "Cantidad" && e.Value != null)
            {
                double cantidad = (double)e.Value;
                string formattedValue = cantidad.ToString("0.###"); // Formato con tres decimales máximo

                // Asignar el valor formateado de vuelta a la celda
                e.Value = formattedValue;
                e.FormattingApplied = true;
            }
        }
    }
}

