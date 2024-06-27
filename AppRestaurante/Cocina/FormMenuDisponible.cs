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
    public partial class FormMenuDisponible : Form
    {
        FormCocina FormCocina { get; set; }
        public ICocinero Cocinero { get; set; }
        public FormMenuDisponible(FormCocina formCocina, ICocinero cocinero)
        {
            InitializeComponent();
            FormCocina = formCocina;
            Cocinero = cocinero;
        }

        private void FormMenuDisponible_Load(object sender, EventArgs e)
        {
            var listaMenuDisponible = Cocinero.GetMenuDisponible();
            lbMenu.DataSource = listaMenuDisponible;
            lbMenu.DisplayMember = "Nombre";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormCocina.Show();
            this.Close();
        }
    }
}
