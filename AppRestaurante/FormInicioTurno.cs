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

namespace AppRestaurante
{
    public partial class FormInicioTurno : Form
    {
        List<Mesero> listaMeseros = new List<Mesero>();
        List<Delivery> listaDelivery = new List<Delivery>();
        List<Cocinero> listaCocineros = new List<Cocinero>();
        List<Encargado> listaEncargados = new List<Encargado>();
        List<Empleado> listaEmpleados = Encargado.ObtenerEmpleados();

        List<Mesero> listaMesetosTurno = new List<Mesero>();
        List<Delivery> listaDeliveryTurno = new List<Delivery>();
        List<Cocinero> listaCocinerosTurno = new List<Cocinero>();
        Encargado EncargadoTurno = new Encargado();

        public FormInicioTurno()
        {
            InitializeComponent();
            CargarListas();
            cargarComboBoxes();
        }

        private void CargarListas()
        {
            listaMeseros = Empleado.CargarEmpleados<Mesero>(Empleado.Perfil.Mesero);
            listaDelivery = Empleado.CargarEmpleados<Delivery>(Empleado.Perfil.Delivery);
            listaCocineros = Empleado.CargarEmpleados<Cocinero>(Empleado.Perfil.Cocinero);
            listaEncargados = Empleado.CargarEmpleados<Encargado>(Empleado.Perfil.Encargado);
        }
        private void cargarComboBoxes()
        {
            cbEncargado.DataSource = listaEncargados;
            cbEncargado.DisplayMember = "Nombre";
            cbEncargado.SelectedIndex = 0;

            cbCocineros.DataSource = listaCocineros;
            cbCocineros.DisplayMember = "Nombre";
            cbCocineros.SelectedIndex = 0;

            cbMeseros.DataSource = listaMeseros;
            cbMeseros.DisplayMember = "Nombre";
            cbMeseros.SelectedIndex = 0;

            cbDeliverys.DataSource = listaDelivery;
            cbDeliverys.DisplayMember = "Nombre";
            cbDeliverys.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var encargado = (Encargado)cbEncargado.SelectedItem;
            EncargadoTurno = encargado;
            lbEnc.Text = encargado.Nombre;
        }
    }
}
