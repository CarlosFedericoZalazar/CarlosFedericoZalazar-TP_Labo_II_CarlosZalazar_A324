namespace AppRestaurante.Panel_Encargado
{
    partial class FormStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblStockComida = new Label();
            lblStockBebidas = new Label();
            dgStock = new DataGridView();
            cbTipoStock = new ComboBox();
            lblTipoStock = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            ((System.ComponentModel.ISupportInitialize)dgStock).BeginInit();
            SuspendLayout();
            // 
            // lblStockComida
            // 
            lblStockComida.AutoSize = true;
            lblStockComida.Location = new Point(399, 347);
            lblStockComida.Name = "lblStockComida";
            lblStockComida.Size = new Size(101, 17);
            lblStockComida.TabIndex = 2;
            lblStockComida.Text = "Stock Comidas: ";
            // 
            // lblStockBebidas
            // 
            lblStockBebidas.AutoEllipsis = true;
            lblStockBebidas.AutoSize = true;
            lblStockBebidas.Location = new Point(404, 377);
            lblStockBebidas.Name = "lblStockBebidas";
            lblStockBebidas.Size = new Size(96, 17);
            lblStockBebidas.TabIndex = 3;
            lblStockBebidas.Text = "Stock Bebidas: ";
            // 
            // dgStock
            // 
            dgStock.AllowUserToAddRows = false;
            dgStock.AllowUserToDeleteRows = false;
            dgStock.AllowUserToResizeColumns = false;
            dgStock.AllowUserToResizeRows = false;
            dgStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStock.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgStock.DefaultCellStyle = dataGridViewCellStyle1;
            dgStock.Location = new Point(28, 105);
            dgStock.Name = "dgStock";
            dgStock.RowHeadersVisible = false;
            dgStock.RowTemplate.Height = 27;
            dgStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStock.Size = new Size(485, 224);
            dgStock.TabIndex = 4;
            // 
            // cbTipoStock
            // 
            cbTipoStock.FormattingEnabled = true;
            cbTipoStock.Location = new Point(28, 29);
            cbTipoStock.Name = "cbTipoStock";
            cbTipoStock.Size = new Size(121, 25);
            cbTipoStock.TabIndex = 5;
            cbTipoStock.SelectedValueChanged += cbTipoStock_SelectedValueChanged;
            // 
            // lblTipoStock
            // 
            lblTipoStock.AutoSize = true;
            lblTipoStock.Location = new Point(28, 10);
            lblTipoStock.Name = "lblTipoStock";
            lblTipoStock.Size = new Size(100, 17);
            lblTipoStock.TabIndex = 6;
            lblTipoStock.Text = "Stock a mostrar";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProducto.Location = new Point(107, 82);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(89, 20);
            lblProducto.TabIndex = 7;
            lblProducto.Text = "PRODUCTO";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidad.Location = new Point(310, 82);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(88, 20);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "CANTIDAD";
            // 
            // FormStock
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 450);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(lblTipoStock);
            Controls.Add(cbTipoStock);
            Controls.Add(dgStock);
            Controls.Add(lblStockBebidas);
            Controls.Add(lblStockComida);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStock";
            Text = "STOCK DISPONIBLE";
            Load += FormStock_Load;
            ((System.ComponentModel.ISupportInitialize)dgStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStockComida;
        private Label lblStockBebidas;
        private DataGridView dgStock;
        private ComboBox cbTipoStock;
        private Label lblTipoStock;
        private Label lblProducto;
        private Label lblCantidad;
    }
}