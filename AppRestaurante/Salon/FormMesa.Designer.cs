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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMesa));
            cbMenu = new ComboBox();
            lblMenu = new Label();
            btnCancelar = new Button();
            btnAGregar = new Button();
            cbBebidas = new ComboBox();
            lblBebidas = new Label();
            btnBebidas = new Button();
            btnPedidoCocina = new Button();
            btnDelPlato = new Button();
            groupBox1 = new GroupBox();
            lblListaPedidos = new Label();
            groupBox2 = new GroupBox();
            lblBebida = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cbMenu
            // 
            cbMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMenu.FormattingEnabled = true;
            cbMenu.Location = new Point(15, 40);
            cbMenu.Name = "cbMenu";
            cbMenu.Size = new Size(161, 29);
            cbMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMenu.Location = new Point(70, 16);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(55, 21);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "MENU";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(143, 322);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 64);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAGregar
            // 
            btnAGregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAGregar.Location = new Point(203, 36);
            btnAGregar.Name = "btnAGregar";
            btnAGregar.Size = new Size(161, 29);
            btnAGregar.TabIndex = 4;
            btnAGregar.Text = "AGREGAR AL PEDIDO";
            btnAGregar.UseVisualStyleBackColor = true;
            btnAGregar.Click += btnAGregar_Click;
            // 
            // cbBebidas
            // 
            cbBebidas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBebidas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbBebidas.FormattingEnabled = true;
            cbBebidas.Location = new Point(401, 40);
            cbBebidas.Name = "cbBebidas";
            cbBebidas.Size = new Size(161, 29);
            cbBebidas.TabIndex = 5;
            // 
            // lblBebidas
            // 
            lblBebidas.AutoSize = true;
            lblBebidas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBebidas.Location = new Point(455, 16);
            lblBebidas.Name = "lblBebidas";
            lblBebidas.Size = new Size(70, 21);
            lblBebidas.TabIndex = 6;
            lblBebidas.Text = "BEBIDAS";
            // 
            // btnBebidas
            // 
            btnBebidas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBebidas.Location = new Point(588, 36);
            btnBebidas.Name = "btnBebidas";
            btnBebidas.Size = new Size(161, 25);
            btnBebidas.TabIndex = 7;
            btnBebidas.Text = "AGREGAR BEBIDA";
            btnBebidas.UseVisualStyleBackColor = true;
            btnBebidas.Click += btnBebidas_Click;
            // 
            // btnPedidoCocina
            // 
            btnPedidoCocina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedidoCocina.Location = new Point(503, 321);
            btnPedidoCocina.Name = "btnPedidoCocina";
            btnPedidoCocina.Size = new Size(152, 64);
            btnPedidoCocina.TabIndex = 8;
            btnPedidoCocina.Text = "CURSAR PEDIDO A COCINA";
            btnPedidoCocina.UseVisualStyleBackColor = true;
            btnPedidoCocina.Click += btnPedidoCocina_Click;
            // 
            // btnDelPlato
            // 
            btnDelPlato.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelPlato.Location = new Point(202, 79);
            btnDelPlato.Name = "btnDelPlato";
            btnDelPlato.Size = new Size(162, 31);
            btnDelPlato.TabIndex = 9;
            btnDelPlato.Text = "DEL. UTIMO PED.";
            btnDelPlato.UseVisualStyleBackColor = true;
            btnDelPlato.Click += btnDelPlato_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblListaPedidos);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(15, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 181);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "PEDIDO";
            // 
            // lblListaPedidos
            // 
            lblListaPedidos.AutoSize = true;
            lblListaPedidos.Location = new Point(15, 32);
            lblListaPedidos.Name = "lblListaPedidos";
            lblListaPedidos.Size = new Size(18, 17);
            lblListaPedidos.TabIndex = 0;
            lblListaPedidos.Text = "* ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblBebida);
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(401, 121);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(351, 181);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "BEBIDAS";
            // 
            // lblBebida
            // 
            lblBebida.AutoSize = true;
            lblBebida.Location = new Point(19, 32);
            lblBebida.Name = "lblBebida";
            lblBebida.Size = new Size(14, 17);
            lblBebida.TabIndex = 0;
            lblBebida.Text = "*";
            // 
            // FormMesa
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(775, 403);
            ControlBox = false;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnDelPlato);
            Controls.Add(btnPedidoCocina);
            Controls.Add(btnBebidas);
            Controls.Add(lblBebidas);
            Controls.Add(cbBebidas);
            Controls.Add(btnAGregar);
            Controls.Add(btnCancelar);
            Controls.Add(lblMenu);
            Controls.Add(cbMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMesa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TOMANDO PEDIDO EN MESA: ";
            Load += FormMesa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMenu;
        private Label lblMenu;
        private Button btnCancelar;
        private Button btnAGregar;
        private ComboBox cbBebidas;
        private Label lblBebidas;
        private Button btnBebidas;
        private Button btnPedidoCocina;
        private Button btnDelPlato;
        private GroupBox groupBox1;
        private Label lblListaPedidos;
        private GroupBox groupBox2;
        private Label lblBebida;
    }
}