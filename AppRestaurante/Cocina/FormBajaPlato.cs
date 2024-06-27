using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Empleados;
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
    public partial class FormBajaPlato : Form
    {
        Cocinero cocinero = new Cocinero("Carlos", "Gonzalez", "Roca 33", "", 230000, Empleado.Perfil.Cocinero);
        
        private BindingList<Menu> bindingList;
        public FormBajaPlato()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var listaMenu = cocinero.GetMenu(); // lista<Menu>
            int cantidad = listaMenu.Count;
            // Inicializar el BindingList con los elementos de la lista original
            bindingList = new BindingList<Menu>(listaMenu);

            // Asignar el BindingList al DataSource de un control, por ejemplo, un DataGridView
            lbPlatos.DataSource = bindingList;
            lbPlatos.DisplayMember = "Nombre";

        }

        private void btnBajaPlato_Click(object sender, EventArgs e)
        {
            var item = lbPlatos.SelectedItem as Menu;

            if (item != null)
            {
                cocinero.QuitarPlato(item);               
                bindingList.Remove(item);
            }
        }
    }
}
