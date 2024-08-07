﻿namespace AppRestaurante.Cocina
{
    partial class FormModificarPlato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarPlato));
            lbPlatos = new ListBox();
            cbIngredientes = new ComboBox();
            txtIngrediente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCantidad = new TextBox();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // lbPlatos
            // 
            lbPlatos.FormattingEnabled = true;
            lbPlatos.ItemHeight = 17;
            lbPlatos.Location = new Point(24, 36);
            lbPlatos.Name = "lbPlatos";
            lbPlatos.Size = new Size(286, 276);
            lbPlatos.TabIndex = 0;
            lbPlatos.SelectedValueChanged += lbPlatos_SelectedValueChanged_1;
            // 
            // cbIngredientes
            // 
            cbIngredientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIngredientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbIngredientes.FormattingEnabled = true;
            cbIngredientes.Location = new Point(379, 36);
            cbIngredientes.Name = "cbIngredientes";
            cbIngredientes.Size = new Size(121, 29);
            cbIngredientes.TabIndex = 1;
            cbIngredientes.SelectedValueChanged += cbIngredientes_SelectedValueChanged;
            // 
            // txtIngrediente
            // 
            txtIngrediente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIngrediente.Location = new Point(359, 123);
            txtIngrediente.Name = "txtIngrediente";
            txtIngrediente.Size = new Size(155, 29);
            txtIngrediente.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(357, 99);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 3;
            label1.Text = "INGREDIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(359, 177);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 4;
            label2.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.Location = new Point(359, 201);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(91, 29);
            txtCantidad.TabIndex = 5;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.Location = new Point(359, 268);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(132, 44);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "MODIFICAR VALORES";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // FormModificarPlato
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 343);
            Controls.Add(btnModificar);
            Controls.Add(txtCantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIngrediente);
            Controls.Add(cbIngredientes);
            Controls.Add(lbPlatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormModificarPlato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MODIFICAR PLATO";
            Load += FormModificarPlato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbPlatos;
        private ComboBox cbIngredientes;
        private TextBox txtIngrediente;
        private Label label1;
        private Label label2;
        private TextBox txtCantidad;
        private Button btnModificar;
    }
}