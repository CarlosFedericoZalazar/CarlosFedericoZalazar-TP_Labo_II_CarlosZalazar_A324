﻿namespace AppRestaurante.Salon
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
            comboBox1 = new ComboBox();
            lblBebidas = new Label();
            btnBebidas = new Button();
            btnPedidoCocina = new Button();
            SuspendLayout();
            // 
            // cbMenu
            // 
            cbMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMenu.FormattingEnabled = true;
            cbMenu.Location = new Point(79, 80);
            cbMenu.Name = "cbMenu";
            cbMenu.Size = new Size(161, 25);
            cbMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(133, 51);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(46, 17);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "MENU";
            // 
            // btnCerrarMesa
            // 
            btnCerrarMesa.Location = new Point(309, 331);
            btnCerrarMesa.Name = "btnCerrarMesa";
            btnCerrarMesa.Size = new Size(141, 64);
            btnCerrarMesa.TabIndex = 2;
            btnCerrarMesa.Text = "CERRAR MESA";
            btnCerrarMesa.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(90, 331);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 64);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAGregar
            // 
            btnAGregar.Location = new Point(79, 123);
            btnAGregar.Name = "btnAGregar";
            btnAGregar.Size = new Size(161, 23);
            btnAGregar.TabIndex = 4;
            btnAGregar.Text = "AGREGAR AL PEDIDO";
            btnAGregar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(79, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 25);
            comboBox1.TabIndex = 5;
            // 
            // lblBebidas
            // 
            lblBebidas.AutoSize = true;
            lblBebidas.Location = new Point(133, 174);
            lblBebidas.Name = "lblBebidas";
            lblBebidas.Size = new Size(56, 17);
            lblBebidas.TabIndex = 6;
            lblBebidas.Text = "BEBIDAS";
            // 
            // btnBebidas
            // 
            btnBebidas.Location = new Point(79, 236);
            btnBebidas.Name = "btnBebidas";
            btnBebidas.Size = new Size(161, 23);
            btnBebidas.TabIndex = 7;
            btnBebidas.Text = "AGREGAR BEBIDA";
            btnBebidas.UseVisualStyleBackColor = true;
            // 
            // btnPedidoCocina
            // 
            btnPedidoCocina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedidoCocina.Location = new Point(364, 80);
            btnPedidoCocina.Name = "btnPedidoCocina";
            btnPedidoCocina.Size = new Size(152, 107);
            btnPedidoCocina.TabIndex = 8;
            btnPedidoCocina.Text = "CURSAR PEDIDO A COCINA";
            btnPedidoCocina.UseVisualStyleBackColor = true;
            btnPedidoCocina.Click += btnPedidoCocina_Click;
            // 
            // FormMesa
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 450);
            ControlBox = false;
            Controls.Add(btnPedidoCocina);
            Controls.Add(btnBebidas);
            Controls.Add(lblBebidas);
            Controls.Add(comboBox1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMenu;
        private Label lblMenu;
        private Button btnCerrarMesa;
        private Button btnCancelar;
        private Button btnAGregar;
        private ComboBox comboBox1;
        private Label lblBebidas;
        private Button btnBebidas;
        private Button btnPedidoCocina;
    }
}