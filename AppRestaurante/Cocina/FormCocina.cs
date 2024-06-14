﻿using AppRestoForm;
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

        private void FormABMCartaRestaurant_Load(object sender, EventArgs e)
        {

        }
    }
}
