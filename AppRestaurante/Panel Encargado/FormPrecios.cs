using AppRestoForm;
using LibraryClassRestaurant.Atencion;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Menu = LibraryClassRestaurant.Atencion.Menu;


namespace AppRestaurante.Panel_Encargado
{
    public partial class FormPrecios : Form
    {
        public FormPanelEncargado FormPanelEncargado { get; set; }
        public IEncargado Encargado { get; set; }
        public ICocinero Cocinero { get; set; }

        List<Menu> listaMenu = new List<Menu>();

        List<StockBebidas> stockBebidas = StockBebidas.GetStockBebibles();
        public FormPrecios(FormPanelEncargado formPanelEncargado, IEncargado encargado, ICocinero cocinero)
        {
            InitializeComponent();
            FormPanelEncargado = formPanelEncargado;
            Encargado = encargado;
            Cocinero = cocinero;
        }

        private void FormPrecios_Load(object sender, EventArgs e)
        {
            cbTipoProducto.DataSource = Enum.GetValues(typeof(Producto.TipoProducto));

            listaMenu = Cocinero.GetMenu();
            dgMenu.DataSource = Cocinero.GetMenu();
            cbTipoProducto.SelectedIndex = 1;

            if (dgMenu.Rows.Count > 0)
            {
                dgMenu.CurrentCell = dgMenu.Rows[0].Cells[0];
                dgMenu.Rows[0].Selected = true;
            }
        }

        private void btnModificarPrecio_Click(object sender, EventArgs e)
        {
            Producto.TipoProducto tipoProducto = (Producto.TipoProducto)cbTipoProducto.SelectedItem;

            try
            {
                DialogResult result = MessageBox.Show($"¿Confirma el nuevo precio {txtPrecio.Text}?", "Confirmación de Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (tipoProducto == Producto.TipoProducto.Comida)
                    {
                        Menu menu = (Menu)dgMenu.CurrentRow.DataBoundItem;
                        listaMenu = Encargado.ModificarPrecio(menu, Convert.ToDouble(txtPrecio.Text), listaMenu); // HACER LA ECEPCION!
                        CargarDataGridPlatos();
                    }
                    else
                    {
                        var lista = stockBebidas;
                        int cantidad = stockBebidas.Count;
                        var item = (StockBebidas)dgMenu.CurrentRow.DataBoundItem;
                        stockBebidas = Encargado.ModificarPrecio(item, Convert.ToDouble(txtPrecio.Text), stockBebidas); // ERROR!
                        CargarDataGredBebidas();
                    }
                }
                else
                {
                    MessageBox.Show("La modificación del registro ha sido cancelada.", "Modificación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPanelEncargado.Show();
            this.Close();
        }

        private void cbTipoProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            Producto.TipoProducto tipoProducto = (Producto.TipoProducto)cbTipoProducto.SelectedItem;

            if (tipoProducto == Producto.TipoProducto.Bebida)
            {
                CargarDataGredBebidas();

            }
            else
            {
                CargarDataGridPlatos();
            }
        }

        void CargarDataGredBebidas()
        {
            dgMenu.DataSource = null;
            dgMenu.DataSource = stockBebidas;
            dgMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgMenu.Rows.Count > 0)
            {
                dgMenu.CurrentCell = dgMenu.Rows[0].Cells[0];
                dgMenu.Rows[0].Selected = true;
            }
            dgMenu.Columns["Alcoholica"].Visible = false;
            dgMenu.Columns["Proveedor"].Visible = false;

            dgMenu.Columns["Cantidad"].Visible = false;

            dgMenu.Columns["Producto"].DisplayIndex = 0;
            dgMenu.Columns["Precio"].DisplayIndex = 1;

        }


        void CargarDataGridPlatos()
        {
            dgMenu.DataSource = null;
            dgMenu.DataSource = listaMenu;
            dgMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMenu.Columns["Disponibilidad"].Visible = false;
            dgMenu.Columns["MensajeStatus"].Visible = false;
            dgMenu.Columns["Plato"].Visible = false;

            if (dgMenu.Rows.Count > 0)
            {
                dgMenu.CurrentCell = dgMenu.Rows[0].Cells[0];
                dgMenu.Rows[0].Selected = true;
            }

        }

        private void dgMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPrecio.Text = dgMenu.CurrentRow.Cells["Precio"].Value.ToString();
        }

        private void dgMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgMenu.CurrentRow != null && dgMenu.CurrentRow.Cells["Precio"].Value != null && dgMenu.CurrentRow.Cells["Precio"].Visible)
            {
                txtPrecio.Text = dgMenu.CurrentRow.Cells["Precio"].Value.ToString();
            }
            else
            {
                txtPrecio.Text = string.Empty; // O algún valor por defecto
            }
        }
    }
}
