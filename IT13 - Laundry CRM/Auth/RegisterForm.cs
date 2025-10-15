using IT13___Laundry_CRM.Customer;
using IT13___Laundry_CRM.Models;
using IT13___Laundry_CRM.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            MakeRounded(textbox_username);
            MakeRounded(textbox_password);
            MakeRounded(textbox_firstname);
            MakeRounded(textbox_middlename);
            MakeRounded(textbox_lastname);
            MakeRounded(textbox_address);
            MakeRounded(textbox_contact);
            MakeRounded(button_cancel);
            MakeRounded(button_register);

        }

        private void MakeRounded(Control control, int radius = 20)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Top-left
            path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90); // Top-right
            path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90); // Bottom-right
            path.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90); // Bottom-left
            path.CloseFigure();

            control.Region = new Region(path);

            // Optional: handle resizing to keep corners rounded
            control.SizeChanged += (s, e) => MakeRounded(control, radius);
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

                // 🔹 Enforce username and password length rules
                if (newUser.username.Length < 4)
                {
                    MessageBox.Show("Username must be at least 4 characters long.",
                        "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (newUser.password.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long.",
                        "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔹 Check if username already exists in the database
                var userRepository = new UserRepository();
                if (userRepository.UsernameExists(newUser.username))
                {
                    MessageBox.Show("This username is already taken. Please choose another one.",
                        "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Save to database
                userRepository.CreateUser(newUser);

                MessageBox.Show("Registration successful! Logging you in...", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Auto-login logic
                AutoLoginAfterRegister(newUser.username, newUser.password);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during registration: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
