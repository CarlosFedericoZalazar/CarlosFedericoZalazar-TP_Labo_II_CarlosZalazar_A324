using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Interfaces;
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
    public partial class FormConsultaPlato : Form
    {
        public ICocinero Cocinero { get; set; }
        public FormCocina FormCocina { get; set; }
        public FormConsultaPlato(ICocinero cocinero, FormCocina formCocina)
        {
            InitializeComponent();
            Cocinero = cocinero;
            FormCocina = formCocina;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var listaPlatos = Cocinero.BusquedaMenuPorIngrediente(txtBusqueda.Text.ToUpper());
            BindingList<Menu> bindingList = new BindingList<Menu>(listaPlatos);
            
            if(bindingList.Count > 0)
            {
                lbPlatos.DataSource = bindingList;
                lbPlatos.DisplayMember = "Nombre";
                return;
            }
            MessageBox.Show("No se encontraron coincidencias.", "Resultado de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbPlatos.DataSource = null;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormCocina.Show();
            this.Close();
        }
    }
}
