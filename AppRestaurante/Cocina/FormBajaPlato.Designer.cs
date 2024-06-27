namespace AppRestaurante.Cocina
{
    partial class FormBajaPlato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBajaPlato));
            lbPlatos = new ListBox();
            btnBajaPlato = new Button();
            btnCocina = new Button();
            SuspendLayout();
            // 
            // lbPlatos
            // 
            lbPlatos.FormattingEnabled = true;
            lbPlatos.ItemHeight = 17;
            lbPlatos.Location = new Point(46, 26);
            lbPlatos.Name = "lbPlatos";
            lbPlatos.Size = new Size(259, 259);
            lbPlatos.TabIndex = 0;
            // 
            // btnBajaPlato
            // 
            btnBajaPlato.Location = new Point(357, 26);
            btnBajaPlato.Name = "btnBajaPlato";
            btnBajaPlato.Size = new Size(158, 39);
            btnBajaPlato.TabIndex = 2;
            btnBajaPlato.Text = "ELIMNAR PLATO";
            btnBajaPlato.UseVisualStyleBackColor = true;
            btnBajaPlato.Click += btnBajaPlato_Click;
            // 
            // btnCocina
            // 
            btnCocina.Location = new Point(97, 329);
            btnCocina.Name = "btnCocina";
            btnCocina.Size = new Size(158, 39);
            btnCocina.TabIndex = 3;
            btnCocina.Text = "PANEL COCINERO";
            btnCocina.UseVisualStyleBackColor = true;
            btnCocina.Click += btnCocina_Click;
            // 
            // FormBajaPlato
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(583, 450);
            Controls.Add(btnCocina);
            Controls.Add(btnBajaPlato);
            Controls.Add(lbPlatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBajaPlato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BAJA PLATO";
            Load += FormBajaPlato_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbPlatos;
        private Button btnBajaPlato;
        private Button btnCocina;
    }
}