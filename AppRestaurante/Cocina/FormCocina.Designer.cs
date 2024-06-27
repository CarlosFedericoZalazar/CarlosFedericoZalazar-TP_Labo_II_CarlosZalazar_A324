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
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            btnConsultaMenu = new Button();
            bntMenuDisponible = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddPlato
            // 
            btnAddPlato.Location = new Point(37, 59);
            btnAddPlato.Name = "btnAddPlato";
            btnAddPlato.Size = new Size(162, 56);
            btnAddPlato.TabIndex = 0;
            btnAddPlato.Text = "NUEVO PLATO";
            btnAddPlato.UseVisualStyleBackColor = true;
            btnAddPlato.Click += btnAddPlato_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(370, 259);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(162, 56);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(37, 138);
            button1.Name = "button1";
            button1.Size = new Size(162, 56);
            button1.TabIndex = 4;
            button1.Text = "ELIMINAR PLATO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(37, 220);
            button2.Name = "button2";
            button2.Size = new Size(165, 56);
            button2.TabIndex = 5;
            button2.Text = "MODIFICAR PLATO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnAddPlato);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(47, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 318);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "ABM PLATOS";
            // 
            // btnConsultaMenu
            // 
            btnConsultaMenu.Location = new Point(370, 98);
            btnConsultaMenu.Name = "btnConsultaMenu";
            btnConsultaMenu.Size = new Size(162, 56);
            btnConsultaMenu.TabIndex = 7;
            btnConsultaMenu.Text = "CONSULTAS MENU POR INGREDIENTE";
            btnConsultaMenu.UseVisualStyleBackColor = true;
            btnConsultaMenu.Click += btnConsultaMenu_Click;
            // 
            // bntMenuDisponible
            // 
            bntMenuDisponible.Location = new Point(370, 177);
            bntMenuDisponible.Name = "bntMenuDisponible";
            bntMenuDisponible.Size = new Size(162, 56);
            bntMenuDisponible.TabIndex = 8;
            bntMenuDisponible.Text = "MENU DISPONIBLE";
            bntMenuDisponible.UseVisualStyleBackColor = true;
            // 
            // FormCocina
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(597, 377);
            Controls.Add(bntMenuDisponible);
            Controls.Add(btnConsultaMenu);
            Controls.Add(groupBox1);
            Controls.Add(btnCancelar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCocina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMINISTRADOR DE CARTA RESTAURANT";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddPlato;
        private Button btnCancelar;
        private BindingSource bindingSource1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Button btnConsultaMenu;
        private Button bntMenuDisponible;
    }
}