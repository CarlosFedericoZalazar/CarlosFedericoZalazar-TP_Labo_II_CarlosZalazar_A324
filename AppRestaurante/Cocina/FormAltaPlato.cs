using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AppRestaurante.ValidateForms.Validate;
using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Interfaces;

namespace AppRestaurante.Cocina
{
    public partial class FormAltaPlato : Form
    {
        FormCocina FormABMCartaRestaurant { get; set; }
        Dictionary<string, double> dictIngredientes = new Dictionary<string, double>();
        public ICocinero Cocinero { get; set; }
        public FormAltaPlato(FormCocina formABMCartaRestaurant, ICocinero cocinero)
        {
            InitializeComponent();
            FormABMCartaRestaurant = formABMCartaRestaurant;
            Cocinero = cocinero;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormABMCartaRestaurant.Show();
            this.Close();
        }

        private void btnAddIngrediente_Click(object sender, EventArgs e)
        {
            if (!ValidateForms.Validate.VerificarTextBoxesLlenos(this))
            {
                return;
            }

            double.TryParse(txtCantidad.Text, out double cantidad);
            string ingrediente = txtIngrediente.Text;

            string titulo = "Confirmación de Ingreso";
            string mensaje = $"¿Agregar {ingrediente}, cantidad {cantidad}?";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show($"Ingrediente {txtIngrediente.Text} ingresado con exito!");
                lblListaIngredientes.Text += $"* {ingrediente} / {cantidad}g \n";
                
                dictIngredientes.Add(ingrediente, cantidad);
            }


        }

        private void txtNombrePlato_Leave(object sender, EventArgs e)
        {
            this.Text = txtNombrePlato.Text;
        }

        private void FormAltaPlato_Load(object sender, EventArgs e)
        {
            txtNombrePlato.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidateForms.Validate.VerificarTextBoxesLlenos(this))
            {
                return;
            }

            var nombre = txtNombrePlato.Text;
            var tiempoPreparacion = int.Parse(textBox1.Text);
            var cantidadIngredientes = dictIngredientes;

            Plato plato = new Plato(nombre, cantidadIngredientes, cantidadIngredientes, tiempoPreparacion);
            Cocinero.AgregarPlato(plato);
        }

    }
}
