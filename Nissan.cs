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
    public partial class Nissan : Form
    {
        public Nissan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            NissanSentra ns = new NissanSentra();
            // Show Form
            ns.ShowDialog();
            //Dispose Form
            ns = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            NissanAltima na = new NissanAltima();
            // Show Form
            na.ShowDialog();
            //Dispose Form
            na = null;
            this.Show();
        }

        private void Nissan_Load(object sender, EventArgs e)
        {

        }
    }
}
