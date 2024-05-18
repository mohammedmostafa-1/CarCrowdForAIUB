using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CarCrowd
{
    public partial class AdminLogin : Form
    {
        // Establish the connection string
        private SqlConnection connection = new SqlConnection("Data Source=MOOSE;Initial Catalog=CARCROWD;Integrated Security=True;");

        public AdminLogin()
        {
            InitializeComponent();
            // Ensure the button click event is associated with the correct event handler
            Loginguna2Button1.Click += new EventHandler(Loginguna2Button1_Click);
        }

        private void Loginguna2Button1_Click(object sender, EventArgs e)
        {/*
            string adminId = guna2TextBox1.Text;
            string adminPassword = guna2TextBox2.Text;
            string adminUsername = guna2TextBox3.Text;

            if (string.IsNullOrWhiteSpace(adminId) || adminId == "Enter Admin Id" ||
                string.IsNullOrWhiteSpace(adminPassword) || adminPassword == "Enter Admin Password" ||
                string.IsNullOrWhiteSpace(adminUsername) || adminUsername == "Enter Admin Username")
            {
                MessageBox.Show("Please enter your username, ID, and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM [ADMIN] WHERE adminid = @AdminId AND adminusername = @Username AND Password = @Password ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AdminId", adminId);
                command.Parameters.AddWithValue("@Password", adminPassword);
                command.Parameters.AddWithValue("@Username", adminUsername);

                int result = (int)command.ExecuteScalar();
                if (result > 0)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
                    // Hide the current form and show the admin panel
                    this.Hide();
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.ShowDialog();
              /*  }
                else
                {
                    MessageBox.Show("Invalid ID, username, or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(sqlEx.ToString()); // Log the exception for debugging
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString()); // Log the exception for debugging
            }
            finally
            {
                connection.Close();
            }*/
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = !guna2CheckBox1.Checked;
        }
    }
}
