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
        List<Mesero> listaMesetosTurno = new List<Mesero>();
        List<Delivery> listaDeliveryTurno = new List<Delivery>();
        List<Cocinero> listaCocineroTurno = new List<Cocinero>();

        List<Empleado> listaEmpleados = Encargado.ObtenerEmpleados();

        public FormInicioTurno()
        {
            InitializeComponent();
            CargarMeseros();
            CargarDelivery();
            CargarCocinero();
            CargarComboBoxes();
        }

        void CargarMeseros()
        {
            foreach (var item in listaEmpleados)
            {
                if (item.Profile == Empleado.Perfil.Mesero)
                {
                    var mesero = FabricaEmpleado.CrearEmpleado(item.Profile, item.Nombre, item.Apellido, item.Direccion, item.Telefono, item.SueldoBolsillo, item.Sueldo);
                    listaMesetosTurno.Add((Mesero)mesero);
                }
            }
        }

        void CargarDelivery()
        {
            foreach (var item in listaEmpleados)
            {
                if (item.Profile == Empleado.Perfil.Delivery)
                {
                    var delivery = FabricaEmpleado.CrearEmpleado(item.Profile, item.Nombre, item.Apellido, item.Direccion, item.Telefono, 0, item.Sueldo);
                    listaDeliveryTurno.Add((Delivery)delivery);
                }
            }
        }

        void CargarCocinero()
        {
            foreach (var item in listaEmpleados)
            {
                if (item.Profile == Empleado.Perfil.Cocinero)
                {
                    var cocinero = FabricaEmpleado.CrearEmpleado(item.Profile, item.Nombre, item.Apellido, item.Direccion, item.Telefono, 0, item.Sueldo);
                    listaCocineroTurno.Add((Cocinero)cocinero);
                }
            }
        }

        void CargarComboBoxes()
        {
            cbMeseros.DataSource = listaMesetosTurno;
            cbMeseros.DisplayMember = "Nombre";

            cbDeliverys.DataSource = listaDeliveryTurno;
            cbDeliverys.DisplayMember = "Nombre";

            cbCocineros.DataSource = listaCocineroTurno;
            cbCocineros.DisplayMember = "Nombre";

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
