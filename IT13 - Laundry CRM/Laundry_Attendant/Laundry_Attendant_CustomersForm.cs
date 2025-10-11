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
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalRecords = 0;
        private string currentSearch = "";

        public Laundry_Attendant_CustomersForm()
        {
            InitializeComponent();
            table_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Laundry_Attendant_CustomersForm_Load(object sender, EventArgs e)
        {
            cmbPageSize.SelectedIndex = 1; // Select 10 as default
            LoadCustomers();
        }

        private void LoadCustomers(string searchText = "", int page = 1)
        {
            try
            {
                currentPage = page;
                currentSearch = searchText;

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

                totalRecords = customers.Count;

                // Apply pagination
                var pagedCustomers = customers
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

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

                // Add Action columns
                AddActionColumns();

                // Prepare data with FullName property
                var data = pagedCustomers.Select(u => new
                {
                    u.user_id,
                    u.username,
                    full_name = $"{u.first_name} {(string.IsNullOrEmpty(u.middle_name) ? "" : u.middle_name + " ")}{u.last_name}",
                    u.address,
                    u.contact,
                    created_at = u.created_at.ToString("yyyy-MM-dd HH:mm:ss")
                }).ToList();

                table_customers.DataSource = data;

                // Update pagination controls
                UpdatePaginationControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddActionColumns()
        {
            // Remove existing action columns if any
            if (table_customers.Columns.Contains("EditAction"))
                table_customers.Columns.Remove("EditAction");
            if (table_customers.Columns.Contains("DeleteAction"))
                table_customers.Columns.Remove("DeleteAction");

            // Add Edit column
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "EditAction";
            editColumn.HeaderText = "Edit";
            editColumn.Text = "✏️";
            editColumn.UseColumnTextForButtonValue = true;
            editColumn.Width = 60;
            editColumn.DefaultCellStyle.BackColor = Color.ForestGreen;
            editColumn.DefaultCellStyle.ForeColor = Color.White;
            editColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table_customers.Columns.Add(editColumn);

            // Add Delete column
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "DeleteAction";
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Text = "🗑️";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Width = 70;
            deleteColumn.DefaultCellStyle.BackColor = Color.IndianRed;
            deleteColumn.DefaultCellStyle.ForeColor = Color.White;
            deleteColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table_customers.Columns.Add(deleteColumn);
        }

        private void UpdatePaginationControls()
        {
            int totalPages = GetTotalPages();
            lblPageInfo.Text = $"Page {currentPage} of {totalPages}";
            lblTotalRecords.Text = $"Total Records: {totalRecords}";

            btnFirst.Enabled = currentPage > 1;
            btnPrevious.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
            btnLast.Enabled = currentPage < totalPages;
        }

        private int GetTotalPages()
        {
            if (totalRecords == 0) return 1;
            return (int)Math.Ceiling((double)totalRecords / pageSize);
        }

        private void table_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var userId = Convert.ToInt32(table_customers.Rows[e.RowIndex].Cells["user_id"].Value);

                if (table_customers.Columns[e.ColumnIndex].Name == "EditAction")
                {
                    EditCustomer(userId);
                }
                else if (table_customers.Columns[e.ColumnIndex].Name == "DeleteAction")
                {
                    DeleteCustomer(userId);
                }
            }
        }

        private void EditCustomer(int userId)
        {
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
                LoadCustomers(currentSearch, currentPage);
            }
        }

        private void DeleteCustomer(int userId)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this customer?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                userepo.DeleteUser(userId);
                LoadCustomers(currentSearch, currentPage);
            }
        }

        // Pagination button click handlers
        private void btnFirst_Click(object sender, EventArgs e)
        {
            LoadCustomers(currentSearch, 1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
                LoadCustomers(currentSearch, currentPage - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < GetTotalPages())
                LoadCustomers(currentSearch, currentPage + 1);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            LoadCustomers(currentSearch, GetTotalPages());
        }

        private void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPageSize.SelectedItem != null)
            {
                pageSize = Convert.ToInt32(cmbPageSize.SelectedItem);
                LoadCustomers(currentSearch, 1);
            }
        }

        private void button_add_cutomer_Click(object sender, EventArgs e)
        {
            var form = new create_edit_customer();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers(currentSearch, currentPage);
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
            EditCustomer(userId);
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
            DeleteCustomer(userId);
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers(textbox_search.Text.Trim(), 1);
        }
    }
}