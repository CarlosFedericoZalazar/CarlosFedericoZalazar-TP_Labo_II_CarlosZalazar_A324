using LibraryClassRestaurant.Empleados;
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

namespace AppRestaurante.Panel_Encargado
{
    public partial class FormBajaEmpleado : Form
    {
        IEncargado Encargado { get; set; }
        List<Mesero> listaMeseros = new List<Mesero>();
        List<Delivery> listaDelivery = new List<Delivery>();
        List<Cocinero> listaCocineros = new List<Cocinero>();
        List<Encargado> listaEncargados = new List<Encargado>();
        public FormBajaEmpleado(IEncargado encargado)
        {
            InitializeComponent();
            CargarListas();
            cbEmplados.DataSource = Enum.GetValues(typeof(Empleado.Perfil));
            cbEmplados.SelectedIndex = 0;
            Encargado = encargado;
        }

        private void CargarListas()
        {
            listaMeseros = Empleado.CargarEmpleados<Mesero>(Empleado.Perfil.Mesero);
            listaDelivery = Empleado.CargarEmpleados<Delivery>(Empleado.Perfil.Delivery);
            listaCocineros = Empleado.CargarEmpleados<Cocinero>(Empleado.Perfil.Cocinero);
            listaEncargados = Empleado.CargarEmpleados<Encargado>(Empleado.Perfil.Encargado);
        }

        private void cbEmplados_SelectedValueChanged(object sender, EventArgs e)
        {
            var perfil = (Empleado.Perfil)cbEmplados.SelectedItem;
            if (cbEmplados.SelectedItem is Empleado.Perfil)
            {
                switch (perfil)
                {
                    case Empleado.Perfil.Mesero:
                        cbEmpleados.DataSource = listaMeseros;
                        break;
                    case Empleado.Perfil.Delivery:
                        cbEmpleados.DataSource = listaDelivery;
                        break;
                    case Empleado.Perfil.Cocinero:
                        cbEmpleados.DataSource = listaCocineros;
                        break;
                    case Empleado.Perfil.Encargado:
                        cbEmpleados.DataSource = listaEncargados;
                        break;
                    default:
                        cbEmpleados.DataSource = null;
                        break;
                }
                cbEmpleados.DisplayMember = "Nombre";
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            var empleado = (Empleado)cbEmpleados.SelectedItem;

            DialogResult result = MessageBox.Show($"¿Deseas eliminar a {empleado.NombreCompleto}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Encargado.EliminarEmpleado(empleado);
                CargarListas();
                cbEmplados.SelectedIndex = 0;

                result = MessageBox.Show($"¿Deseas eliminar mas empleados", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
