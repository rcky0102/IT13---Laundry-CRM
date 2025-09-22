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
    public partial class create_edit_user_form : Form
    {
        public create_edit_user_form()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

            // Initialize Role ComboBox
            combobox_role.Items.Add("laundry_attendant");
            combobox_role.Items.Add("customer");
            combobox_role.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private int userId = 0;

        public void EditUser(User user)
        {
            this.Text = "Edit User";
            this.label_title.Text = "Edit User";
            this.label_id.Text = user.UserId.ToString();

            this.textbox_username.Text = user.Username;
            this.textbox_password.Text = user.PasswordHash; // ⚠️ for real projects, don’t show raw hashes!
            this.combobox_role.SelectedItem = user.Role;

            this.userId = user.UserId;
        }

        private void create_edit_user_form_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                UserId = this.userId,
                Username = this.textbox_username.Text,
                PasswordHash = this.textbox_password.Text, // ⚠️ hash this in real usage!
                Role = this.combobox_role.SelectedItem?.ToString() ?? "customer",
                CreatedAt = DateTime.Now
            };

            var repo = new UserRepository();

            if (user.UserId == 0)
            {
                repo.CreateUser(user);
            }
            else
            {
                repo.UpdateUser(user);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
