namespace AppRestaurante.Salon
{
    partial class FormMesa
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
            cbMenu = new ComboBox();
            lblMenu = new Label();
            btnCerrarMesa = new Button();
            btnCancelar = new Button();
            btnAGregar = new Button();
            cbBebidas = new ComboBox();
            lblBebidas = new Label();
            btnBebidas = new Button();
            btnPedidoCocina = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            lblListaPedidos = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cbMenu
            // 
            cbMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMenu.FormattingEnabled = true;
            cbMenu.Location = new Point(26, 51);
            cbMenu.Name = "cbMenu";
            cbMenu.Size = new Size(161, 25);
            cbMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(80, 22);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(46, 17);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "MENU";
            // 
            // btnCerrarMesa
            // 
            btnCerrarMesa.Location = new Point(179, 243);
            btnCerrarMesa.Name = "btnCerrarMesa";
            btnCerrarMesa.Size = new Size(141, 64);
            btnCerrarMesa.TabIndex = 2;
            btnCerrarMesa.Text = "CERRAR MESA";
            btnCerrarMesa.UseVisualStyleBackColor = true;
            btnCerrarMesa.Click += btnCerrarMesa_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 243);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 64);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAGregar
            // 
            btnAGregar.Location = new Point(203, 51);
            btnAGregar.Name = "btnAGregar";
            btnAGregar.Size = new Size(161, 23);
            btnAGregar.TabIndex = 4;
            btnAGregar.Text = "AGREGAR AL PEDIDO";
            btnAGregar.UseVisualStyleBackColor = true;
            btnAGregar.Click += btnAGregar_Click;
            // 
            // cbBebidas
            // 
            cbBebidas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBebidas.FormattingEnabled = true;
            cbBebidas.Location = new Point(26, 140);
            cbBebidas.Name = "cbBebidas";
            cbBebidas.Size = new Size(161, 25);
            cbBebidas.TabIndex = 5;
            // 
            // lblBebidas
            // 
            lblBebidas.AutoSize = true;
            lblBebidas.Location = new Point(80, 120);
            lblBebidas.Name = "lblBebidas";
            lblBebidas.Size = new Size(56, 17);
            lblBebidas.TabIndex = 6;
            lblBebidas.Text = "BEBIDAS";
            // 
            // btnBebidas
            // 
            btnBebidas.Location = new Point(26, 182);
            btnBebidas.Name = "btnBebidas";
            btnBebidas.Size = new Size(161, 23);
            btnBebidas.TabIndex = 7;
            btnBebidas.Text = "AGREGAR BEBIDA";
            btnBebidas.UseVisualStyleBackColor = true;
            // 
            // btnPedidoCocina
            // 
            btnPedidoCocina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedidoCocina.Location = new Point(400, 22);
            btnPedidoCocina.Name = "btnPedidoCocina";
            btnPedidoCocina.Size = new Size(152, 107);
            btnPedidoCocina.TabIndex = 8;
            btnPedidoCocina.Text = "CURSAR PEDIDO A COCINA";
            btnPedidoCocina.UseVisualStyleBackColor = true;
            btnPedidoCocina.Click += btnPedidoCocina_Click;
            // 
            // button1
            // 
            button1.Location = new Point(203, 80);
            button1.Name = "button1";
            button1.Size = new Size(162, 23);
            button1.TabIndex = 9;
            button1.Text = "DEL. UTIMO PED.";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblListaPedidos);
            groupBox1.Location = new Point(400, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 181);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "PEDIDO";
            // 
            // lblListaPedidos
            // 
            lblListaPedidos.AutoSize = true;
            lblListaPedidos.Location = new Point(15, 32);
            lblListaPedidos.Name = "lblListaPedidos";
            lblListaPedidos.Size = new Size(17, 17);
            lblListaPedidos.TabIndex = 0;
            lblListaPedidos.Text = "* ";
            // 
            // FormMesa
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 346);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(btnPedidoCocina);
            Controls.Add(btnBebidas);
            Controls.Add(lblBebidas);
            Controls.Add(cbBebidas);
            Controls.Add(btnAGregar);
            Controls.Add(btnCancelar);
            Controls.Add(btnCerrarMesa);
            Controls.Add(lblMenu);
            Controls.Add(cbMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMesa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MOSO TOMANDO PEDIDO EN MESA: ";
            Load += FormMesa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMenu;
        private Label lblMenu;
        private Button btnCerrarMesa;
        private Button btnCancelar;
        private Button btnAGregar;
        private ComboBox cbBebidas;
        private Label lblBebidas;
        private Button btnBebidas;
        private Button btnPedidoCocina;
        private Button button1;
        private GroupBox groupBox1;
        private Label lblListaPedidos;
    }
}