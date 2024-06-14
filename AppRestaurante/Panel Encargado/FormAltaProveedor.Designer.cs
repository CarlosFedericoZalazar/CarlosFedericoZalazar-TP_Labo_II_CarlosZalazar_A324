namespace AppRestaurante.Panel_Encargado
{
    partial class FormAltaProveedor
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
            lblDiaEntrega = new Label();
            cbDiaEntrega = new ComboBox();
            label3 = new Label();
            cbMedioPago = new ComboBox();
            label2 = new Label();
            txtCuit = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            btnConfirmar = new Button();
            label4 = new Label();
            cbTipoProducto = new ComboBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblDiaEntrega
            // 
            lblDiaEntrega.AutoSize = true;
            lblDiaEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiaEntrega.Location = new Point(255, 170);
            lblDiaEntrega.Name = "lblDiaEntrega";
            lblDiaEntrega.Size = new Size(111, 21);
            lblDiaEntrega.TabIndex = 16;
            lblDiaEntrega.Text = "Dia de Entrega";
            // 
            // cbDiaEntrega
            // 
            cbDiaEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbDiaEntrega.FormattingEnabled = true;
            cbDiaEntrega.Location = new Point(255, 194);
            cbDiaEntrega.Name = "cbDiaEntrega";
            cbDiaEntrega.Size = new Size(144, 29);
            cbDiaEntrega.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 170);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 14;
            label3.Text = "Medios de Pago";
            // 
            // cbMedioPago
            // 
            cbMedioPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMedioPago.FormattingEnabled = true;
            cbMedioPago.Location = new Point(27, 194);
            cbMedioPago.Name = "cbMedioPago";
            cbMedioPago.Size = new Size(143, 29);
            cbMedioPago.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 87);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 12;
            label2.Text = "CUIT";
            // 
            // txtCuit
            // 
            txtCuit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuit.Location = new Point(27, 111);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(177, 29);
            txtCuit.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(27, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(218, 29);
            txtNombre.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(194, 21);
            label1.TabIndex = 9;
            label1.Text = "Nombre Nuevo Proveedor";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(49, 295);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(174, 67);
            btnConfirmar.TabIndex = 17;
            btnConfirmar.Text = "CONFIRMAR PROVEEDOR";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(290, 16);
            label4.Name = "label4";
            label4.Size = new Size(175, 25);
            label4.TabIndex = 18;
            label4.Text = "TIPO DE ALIMENTO";
            // 
            // cbTipoProducto
            // 
            cbTipoProducto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoProducto.FormattingEnabled = true;
            cbTipoProducto.Location = new Point(297, 44);
            cbTipoProducto.Name = "cbTipoProducto";
            cbTipoProducto.Size = new Size(168, 33);
            cbTipoProducto.TabIndex = 19;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(255, 295);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(173, 67);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAltaProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 415);
            Controls.Add(btnCancelar);
            Controls.Add(cbTipoProducto);
            Controls.Add(label4);
            Controls.Add(btnConfirmar);
            Controls.Add(lblDiaEntrega);
            Controls.Add(cbDiaEntrega);
            Controls.Add(label3);
            Controls.Add(cbMedioPago);
            Controls.Add(label2);
            Controls.Add(txtCuit);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAltaProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAltaProveedor";
            Load += FormAltaProveedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDiaEntrega;
        private ComboBox cbDiaEntrega;
        private Label label3;
        private ComboBox cbMedioPago;
        private Label label2;
        private TextBox txtCuit;
        private TextBox txtNombre;
        private Label label1;
        private Button btnConfirmar;
        private Label label4;
        private ComboBox cbTipoProducto;
        private Button btnCancelar;
    }
}