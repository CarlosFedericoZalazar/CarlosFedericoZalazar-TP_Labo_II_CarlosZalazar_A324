namespace AppRestaurante.Cocina
{
    partial class FormConsultaPlato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaPlato));
            txtBusqueda = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            lbPlatos = new ListBox();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // txtBusqueda
            // 
            txtBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBusqueda.Location = new Point(55, 74);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(221, 29);
            txtBusqueda.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 44);
            label1.Name = "label1";
            label1.Size = new Size(221, 21);
            label1.TabIndex = 1;
            label1.Text = "Ingrese Producto de Busqueda";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(108, 119);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(113, 46);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lbPlatos
            // 
            lbPlatos.FormattingEnabled = true;
            lbPlatos.ItemHeight = 17;
            lbPlatos.Location = new Point(313, 44);
            lbPlatos.Name = "lbPlatos";
            lbPlatos.Size = new Size(297, 276);
            lbPlatos.TabIndex = 3;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(519, 338);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(144, 34);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormConsultaPlato
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(675, 384);
            Controls.Add(btnVolver);
            Controls.Add(lbPlatos);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(txtBusqueda);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaPlato";
            Text = "BUSQUEDA PLATOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBusqueda;
        private Label label1;
        private Button btnBuscar;
        private ListBox lbPlatos;
        private Button btnVolver;
    }
}