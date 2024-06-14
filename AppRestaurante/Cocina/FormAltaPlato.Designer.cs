﻿namespace AppRestaurante.Cocina
{
    partial class FormAltaPlato
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
            btnCancelar = new Button();
            lblIngrediente = new Label();
            txtIngrediente = new TextBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            btnAddIngrediente = new Button();
            groupBox1 = new GroupBox();
            lblListaIngredientes = new Label();
            txtNombrePlato = new TextBox();
            label1 = new Label();
            btnAceptar = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(234, 283);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 65);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblIngrediente
            // 
            lblIngrediente.AutoSize = true;
            lblIngrediente.Location = new Point(26, 80);
            lblIngrediente.Name = "lblIngrediente";
            lblIngrediente.Size = new Size(88, 17);
            lblIngrediente.TabIndex = 1;
            lblIngrediente.Text = "INGREDIENTE";
            // 
            // txtIngrediente
            // 
            txtIngrediente.Location = new Point(26, 100);
            txtIngrediente.Name = "txtIngrediente";
            txtIngrediente.Size = new Size(166, 25);
            txtIngrediente.TabIndex = 2;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(26, 147);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(70, 17);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(26, 167);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PlaceholderText = "(Kilogramos)";
            txtCantidad.Size = new Size(166, 25);
            txtCantidad.TabIndex = 3;
            // 
            // btnAddIngrediente
            // 
            btnAddIngrediente.Location = new Point(234, 156);
            btnAddIngrediente.Name = "btnAddIngrediente";
            btnAddIngrediente.Size = new Size(106, 45);
            btnAddIngrediente.TabIndex = 5;
            btnAddIngrediente.Text = "AGREGAR INGREDIENTE";
            btnAddIngrediente.UseVisualStyleBackColor = true;
            btnAddIngrediente.Click += btnAddIngrediente_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblListaIngredientes);
            groupBox1.Location = new Point(401, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 294);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "INGREDIENTES:";
            // 
            // lblListaIngredientes
            // 
            lblListaIngredientes.AutoSize = true;
            lblListaIngredientes.Location = new Point(15, 40);
            lblListaIngredientes.Name = "lblListaIngredientes";
            lblListaIngredientes.Size = new Size(0, 17);
            lblListaIngredientes.TabIndex = 0;
            // 
            // txtNombrePlato
            // 
            txtNombrePlato.Location = new Point(77, 35);
            txtNombrePlato.Name = "txtNombrePlato";
            txtNombrePlato.Size = new Size(170, 25);
            txtNombrePlato.TabIndex = 1;
            txtNombrePlato.Leave += txtNombrePlato_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 15);
            label1.Name = "label1";
            label1.Size = new Size(128, 17);
            label1.TabIndex = 8;
            label1.Text = "NOMBRE DEL PLATO";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(60, 283);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(132, 65);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 206);
            label2.Name = "label2";
            label2.Size = new Size(141, 17);
            label2.TabIndex = 10;
            label2.Text = "TIEMPO PREPARACION";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 226);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "(Minutos)";
            textBox1.Size = new Size(172, 25);
            textBox1.TabIndex = 11;
            // 
            // FormAltaPlato
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 360);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Controls.Add(txtNombrePlato);
            Controls.Add(groupBox1);
            Controls.Add(btnAddIngrediente);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtIngrediente);
            Controls.Add(lblIngrediente);
            Controls.Add(btnCancelar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAltaPlato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NUEVO PLATO";
            Load += FormAltaPlato_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Label lblIngrediente;
        private TextBox txtIngrediente;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Button btnAddIngrediente;
        private GroupBox groupBox1;
        private Label lblListaIngredientes;
        private TextBox txtNombrePlato;
        private Label label1;
        private Button btnAceptar;
        private Label label2;
        private TextBox textBox1;
    }
}