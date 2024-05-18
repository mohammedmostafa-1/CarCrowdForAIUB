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
    public partial class Chevrolet : Form
    {
        public Chevrolet()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            ChevroletMalibu cm = new ChevroletMalibu();
            // Show Form
            cm.ShowDialog();
            //Dispose Form
            cm = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            ChevroletCruze cc = new ChevroletCruze();
            // Show Form
            cc.ShowDialog();
            //Dispose Form
            cc = null;
            this.Show();
        }

        private void Chevrolet_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
