using RestoApp.Clases;
using RestoApp.Files;
using RestoApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestoForm
{
    public partial class FormStockDisponible : Form
    {
        public FormStockDisponible()
        {
            InitializeComponent();
        }

        private void FormStockDisponible_Load(object sender, EventArgs e)
        {
            dgStock.DataSource = Serializador.Archivo.ReadJson<Pedido>("pedido");
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Producto.Tipo)));
            comboBox1.SelectedIndex = 1;

            //dgStock.DataSource = 
        }
    }
}
