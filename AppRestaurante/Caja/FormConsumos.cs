using LibraryClassRestaurant.Atencion;
using LibraryClassRestaurant.Empleados;
using LibraryClassRestaurant.Interfaces;
using LibraryClassRestaurant.Mercaderia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestaurante.Caja
{
    public partial class FormConsumos : Form
    {
        public IEncargado EncargadoTurno { get; set; }
        public FormCaja FormCaja { get; set; }
        List<Cuenta> listaTickets = Encargado.GetTickets();
        List<Cuenta> listaFiltrada = new List<Cuenta>();

        public FormConsumos(FormCaja formCaja, IEncargado encargado)
        {
            InitializeComponent();
            FormCaja = formCaja;
            EncargadoTurno = encargado;
        }
        private void FormConsumos_Load(object sender, EventArgs e)
        {
            // Inicializar cbMedioPago primero
            var medioPagos = Enum.GetNames(typeof(Cuenta.MedioPago)).ToList();
            medioPagos.Insert(0, "TODOS");
            cbMedioPago.DataSource = medioPagos;
            cbMedioPago.SelectedIndex = 0;

            // Luego inicializar cbEmpleados
            var perfiles = new List<string> { "TODOS", "Mesero", "Delivery" };
            cbEmpleados.DataSource = perfiles;
            cbEmpleados.SelectedIndex = 0;

            // Resto del código
            int cantidadTickets = listaTickets.Count;
            dgTickets.DataSource = listaTickets;

            dgTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgTickets.Columns["Cobrado"].Visible = false;
            dgTickets.Columns["Levantado"].Visible = false;
            dgTickets.Columns["Nombre"].DisplayIndex = 1;
            dgTickets.Columns["Monto"].DisplayIndex = 2;

            foreach (DataGridViewColumn column in this.dgTickets.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void cbEmpleados_SelectedValueChanged(object sender, EventArgs e)
        {
            var perfil = cbEmpleados.SelectedItem.ToString();

            if (perfil != null)
            {
                if (perfil == "TODOS")
                {
                    dgTickets.DataSource = listaTickets;
                    return;
                }
                else
                {
                    listaFiltrada = EncargadoTurno.Caja.ConsumoPorEmpleados(listaTickets, perfil);
                    dgTickets.DataSource = listaFiltrada;
                }
            }
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            var medioPago = cbMedioPago.SelectedItem.ToString();

            if (medioPago != null)
            {
                if (medioPago == "TODOS")
                {
                    dgTickets.DataSource = listaTickets;
                    return;
                }
                else
                {
                    var listaFiltradaMedioPago = EncargadoTurno.Caja.ConsumoPorMedioPago(listaFiltrada, medioPago);
                    dgTickets.DataSource = listaFiltradaMedioPago;
                }
            }
        }

        private void cbMedioPago_SelectedValueChanged(object sender, EventArgs e)
        {
            var medioPago = cbMedioPago.SelectedItem.ToString();

            if (medioPago != null)
            {
                if (medioPago == "TODOS")
                {
                    dgTickets.DataSource = listaTickets;
                    return;
                }
                else
                {
                    var listaFiltradaMedioPago = EncargadoTurno.Caja.ConsumoPorMedioPago(listaFiltrada, medioPago);
                    dgTickets.DataSource = listaFiltradaMedioPago;
                }
            }
        }
    }
}
