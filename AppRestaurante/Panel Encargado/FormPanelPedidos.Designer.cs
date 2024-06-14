namespace AppRestaurante.Panel_Encargado
{
    partial class FormPanelPedidos
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
            btnProveedores = new Button();
            btnPedidos = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(57, 62);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(155, 52);
            btnProveedores.TabIndex = 0;
            btnProveedores.Text = "PROVEEDORES";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(57, 162);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(155, 52);
            btnPedidos.TabIndex = 1;
            btnPedidos.Text = "PEDIDOS";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(186, 396);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormPanelPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnPedidos);
            Controls.Add(btnProveedores);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPanelPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GESTOR DE PEDIDOS";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProveedores;
        private Button btnPedidos;
        private Button btnVolver;
    }
}