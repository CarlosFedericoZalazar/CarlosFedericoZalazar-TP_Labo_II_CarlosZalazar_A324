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
        Cocinero cocinero = new Cocinero("Carlos", "Gonzalez", "Roca 33", "",0, 230000, Empleado.Perfil.Cocinero);

        private BindingList<Menu> bindingList;

        FormCocina FormCocina { get; set; }
        public FormBajaPlato(FormCocina formCocina)
        {
            InitializeComponent();
            FormCocina = formCocina;
        }
        private void FormBajaPlato_Load(object sender, EventArgs e)
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

        private void btnBajaPlato_Click(object sender, EventArgs e)
        {
            var item = lbPlatos.SelectedItem as Menu;

            if (item != null)
            {
                cocinero.QuitarPlato(item);
                bindingList.Remove(item);
            }
        }

        private void btnCocina_Click(object sender, EventArgs e)
        {
            FormCocina.Show();
            this.Close();
        }
    }
}
