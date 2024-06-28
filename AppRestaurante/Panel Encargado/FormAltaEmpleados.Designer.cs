namespace AppRestaurante.Panel_Encargado
{
    partial class FormAltaEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaEmpleados));
            cbPerfilEmpleado = new ComboBox();
            button1 = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblSueldo = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtSueldo = new TextBox();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cbPerfilEmpleado
            // 
            cbPerfilEmpleado.FormattingEnabled = true;
            cbPerfilEmpleado.Location = new Point(56, 33);
            cbPerfilEmpleado.Name = "cbPerfilEmpleado";
            cbPerfilEmpleado.Size = new Size(127, 25);
            cbPerfilEmpleado.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(249, 191);
            button1.Name = "button1";
            button1.Size = new Size(190, 68);
            button1.TabIndex = 1;
            button1.Text = "CREAR EMPLEADO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(56, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 17);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "NOMBRE";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(249, 70);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(64, 17);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "APELLIDO";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(56, 131);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(74, 17);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "DIRECCION";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(56, 188);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(71, 17);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "TELEFONO";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(56, 242);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(56, 17);
            lblSueldo.TabIndex = 6;
            lblSueldo.Text = "SUELDO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 13);
            label5.Name = "label5";
            label5.Size = new Size(96, 17);
            label5.TabIndex = 7;
            label5.Text = "TIPO DE PERFIL";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(56, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 25);
            txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(249, 90);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(160, 25);
            txtApellido.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(56, 151);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Calle - Nro - Ciudad";
            txtDireccion.Size = new Size(353, 25);
            txtDireccion.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(56, 208);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "XX-XXXX-XXXX";
            txtTelefono.Size = new Size(160, 25);
            txtTelefono.TabIndex = 11;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(56, 262);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(160, 25);
            txtSueldo.TabIndex = 12;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(249, 274);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(190, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAltaEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 332);
            Controls.Add(btnCancelar);
            Controls.Add(txtSueldo);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(lblSueldo);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(button1);
            Controls.Add(cbPerfilEmpleado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAltaEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GESTION DE EMPLEADOS";
            Load += FormGestionEmpleados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbPerfilEmpleado;
        private Button button1;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblSueldo;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtSueldo;
        private Button btnCancelar;
    }
}