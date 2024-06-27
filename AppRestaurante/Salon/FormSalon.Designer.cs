namespace AppRestaurante.Salon
{
    partial class FormSalon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalon));
            cbMesas = new ComboBox();
            lblMesa = new Label();
            cbMeseros = new ComboBox();
            lblMeseros = new Label();
            btnPedido = new Button();
            lblCancelar = new Button();
            lblEncargado = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // cbMesas
            // 
            cbMesas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMesas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cbMesas.FormattingEnabled = true;
            cbMesas.Location = new Point(68, 83);
            cbMesas.Name = "cbMesas";
            cbMesas.Size = new Size(50, 33);
            cbMesas.TabIndex = 0;
            cbMesas.SelectedValueChanged += cbMesas_SelectedValueChanged;
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMesa.Location = new Point(76, 59);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(51, 21);
            lblMesa.TabIndex = 1;
            lblMesa.Text = "MESA";
            // 
            // cbMeseros
            // 
            cbMeseros.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMeseros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMeseros.FormattingEnabled = true;
            cbMeseros.Location = new Point(221, 83);
            cbMeseros.Name = "cbMeseros";
            cbMeseros.Size = new Size(165, 29);
            cbMeseros.TabIndex = 2;
            // 
            // lblMeseros
            // 
            lblMeseros.AutoSize = true;
            lblMeseros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMeseros.Location = new Point(264, 59);
            lblMeseros.Name = "lblMeseros";
            lblMeseros.Size = new Size(80, 21);
            lblMeseros.TabIndex = 3;
            lblMeseros.Text = "MESEROS";
            // 
            // btnPedido
            // 
            btnPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedido.Location = new Point(221, 144);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(165, 85);
            btnPedido.TabIndex = 4;
            btnPedido.Text = "TOMAR PEDIDO DE MESA";
            btnPedido.UseVisualStyleBackColor = true;
            btnPedido.Click += btnPedido_Click;
            // 
            // lblCancelar
            // 
            lblCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCancelar.Location = new Point(33, 144);
            lblCancelar.Name = "lblCancelar";
            lblCancelar.Size = new Size(165, 85);
            lblCancelar.TabIndex = 5;
            lblCancelar.Text = "PANEL PRINCIPAL";
            lblCancelar.UseVisualStyleBackColor = true;
            lblCancelar.Click += lblCancelar_Click;
            // 
            // lblEncargado
            // 
            lblEncargado.AutoSize = true;
            lblEncargado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblEncargado.Location = new Point(12, 18);
            lblEncargado.Name = "lblEncargado";
            lblEncargado.Size = new Size(166, 21);
            lblEncargado.TabIndex = 6;
            lblEncargado.Text = "- Encargado de Turno:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Green;
            lblStatus.Location = new Point(124, 87);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(16, 21);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "-";
            // 
            // FormSalon
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(440, 278);
            Controls.Add(lblStatus);
            Controls.Add(lblEncargado);
            Controls.Add(lblCancelar);
            Controls.Add(btnPedido);
            Controls.Add(lblMeseros);
            Controls.Add(cbMeseros);
            Controls.Add(lblMesa);
            Controls.Add(cbMesas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSalon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATENCION EN SALON";
            Load += FormSalon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMesas;
        private Label lblMesa;
        private ComboBox cbMeseros;
        private Label lblMeseros;
        private Button btnPedido;
        private Button lblCancelar;
        private Label lblEncargado;
        private Label lblStatus;
    }
}