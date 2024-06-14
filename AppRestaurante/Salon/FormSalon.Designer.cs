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
            button1 = new Button();
            lblCancelar = new Button();
            lblEncargado = new Label();
            SuspendLayout();
            // 
            // cbMesas
            // 
            cbMesas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMesas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cbMesas.FormattingEnabled = true;
            cbMesas.Location = new Point(85, 82);
            cbMesas.Name = "cbMesas";
            cbMesas.Size = new Size(43, 33);
            cbMesas.TabIndex = 0;
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Location = new Point(85, 58);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(42, 17);
            lblMesa.TabIndex = 1;
            lblMesa.Text = "MESA";
            // 
            // cbMeseros
            // 
            cbMeseros.FormattingEnabled = true;
            cbMeseros.Location = new Point(231, 82);
            cbMeseros.Name = "cbMeseros";
            cbMeseros.Size = new Size(165, 25);
            cbMeseros.TabIndex = 2;
            // 
            // lblMeseros
            // 
            lblMeseros.AutoSize = true;
            lblMeseros.Location = new Point(274, 58);
            lblMeseros.Name = "lblMeseros";
            lblMeseros.Size = new Size(66, 17);
            lblMeseros.TabIndex = 3;
            lblMeseros.Text = "MESEROS";
            // 
            // button1
            // 
            button1.Location = new Point(231, 153);
            button1.Name = "button1";
            button1.Size = new Size(165, 85);
            button1.TabIndex = 4;
            button1.Text = "TOMAR PEDIDO DE MESA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblCancelar
            // 
            lblCancelar.Location = new Point(43, 153);
            lblCancelar.Name = "lblCancelar";
            lblCancelar.Size = new Size(165, 85);
            lblCancelar.TabIndex = 5;
            lblCancelar.Text = "CANCELAR";
            lblCancelar.UseVisualStyleBackColor = true;
            // 
            // lblEncargado
            // 
            lblEncargado.AutoSize = true;
            lblEncargado.Location = new Point(12, 19);
            lblEncargado.Name = "lblEncargado";
            lblEncargado.Size = new Size(140, 17);
            lblEncargado.TabIndex = 6;
            lblEncargado.Text = "- Encargado de Turno:";
            // 
            // FormSalon
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 278);
            Controls.Add(lblEncargado);
            Controls.Add(lblCancelar);
            Controls.Add(button1);
            Controls.Add(lblMeseros);
            Controls.Add(cbMeseros);
            Controls.Add(lblMesa);
            Controls.Add(cbMesas);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSalon";
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
        private Button button1;
        private Button lblCancelar;
        private Label lblEncargado;
    }
}