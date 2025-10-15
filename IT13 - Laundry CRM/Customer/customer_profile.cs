using IT13___Laundry_CRM.Models;
using IT13___Laundry_CRM.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IT13___Laundry_CRM.Models.User;

namespace IT13___Laundry_CRM.Customer
{
    public partial class customer_profile : Form
    {
        private readonly UserRepository userRepository = new UserRepository();
        public customer_profile()
        {
            InitializeComponent();

            MakeRounded(label1);
            MakeRounded(label2);
            MakeRounded(label3);
            MakeRounded(label4);
            MakeRounded(label5);
            MakeRounded(label6);
            MakeRounded(label7);
            MakeRounded(label8);
            MakeRounded(panel1);

            MakeRounded(textbox_username);
            MakeRounded(textbox_password);
            MakeRounded(textbox_firstname);
            MakeRounded(textbox_middlename);
            MakeRounded(textbox_lastname);
            MakeRounded(textbox_address);
            MakeRounded(textbox_contact);

        }

        private void customer_profile_Load(object sender, EventArgs e)
        {
            if (CurrentUser.User != null)
            {
                var user = CurrentUser.User;

                textbox_firstname.Text = user.first_name;
                textbox_middlename.Text = user.middle_name;
                textbox_lastname.Text = user.last_name;
                textbox_address.Text = user.address;
                textbox_contact.Text = user.contact;
                textbox_username.Text = user.username;

                // Leave password field blank for security
                textbox_password.Text = "";
            }
            else
            {
                MessageBox.Show("No user is currently logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
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

        private void button_save_Click(object sender, EventArgs e)
        {
            if (CurrentUser.User == null)
                return;

            var user = CurrentUser.User;

            // ✅ Validate input fields
            if (string.IsNullOrWhiteSpace(textbox_firstname.Text) ||
                string.IsNullOrWhiteSpace(textbox_lastname.Text) ||
                string.IsNullOrWhiteSpace(textbox_address.Text) ||
                string.IsNullOrWhiteSpace(textbox_contact.Text) ||
                string.IsNullOrWhiteSpace(textbox_username.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Missing Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Validate username format
            string username = textbox_username.Text.Trim();
            if (username.Length < 4 || !username.All(c => char.IsLetterOrDigit(c) || c == '_'))
            {
                MessageBox.Show("Username must be at least 4 characters long and contain only letters, numbers, or underscores.",
                                "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Update user object
            user.first_name = textbox_firstname.Text.Trim();
            user.middle_name = textbox_middlename.Text.Trim();
            user.last_name = textbox_lastname.Text.Trim();
            user.address = textbox_address.Text.Trim();
            user.contact = textbox_contact.Text.Trim();
            user.username = username;

            // ✅ Update password if changed
            if (!string.IsNullOrEmpty(textbox_password.Text))
            {
                string password = textbox_password.Text.Trim();
                if (password.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long.",
                                    "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                user.password = HashPassword(password);
            }

            // ✅ Attempt database update
            bool updated = userRepository.UpdateUserProfile(user);

            if (updated)
            {
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbox_lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
