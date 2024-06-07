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
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Producto.Tipo)));
            comboBox1.SelectedIndex = 1;

            CargarData();
        }


        private void CargarData() 
        {
            var tipo = comboBox1.SelectedItem.ToString();            

            // Asume que tienes un DataGridView llamado dataGridView en tu formulario
            dgStock.AutoGenerateColumns = false; // No generar columnas automáticamente

            // Crear la columna para Nombre
            DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
            nombreColumn.DataPropertyName = "NombreProducto"; // Propiedad de la clase Persona
            nombreColumn.HeaderText = "Producto";
            dgStock.Columns.Add(nombreColumn); // Añadir la columna al DataGridView

            // Crear la columna para Edad
            DataGridViewTextBoxColumn cantidadColumn = new DataGridViewTextBoxColumn();
            cantidadColumn.DataPropertyName = "CantidadProducto"; // Propiedad de la clase Persona
            cantidadColumn.HeaderText = "Cantidad";
            dgStock.Columns.Add(cantidadColumn); // Añadir la columna al DataGridView

            // Asignar la lista de personas como el origen de datos del DataGridView
            dgStock.DataSource = Stock.ReadStock();
            AjustarAltoDataGred();
            AjustarAnchoDataGred();

            // Inhabilitar que el usuario modifique el tamaño de las columnas y filas
            dgStock.AllowUserToResizeColumns = false;
            dgStock.AllowUserToResizeRows = false;

            //dgStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //// Ajustar el ancho del DataGridView para que se ajuste al contenido de las columnas
            //dgStock.AutoSize = true;
        }

        public void AjustarAltoDataGred()
        {
            int totalHeight = dgStock.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgStock.Rows)
            {
                totalHeight += row.Height;
            }

            // Establecer la altura del control al totalHeight calculado
            dgStock.Height = totalHeight;

        }

        public void AjustarAnchoDataGred()
        {
            int totalWidth = dgStock.RowHeadersWidth;

            foreach (DataGridViewColumn column in dgStock.Columns)
            {
                totalWidth += column.Width;
            }

            // Establecer el ancho del control al totalWidth calculado
            dgStock.Width = totalWidth;
        }

    }
}
