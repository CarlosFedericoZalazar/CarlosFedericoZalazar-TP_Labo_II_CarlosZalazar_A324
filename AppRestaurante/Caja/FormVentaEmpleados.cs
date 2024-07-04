using LibraryClassRestaurant.Atencion;
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

namespace AppRestaurante.Caja
{
    public partial class FormVentaEmpleados : Form
    {
        int cantidadMostrarTop = 3;
        public IEncargado EncargadoTurno { get; set; }
        public FormCaja FormCaja { get; set; }
        List<Cuenta> listaTickets = Encargado.GetTickets();
        public FormVentaEmpleados(FormCaja formCaja, IEncargado encargado)
        {
            InitializeComponent();
            FormCaja = formCaja;
            EncargadoTurno = encargado;
        }

        private void FormVentaEmpleados_Load(object sender, EventArgs e)
        {
            int contador = 0;

            dgVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var empleadosOrdenados = EncargadoTurno.Caja.TopVentasEmpleados(listaTickets);
            // Agregar las columnas manualmente
            dgVentas.Columns.Add("Nombre", "Nombre");
            dgVentas.Columns.Add("CantidadVentas", "Cantidad Ventas");
            dgVentas.Columns.Add("Perfil", "Perfil");
            foreach (var item in empleadosOrdenados)
            {
                if (contador == cantidadMostrarTop)
                {
                    break;
                }
                var funcionEmpleado = Empleado.GetPerfil(item.Key);
                dgVentas.Rows.Add(item.Key, item.Value, funcionEmpleado);
            }
            foreach (DataGridViewColumn column in this.dgVentas.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormCaja.Show();
            this.Close();
        }
    }
}
