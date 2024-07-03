namespace AppRestaurante.EntregasDelivery
{
    partial class FormPedidoTelefonico
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
            txtNombre = new TextBox();
            lvlClientel = new Label();
            lvlDireccion = new Label();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cbMenu
            // 
            cbMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMenu.FormattingEnabled = true;
            cbMenu.Location = new Point(308, 47);
            cbMenu.Name = "cbMenu";
            cbMenu.Size = new Size(227, 29);
            cbMenu.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(34, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "nombre";
            txtNombre.Size = new Size(163, 29);
            txtNombre.TabIndex = 1;
            // 
            // lvlClientel
            // 
            lvlClientel.AutoSize = true;
            lvlClientel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvlClientel.Location = new Point(34, 26);
            lvlClientel.Name = "lvlClientel";
            lvlClientel.Size = new Size(137, 21);
            lvlClientel.TabIndex = 2;
            lvlClientel.Text = "NOMBRE CLIENTE";
            // 
            // lvlDireccion
            // 
            lvlDireccion.AutoSize = true;
            lvlDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvlDireccion.Location = new Point(34, 93);
            lvlDireccion.Name = "lvlDireccion";
            lvlDireccion.Size = new Size(91, 21);
            lvlDireccion.TabIndex = 3;
            lvlDireccion.Text = "DIRECCION";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.Location = new Point(34, 117);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Calle - Nro - e\\calles";
            txtDireccion.Size = new Size(244, 29);
            txtDireccion.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(34, 188);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "celular";
            txtTelefono.Size = new Size(137, 29);
            txtTelefono.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 164);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 6;
            label1.Text = "TELEFONO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(308, 23);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 7;
            label2.Text = "MENU DISPONIBLE";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(349, 82);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(145, 32);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "AGREGAR AL PEDIDO";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(287, 280);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(113, 49);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "CONFIRMAR PEDIDO";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(114, 280);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 49);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormPedidoTelefonico
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(574, 356);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(lvlDireccion);
            Controls.Add(lvlClientel);
            Controls.Add(txtNombre);
            Controls.Add(cbMenu);
            Name = "FormPedidoTelefonico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PedidoTelefonico";
            Load += FormPedidoTelefonico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMenu;
        private TextBox txtNombre;
        private Label lvlClientel;
        private Label lvlDireccion;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Label label1;
        private Label label2;
        private Button btnAgregar;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}