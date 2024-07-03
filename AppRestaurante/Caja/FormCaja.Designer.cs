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
            btnPagoProveedores = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDineroCaja
            // 
            lblDineroCaja.AutoSize = true;
            lblDineroCaja.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDineroCaja.Location = new Point(312, 31);
            lblDineroCaja.Name = "lblDineroCaja";
            lblDineroCaja.Size = new Size(137, 25);
            lblDineroCaja.TabIndex = 0;
            lblDineroCaja.Text = "Dinero en Caja";
            // 
            // txtDineroCaja
            // 
            txtDineroCaja.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDineroCaja.Location = new Point(312, 59);
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
            btnTickets.Location = new Point(32, 212);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(160, 64);
            btnTickets.TabIndex = 3;
            btnTickets.Text = "DINERO TICKETS";
            btnTickets.UseVisualStyleBackColor = true;
            btnTickets.Click += btnTickets_Click;
            // 
            // btnPagoProveedores
            // 
            btnPagoProveedores.Location = new Point(32, 128);
            btnPagoProveedores.Name = "btnPagoProveedores";
            btnPagoProveedores.Size = new Size(160, 64);
            btnPagoProveedores.TabIndex = 4;
            btnPagoProveedores.Text = "PAGO PROVEEDORES";
            btnPagoProveedores.UseVisualStyleBackColor = true;
            btnPagoProveedores.Click += btnPagoProveedores_Click;
            // 
            // button1
            // 
            button1.Location = new Point(32, 297);
            button1.Name = "button1";
            button1.Size = new Size(160, 64);
            button1.TabIndex = 5;
            button1.Text = "CONSUMOS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(331, 251);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "PRUEBA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 25);
            textBox1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(73, 67);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "INGRESAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(569, 384);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(btnPagoProveedores);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDineroCaja;
        private TextBox txtDineroCaja;
        private Button btnPagos;
        private Button btnTickets;
        private Button btnPagoProveedores;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBox1;
    }
}