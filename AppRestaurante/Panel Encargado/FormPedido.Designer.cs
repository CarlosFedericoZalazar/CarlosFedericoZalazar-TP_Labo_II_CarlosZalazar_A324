namespace AppRestaurante.Panel_Encargado
{
    partial class FormPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedido));
            cbProveedor = new ComboBox();
            lblTipo = new Label();
            lblProveedor = new Label();
            cbTipo = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            lblProducto = new Label();
            cbProducto = new ComboBox();
            lblPrecio = new Label();
            txtAPagar = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbProveedor
            // 
            cbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(264, 35);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(206, 29);
            cbProveedor.TabIndex = 19;
            cbProveedor.SelectedValueChanged += cbProveedor_SelectedValueChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(21, 9);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(40, 21);
            lblTipo.TabIndex = 17;
            lblTipo.Text = "Tipo";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedor.Location = new Point(265, 9);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(82, 21);
            lblProveedor.TabIndex = 16;
            lblProveedor.Text = "Proveedor";
            // 
            // cbTipo
            // 
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(21, 35);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(205, 29);
            cbTipo.TabIndex = 15;
            cbTipo.SelectedValueChanged += cbTipo_SelectedValueChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(66, 244);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(139, 48);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(262, 246);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 46);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(289, 98);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(145, 29);
            txtPrecio.TabIndex = 29;
            txtPrecio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(23, 166);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(145, 25);
            txtCantidad.TabIndex = 25;
            txtCantidad.TextAlign = HorizontalAlignment.Center;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(21, 142);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 21);
            lblCantidad.TabIndex = 24;
            lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProducto.Location = new Point(21, 78);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(73, 21);
            lblProducto.TabIndex = 22;
            lblProducto.Text = "Producto";
            // 
            // cbProducto
            // 
            cbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new Point(23, 102);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new Size(203, 29);
            cbProducto.TabIndex = 30;
            cbProducto.SelectedValueChanged += cbProducto_SelectedValueChanged;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(289, 74);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(63, 21);
            lblPrecio.TabIndex = 32;
            lblPrecio.Text = "PRECIO";
            // 
            // txtAPagar
            // 
            txtAPagar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAPagar.Location = new Point(286, 162);
            txtAPagar.Name = "txtAPagar";
            txtAPagar.ReadOnly = true;
            txtAPagar.Size = new Size(148, 29);
            txtAPagar.TabIndex = 33;
            txtAPagar.Text = "0";
            txtAPagar.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(289, 139);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 34;
            label1.Text = "A PAGAR $";
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(489, 344);
            Controls.Add(label1);
            Controls.Add(txtAPagar);
            Controls.Add(lblPrecio);
            Controls.Add(cbProducto);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cbProveedor);
            Controls.Add(lblTipo);
            Controls.Add(lblProveedor);
            Controls.Add(cbTipo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HACER PEDIDO DE MERCADERIA";
            Load += FormPedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbProveedor;
        private Label lblTipo;
        private Label lblProveedor;
        private ComboBox cbTipo;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private Label lblProducto;
        private ComboBox cbProducto;
        private Label lblPrecio;
        private TextBox txtAPagar;
        private Label label1;
    }
}