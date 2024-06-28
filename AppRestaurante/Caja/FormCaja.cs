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
    using LibraryClassRestaurant.Interfaces;

    public partial class FormCaja : Form
    {
        public IEncargado Encargado { get; set; }
        public FormCaja(IEncargado encargado)
        {
            InitializeComponent();
            Encargado = encargado;
        }

        private void FormCaja_Load(object sender, EventArgs e)
        {
            var caja = Encargado.Caja;
            txtDineroCaja.Text = caja.Dinero.ToString();
        }

    }
}
