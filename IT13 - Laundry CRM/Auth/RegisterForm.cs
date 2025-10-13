using IT13___Laundry_CRM.Customer;
using IT13___Laundry_CRM.Models;
using IT13___Laundry_CRM.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IT13___Laundry_CRM.Models.User;

namespace IT13___Laundry_CRM
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            try
            {
                // Build User object from form inputs
                User newUser = new User
                {
                    username = textbox_username.Text.Trim(),
                    password = textbox_password.Text, // will be hashed inside CreateUser
                    role = "customer", // fixed role
                    first_name = textbox_firstname.Text.Trim(),
                    middle_name = string.IsNullOrWhiteSpace(textbox_middlename.Text) ? null : textbox_middlename.Text.Trim(),
                    last_name = textbox_lastname.Text.Trim(),
                    address = textbox_address.Text.Trim(),
                    contact = textbox_contact.Text.Trim(),
                    created_at = DateTime.Now
                };

                // 🔸 Validate required fields
                if (string.IsNullOrWhiteSpace(newUser.username) ||
                    string.IsNullOrWhiteSpace(newUser.password) ||
                    string.IsNullOrWhiteSpace(newUser.first_name) ||
                    string.IsNullOrWhiteSpace(newUser.last_name) ||
                    string.IsNullOrWhiteSpace(newUser.address) ||
                    string.IsNullOrWhiteSpace(newUser.contact))
                {
                    MessageBox.Show("Please fill out all required fields.",
                        "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Save to database
                var userRepository = new UserRepository();
                userRepository.CreateUser(newUser);

                MessageBox.Show("Registration successful! Logging you in...", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Auto-login logic
                AutoLoginAfterRegister(newUser.username, newUser.password);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AutoLoginAfterRegister(string username, string password)
        {
            var userRepository = new UserRepository();
            User? user = userRepository.GetUserByUsername(username);

            if (user != null)
            {
                // Hash entered password (the same way as login does)
                using (var sha256 = System.Security.Cryptography.SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(password);
                    byte[] hash = sha256.ComputeHash(bytes);
                    string hashedPassword = Convert.ToBase64String(hash);

                    if (user.password == hashedPassword)
                    {
                        CurrentUser.User = user;

                        if (user.role == "customer")
                        {
                            //MessageBox.Show("Welcome Laundry Customer!", "Login Successful",
                            //    MessageBoxButtons.OK, MessageBoxIcon.Information);

                            customer_status status = new customer_status(); 
                            status.Show();

                            this.Hide();
                        }
                        else if (user.role == "admin")
                        {
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                            this.Hide();
                        }
                        else if (user.role == "laundry_attendant")
                        {
                            Laundry_Attendant_Dashboard attendantForm = new Laundry_Attendant_Dashboard();
                            attendantForm.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }


        private void button_cancel_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

            this.Close();

        }

        private void ClearForm()
        {
            textbox_username.Clear();
            textbox_password.Clear();
            textbox_firstname.Clear();
            textbox_middlename.Clear();
            textbox_lastname.Clear();
            textbox_address.Clear();
            textbox_contact.Clear();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
