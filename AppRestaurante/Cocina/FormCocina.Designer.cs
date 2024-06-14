namespace AppRestaurante.Cocina
{
    partial class FormCocina
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
            btnAddPlato = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnAddPlato
            // 
            btnAddPlato.Location = new Point(85, 72);
            btnAddPlato.Name = "btnAddPlato";
            btnAddPlato.Size = new Size(162, 56);
            btnAddPlato.TabIndex = 0;
            btnAddPlato.Text = "NUEVO PLATO";
            btnAddPlato.UseVisualStyleBackColor = true;
            btnAddPlato.Click += btnAddPlato_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(85, 254);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(154, 56);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormABMCartaRestaurant
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAddPlato);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormABMCartaRestaurant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMINISTRADOR DE CARTA RESTAURANT";
            Load += FormABMCartaRestaurant_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddPlato;
        private Button btnCancelar;
    }
}