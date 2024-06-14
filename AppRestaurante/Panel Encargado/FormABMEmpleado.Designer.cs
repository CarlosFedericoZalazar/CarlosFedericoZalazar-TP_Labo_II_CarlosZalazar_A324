namespace AppRestaurante.Panel_Encargado
{
    partial class FormABMEmpleado
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
            btnAltaEmpleado = new Button();
            btnBaja = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnAltaEmpleado
            // 
            btnAltaEmpleado.Location = new Point(84, 64);
            btnAltaEmpleado.Name = "btnAltaEmpleado";
            btnAltaEmpleado.Size = new Size(141, 61);
            btnAltaEmpleado.TabIndex = 0;
            btnAltaEmpleado.Text = "ALTA EMPLEADO";
            btnAltaEmpleado.UseVisualStyleBackColor = true;
            btnAltaEmpleado.Click += btnAltaEmpleado_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(84, 207);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(141, 61);
            btnBaja.TabIndex = 1;
            btnBaja.Text = "BAJA EMPLEADO";
            btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(246, 428);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormABMEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnBaja);
            Controls.Add(btnAltaEmpleado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormABMEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PANEL EMPLEADOS";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAltaEmpleado;
        private Button btnBaja;
        private Button btnVolver;
    }
}