namespace AppRestaurante.Panel_Encargado
{
    partial class FormProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            cbTipoProducto = new ComboBox();
            lblTipoProducto = new Label();
            btnCerrar = new Button();
            txtNombreProducto = new TextBox();
            groupBox1 = new GroupBox();
            btnIngresar = new Button();
            label2 = new Label();
            txtPrecio = new TextBox();
            label1 = new Label();
            cbProveedor = new ComboBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cbTipoProducto
            // 
            cbTipoProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoProducto.FormattingEnabled = true;
            cbTipoProducto.Location = new Point(12, 34);
            cbTipoProducto.Name = "cbTipoProducto";
            cbTipoProducto.Size = new Size(152, 29);
            cbTipoProducto.TabIndex = 0;
            cbTipoProducto.SelectedValueChanged += cbTipoProducto_SelectedValueChanged;
            // 
            // lblTipoProducto
            // 
            lblTipoProducto.AutoSize = true;
            lblTipoProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoProducto.Location = new Point(12, 10);
            lblTipoProducto.Name = "lblTipoProducto";
            lblTipoProducto.Size = new Size(137, 21);
            lblTipoProducto.TabIndex = 1;
            lblTipoProducto.Text = "TIPO PROVEEDOR";
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(119, 339);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(141, 60);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(17, 56);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(168, 29);
            txtNombreProducto.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombreProducto);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(75, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 227);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "NUEVO PRODUCTO";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(54, 170);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(99, 36);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 99);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 6;
            label2.Text = "PRECIO";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(17, 123);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 29);
            txtPrecio.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 32);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 4;
            label1.Text = "NOMBRE";
            // 
            // cbProveedor
            // 
            cbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(201, 34);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(152, 29);
            cbProveedor.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(201, 10);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 6;
            label3.Text = "PROVEEDOR";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(378, 439);
            Controls.Add(label3);
            Controls.Add(cbProveedor);
            Controls.Add(groupBox1);
            Controls.Add(btnCerrar);
            Controls.Add(lblTipoProducto);
            Controls.Add(cbTipoProducto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GESTOR PRODUCTOS PROVEEDORES";
            Load += FormProductos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTipoProducto;
        private Label lblTipoProducto;
        private Button btnCerrar;
        private TextBox txtNombreProducto;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtPrecio;
        private Label label1;
        private Button btnIngresar;
        private ComboBox cbProveedor;
        private Label label3;
    }
}