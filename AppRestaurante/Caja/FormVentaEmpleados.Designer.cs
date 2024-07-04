namespace AppRestaurante.Caja
{
    partial class FormVentaEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentaEmpleados));
            dgVentas = new DataGridView();
            label1 = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgVentas).BeginInit();
            SuspendLayout();
            // 
            // dgVentas
            // 
            dgVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVentas.Location = new Point(56, 74);
            dgVentas.Name = "dgVentas";
            dgVentas.RowHeadersVisible = false;
            dgVentas.RowTemplate.Height = 27;
            dgVentas.Size = new Size(288, 134);
            dgVentas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 54);
            label1.Name = "label1";
            label1.Size = new Size(128, 17);
            label1.TabIndex = 1;
            label1.Text = "TOP 3 VENDEDORES";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(109, 243);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(176, 40);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormVentaEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(411, 311);
            ControlBox = false;
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(dgVentas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVentaEmpleados";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VENTA EMPLEADOS";
            Load += FormVentaEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgVentas;
        private Label label1;
        private Button btnVolver;
    }
}