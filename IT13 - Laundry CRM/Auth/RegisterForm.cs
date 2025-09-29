using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT13___Laundry_CRM.Models;
using IT13___Laundry_CRM.Repositories;

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
                    role = "customer", // fixed role for registration
                    first_name = string.IsNullOrWhiteSpace(textbox_firstname.Text) ? null : textbox_firstname.Text.Trim(),
                    middle_name = string.IsNullOrWhiteSpace(textbox_middlename.Text) ? null : textbox_middlename.Text.Trim(),
                    last_name = string.IsNullOrWhiteSpace(textbox_lastname.Text) ? null : textbox_lastname.Text.Trim(),
                    address = string.IsNullOrWhiteSpace(textbox_address.Text) ? null : textbox_address.Text.Trim(),
                    contact = string.IsNullOrWhiteSpace(textbox_contact.Text) ? null : textbox_contact.Text.Trim(),
                    created_at = DateTime.Now
                };

                // Simple validation
                if (string.IsNullOrEmpty(newUser.username) || string.IsNullOrEmpty(newUser.password))
                {
                    MessageBox.Show("Username and Password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Save to database
                var userRepository = new UserRepository();
                userRepository.CreateUser(newUser);

                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                customer_dashboard dashboard = new customer_dashboard(); // pass username if needed
                dashboard.Show();
                this.Hide();

                // Optionally clear the form
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
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
