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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaja));
            lblDineroCaja = new Label();
            txtDineroCaja = new TextBox();
            btnPagos = new Button();
            btnTickets = new Button();
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
            // btnPagos
            // 
            btnPagos.Location = new Point(32, 44);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(160, 64);
            btnPagos.TabIndex = 2;
            btnPagos.Text = "PAGOS";
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // btnTickets
            // 
            btnTickets.Location = new Point(32, 149);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(160, 64);
            btnTickets.TabIndex = 3;
            btnTickets.Text = "DINERO TICKETS";
            btnTickets.UseVisualStyleBackColor = true;
            btnTickets.Click += btnTickets_Click;
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTickets);
            Controls.Add(btnPagos);
            Controls.Add(txtDineroCaja);
            Controls.Add(lblDineroCaja);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button btnPagos;
        private Button btnTickets;
    }
}