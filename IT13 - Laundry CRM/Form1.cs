using IT13___Laundry_CRM.Repositories;
using IT13___Laundry_CRM.Models;

namespace IT13___Laundry_CRM
{
    public partial class Form1 : Form
    {
        private readonly UserRepository userRepository = new UserRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = textbox_username.Text.Trim();
            string password = textbox_password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User? user = userRepository.GetUserByUsername(username);

            if (user != null && user.PasswordHash == password)
            {
                if (user.Role == "admin")
                {
                    MessageBox.Show("Welcome Admin!", "Login Successful",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();

                    this.Hide();

                }
                else if (user.Role == "laundry_attendant")
                {
                    MessageBox.Show("Welcome Laundry Attendant!", "Login Successful",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
