using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCrowd

{
    partial class AdminPanel : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)        {

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AdminPanel));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnUserInfo = new Button();
            btnCarInfo = new Button();
            btnTransactions = new Button();
            btnDealerManagement = new Button();
            label2 = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            LoginLogo = new PictureBox();
            guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            Homepageguna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            ((ISupportInitialize)LoginLogo).BeginInit();
            SuspendLayout();
            // 
            // btnUserInfo
            // 
            btnUserInfo.BackColor = SystemColors.GrayText;
            btnUserInfo.Location = new Point(199, 268);
            btnUserInfo.Margin = new Padding(4, 3, 4, 3);
            btnUserInfo.Name = "btnUserInfo";
            btnUserInfo.Size = new Size(271, 50);
            btnUserInfo.TabIndex = 4;
            btnUserInfo.Text = "Manage User Information";
            btnUserInfo.UseVisualStyleBackColor = false;
            btnUserInfo.Click += btnUserInfo_Click;
            // 
            // btnCarInfo
            // 
            btnCarInfo.BackColor = SystemColors.GrayText;
            btnCarInfo.Location = new Point(199, 380);
            btnCarInfo.Margin = new Padding(4, 3, 4, 3);
            btnCarInfo.Name = "btnCarInfo";
            btnCarInfo.Size = new Size(271, 50);
            btnCarInfo.TabIndex = 5;
            btnCarInfo.Text = "Display Car Information";
            btnCarInfo.UseVisualStyleBackColor = false;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = SystemColors.GrayText;
            btnTransactions.Location = new Point(199, 436);
            btnTransactions.Margin = new Padding(4, 3, 4, 3);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(271, 50);
            btnTransactions.TabIndex = 7;
            btnTransactions.Text = "Show Transactions/Payment Details";
            btnTransactions.UseVisualStyleBackColor = false;
            // 
            // btnDealerManagement
            // 
            btnDealerManagement.BackColor = SystemColors.GrayText;
            btnDealerManagement.Location = new Point(199, 324);
            btnDealerManagement.Margin = new Padding(4, 3, 4, 3);
            btnDealerManagement.Name = "btnDealerManagement";
            btnDealerManagement.Size = new Size(271, 50);
            btnDealerManagement.TabIndex = 8;
            btnDealerManagement.Text = "Manage Dealer Information";
            btnDealerManagement.UseVisualStyleBackColor = false;
            btnDealerManagement.UseWaitCursor = true;
            btnDealerManagement.Click += btnLogout_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(304, 187);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 39);
            label2.TabIndex = 14;
            label2.Text = "ADMIN";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackColor = Color.Transparent;
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(199, 65);
            guna2CirclePictureBox1.Margin = new Padding(4, 3, 4, 3);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(112, 113);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 16;
            guna2CirclePictureBox1.TabStop = false;
            guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // LoginLogo
            // 
            LoginLogo.BackgroundImageLayout = ImageLayout.None;
            LoginLogo.Image = (Image)resources.GetObject("LoginLogo.Image");
            LoginLogo.Location = new Point(256, 45);
            LoginLogo.Margin = new Padding(4, 3, 4, 3);
            LoginLogo.Name = "LoginLogo";
            LoginLogo.Size = new Size(289, 164);
            LoginLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            LoginLogo.TabIndex = 15;
            LoginLogo.TabStop = false;
            // 
            // guna2GradientPanel2
            // 
            guna2GradientPanel2.BackColor = Color.White;
            guna2GradientPanel2.CustomizableEdges = customizableEdges2;
            guna2GradientPanel2.Location = new Point(578, 4);
            guna2GradientPanel2.Margin = new Padding(4, 3, 4, 3);
            guna2GradientPanel2.Name = "guna2GradientPanel2";
            guna2GradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2GradientPanel2.Size = new Size(4, 52);
            guna2GradientPanel2.TabIndex = 17;
            // 
            // Homepageguna2Button1
            // 
            Homepageguna2Button1.Animated = true;
            Homepageguna2Button1.AutoRoundedCorners = true;
            Homepageguna2Button1.BackColor = Color.Transparent;
            Homepageguna2Button1.BorderColor = Color.Transparent;
            Homepageguna2Button1.BorderRadius = 25;
            Homepageguna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            Homepageguna2Button1.BorderThickness = 20;
            Homepageguna2Button1.CustomizableEdges = customizableEdges4;
            Homepageguna2Button1.DisabledState.BorderColor = Color.DarkGray;
            Homepageguna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            Homepageguna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Homepageguna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Homepageguna2Button1.FillColor = Color.Transparent;
            Homepageguna2Button1.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Homepageguna2Button1.ForeColor = Color.White;
            Homepageguna2Button1.Location = new Point(572, 6);
            Homepageguna2Button1.Margin = new Padding(4, 3, 4, 3);
            Homepageguna2Button1.Name = "Homepageguna2Button1";
            Homepageguna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            Homepageguna2Button1.Size = new Size(107, 52);
            Homepageguna2Button1.TabIndex = 19;
            Homepageguna2Button1.Text = " Logout       ";
            Homepageguna2Button1.TextAlign = HorizontalAlignment.Left;
            Homepageguna2Button1.TextFormatNoPrefix = true;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(684, 561);
            Controls.Add(guna2GradientPanel2);
            Controls.Add(Homepageguna2Button1);
            Controls.Add(label2);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(LoginLogo);
            Controls.Add(btnDealerManagement);
            Controls.Add(btnTransactions);
            Controls.Add(btnCarInfo);
            Controls.Add(btnUserInfo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ((ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ((ISupportInitialize)LoginLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Button btnCarInfo;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnPaymentInfo;
        private System.Windows.Forms.Button btnTransactionDetails;
        private System.Windows.Forms.Button Logout;
        private EventHandler btnPaymentInfo_Click;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private PictureBox LoginLogo;
        private Button btnTransactions;
        private Button btnDealerManagement;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2Button Homepageguna2Button1;
    }
}

