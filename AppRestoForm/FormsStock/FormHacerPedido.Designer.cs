namespace AppRestoForm
{
    partial class FormHacerPedido
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
            lblProducto = new Label();
            lblCantidad = new Label();
            cbTipo = new ComboBox();
            txtProducto = new TextBox();
            txtCantidad = new TextBox();
            lblUnidKilos = new Label();
            lblProveedor = new Label();
            lblTipo = new Label();
            gbAlcohol = new GroupBox();
            rbNo = new RadioButton();
            rbSi = new RadioButton();
            btnAceptar = new Button();
            btnCancelar = new Button();
            button1 = new Button();
            btnAddProveedor = new Button();
            cbProveedor = new ComboBox();
            label1 = new Label();
            txtPrecio = new TextBox();
            gbAlcohol.SuspendLayout();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(29, 107);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(61, 17);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(29, 139);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(60, 17);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(394, 35);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(144, 25);
            cbTipo.TabIndex = 2;
            cbTipo.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(118, 104);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(145, 25);
            txtProducto.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(118, 136);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(145, 25);
            txtCantidad.TabIndex = 2;
            // 
            // lblUnidKilos
            // 
            lblUnidKilos.AutoSize = true;
            lblUnidKilos.Location = new Point(269, 139);
            lblUnidKilos.Name = "lblUnidKilos";
            lblUnidKilos.Size = new Size(14, 17);
            lblUnidKilos.TabIndex = 5;
            lblUnidKilos.Text = "?";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(29, 36);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(69, 17);
            lblProveedor.TabIndex = 6;
            lblProveedor.Text = "Proveedor";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(394, 15);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(34, 17);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo";
            // 
            // gbAlcohol
            // 
            gbAlcohol.Controls.Add(rbNo);
            gbAlcohol.Controls.Add(rbSi);
            gbAlcohol.Location = new Point(29, 217);
            gbAlcohol.Name = "gbAlcohol";
            gbAlcohol.Size = new Size(133, 78);
            gbAlcohol.TabIndex = 9;
            gbAlcohol.TabStop = false;
            gbAlcohol.Text = "Bebida Alcholica";
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Location = new Point(6, 24);
            rbNo.Name = "rbNo";
            rbNo.Size = new Size(46, 21);
            rbNo.TabIndex = 1;
            rbNo.TabStop = true;
            rbNo.Text = "NO";
            rbNo.UseVisualStyleBackColor = true;
            // 
            // rbSi
            // 
            rbSi.AutoSize = true;
            rbSi.Location = new Point(6, 51);
            rbSi.Name = "rbSi";
            rbSi.Size = new Size(36, 21);
            rbSi.TabIndex = 0;
            rbSi.TabStop = true;
            rbSi.Text = "SI";
            rbSi.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(114, 312);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(125, 44);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "CURSAR PEDIDO";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(266, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 44);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(147, 365);
            button1.Name = "button1";
            button1.Size = new Size(186, 36);
            button1.TabIndex = 12;
            button1.Text = "GRABAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAddProveedor
            // 
            btnAddProveedor.Location = new Point(269, 33);
            btnAddProveedor.Name = "btnAddProveedor";
            btnAddProveedor.Size = new Size(75, 28);
            btnAddProveedor.TabIndex = 13;
            btnAddProveedor.Text = "add";
            btnAddProveedor.UseVisualStyleBackColor = true;
            btnAddProveedor.Click += btnAddProveedor_Click;
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(118, 36);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(145, 25);
            cbProveedor.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 172);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 15;
            label1.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(118, 169);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(145, 25);
            txtPrecio.TabIndex = 16;
            // 
            // FormHacerPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 427);
            Controls.Add(txtPrecio);
            Controls.Add(label1);
            Controls.Add(cbProveedor);
            Controls.Add(btnAddProveedor);
            Controls.Add(button1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(gbAlcohol);
            Controls.Add(lblTipo);
            Controls.Add(lblProveedor);
            Controls.Add(lblUnidKilos);
            Controls.Add(txtCantidad);
            Controls.Add(txtProducto);
            Controls.Add(cbTipo);
            Controls.Add(lblCantidad);
            Controls.Add(lblProducto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormHacerPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HacerPedidoForm";
            Activated += FormHacerPedido_Activated;
            Load += HacerPedidoForm_Load;
            gbAlcohol.ResumeLayout(false);
            gbAlcohol.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private Label lblCantidad;
        private ComboBox cbTipo;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private Label lblUnidKilos;
        private Label lblProveedor;
        private Label lblTipo;
        private GroupBox gbAlcohol;
        private RadioButton rbNo;
        private RadioButton rbSi;
        private Button btnAceptar;
        private Button btnCancelar;
        private Button button1;
        private Button btnAddProveedor;
        private ComboBox cbProveedor;
        private Label label1;
        private TextBox txtPrecio;
    }
}