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
        List<Bebida>ListaBebidas= new List<Bebida>();
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
            dgMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMenu.Columns["Disponibilidad"].Visible = false;
            dgMenu.Columns["MensajeStatus"].Visible = false;
            dgMenu.Columns["Plato"].Visible = false;
        }

        private void dgMenu_SelectionChanged(object sender, EventArgs e)
        {

            txtPrecio.Text = dgMenu.CurrentRow.Cells["Precio"].Value.ToString();

        }

        public void Prueba(List<Menu> prueba) { }

        private void button1_Click(object sender, EventArgs e)
        {
            listaMenu[0].Precio = Convert.ToDouble(txtPrecio.Text);
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dgMenu.DataSource = null;
            dgMenu.DataSource = listaMenu;
            dgMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMenu.Columns["Disponibilidad"].Visible = false;
            dgMenu.Columns["MensajeStatus"].Visible = false;
            dgMenu.Columns["Plato"].Visible = false;
        }

        private void btnModificarPrecio_Click(object sender, EventArgs e)
        {
            Menu item = (Menu)dgMenu.CurrentRow.DataBoundItem;
            try
            {
                DialogResult result = MessageBox.Show($"¿Confirma el nuevo precio {txtPrecio.Text}?", "Confirmación de Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    listaMenu = Encargado.ModificarPrecio(item, Convert.ToDouble(txtPrecio.Text), listaMenu); // HACER LA ECEPCION!
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

            ActualizarDataGrid();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPanelEncargado.Show();
            this.Close();
        }

        private void cbTipoProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            //Producto.TipoProducto tipoProducto = (Producto.TipoProducto)cbTipoStock.SelectedItem;

            //if (tipoProducto == Producto.TipoProducto.Bebida)
            //{

            //}
            //else
            //{
            //    dgMenu.DataSource = null;
            //    dgMenu.DataSource = listaMenu;
            //}
        }
    }
}
