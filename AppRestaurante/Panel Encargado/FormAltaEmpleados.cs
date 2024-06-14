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
using LibraryClassRestaurant.Empleados;
using static LibraryClassRestaurant.Empleados.Empleado;
using static AppRestaurante.ValidateForms.Validate;
using AppRestaurante.ValidateForms;
using LibraryClassRestaurant.Archivos;
using LibraryClassRestaurant.Interfaces;

namespace AppRestaurante.Panel_Encargado
{
    public partial class FormAltaEmpleados : Form
    {
        IEncargado encargado = new Encargado(); // recibir por parametro
        public FormAltaEmpleados()
        {
            InitializeComponent();
        }

        private void FormGestionEmpleados_Load(object sender, EventArgs e)
        {
            var valoresEnum = Enum.GetValues(typeof(Perfil)).Cast<Perfil>().ToList();
            cbPerfilEmpleado.DataSource = valoresEnum;

            cbPerfilEmpleado.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado.Perfil perfilEmpleado = (Empleado.Perfil)cbPerfilEmpleado.SelectedItem;

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            if (!double.TryParse(txtSueldo.Text, out double sueldo))
            {
                MessageBox.Show("El sueldo debe ser un número");
                return;
            }
            Empleado empleado = FabricaEmpleado.CrearEmpleado(perfilEmpleado, nombre, apellido, direccion, telefono, sueldo);


            bool TextsBoxOk = VerificarTextBoxesLlenos(this);
            if (TextsBoxOk)
            {
                encargado.AgregarEmpleado(empleado);
                MessageBox.Show("Empleado creado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
    }

}
}
