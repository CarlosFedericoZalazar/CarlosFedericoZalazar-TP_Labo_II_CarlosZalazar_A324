namespace AppRestaurante.Caja
{
    partial class FormCaja
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
            lblDineroCaja = new Label();
            txtDineroCaja = new TextBox();
            SuspendLayout();
            // 
            // lblDineroCaja
            // 
            lblDineroCaja.AutoSize = true;
            lblDineroCaja.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDineroCaja.Location = new Point(583, 31);
            lblDineroCaja.Name = "lblDineroCaja";
            lblDineroCaja.Size = new Size(137, 25);
            lblDineroCaja.TabIndex = 0;
            lblDineroCaja.Text = "Dinero en Caja";
            // 
            // txtDineroCaja
            // 
            txtDineroCaja.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDineroCaja.Location = new Point(583, 59);
            txtDineroCaja.Name = "txtDineroCaja";
            txtDineroCaja.ReadOnly = true;
            txtDineroCaja.Size = new Size(146, 33);
            txtDineroCaja.TabIndex = 1;
            txtDineroCaja.Text = "0";
            txtDineroCaja.TextAlign = HorizontalAlignment.Center;
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDineroCaja);
            Controls.Add(lblDineroCaja);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCaja";
            Text = "CAJA";
            Load += FormCaja_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDineroCaja;
        private TextBox txtDineroCaja;
    }
}