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
    public partial class NissanAltima : Form
    {
        public NissanAltima()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hide current form when clicked
            this.Hide();
            //Create an Instance of another Form
            Payment p = new Payment();
            //Show another Form
            p.ShowDialog();
            //Dispose Form
            p = null;
            this.Show();
        }

        private void NissanAltima_Load(object sender, EventArgs e)
        {

        }
    }
}
