namespace AppRestoForm
{
    partial class FormStockDisponible
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
            comboBox1 = new ComboBox();
            dgStock = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgStock).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(46, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 25);
            comboBox1.TabIndex = 1;
            // 
            // dgStock
            // 
            dgStock.AllowUserToAddRows = false;
            dgStock.AllowUserToDeleteRows = false;
            dgStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStock.Location = new Point(198, 73);
            dgStock.Name = "dgStock";
            dgStock.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgStock.RowTemplate.Height = 27;
            dgStock.ScrollBars = ScrollBars.None;
            dgStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgStock.Size = new Size(449, 249);
            dgStock.TabIndex = 2;
            // 
            // FormStockDisponible
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgStock);
            Controls.Add(comboBox1);
            Name = "FormStockDisponible";
            Text = "Stock Disponible";
            Load += FormStockDisponible_Load;
            ((System.ComponentModel.ISupportInitialize)dgStock).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox1;
        private DataGridView dgStock;
    }
}