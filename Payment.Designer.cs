namespace CarCrowd
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            HomepagepictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)HomepagepictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(228, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(462, 50);
            label1.TabIndex = 32;
            label1.Text = "PROCEED TO PAYMENT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(43, 119);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 33;
            label5.Text = "Payment ID:";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 174);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 34;
            label2.Text = "Transaction ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 230);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 35;
            label3.Text = "Payment Method:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 285);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 36;
            label4.Text = "Amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(43, 343);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 37;
            label6.Text = "Date Paid:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 393);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 38;
            label7.Text = "Amount:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 23);
            textBox1.TabIndex = 39;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(357, 23);
            textBox2.TabIndex = 40;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(231, 343);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(357, 23);
            textBox3.TabIndex = 41;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(231, 390);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(357, 23);
            textBox4.TabIndex = 42;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(231, 282);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(357, 23);
            textBox5.TabIndex = 43;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(223, 229);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 44;
            radioButton1.TabStop = true;
            radioButton1.Text = "PayPal";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(309, 229);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(52, 19);
            radioButton2.TabIndex = 45;
            radioButton2.TabStop = true;
            radioButton2.Text = "Cash";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = SystemColors.ButtonHighlight;
            radioButton3.Location = new Point(376, 229);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(104, 19);
            radioButton3.TabIndex = 46;
            radioButton3.TabStop = true;
            radioButton3.Text = "Bank Transfer";
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton4.ForeColor = SystemColors.ButtonHighlight;
            radioButton4.Location = new Point(498, 229);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(90, 19);
            radioButton4.TabIndex = 47;
            radioButton4.TabStop = true;
            radioButton4.Text = "Credit Card";
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GrayText;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(376, 459);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(239, 33);
            button1.TabIndex = 48;
            button1.Text = "Confirm Payment";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HomepagepictureBox1
            // 
            HomepagepictureBox1.Image = (Image)resources.GetObject("HomepagepictureBox1.Image");
            HomepagepictureBox1.Location = new Point(634, 155);
            HomepagepictureBox1.Margin = new Padding(4, 3, 4, 3);
            HomepagepictureBox1.Name = "HomepagepictureBox1";
            HomepagepictureBox1.Size = new Size(318, 224);
            HomepagepictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            HomepagepictureBox1.TabIndex = 49;
            HomepagepictureBox1.TabStop = false;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1005, 561);
            Controls.Add(HomepagepictureBox1);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Payment";
            Text = "Purchase your car!";
            ((System.ComponentModel.ISupportInitialize)HomepagepictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
        private PictureBox HomepagepictureBox1;
    }
}