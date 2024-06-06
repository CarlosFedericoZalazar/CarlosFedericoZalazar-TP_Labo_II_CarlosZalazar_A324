namespace AppRestoForm.FormsSalon
{
    partial class FormMesa
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
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(73, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 25);
            comboBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(431, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 348);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orden:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 33);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(266, 52);
            button1.Name = "button1";
            button1.Size = new Size(112, 56);
            button1.TabIndex = 2;
            button1.Text = "AGREGAR ORDEN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 25);
            comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(6, 123);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(133, 25);
            comboBox3.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Location = new Point(73, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(184, 169);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "BEBIDAS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 103);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 5;
            label2.Text = "Alcoholicas";
            // 
            // button2
            // 
            button2.Location = new Point(482, 375);
            button2.Name = "button2";
            button2.Size = new Size(145, 47);
            button2.TabIndex = 6;
            button2.Text = "ENVIAR A COCINA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormMesa
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 450);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Name = "FormMesa";
            Text = "FormMesa";
            Load += FormMesa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Button button1;
        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private GroupBox groupBox2;
        private Label label2;
        private Button button2;
    }
}