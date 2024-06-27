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
            button1 = new Button();
            btnBajaPlato = new Button();
            SuspendLayout();
            // 
            // lbPlatos
            // 
            lbPlatos.FormattingEnabled = true;
            lbPlatos.ItemHeight = 17;
            lbPlatos.Location = new Point(425, 58);
            lbPlatos.Name = "lbPlatos";
            lbPlatos.Size = new Size(259, 259);
            lbPlatos.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(172, 143);
            button1.Name = "button1";
            button1.Size = new Size(189, 57);
            button1.TabIndex = 1;
            button1.Text = "PRUEBA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnBajaPlato
            // 
            btnBajaPlato.Location = new Point(488, 336);
            btnBajaPlato.Name = "btnBajaPlato";
            btnBajaPlato.Size = new Size(158, 39);
            btnBajaPlato.TabIndex = 2;
            btnBajaPlato.Text = "ELIMNAR PLATO";
            btnBajaPlato.UseVisualStyleBackColor = true;
            btnBajaPlato.Click += btnBajaPlato_Click;
            // 
            // FormBajaPlato
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBajaPlato);
            Controls.Add(button1);
            Controls.Add(lbPlatos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBajaPlato";
            Text = "BAJA PLATO";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbPlatos;
        private Button button1;
        private Button btnBajaPlato;
    }
}