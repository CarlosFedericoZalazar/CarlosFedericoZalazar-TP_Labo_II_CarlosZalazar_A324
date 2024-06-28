namespace AppRestaurante.EntregasDelivery
{
    partial class FormDespachoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDespachoPedido));
            cbDelivery = new ComboBox();
            lblDeliveryNombre = new Label();
            btnLlevar = new Button();
            label1 = new Label();
            txtCosto = new TextBox();
            SuspendLayout();
            // 
            // cbDelivery
            // 
            cbDelivery.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDelivery.FormattingEnabled = true;
            cbDelivery.Location = new Point(12, 59);
            cbDelivery.Name = "cbDelivery";
            cbDelivery.Size = new Size(176, 25);
            cbDelivery.TabIndex = 0;
            // 
            // lblDeliveryNombre
            // 
            lblDeliveryNombre.AutoSize = true;
            lblDeliveryNombre.Location = new Point(12, 30);
            lblDeliveryNombre.Name = "lblDeliveryNombre";
            lblDeliveryNombre.Size = new Size(200, 17);
            lblDeliveryNombre.TabIndex = 1;
            lblDeliveryNombre.Text = "ENCARGADO DE LLEVAR PEDIDO";
            // 
            // btnLlevar
            // 
            btnLlevar.Location = new Point(151, 125);
            btnLlevar.Name = "btnLlevar";
            btnLlevar.Size = new Size(126, 57);
            btnLlevar.TabIndex = 2;
            btnLlevar.Text = "LLEVAR AL DOMICILIO";
            btnLlevar.UseVisualStyleBackColor = true;
            btnLlevar.Click += btnLlevar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 30);
            label1.Name = "label1";
            label1.Size = new Size(124, 17);
            label1.TabIndex = 3;
            label1.Text = "COSTO DEL PEDIDO";
            // 
            // txtCosto
            // 
            txtCosto.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCosto.Location = new Point(277, 50);
            txtCosto.Name = "txtCosto";
            txtCosto.ReadOnly = true;
            txtCosto.Size = new Size(147, 35);
            txtCosto.TabIndex = 4;
            // 
            // FormDespachoPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(452, 194);
            Controls.Add(txtCosto);
            Controls.Add(label1);
            Controls.Add(btnLlevar);
            Controls.Add(lblDeliveryNombre);
            Controls.Add(cbDelivery);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDespachoPedido";
            Text = "DESPACHO PEDIDO DELIVERY";
            Load += FormDespachoPedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDelivery;
        private Label lblDeliveryNombre;
        private Button btnLlevar;
        private Label label1;
        private TextBox txtCosto;
    }
}