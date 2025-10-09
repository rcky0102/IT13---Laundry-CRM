using IT13___Laundry_CRM.Admin;
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
using IT13___Laundry_CRM.Laundry_Attendant;

namespace IT13___Laundry_CRM
{
    public partial class Laundry_Attendant_CustomersForm : Laundry_Attendant_Template
    {
        private readonly UserRepository userepo = new UserRepository();

        public Laundry_Attendant_CustomersForm()
        {
            InitializeComponent();
            table_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void ReadUsers()
        {

        }

        private void Laundry_Attendant_CustomersForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers(string searchText = "")
        {
            try
            {
                List<User> customers = userepo.GetUsers()
                    .Where(u => u.role.Equals("customer", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                // Apply search filter
                if (!string.IsNullOrEmpty(searchText))
                {
                    customers = customers
                        .Where(u =>
                            u.user_id.ToString().Contains(searchText) ||
                            (u.first_name ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                            (u.last_name ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                            (u.username ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }

                table_customers.AutoGenerateColumns = false;
                table_customers.Columns.Clear(); // clear previous columns

                // ID
                table_customers.Columns.Add("user_id", "ID");
                table_customers.Columns["user_id"].DataPropertyName = "user_id";

                // Username
                table_customers.Columns.Add("username", "Username");
                table_customers.Columns["username"].DataPropertyName = "username";

                // Full Name
                table_customers.Columns.Add("full_name", "Full Name");
                table_customers.Columns["full_name"].DataPropertyName = "full_name";

                // Address
                table_customers.Columns.Add("address", "Address");
                table_customers.Columns["address"].DataPropertyName = "address";

                // Contact
                table_customers.Columns.Add("contact", "Contact");
                table_customers.Columns["contact"].DataPropertyName = "contact";

                // Created At
                table_customers.Columns.Add("created_at", "Created At");
                table_customers.Columns["created_at"].DataPropertyName = "created_at";

                // Prepare data with FullName property
                var data = customers.Select(u => new
                {
                    u.user_id,
                    u.username,
                    full_name = $"{u.first_name} {(string.IsNullOrEmpty(u.middle_name) ? "" : u.middle_name + " ")}{u.last_name}",
                    u.address,
                    u.contact,
                    u.created_at
                }).ToList();

                table_customers.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button_add_cutomer_Click(object sender, EventArgs e)
        {
            var form = new create_edit_customer();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (table_customers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = (int)table_customers.SelectedRows[0].Cells["user_id"].Value;

            var customer = userepo.GetUser(userId);
            if (customer == null)
            {
                MessageBox.Show("Customer not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new create_edit_customer();
            form.EditUser(customer); // opens customer for editing

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (table_customers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId = (int)table_customers.SelectedRows[0].Cells["user_id"].Value;

            var confirm = MessageBox.Show("Are you sure you want to delete this customer?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                userepo.DeleteUser(userId);
                LoadCustomers();
            }
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers(textbox_search.Text.Trim());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
