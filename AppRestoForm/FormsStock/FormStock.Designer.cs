namespace AppRestoForm
{
    partial class StockForm
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
            btnHacerPedido = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnHacerPedido
            // 
            btnHacerPedido.Location = new Point(53, 124);
            btnHacerPedido.Name = "btnHacerPedido";
            btnHacerPedido.Size = new Size(184, 57);
            btnHacerPedido.TabIndex = 0;
            btnHacerPedido.Text = "REALIZAR PEDIDO";
            btnHacerPedido.UseVisualStyleBackColor = true;
            btnHacerPedido.Click += btnHacerPedido_Click;
            // 
            // button1
            // 
            button1.Location = new Point(53, 26);
            button1.Name = "button1";
            button1.Size = new Size(184, 57);
            button1.TabIndex = 1;
            button1.Text = "REVISAR STOCK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 450);
            Controls.Add(button1);
            Controls.Add(btnHacerPedido);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "STOCK";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHacerPedido;
        private Button button1;
    }
}