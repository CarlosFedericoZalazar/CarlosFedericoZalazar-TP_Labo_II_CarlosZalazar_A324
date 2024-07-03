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
            label1 = new Label();
            gbAlcohol = new GroupBox();
            rbNo = new RadioButton();
            rbSi = new RadioButton();
            lblUnidKilos = new Label();
            txtCantidad = new TextBox();
            txtProducto = new TextBox();
            lblCantidad = new Label();
            lblProducto = new Label();
            gbAlcohol.SuspendLayout();
            SuspendLayout();
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(325, 100);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(145, 25);
            cbProveedor.TabIndex = 19;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(325, 14);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(34, 17);
            lblTipo.TabIndex = 17;
            lblTipo.Text = "Tipo";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(325, 79);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(69, 17);
            lblProveedor.TabIndex = 16;
            lblProveedor.Text = "Proveedor";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(325, 34);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(144, 25);
            cbTipo.TabIndex = 15;
            cbTipo.SelectedValueChanged += cbTipo_SelectedValueChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(108, 253);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(139, 48);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(304, 255);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 46);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(104, 100);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(145, 25);
            txtPrecio.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 103);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 28;
            label1.Text = "Precio";
            // 
            // gbAlcohol
            // 
            gbAlcohol.Controls.Add(rbNo);
            gbAlcohol.Controls.Add(rbSi);
            gbAlcohol.Location = new Point(15, 148);
            gbAlcohol.Name = "gbAlcohol";
            gbAlcohol.Size = new Size(133, 78);
            gbAlcohol.TabIndex = 27;
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
            // lblUnidKilos
            // 
            lblUnidKilos.AutoSize = true;
            lblUnidKilos.Location = new Point(255, 70);
            lblUnidKilos.Name = "lblUnidKilos";
            lblUnidKilos.Size = new Size(14, 17);
            lblUnidKilos.TabIndex = 26;
            lblUnidKilos.Text = "?";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(104, 67);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(145, 25);
            txtCantidad.TabIndex = 25;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(104, 35);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(145, 25);
            txtProducto.TabIndex = 23;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(15, 70);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(60, 17);
            lblCantidad.TabIndex = 24;
            lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(15, 38);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(61, 17);
            lblProducto.TabIndex = 22;
            lblProducto.Text = "Producto";
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(537, 321);
            Controls.Add(txtPrecio);
            Controls.Add(label1);
            Controls.Add(gbAlcohol);
            Controls.Add(lblUnidKilos);
            Controls.Add(txtCantidad);
            Controls.Add(txtProducto);
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
            gbAlcohol.ResumeLayout(false);
            gbAlcohol.PerformLayout();
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
        private Label label1;
        private GroupBox gbAlcohol;
        private RadioButton rbNo;
        private RadioButton rbSi;
        private Label lblUnidKilos;
        private TextBox txtCantidad;
        private TextBox txtProducto;
        private Label lblCantidad;
        private Label lblProducto;
    }
}