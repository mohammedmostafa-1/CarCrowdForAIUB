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
    public partial class Toyota : Form
    {
        public Toyota()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            ToyotaCamry tc = new ToyotaCamry();
            // Show Form
            tc.ShowDialog();
            //Dispose Form
            tc = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            ToyotaCorolla tcl = new ToyotaCorolla();
            // Show Form
            tcl.ShowDialog();
            //Dispose Form
            tcl = null;
            this.Show();
        }
    }
}
