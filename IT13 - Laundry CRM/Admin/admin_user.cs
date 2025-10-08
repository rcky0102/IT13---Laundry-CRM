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

namespace IT13___Laundry_CRM.Admin
{
    public partial class admin_user : SIdebarTemplate
    {

        private readonly UserRepository userRepository = new UserRepository();
        private List<User> allUsers = new List<User>();

        public admin_user()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            admin_create_edit_user user = new admin_create_edit_user();
            user.ShowDialog();

        }

        private void admin_user_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                allUsers = userRepository.GetUsers(); // store in local list

                table_users.AutoGenerateColumns = false;
                table_users.Columns.Clear(); // clear previous columns

                table_users.Columns.Add("user_id", "ID");
                table_users.Columns["user_id"].DataPropertyName = "user_id";

                table_users.Columns.Add("username", "Username");
                table_users.Columns["username"].DataPropertyName = "username";

                table_users.Columns.Add("role", "Role");
                table_users.Columns["role"].DataPropertyName = "role";

                table_users.Columns.Add("full_name", "Full Name");
                table_users.Columns["full_name"].DataPropertyName = "full_name";

                table_users.Columns.Add("address", "Address");
                table_users.Columns["address"].DataPropertyName = "address";

                table_users.Columns.Add("contact", "Contact");
                table_users.Columns["contact"].DataPropertyName = "contact";

                table_users.Columns.Add("created_at", "Created At");
                table_users.Columns["created_at"].DataPropertyName = "created_at";

                // Prepare data with FullName property
                var data = allUsers.Select(u => new
                {
                    u.user_id,
                    u.username,
                    u.role,
                    full_name = $"{u.first_name} {(string.IsNullOrEmpty(u.middle_name) ? "" : u.middle_name + " ")}{u.last_name}",
                    u.address,
                    u.contact,
                    u.created_at
                }).ToList();

                table_users.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button_edit_Click(object sender, EventArgs e)
        {
            if (table_users.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var val = table_users.SelectedRows[0].Cells["user_id"].Value.ToString();
            if (string.IsNullOrEmpty(val)) return;

            int userId = int.Parse(val);

            // fetch user from repository
            var user = userRepository.GetUser(userId);
            if (user == null)
            {
                MessageBox.Show("User not found.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // open edit form
            admin_create_edit_user form = new admin_create_edit_user();
            form.EditUser(user);  // assumes you add an EditUser(User u) method in your form

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadUsers(); // reload DataGridView
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (table_users.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var val = table_users.SelectedRows[0].Cells["user_id"].Value.ToString();
            if (string.IsNullOrEmpty(val)) return;

            int userId = int.Parse(val);

            var confirm = MessageBox.Show("Are you sure you want to delete this user?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                userRepository.DeleteUser(userId);
                LoadUsers(); // refresh grid
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string query = textBox_search.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(query))
            {
                LoadUsers();
            }
            else
            {
                var filtered = allUsers.Where(u =>
                    u.user_id.ToString().Contains(query) ||
                    (!string.IsNullOrEmpty(u.first_name) &&
                     $"{u.first_name} {(string.IsNullOrEmpty(u.middle_name) ? "" : u.middle_name + " ")}{u.last_name}".ToLower().Contains(query)) ||
                    (!string.IsNullOrEmpty(u.username) && u.username.ToLower().Contains(query)) ||
                    (!string.IsNullOrEmpty(u.address) && u.address.ToLower().Contains(query))
                ).Select(u => new
                {
                    u.user_id,
                    u.username,
                    u.role,
                    full_name = $"{u.first_name} {(string.IsNullOrEmpty(u.middle_name) ? "" : u.middle_name + " ")}{u.last_name}",
                    u.address,
                    u.contact,
                    u.created_at
                }).ToList();

                table_users.DataSource = filtered;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
