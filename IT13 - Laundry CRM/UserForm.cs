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

namespace IT13___Laundry_CRM
{
    public partial class UserForm : SIdebarTemplate
    {
        private readonly UserRepository userRepo = new UserRepository();

        public UserForm()
        {
            InitializeComponent();

            ReadUsers();
        }

        private void ReadUsers()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Role");
            dataTable.Columns.Add("Created At");

            var users = userRepo.GetUsers();

            foreach (var user in users)
            {
                var row = dataTable.NewRow();

                row["ID"] = user.UserId;
                row["Username"] = user.Username;
                row["Role"] = user.Role;
                row["Created At"] = user.CreatedAt.ToString("yyyy-MM-dd HH:mm");

                dataTable.Rows.Add(row);
            }

            this.table_users.DataSource = dataTable; // ⚠️ your DataGridView should be renamed to `users_table`
        }


        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void button_add_user_Click(object sender, EventArgs e)
        {
            create_edit_user_form form = new create_edit_user_form();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadUsers();
            }
        }

        private void button_update_user_Click(object sender, EventArgs e)
        {
            if (this.table_users.SelectedRows.Count == 0) return;

            var val = this.table_users.SelectedRows[0].Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(val)) return;

            int userId = int.Parse(val);

            var user = userRepo.GetUserById(userId);
            if (user == null) return;

            create_edit_user_form form = new create_edit_user_form();
            form.EditUser(user);

            if (form.ShowDialog() == DialogResult.OK)
            {
                ReadUsers();
            }
        }

        private void button_delete_user_Click(object sender, EventArgs e)
        {
            if (this.table_users.SelectedRows.Count == 0) return;

            var val = this.table_users.SelectedRows[0].Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(val)) return;

            int userId = int.Parse(val);

            DialogResult dialogResult =
                MessageBox.Show("Are you sure you want to delete this user?",
                "Delete User", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            userRepo.DeleteUser(userId);

            ReadUsers();
        }
    }
}
