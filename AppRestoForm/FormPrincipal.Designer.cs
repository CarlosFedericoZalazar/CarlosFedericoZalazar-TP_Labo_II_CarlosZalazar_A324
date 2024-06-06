namespace AppRestoForm
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPedidos = new Button();
            btnSalon = new Button();
            SuspendLayout();
            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(71, 48);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(123, 56);
            btnPedidos.TabIndex = 0;
            btnPedidos.Text = "STOCK";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnSalon
            // 
            btnSalon.Location = new Point(71, 132);
            btnSalon.Name = "btnSalon";
            btnSalon.Size = new Size(123, 56);
            btnSalon.TabIndex = 1;
            btnSalon.Text = "SALON";
            btnSalon.UseVisualStyleBackColor = true;
            btnSalon.Click += btnSalon_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 450);
            Controls.Add(btnSalon);
            Controls.Add(btnPedidos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Restó App";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPedidos;
        private Button btnSalon;
    }
}
