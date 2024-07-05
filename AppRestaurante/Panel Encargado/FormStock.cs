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

namespace AppRestaurante.Panel_Encargado
{
    public partial class FormStock : Form
    {
        List<StockBebidas> stockBebidas = StockBebidas.GetStockBebibles();
        List<StockComestible> stockComestibles = StockComestible.GetStockComestibles();

        public IEncargado Encargado { get; set; }
        public FormStock(IEncargado encargado)
        {
            InitializeComponent();
            Encargado = encargado;
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            cbTipoProducto.DataSource = Enum.GetValues(typeof(Producto.TipoProducto));
            cbTipoProducto.SelectedIndex = 1;
            CargarDataGred();
            Thread mensajeStockThread = new Thread(GenerarMensajesStock);
            mensajeStockThread.Start();
            lblStockBebidas.Text += stockBebidas.Count.ToString();
            lblStockComida.Text += stockComestibles.Count.ToString();
            dgStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgStock.Columns["Producto"].DisplayIndex = 0;
            dgStock.Columns["Cantidad"].DisplayIndex = 1;            
        }
        private void CargarDataGred()
        {            
            dgStock.AutoGenerateColumns = false;
        }
        private void GenerarMensajesStock()
        {
            bool stockBajo = false;
            StringBuilder mensaje = new StringBuilder();
            mensaje.Append("Stock bajo: ");
            foreach (StockComestible stock in stockComestibles)
            {
                if (stock.Cantidad < 10)
                {
                    stockBajo = true;
                    mensaje.Append($"Stock de {stock.Producto} bajo. Quedan {stock.Cantidad} unidades.");
                }
            }
            foreach (StockBebidas stock in stockBebidas)
            {
                if (stock.Cantidad < 10)
                {
                    stockBajo = true;
                    mensaje.Append($"Stock de {stock.Producto} bajo. Quedan {stock.Cantidad} unidades.");
                }
            }
            if(stockBajo)
            {
                Thread.Sleep(3000);
                MessageBox.Show(mensaje.ToString());
            }
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

