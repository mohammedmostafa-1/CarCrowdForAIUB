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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            Nissan n = new Nissan();
            // Show Form
            n.ShowDialog();
            //Dispose Form
            n = null;
            this.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            Toyota t = new Toyota();
            // Show Form
            t.ShowDialog();
            //Dispose Form
            t = null;
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            Chevrolet c = new Chevrolet();
            // Show Form
            c.ShowDialog();
            //Dispose Form
            c = null;
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            Honda h = new Honda();
            // Show Form
            h.ShowDialog();
            //Dispose Form
            h = null;
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            Ford f = new Ford();
            // Show Form
            f.ShowDialog();
            //Dispose Form
            f = null;
            this.Show();
        }
    }
}
