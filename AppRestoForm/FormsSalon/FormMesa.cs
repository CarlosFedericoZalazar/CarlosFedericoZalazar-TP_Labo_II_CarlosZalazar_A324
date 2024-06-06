using RestoApp.Clases;
using RestoApp.ClasesSalon;
using RestoApp.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestoForm.FormsSalon
{
    public partial class FormMesa : Form
    {
        private int _numeroMesa;
        private string _nombreMozo;
        private Cocinero _cocinero;
        public FormMesa(int numeroMesa, string mozo)
        {
            InitializeComponent();
            _numeroMesa = numeroMesa;
            _nombreMozo = mozo;
            //_cocinero = cocinero;

        }

        private void FormMesa_Load(object sender, EventArgs e)
        {
            this.Text = $"MESA: {_numeroMesa} A/C {_nombreMozo}";
            comboBox1.DataSource = Serializador.Archivo.ReadJson<Plato>("Menu_Platos");
            comboBox1.DisplayMember = "NombrePlato";

            List<ProductoBebible> listaBebidas = new List<ProductoBebible>();
            listaBebidas = Serializador.Archivo.ReadJson<ProductoBebible>("ProductoBebible").ToList();
            CargarListaBebidas(listaBebidas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Plato platoString)
            {
                label1.Text += $"* {platoString.NombrePlato}\n";
            }
        }

        private void CargarListaBebidas(List<ProductoBebible> lista)
        {
            List<ProductoBebible> listaAlcohol = new List<ProductoBebible>();
            List<ProductoBebible> listaSinAlcohol = new List<ProductoBebible>();

            foreach (var item in lista)
            {
                if (item.Alcoholica)
                {
                    listaAlcohol.Add(item);
                }
                else
                {
                    listaSinAlcohol.Add(item);
                }
            }
            comboBox2.DataSource = listaSinAlcohol;
            comboBox3.DataSource = listaAlcohol;

            comboBox2.DisplayMember = "Nombre";
            comboBox3.DisplayMember = "Nombre";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Pedido> lista = Serializador.Archivo.ReadJson<Pedido>("pedido").ToList();
            int a = lista.Count;
        }
    }
}
