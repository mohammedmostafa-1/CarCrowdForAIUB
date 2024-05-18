using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarCrowd
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1.Enter += new System.EventHandler(this.guna2TextBox1_Enter);
            this.guna2TextBox1.Leave += new System.EventHandler(this.guna2TextBox1_Leave);
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.guna2TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guna2TextBox1_KeyDown);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Text = "Search model, manufacturer, or mileage";
            this.guna2TextBox1.ForeColor = Color.FromArgb(125, 137, 149);
            // 
            // MyForm
            // 
            this.Controls.Add(this.guna2TextBox1);
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
        }

        private void Homepagelabel1_Click(object sender, EventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            Homepagelabel1.Parent = HomepagepictureBox2;
            Homepagelabel1.BackColor = Color.Transparent;

            Homepagelabel2.Parent = HomepagepictureBox2;
            Homepagelabel2.BackColor = Color.Transparent;
            HomepageSearchguna2TextBox1.Parent = HomepagepictureBox2;
        }

        private void Homepagelabel2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Homepageguna2Button1_Click(object sender, EventArgs e)
        {
            //Hide current form when clicked
            this.Hide();
            //Create an Instance of Login Form
            Login login = new Login();
            //Show Login Form
            login.ShowDialog();
            //Dispose Form
            login = null;
            this.Show();
        }
        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "Search model, manufacturer, or mileage")
            {
                guna2TextBox1.Text = "";
                guna2TextBox1.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                guna2TextBox1.Text = "Search model, manufacturer, or mileage";
                guna2TextBox1.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "Search model, manufacturer, or mileage")
            {
                guna2TextBox1.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                guna2TextBox1.ForeColor = Color.Black;
            }
            else if (e.Control && e.KeyCode == Keys.X)
            {
                guna2TextBox1.ForeColor = Color.Black;
            }
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            guna2TextBox1.ForeColor = Color.FromArgb(125, 137, 149);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Hide current form when clicked
            this.Hide();
            //Create an Instance of Form
            BMW carpage1 = new BMW();
            //Show Form
            carpage1.ShowDialog();
            //Dispose Form
            carpage1 = null;
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Hide current form when clicked
            this.Hide();
            //Create an Instance of Form
            Mercedes carpage2 = new Mercedes();
            //Show Form
            carpage2.ShowDialog();
            //Dispose Form
            carpage2 = null;
            this.Show();
        }
        /*
private void guna2TextBox1_Enter(object sender, EventArgs e)
{
if (guna2TextBox1.Text  == "Search model, manufacturer,  or mileage") { guna2TextBox1.Text = ""; guna2TextBox1.ForeColor = Color.Black; }
}

private void guna2TextBox1_Leave(object sender, EventArgs e)
{
if (guna2TextBox1.Text == "")
{
guna2TextBox1.Text = "Search model, manufacturer, or mileage";
guna2TextBox1.ForeColor = Color.FromArgb(125, 137, 149);
}
}*/
    }
}
