namespace AppRestoForm
{
    partial class FormAddProveedor
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtCuit = new TextBox();
            label2 = new Label();
            cbMedioPago = new ComboBox();
            label3 = new Label();
            cbDiaEntrega = new ComboBox();
            lblDiaEntrega = new Label();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(194, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre Nuevo Proveedor";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(24, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(177, 29);
            txtNombre.TabIndex = 1;
            // 
            // txtCuit
            // 
            txtCuit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCuit.Location = new Point(236, 49);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(177, 29);
            txtCuit.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(236, 25);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 3;
            label2.Text = "CUIT";
            // 
            // cbMedioPago
            // 
            cbMedioPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMedioPago.FormattingEnabled = true;
            cbMedioPago.Location = new Point(24, 119);
            cbMedioPago.Name = "cbMedioPago";
            cbMedioPago.Size = new Size(121, 29);
            cbMedioPago.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 95);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 5;
            label3.Text = "Medios de Pago";
            // 
            // cbDiaEntrega
            // 
            cbDiaEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbDiaEntrega.FormattingEnabled = true;
            cbDiaEntrega.Location = new Point(236, 119);
            cbDiaEntrega.Name = "cbDiaEntrega";
            cbDiaEntrega.Size = new Size(121, 29);
            cbDiaEntrega.TabIndex = 7;
            // 
            // lblDiaEntrega
            // 
            lblDiaEntrega.AutoSize = true;
            lblDiaEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiaEntrega.Location = new Point(236, 95);
            lblDiaEntrega.Name = "lblDiaEntrega";
            lblDiaEntrega.Size = new Size(111, 21);
            lblDiaEntrega.TabIndex = 8;
            lblDiaEntrega.Text = "Dia de Entrega";
            // 
            // btnConfirmar
            // 
            btnConfirmar.FlatStyle = FlatStyle.System;
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(77, 205);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(141, 61);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "CONFIRMAR PROVEEDOR";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FormAddProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 298);
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
            Name = "FormAddProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ALTA PROVEEDOR";
            Load += FormAddProveedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtCuit;
        private Label label2;
        private ComboBox cbMedioPago;
        private Label label3;
        private ComboBox cbDiaEntrega;
        private Label lblDiaEntrega;
        private Button btnConfirmar;
    }
}