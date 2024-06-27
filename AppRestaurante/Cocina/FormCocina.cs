using AppRestoForm;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppRestaurante.Cocina
{
    public partial class FormCocina : Form
    {
        FormPrincipal FormPrincipal { get; set; }
        public ICocinero Cocinero { get; set; }
        public FormCocina(FormPrincipal formPrincipal, ICocinero cocinero)
        {
            InitializeComponent();
            FormPrincipal = formPrincipal;
            Cocinero = cocinero;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormPrincipal.Show();
            this.Close();
        }

        private void btnAddPlato_Click(object sender, EventArgs e)
        {
            FormAltaPlato formAltaPlato = new FormAltaPlato(this, Cocinero);
            formAltaPlato.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBajaPlato formBajaPlato = new FormBajaPlato(this);
            formBajaPlato.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormModificarPlato formModificarPlato = new FormModificarPlato();
            formModificarPlato.Show();

        }

        private void btnConsultaMenu_Click(object sender, EventArgs e)
        {
            FormConsultaPlato formConsultaPlato = new FormConsultaPlato(Cocinero, this);
            formConsultaPlato.Show();
            this.Hide();
        }
    }
}
