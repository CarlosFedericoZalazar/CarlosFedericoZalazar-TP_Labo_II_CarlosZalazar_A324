namespace AppRestaurante.Cocina
{
    partial class FormMenuDisponible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuDisponible));
            lbMenu = new ListBox();
            label1 = new Label();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lbMenu
            // 
            lbMenu.FormattingEnabled = true;
            lbMenu.ItemHeight = 17;
            lbMenu.Location = new Point(35, 56);
            lbMenu.Name = "lbMenu";
            lbMenu.Size = new Size(287, 310);
            lbMenu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 23);
            label1.Name = "label1";
            label1.Size = new Size(194, 30);
            label1.TabIndex = 1;
            label1.Text = "MENU DISPONIBLE";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(112, 387);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(136, 51);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormMenuDisponible
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(364, 450);
            Controls.Add(btnVolver);
            Controls.Add(label1);
            Controls.Add(lbMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenuDisponible";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU DISPONIBLE";
            Load += FormMenuDisponible_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbMenu;
        private Label label1;
        private Button btnVolver;
    }
}