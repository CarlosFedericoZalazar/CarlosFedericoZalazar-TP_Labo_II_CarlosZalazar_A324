using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Empleados;
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

namespace AppRestaurante.Cocina
{
    public partial class FormModificarPlato : Form
    {
        Cocinero cocinero = new Cocinero("Carlos", "Gonzalez", "Roca 33", "",0, 230000, Empleado.Perfil.Cocinero);

        private BindingList<Menu> bindingList;

        public FormModificarPlato()
        {
            InitializeComponent();
        }

        private void FormModificarPlato_Load(object sender, EventArgs e)
        {
            CargarListBox();
            if (bindingList.Count > 0)
            {
                lbPlatos.SelectedIndex = 0;
            }
        }
        private void CargarListBox()
        {

            var listaMenu = cocinero.GetMenu();
            int cantidad = listaMenu.Count;

            bindingList = new BindingList<Menu>(listaMenu);

            lbPlatos.DataSource = bindingList;
            lbPlatos.DisplayMember = "Nombre";
        }

        private void lbPlatos_SelectedValueChanged_1(object sender, EventArgs e)
        {
            var item = lbPlatos.SelectedItem as Menu;

            var seleccionPlato = item.Plato.CantidadDeIngredientes;

            cbIngredientes.DataSource = new BindingSource(seleccionPlato, null);
            cbIngredientes.DisplayMember = "Key";
            cbIngredientes.ValueMember = "Value";

            CargarIngredientesTextBoxes();

        }
        private void CargarIngredientesTextBoxes()
        {
            if (cbIngredientes.SelectedItem != null)
            {
                KeyValuePair<string, double> selectedPair = (KeyValuePair<string, double>)cbIngredientes.SelectedItem;

                string clave = selectedPair.Key;
                double valor = selectedPair.Value;

                txtIngrediente.Text = clave;
                txtCantidad.Text = valor.ToString();
            }

        }

        private void cbIngredientes_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarIngredientesTextBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var menuSeleccionado = lbPlatos.SelectedItem as Menu;

            DialogResult result = MessageBox.Show("¿Desea confirmar la modificación de los registros?", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if(string.IsNullOrEmpty(txtIngrediente.Text) || string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("Debe seleccionar un ingrediente y una cantidad para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (menuSeleccionado != null) 
                {
                    int indice = bindingList.IndexOf(menuSeleccionado);

                    bool numeroOk = double.TryParse(txtCantidad.Text, out double cantidad);
                    if(!numeroOk || cantidad < 0)
                    {
                        MessageBox.Show("La cantidad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCantidad.Focus();
                        txtCantidad.SelectAll();
                        return;
                    }
                    menuSeleccionado.Plato.CantidadDeIngredientes[txtIngrediente.Text] = cantidad;
                    bindingList[indice] = menuSeleccionado;
                    List<Menu> listaPlatos = new List<Menu>(bindingList);
                    cocinero.ModificarPlato(listaPlatos);
                }
                
                // Código para confirmar la modificación de los registros
                // Aquí puedes colocar la lógica para modificar los registros
                MessageBox.Show("Modificación confirmada.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Código para cancelar la modificación de los registros o cualquier otra acción
                MessageBox.Show("Modificación cancelada.", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
