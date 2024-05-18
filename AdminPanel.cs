using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            // Display the list of users in the ListBox
            DisplayUserList();
        }

        private void DisplayUserList()
        { }
        private void BtnPaymentInfo_Click(object sender, EventArgs e)
        {
            // Get the selected user
            string selectedUser = listBoxUsers.SelectedItem as string;
            if (selectedUser == null || selectedUser.StartsWith("Username")) // Ensure a user is selected
            {
                MessageBox.Show("Please select a user to view payment information.");
                return;
            }

            // Extract the username from the selected string
            string[] userInfo = selectedUser.Split('\t');
            string username = userInfo[0].Trim();
        }

        private void btnCarInfo_Click(object sender, EventArgs e)
        {
            // Get the selected user
            string? selectedUser = listBoxUsers.SelectedItem as string;
            if (selectedUser == null || selectedUser.StartsWith("Username")) // Ensure a user is selected
            {
                MessageBox.Show("Please select a user to view car information.");
                return;
            }

            // Extract the username from the selected string
            string[] userInfo = selectedUser.Split('\t');
            string username = userInfo[0].Trim();

        }
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            //Hide current form when clicked
            this.Hide();
            //Create an Instance of Admin Login Form
            DealerManagement dealermanage = new DealerManagement();
            //Show Login Form
            dealermanage.ShowDialog();
        }
        private static void btnUserInfo_Click(object sender, EventArgs e, AdminPanel adminPanel)
        {
            adminPanel.Hide();
            //Create an Instance of Admin Login Form
            User user = new User();
            //Show Login Form
            user.ShowDialog();
        }

        private static void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private static void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void pictureBox2_Click(object sender, EventArgs e)
        {
            // Optional: Handle any additional click events for the picture box
        }

        private static void btnLogout_Click(object sender, EventArgs e)
        {
            // Exit the application gracefully
            Application.Exit();
        }
    }
}