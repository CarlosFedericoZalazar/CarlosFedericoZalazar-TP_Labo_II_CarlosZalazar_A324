namespace AppRestaurante.Panel_Encargado
{
    partial class FormBajaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBajaEmpleado));
            cbEmplados = new ComboBox();
            lbEmpleados = new Label();
            cbEmpleados = new ComboBox();
            label1 = new Label();
            btnBaja = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cbEmplados
            // 
            cbEmplados.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmplados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbEmplados.FormattingEnabled = true;
            cbEmplados.Location = new Point(28, 57);
            cbEmplados.Name = "cbEmplados";
            cbEmplados.Size = new Size(151, 29);
            cbEmplados.TabIndex = 0;
            cbEmplados.SelectedValueChanged += cbEmplados_SelectedValueChanged;
            // 
            // lbEmpleados
            // 
            lbEmpleados.AutoSize = true;
            lbEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmpleados.Location = new Point(28, 33);
            lbEmpleados.Name = "lbEmpleados";
            lbEmpleados.Size = new Size(99, 21);
            lbEmpleados.TabIndex = 1;
            lbEmpleados.Text = "EMPLEADOS";
            // 
            // cbEmpleados
            // 
            cbEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbEmpleados.FormattingEnabled = true;
            cbEmpleados.Location = new Point(230, 57);
            cbEmpleados.Name = "cbEmpleados";
            cbEmpleados.Size = new Size(180, 29);
            cbEmpleados.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(230, 33);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 3;
            label1.Text = "NOMBRE";
            // 
            // btnBaja
            // 
            btnBaja.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBaja.Location = new Point(230, 127);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(123, 45);
            btnBaja.TabIndex = 4;
            btnBaja.Text = "ELIMINAR EMPLEADO";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(56, 126);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 46);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormBajaEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 184);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnBaja);
            Controls.Add(label1);
            Controls.Add(cbEmpleados);
            Controls.Add(lbEmpleados);
            Controls.Add(cbEmplados);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBajaEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BAJA EMPLEADO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbEmplados;
        private Label lbEmpleados;
        private ComboBox cbEmpleados;
        private Label label1;
        private Button btnBaja;
        private Button btnCancelar;
    }
}