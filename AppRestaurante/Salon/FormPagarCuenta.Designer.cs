namespace AppRestaurante.Salon
{
    partial class FormPagarCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagarCuenta));
            cbMedioPago = new ComboBox();
            lblMonto = new Label();
            btnPagar = new Button();
            lblMedioPago = new Label();
            SuspendLayout();
            // 
            // cbMedioPago
            // 
            cbMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMedioPago.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbMedioPago.FormattingEnabled = true;
            cbMedioPago.Location = new Point(403, 41);
            cbMedioPago.Name = "cbMedioPago";
            cbMedioPago.Size = new Size(121, 38);
            cbMedioPago.TabIndex = 0;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonto.Location = new Point(31, 31);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(161, 30);
            lblMonto.TabIndex = 1;
            lblMonto.Text = "Monto a Pagar: ";
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(214, 105);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(135, 43);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // lblMedioPago
            // 
            lblMedioPago.AutoSize = true;
            lblMedioPago.Location = new Point(403, 20);
            lblMedioPago.Name = "lblMedioPago";
            lblMedioPago.Size = new Size(99, 17);
            lblMedioPago.TabIndex = 3;
            lblMedioPago.Text = "Medio de Pago";
            // 
            // FormPagarCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(581, 160);
            Controls.Add(lblMedioPago);
            Controls.Add(btnPagar);
            Controls.Add(lblMonto);
            Controls.Add(cbMedioPago);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPagarCuenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CUENTA";
            Load += FormPagarCuenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMedioPago;
        private Label lblMonto;
        private Button btnPagar;
        private Label lblMedioPago;
    }
}