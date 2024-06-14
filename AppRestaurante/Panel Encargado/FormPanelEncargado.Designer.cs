namespace AppRestoForm
{
    partial class FormPanelEncargado
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
            btnPedidos = new Button();
            btnStock = new Button();
            btnGestionarEmpleado = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(53, 239);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(184, 57);
            btnPedidos.TabIndex = 3;
            btnPedidos.Text = "GESTION DE PEDIDOS";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(53, 141);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(184, 57);
            btnStock.TabIndex = 2;
            btnStock.Text = "REVISAR STOCK";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // btnGestionarEmpleado
            // 
            btnGestionarEmpleado.Location = new Point(53, 37);
            btnGestionarEmpleado.Name = "btnGestionarEmpleado";
            btnGestionarEmpleado.Size = new Size(184, 61);
            btnGestionarEmpleado.TabIndex = 1;
            btnGestionarEmpleado.Text = "GESTIONAR EMPLEADOS";
            btnGestionarEmpleado.UseVisualStyleBackColor = true;
            btnGestionarEmpleado.Click += btnGestionarEmpleado_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(218, 425);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormPanelEncargado
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnGestionarEmpleado);
            Controls.Add(btnStock);
            Controls.Add(btnPedidos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPanelEncargado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ENCARGADO";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPedidos;
        private Button btnStock;
        private Button btnGestionarEmpleado;
        private Button btnVolver;
    }
}