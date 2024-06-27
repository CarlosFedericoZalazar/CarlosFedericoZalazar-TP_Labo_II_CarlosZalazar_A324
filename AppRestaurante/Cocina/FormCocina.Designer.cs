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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCocina));
            btnAddPlato = new Button();
            btnCancelar = new Button();
            bindingSource1 = new BindingSource(components);
            btnMenu = new Button();
            comboBox1 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnAddPlato
            // 
            btnAddPlato.Location = new Point(62, 38);
            btnAddPlato.Name = "btnAddPlato";
            btnAddPlato.Size = new Size(162, 56);
            btnAddPlato.TabIndex = 0;
            btnAddPlato.Text = "NUEVO PLATO";
            btnAddPlato.UseVisualStyleBackColor = true;
            btnAddPlato.Click += btnAddPlato_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(62, 348);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 56);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(62, 249);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(162, 56);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "VER MENU";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(365, 360);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 25);
            comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(62, 117);
            button1.Name = "button1";
            button1.Size = new Size(162, 56);
            button1.TabIndex = 4;
            button1.Text = "ELIMINAR PLATO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormCocina
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 541);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(btnMenu);
            Controls.Add(btnCancelar);
            Controls.Add(btnAddPlato);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCocina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMINISTRADOR DE CARTA RESTAURANT";
            Load += FormABMCartaRestaurant_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddPlato;
        private Button btnCancelar;
        private BindingSource bindingSource1;
        private Button btnMenu;
        private ComboBox comboBox1;
        private Button button1;
    }
}