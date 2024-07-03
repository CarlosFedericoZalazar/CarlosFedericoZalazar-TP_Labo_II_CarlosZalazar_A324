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

namespace AppRestaurante.Panel_Encargado
{
    public partial class FormABMEmpleado : Form
    {
        IEncargado Encargado { get; set; }
        public FormPanelEncargado FormPanelEncargado { get; set; }
        public FormABMEmpleado(FormPanelEncargado formPanelEncargado, IEncargado encargado)
        {
            InitializeComponent();
            FormPanelEncargado = formPanelEncargado;
            Encargado = encargado;
        }

        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            FormAltaEmpleados formAltaEmpleados = new FormAltaEmpleados();
            formAltaEmpleados.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPanelEncargado.Show();
            this.Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            FormBajaEmpleado formBajaEmpleado = new FormBajaEmpleado(Encargado);
            formBajaEmpleado.ShowDialog();
        }
    }
}
