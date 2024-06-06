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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppRestoForm.FormsSalon
{
    public partial class FormSalon : Form
    {
        int cantidadMesas;
        List<string> listaMozos;
        public FormSalon(int cantidadMesas, List<string> listaMozos)
        {
            InitializeComponent();
            this.cantidadMesas = cantidadMesas;
            this.listaMozos = listaMozos;
        }

        private void FormSalon_Load(object sender, EventArgs e)
        {
            FillComboBox(cantidadMesas); // Cambia 10 por el número que deseas.
            comboBox1.SelectedIndex = 0;
            comboBox2.DataSource = listaMozos;
            comboBox2.SelectedIndex = 0;
        }

        public void FillComboBox(int number)
        {
            comboBox1.Items.Clear(); // Limpiar los elementos actuales del ComboBox.
            for (int i = 1; i <= number; i++)
            {
                comboBox1.Items.Add(i); // Agregar cada número al ComboBox.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = Serializador.Archivo.ReadJson<Plato>("Menu_Platos").ToList();

            var listaProductos = Serializador.Archivo.ReadJson<ProductoComestible>("ProductoComestible").ToList();
            //DescontarMercaderia(listaProductos, lista);
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            int mesa;
            int.TryParse(comboBox1.SelectedItem.ToString(), out mesa);            
            var mozo = comboBox2.SelectedItem.ToString();
            if (mozo != null) 
            {
                FormMesa formularioMesas = new FormMesa(mesa, mozo); 
                formularioMesas.ShowDialog();
            }

        }
    }
}
