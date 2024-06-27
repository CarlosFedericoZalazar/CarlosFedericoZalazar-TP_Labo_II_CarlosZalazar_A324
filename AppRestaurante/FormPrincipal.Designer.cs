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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            btnPanelEncargado = new Button();
            btnSalon = new Button();
            btnCocina = new Button();
            SuspendLayout();
            // 
            // btnPanelEncargado
            // 
            btnPanelEncargado.Location = new Point(71, 48);
            btnPanelEncargado.Name = "btnPanelEncargado";
            btnPanelEncargado.Size = new Size(123, 56);
            btnPanelEncargado.TabIndex = 0;
            btnPanelEncargado.Text = "PANEL ENCARGADO";
            btnPanelEncargado.UseVisualStyleBackColor = true;
            btnPanelEncargado.Click += btnPanelEncargado_Click;
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
            // btnCocina
            // 
            btnCocina.Location = new Point(71, 223);
            btnCocina.Name = "btnCocina";
            btnCocina.Size = new Size(123, 56);
            btnCocina.TabIndex = 2;
            btnCocina.Text = "COCINA";
            btnCocina.UseVisualStyleBackColor = true;
            btnCocina.Click += btnCocina_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(267, 450);
            Controls.Add(btnCocina);
            Controls.Add(btnSalon);
            Controls.Add(btnPanelEncargado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RESTAURANT UTN";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPanelEncargado;
        private Button btnSalon;
        private Button btnCocina;
    }
}
