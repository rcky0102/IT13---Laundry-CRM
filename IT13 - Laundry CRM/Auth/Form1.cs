using IT13___Laundry_CRM.Customer;
using IT13___Laundry_CRM.Models;
using IT13___Laundry_CRM.Repositories;
using System.Security.Cryptography;
using System.Text;
using static IT13___Laundry_CRM.Models.User;

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

            // ✅ Check if fields are filled
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Username rule (optional but recommended)
            // Minimum 4 characters, letters/numbers/underscores only
            if (username.Length < 4 || !username.All(c => char.IsLetterOrDigit(c) || c == '_'))
            {
                MessageBox.Show("Username must be at least 4 characters long and contain only letters, numbers, or underscores.",
                                "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Password rule: at least 8 characters (simple security)
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.",
                                "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Fetch user from database
            User? user = userRepository.GetUserByUsername(username);

            if (user != null)
            {
                // ✅ Hash entered password before comparison
                string hashedPassword = HashPassword(password);

                if (user.password == hashedPassword)
                {
                    if (user.role == "admin")
                    {
                        CurrentUser.User = user;

                        //MessageBox.Show("Welcome Admin!", "Login Successful",
                        //                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //SIdebarTemplate.LastActiveButtonName = null;
                        AdminForm dashboard = new AdminForm();
                        dashboard.Show();
                        this.Hide();
                    }
                    else if (user.role == "laundry_attendant")
                    {
                        CurrentUser.User = user;

                        //MessageBox.Show("Welcome Laundry Attendant!", "Login Successful",
                        //                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Laundry_Attendant_Template.LastActiveButtonName = null;
                        Laundry_Attendant_Dashboard dashboard = new Laundry_Attendant_Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else if (user.role == "customer")
                    {
                        CurrentUser.User = user;

                        //MessageBox.Show("Welcome Laundry Customer!", "Login Successful",
                        //                MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //customer_template.LastActiveButtonName = null;
                        customer_status status = new customer_status();
                        status.Show();

                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //RegisterForm registerform = new RegisterForm();
            //registerform.ShowDialog();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linklabel_reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.Show();

            this.Hide();    
        }
    }
}
