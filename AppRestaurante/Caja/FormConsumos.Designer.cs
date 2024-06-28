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
            ((System.ComponentModel.ISupportInitialize)dgTickets).BeginInit();
            SuspendLayout();
            // 
            // dgTickets
            // 
            dgTickets.AllowUserToResizeRows = false;
            dgTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTickets.Location = new Point(38, 25);
            dgTickets.Name = "dgTickets";
            dgTickets.ReadOnly = true;
            dgTickets.RowHeadersVisible = false;
            dgTickets.RowTemplate.Height = 27;
            dgTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTickets.Size = new Size(808, 413);
            dgTickets.TabIndex = 0;
            // 
            // FormConsumos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 450);
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
        }

        #endregion

        private DataGridView dgTickets;
    }
}