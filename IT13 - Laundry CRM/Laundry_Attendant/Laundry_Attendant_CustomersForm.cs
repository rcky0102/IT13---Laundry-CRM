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

        private void LoadCustomers()
        {
            try
            {
                List<User> customers = userepo.GetUsers()
                    .Where(u => u.role.Equals("customer", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                table_customers.AutoGenerateColumns = false;

                if (table_customers.Columns.Count == 0)
                {
                    table_customers.Columns.Add("user_id", "ID");
                    table_customers.Columns["user_id"].DataPropertyName = "user_id";

                    table_customers.Columns.Add("username", "Username");
                    table_customers.Columns["username"].DataPropertyName = "username";

                    table_customers.Columns.Add("first_name", "First Name");
                    table_customers.Columns["first_name"].DataPropertyName = "first_name";

                    table_customers.Columns.Add("last_name", "Last Name");
                    table_customers.Columns["last_name"].DataPropertyName = "last_name";

                    table_customers.Columns.Add("contact", "Contact");
                    table_customers.Columns["contact"].DataPropertyName = "contact";

                    table_customers.Columns.Add("created_at", "Created At");
                    table_customers.Columns["created_at"].DataPropertyName = "created_at";
                }

                table_customers.DataSource = customers;
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
    }
}
