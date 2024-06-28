namespace AppRestaurante.Panel_Encargado
{
    partial class FormABMProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABMProveedor));
            btnAltaProveedor = new Button();
            btnBajaProveedor = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnAltaProveedor
            // 
            btnAltaProveedor.Location = new Point(49, 75);
            btnAltaProveedor.Name = "btnAltaProveedor";
            btnAltaProveedor.Size = new Size(149, 59);
            btnAltaProveedor.TabIndex = 0;
            btnAltaProveedor.Text = "ALTA PROVEEDOR";
            btnAltaProveedor.UseVisualStyleBackColor = true;
            btnAltaProveedor.Click += button1_Click;
            // 
            // btnBajaProveedor
            // 
            btnBajaProveedor.Location = new Point(49, 227);
            btnBajaProveedor.Name = "btnBajaProveedor";
            btnBajaProveedor.Size = new Size(149, 59);
            btnBajaProveedor.TabIndex = 1;
            btnBajaProveedor.Text = "BAJA PROVEEDOR";
            btnBajaProveedor.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(169, 386);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(81, 31);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormABMProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(253, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnBajaProveedor);
            Controls.Add(btnAltaProveedor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormABMProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GESTOR PROVEEDORES";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAltaProveedor;
        private Button btnBajaProveedor;
        private Button btnVolver;
    }
}