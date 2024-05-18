using System.Data.SqlClient;
namespace CarCrowd
{
    public partial class Login : Form
    {
        // Establish using address
        SqlConnection connection = new SqlConnection("Data Source=MOOSE;Initial Catalog=CARCROWD;Integrated Security=True;");
        public Login()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Ensure guna2TextBox2 is masked by default
            guna2TextBox2.UseSystemPasswordChar = true;

            // Subscribe to the CheckedChanged event of guna2CheckBox1
            guna2CheckBox1.CheckedChanged += guna2CheckBox1_CheckedChanged;


            // Set default text and color for guna2TextBox1
            guna2TextBox1.Text = "Email Address";
            guna2TextBox1.ForeColor = Color.Silver;

            // Subscribe to the Enter and Leave events of guna2TextBox1
            guna2TextBox1.Enter += guna2TextBox1_Enter;
            guna2TextBox1.Leave += guna2TextBox1_Leave;

            // Subscribe to the Enter and Leave events of guna2TextBox2
            guna2TextBox2.Enter += guna2TextBox2_Enter;
            guna2TextBox2.Leave += guna2TextBox2_Leave;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string email = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;

            if (string.IsNullOrWhiteSpace(email) || email == "Email Address" || string.IsNullOrWhiteSpace(password) || password == "Password")
            {
                MessageBox.Show("Please enter your email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM [USER] WHERE Email = @Email AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                int result = (int)command.ExecuteScalar();
                if (result > 0)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hide current form when clicked
                    this.Hide();
                    // Create an Instance of Car Form
                    Car car = new Car();
                    // Show Car Form
                    car.ShowDialog();
                    // Dispose Car Form
                    car = null;
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "Email Address")
            {
                guna2TextBox1.Text = "";
                guna2TextBox1.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox1.Text))
            {
                guna2TextBox1.Text = "Email Address";
                guna2TextBox1.ForeColor = Color.Silver;
            }
        }

        private void LoginAdminPanelButton_Click(object sender, EventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Admin Login Form
            AdminLogin adminlogin = new AdminLogin();
            // Show Login Form
            adminlogin.ShowDialog();
            // Dispose Admin Login Form
            adminlogin = null;
            this.Show();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e) => guna2TextBox2.UseSystemPasswordChar = !guna2CheckBox1.Checked;

        private void guna2TextBox2_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "Password")
            {
                guna2TextBox2.Text = "";
                guna2TextBox2.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(guna2TextBox2.Text))
            {
                guna2TextBox2.Text = "Password";
                guna2TextBox2.ForeColor = Color.Silver;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hide current form when clicked
            this.Hide();
            // Create an Instance of Another Form
            ForgotPassoword fp = new ForgotPassoword();
            // Show Form
            fp.ShowDialog();
            // Dispose Form
            fp = null;
            this.Show();
        }
    }
}
