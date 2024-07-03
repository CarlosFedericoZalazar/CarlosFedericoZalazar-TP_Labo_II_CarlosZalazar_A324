namespace AppRestaurante.Caja
{
    partial class FormConsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsumos));
            dgTickets = new DataGridView();
            cbEmpleados = new ComboBox();
            label1 = new Label();
            cbMedioPago = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgTickets).BeginInit();
            SuspendLayout();
            // 
            // dgTickets
            // 
            dgTickets.AllowUserToResizeRows = false;
            dgTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTickets.Location = new Point(38, 87);
            dgTickets.Name = "dgTickets";
            dgTickets.ReadOnly = true;
            dgTickets.RowHeadersVisible = false;
            dgTickets.RowTemplate.Height = 27;
            dgTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTickets.Size = new Size(808, 351);
            dgTickets.TabIndex = 0;
            // 
            // cbEmpleados
            // 
            cbEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbEmpleados.FormattingEnabled = true;
            cbEmpleados.Location = new Point(37, 47);
            cbEmpleados.Name = "cbEmpleados";
            cbEmpleados.Size = new Size(157, 29);
            cbEmpleados.TabIndex = 1;
            cbEmpleados.SelectedValueChanged += cbEmpleados_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 23);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 2;
            label1.Text = "EMPLEADOS";
            // 
            // cbMedioPago
            // 
            cbMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMedioPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMedioPago.FormattingEnabled = true;
            cbMedioPago.Location = new Point(242, 47);
            cbMedioPago.Name = "cbMedioPago";
            cbMedioPago.Size = new Size(138, 29);
            cbMedioPago.TabIndex = 3;
            cbMedioPago.SelectedValueChanged += cbMedioPago_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(242, 23);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 4;
            label2.Text = "MEDIO DE PAGO";
            // 
            // FormConsumos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 450);
            Controls.Add(label2);
            Controls.Add(cbMedioPago);
            Controls.Add(label1);
            Controls.Add(cbEmpleados);
            Controls.Add(dgTickets);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsumos";
            Text = "CONSUMOS";
            Load += FormConsumos_Load;
            ((System.ComponentModel.ISupportInitialize)dgTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgTickets;
        private ComboBox cbEmpleados;
        private Label label1;
        private ComboBox cbMedioPago;
        private Label label2;
    }
}