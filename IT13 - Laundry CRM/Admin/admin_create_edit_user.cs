using IT13___Laundry_CRM.Repositories;

using IT13___Laundry_CRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace IT13___Laundry_CRM.Admin
{
    public partial class admin_create_edit_user : Form
    {
        private readonly UserRepository userRepository = new UserRepository();

        public admin_create_edit_user()
        {
            InitializeComponent();

            combobox_role.Items.Add("customer");
            combobox_role.Items.Add("laundry_attendant");
            combobox_role.SelectedIndex = 0;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Build User object from form inputs
                User user = new User
                {
                    user_id = this.Tag is int ? (int)this.Tag : 0, // Use Tag if editing
                    username = textbox_username.Text.Trim(),
                    password = textbox_password.Text.Trim(),
                    role = combobox_role.SelectedItem?.ToString() ?? "customer",
                    first_name = string.IsNullOrWhiteSpace(textbox_firstname.Text) ? null : textbox_firstname.Text.Trim(),
                    middle_name = string.IsNullOrWhiteSpace(textbox_middlename.Text) ? null : textbox_middlename.Text.Trim(),
                    last_name = string.IsNullOrWhiteSpace(textbox_lastname.Text) ? null : textbox_lastname.Text.Trim(),
                    address = string.IsNullOrWhiteSpace(textbox_address.Text) ? null : textbox_address.Text.Trim(),
                    contact = string.IsNullOrWhiteSpace(textbox_contact.Text) ? null : textbox_contact.Text.Trim(),
                    created_at = DateTime.Now
                };

                // 🔹 Basic validation
                if (string.IsNullOrEmpty(user.username))
                {
                    MessageBox.Show("Username is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (user.username.Length < 4 || !user.username.All(c => char.IsLetterOrDigit(c) || c == '_'))
                {
                    MessageBox.Show("Username must be at least 4 characters long and contain only letters, numbers, or underscores.",
                        "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔹 Check for existing username
                var existingUser = userRepository.GetUserByUsername(user.username);
                if (existingUser != null && existingUser.user_id != user.user_id)
                {
                    MessageBox.Show("This username already exists. Please choose a different one.",
                        "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔹 New user → Must have password
                if (user.user_id == 0 && string.IsNullOrEmpty(user.password))
                {
                    MessageBox.Show("Password is required for new users.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔹 Hash password if present
                if (!string.IsNullOrEmpty(user.password))
                {
                    if (user.password.Length < 8)
                    {
                        MessageBox.Show("Password must be at least 8 characters long.",
                            "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    user.password = HashPassword(user.password);
                }

                // 🔹 Save user (insert or update)
                if (user.user_id > 0)
                {
                    userRepository.UpdateUser(user);
                    MessageBox.Show("User updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    userRepository.CreateUser(user);
                    MessageBox.Show("User created successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK; // Signal parent to reload DataGridView
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving user: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            combobox_role.SelectedIndex = 0; // reset to customer
        }


        public void EditUser(User user)
        {
            textbox_username.Text = user.username;
            combobox_role.Text = user.role;
            textbox_firstname.Text = user.first_name;
            textbox_middlename.Text = user.middle_name;
            textbox_lastname.Text = user.last_name;
            textbox_address.Text = user.address;
            textbox_contact.Text = user.contact;

            this.Tag = user.user_id;

            // Leave password blank for security
            textbox_password.Text = "";

            if (user.username == "admin")
            {
                combobox_role.Enabled = false;
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
    }
}
