using AppRestoForm;
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
        FormPanelEncargado _formPanelEncargado;
        public FormABMEmpleado(FormPanelEncargado formPanelEncargado)
        {
            InitializeComponent();
            _formPanelEncargado = formPanelEncargado;
        }

        private void btnAltaEmpleado_Click(object sender, EventArgs e)
        {
            FormAltaEmpleados formAltaEmpleados = new FormAltaEmpleados();
            formAltaEmpleados.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _formPanelEncargado.Show();
            this.Close();
        }
    }
}
