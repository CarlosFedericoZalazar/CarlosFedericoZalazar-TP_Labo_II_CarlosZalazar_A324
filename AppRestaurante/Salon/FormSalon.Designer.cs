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
            cbMesas = new ComboBox();
            lblMesa = new Label();
            cbMeseros = new ComboBox();
            lblMeseros = new Label();
            btnPedido = new Button();
            lblCancelar = new Button();
            lblEncargado = new Label();
            lblStatus = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cbMesas
            // 
            cbMesas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMesas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cbMesas.FormattingEnabled = true;
            cbMesas.Location = new Point(78, 111);
            cbMesas.Name = "cbMesas";
            cbMesas.Size = new Size(50, 33);
            cbMesas.TabIndex = 0;
            cbMesas.SelectedValueChanged += cbMesas_SelectedValueChanged;
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Location = new Point(86, 87);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(42, 17);
            lblMesa.TabIndex = 1;
            lblMesa.Text = "MESA";
            // 
            // cbMeseros
            // 
            cbMeseros.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMeseros.FormattingEnabled = true;
            cbMeseros.Location = new Point(231, 111);
            cbMeseros.Name = "cbMeseros";
            cbMeseros.Size = new Size(165, 25);
            cbMeseros.TabIndex = 2;
            // 
            // lblMeseros
            // 
            lblMeseros.AutoSize = true;
            lblMeseros.Location = new Point(274, 87);
            lblMeseros.Name = "lblMeseros";
            lblMeseros.Size = new Size(66, 17);
            lblMeseros.TabIndex = 3;
            lblMeseros.Text = "MESEROS";
            // 
            // btnPedido
            // 
            btnPedido.Location = new Point(231, 172);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(165, 85);
            btnPedido.TabIndex = 4;
            btnPedido.Text = "TOMAR PEDIDO DE MESA";
            btnPedido.UseVisualStyleBackColor = true;
            btnPedido.Click += btnPedido_Click;
            // 
            // lblCancelar
            // 
            lblCancelar.Location = new Point(43, 172);
            lblCancelar.Name = "lblCancelar";
            lblCancelar.Size = new Size(165, 85);
            lblCancelar.TabIndex = 5;
            lblCancelar.Text = "CANCELAR";
            lblCancelar.UseVisualStyleBackColor = true;
            lblCancelar.Click += lblCancelar_Click;
            // 
            // lblEncargado
            // 
            lblEncargado.AutoSize = true;
            lblEncargado.Location = new Point(12, 9);
            lblEncargado.Name = "lblEncargado";
            lblEncargado.Size = new Size(140, 17);
            lblEncargado.TabIndex = 6;
            lblEncargado.Text = "- Encargado de Turno:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.Green;
            lblStatus.Location = new Point(134, 115);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(16, 21);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "-";
            // 
            // button1
            // 
            button1.Location = new Point(231, 12);
            button1.Name = "button1";
            button1.Size = new Size(157, 29);
            button1.TabIndex = 8;
            button1.Text = "cantidadPLatos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormSalon
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 278);
            Controls.Add(button1);
            Controls.Add(lblStatus);
            Controls.Add(lblEncargado);
            Controls.Add(lblCancelar);
            Controls.Add(btnPedido);
            Controls.Add(lblMeseros);
            Controls.Add(cbMeseros);
            Controls.Add(lblMesa);
            Controls.Add(cbMesas);
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
        private Button button1;
    }
}