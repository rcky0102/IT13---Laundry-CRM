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
                List<User> users = userRepository.GetUsers();

                table_users.AutoGenerateColumns = false;

                if (table_users.Columns.Count == 0)
                {
                    table_users.Columns.Add("user_id", "ID");
                    table_users.Columns["user_id"].DataPropertyName = "user_id";

                    table_users.Columns.Add("username", "Username");
                    table_users.Columns["username"].DataPropertyName = "username";

                    table_users.Columns.Add("role", "Role");
                    table_users.Columns["role"].DataPropertyName = "role";

                    table_users.Columns.Add("first_name", "First Name");
                    table_users.Columns["first_name"].DataPropertyName = "first_name";

                    table_users.Columns.Add("last_name", "Last Name");
                    table_users.Columns["last_name"].DataPropertyName = "last_name";

                    table_users.Columns.Add("contact", "Contact");
                    table_users.Columns["contact"].DataPropertyName = "contact";

                    table_users.Columns.Add("created_at", "Created At");
                    table_users.Columns["created_at"].DataPropertyName = "created_at";
                }

                table_users.DataSource = users;
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
    }
}
