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
    using LibraryClassRestaurant.Atencion;
    public partial class FormCaja : Form
    {
        public FormCaja()
        {
            InitializeComponent();
        }

        private void FormCaja_Load(object sender, EventArgs e)
        {
            var caja = Caja.ObtenerDineroCaja();
            txtDineroCaja.Text = caja.Dinero.ToString();
        }

    }
}
