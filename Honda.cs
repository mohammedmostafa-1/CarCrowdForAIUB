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
    public partial class Honda : Form
    {
        public Honda()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            HondaCivic HC = new HondaCivic();
            // Show Form
            HC.ShowDialog();
            //Dispose Form
            HC = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            HondaAccord ha = new HondaAccord();
            // Show Form
            ha.ShowDialog();
            //Dispose Form
            ha = null;
            this.Show();
        }
    }
}
