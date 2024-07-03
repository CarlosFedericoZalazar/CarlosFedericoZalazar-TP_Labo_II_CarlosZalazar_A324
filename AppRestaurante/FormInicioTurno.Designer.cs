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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioTurno));
            label1 = new Label();
            cbMeseros = new ComboBox();
            cbDeliverys = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cbCocineros = new ComboBox();
            btnMeseros = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            cbEncargado = new ComboBox();
            label4 = new Label();
            lbEnc = new Label();
            lvMe = new Label();
            lbDel = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 81);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "MESEROS";
            // 
            // cbMeseros
            // 
            cbMeseros.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMeseros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbMeseros.FormattingEnabled = true;
            cbMeseros.Location = new Point(30, 105);
            cbMeseros.Name = "cbMeseros";
            cbMeseros.Size = new Size(144, 29);
            cbMeseros.TabIndex = 3;
            // 
            // cbDeliverys
            // 
            cbDeliverys.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDeliverys.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbDeliverys.FormattingEnabled = true;
            cbDeliverys.Location = new Point(30, 172);
            cbDeliverys.Name = "cbDeliverys";
            cbDeliverys.Size = new Size(144, 29);
            cbDeliverys.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 148);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 3;
            label2.Text = "DELIVERYS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 217);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 4;
            label3.Text = "COCINERO";
            // 
            // cbCocineros
            // 
            cbCocineros.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCocineros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCocineros.FormattingEnabled = true;
            cbCocineros.Location = new Point(30, 241);
            cbCocineros.Name = "cbCocineros";
            cbCocineros.Size = new Size(144, 29);
            cbCocineros.TabIndex = 7;
            // 
            // btnMeseros
            // 
            btnMeseros.Location = new Point(210, 105);
            btnMeseros.Name = "btnMeseros";
            btnMeseros.Size = new Size(143, 29);
            btnMeseros.TabIndex = 4;
            btnMeseros.Text = "Agregar";
            btnMeseros.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(210, 172);
            button1.Name = "button1";
            button1.Size = new Size(143, 29);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(210, 241);
            button2.Name = "button2";
            button2.Size = new Size(143, 29);
            button2.TabIndex = 8;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(210, 46);
            button3.Name = "button3";
            button3.Size = new Size(143, 30);
            button3.TabIndex = 2;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // cbEncargado
            // 
            cbEncargado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEncargado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbEncargado.FormattingEnabled = true;
            cbEncargado.Location = new Point(30, 46);
            cbEncargado.Name = "cbEncargado";
            cbEncargado.Size = new Size(144, 29);
            cbEncargado.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 22);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 10;
            label4.Text = "ENCARGADO";
            // 
            // lbEnc
            // 
            lbEnc.AutoSize = true;
            lbEnc.Location = new Point(374, 52);
            lbEnc.Name = "lbEnc";
            lbEnc.Size = new Size(24, 17);
            lbEnc.TabIndex = 11;
            lbEnc.Text = "lv1";
            // 
            // lvMe
            // 
            lvMe.AutoSize = true;
            lvMe.Location = new Point(374, 111);
            lvMe.Name = "lvMe";
            lvMe.Size = new Size(24, 17);
            lvMe.TabIndex = 12;
            lvMe.Text = "lv2";
            // 
            // lbDel
            // 
            lbDel.AutoSize = true;
            lbDel.Location = new Point(374, 178);
            lbDel.Name = "lbDel";
            lbDel.Size = new Size(24, 17);
            lbDel.TabIndex = 13;
            lbDel.Text = "lv3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 247);
            label5.Name = "label5";
            label5.Size = new Size(24, 17);
            label5.TabIndex = 14;
            label5.Text = "lv4";
            // 
            // FormInicioTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(442, 319);
            Controls.Add(label5);
            Controls.Add(lbDel);
            Controls.Add(lvMe);
            Controls.Add(lbEnc);
            Controls.Add(cbEncargado);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnMeseros);
            Controls.Add(cbCocineros);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbDeliverys);
            Controls.Add(cbMeseros);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormInicioTurno";
            Text = "INICIO DEL TURNO";
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
        private Button button3;
        private ComboBox cbEncargado;
        private Label label4;
        private Label lbEnc;
        private Label lvMe;
        private Label lbDel;
        private Label label5;
    }
}