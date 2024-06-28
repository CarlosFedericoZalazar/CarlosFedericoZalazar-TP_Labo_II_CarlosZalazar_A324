namespace AppRestaurante.Panel_Encargado
{
    partial class FormPrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrecios));
            dgMenu = new DataGridView();
            btnModificarPrecio = new Button();
            txtPrecio = new TextBox();
            btnVolver = new Button();
            cbTipoProducto = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgMenu).BeginInit();
            SuspendLayout();
            // 
            // dgMenu
            // 
            dgMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMenu.Location = new Point(45, 74);
            dgMenu.Name = "dgMenu";
            dgMenu.ReadOnly = true;
            dgMenu.RowHeadersVisible = false;
            dgMenu.RowTemplate.Height = 27;
            dgMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMenu.Size = new Size(349, 196);
            dgMenu.TabIndex = 0;
            dgMenu.CellClick += dgMenu_CellClick;
            dgMenu.SelectionChanged += dgMenu_SelectionChanged;
            // 
            // btnModificarPrecio
            // 
            btnModificarPrecio.Location = new Point(45, 293);
            btnModificarPrecio.Name = "btnModificarPrecio";
            btnModificarPrecio.Size = new Size(142, 51);
            btnModificarPrecio.TabIndex = 1;
            btnModificarPrecio.Text = "MODIFICAR PRECIO";
            btnModificarPrecio.UseVisualStyleBackColor = true;
            btnModificarPrecio.Click += btnModificarPrecio_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtPrecio.Location = new Point(215, 293);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(165, 50);
            txtPrecio.TabIndex = 2;
            txtPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(355, 369);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // cbTipoProducto
            // 
            cbTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoProducto.FormattingEnabled = true;
            cbTipoProducto.Location = new Point(45, 43);
            cbTipoProducto.Name = "cbTipoProducto";
            cbTipoProducto.Size = new Size(121, 25);
            cbTipoProducto.TabIndex = 4;
            cbTipoProducto.SelectedValueChanged += cbTipoProducto_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 11);
            label1.Name = "label1";
            label1.Size = new Size(110, 17);
            label1.TabIndex = 5;
            label1.Text = "Tipo de Producto";
            // 
            // FormPrecios
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(472, 401);
            Controls.Add(label1);
            Controls.Add(cbTipoProducto);
            Controls.Add(btnVolver);
            Controls.Add(txtPrecio);
            Controls.Add(btnModificarPrecio);
            Controls.Add(dgMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrecios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PANEL ENCARGADO - PRECIOS";
            Load += FormPrecios_Load;
            ((System.ComponentModel.ISupportInitialize)dgMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgMenu;
        private Button btnModificarPrecio;
        private TextBox txtPrecio;
        private Button btnVolver;
        private ComboBox cbTipoProducto;
        private Label label1;
    }
}