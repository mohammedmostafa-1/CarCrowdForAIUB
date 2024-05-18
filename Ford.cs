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
    public partial class Ford : Form
    {
        public Ford()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            FordFusion fu = new FordFusion();
            // Show Form
            fu.ShowDialog();
            //Dispose Form
            fu = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            FordFocus ff = new FordFocus();
            // Show Form
            ff.ShowDialog();
            //Dispose Form
            ff = null;
            this.Show();
        }
    }
}
