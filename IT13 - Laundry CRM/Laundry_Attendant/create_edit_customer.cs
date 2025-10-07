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

namespace IT13___Laundry_CRM.Laundry_Attendant
{
    public partial class create_edit_customer : Form
    {
        public create_edit_customer()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Build User object from form inputs
                User user = new User
                {
                    user_id = this.Tag is int ? (int)this.Tag : 0, // use Tag if editing
                    username = textbox_username.Text.Trim(),
                    password = textbox_password.Text, // will be hashed in repository
                    role = "customer", // automatically set
                    first_name = string.IsNullOrWhiteSpace(textbox_firstname.Text) ? null : textbox_firstname.Text.Trim(),
                    middle_name = string.IsNullOrWhiteSpace(textbox_middlename.Text) ? null : textbox_middlename.Text.Trim(),
                    last_name = string.IsNullOrWhiteSpace(textbox_lastname.Text) ? null : textbox_lastname.Text.Trim(),
                    address = string.IsNullOrWhiteSpace(textbox_address.Text) ? null : textbox_address.Text.Trim(),
                    contact = string.IsNullOrWhiteSpace(textbox_contact.Text) ? null : textbox_contact.Text.Trim(),
                    created_at = DateTime.Now
                };

                // validation
                if (string.IsNullOrEmpty(user.username))
                {
                    MessageBox.Show("Username is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var userRepository = new UserRepository();

                if (user.user_id > 0)
                {
                    // Existing user → Update
                    userRepository.UpdateUser(user);
                    MessageBox.Show("User updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // New user → Create
                    if (string.IsNullOrEmpty(user.password))
                    {
                        MessageBox.Show("Password is required for new users.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    userRepository.CreateUser(user);
                    MessageBox.Show("User recorded successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK; // signal parent to reload DataGridView
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

        public void EditUser(User user)
        {
            textbox_username.Text = user.username;
            textbox_firstname.Text = user.first_name;
            textbox_middlename.Text = user.middle_name;
            textbox_lastname.Text = user.last_name;
            textbox_address.Text = user.address;
            textbox_contact.Text = user.contact;

            this.Tag = user.user_id;
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
    }
}
