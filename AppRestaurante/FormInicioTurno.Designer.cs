namespace AppRestaurante
{
    partial class FormInicioTurno
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
            label1 = new Label();
            cbMeseros = new ComboBox();
            cbDeliverys = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cbCocineros = new ComboBox();
            btnMeseros = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 45);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "MESEROS";
            // 
            // cbMeseros
            // 
            cbMeseros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMeseros.FormattingEnabled = true;
            cbMeseros.Location = new Point(33, 69);
            cbMeseros.Name = "cbMeseros";
            cbMeseros.Size = new Size(121, 29);
            cbMeseros.TabIndex = 1;
            // 
            // cbDeliverys
            // 
            cbDeliverys.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbDeliverys.FormattingEnabled = true;
            cbDeliverys.Location = new Point(33, 136);
            cbDeliverys.Name = "cbDeliverys";
            cbDeliverys.Size = new Size(121, 29);
            cbDeliverys.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 112);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 3;
            label2.Text = "DELIVERYS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 181);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 4;
            label3.Text = "COCINERO";
            // 
            // cbCocineros
            // 
            cbCocineros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCocineros.FormattingEnabled = true;
            cbCocineros.Location = new Point(33, 205);
            cbCocineros.Name = "cbCocineros";
            cbCocineros.Size = new Size(121, 29);
            cbCocineros.TabIndex = 5;
            // 
            // btnMeseros
            // 
            btnMeseros.Location = new Point(213, 69);
            btnMeseros.Name = "btnMeseros";
            btnMeseros.Size = new Size(143, 29);
            btnMeseros.TabIndex = 6;
            btnMeseros.Text = "Agregar";
            btnMeseros.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(213, 136);
            button1.Name = "button1";
            button1.Size = new Size(143, 29);
            button1.TabIndex = 7;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(213, 205);
            button2.Name = "button2";
            button2.Size = new Size(143, 29);
            button2.TabIndex = 8;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormInicioTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnMeseros);
            Controls.Add(cbCocineros);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbDeliverys);
            Controls.Add(cbMeseros);
            Controls.Add(label1);
            Name = "FormInicioTurno";
            Text = "FormInicioTurno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbMeseros;
        private ComboBox cbDeliverys;
        private Label label2;
        private Label label3;
        private ComboBox cbCocineros;
        private Button btnMeseros;
        private Button button1;
        private Button button2;
    }
}