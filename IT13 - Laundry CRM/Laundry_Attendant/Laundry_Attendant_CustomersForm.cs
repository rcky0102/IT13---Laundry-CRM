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
    public partial class Laundry_Attendant_CustomersForm : Laundry_Attendant_Template
    {
        private readonly UserRepository userepo = new UserRepository();
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalRecords = 0;
        private List<User> allCustomers = new List<User>();

        public Laundry_Attendant_CustomersForm()
        {
            InitializeComponent();
<<<<<<< Updated upstream
=======
            table_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SetupPaginationControls();
>>>>>>> Stashed changes
        }

        private void SetupPaginationControls()
        {
            cmbPageSize.Items.AddRange(new object[] { 5, 10, 20, 50 });
            cmbPageSize.SelectedItem = pageSize;
        }

        private void Laundry_Attendant_CustomersForm_Load(object sender, EventArgs e)
        {
<<<<<<< Updated upstream

=======
            LoadCustomers();
        }

        private void LoadCustomers(string searchText = "")
        {
            try
            {
                // Get all customers
                allCustomers = userepo.GetUsers()
                    .Where(u => u.role.Equals("customer", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                // Apply search filter
                if (!string.IsNullOrEmpty(searchText))
                {
                    allCustomers = allCustomers
                        .Where(u =>
                            u.user_id.ToString().Contains(searchText) ||
                            (u.first_name ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                            (u.last_name ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                            (u.username ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }

                totalRecords = allCustomers.Count;

                // Apply pagination
                var pagedCustomers = allCustomers
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                table_customers.AutoGenerateColumns = false;
                table_customers.Columns.Clear();

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

                // Use the custom Action Column
                DataGridViewActionColumn actionColumn = new DataGridViewActionColumn();
                actionColumn.Name = "actions";
                actionColumn.HeaderText = "Actions";
                table_customers.Columns.Add(actionColumn);

                // Prepare data with FullName property
                var data = pagedCustomers.Select(u => new
                {
                    u.user_id,
                    u.username,
                    full_name = $"{u.first_name} {(string.IsNullOrEmpty(u.middle_name) ? "" : u.middle_name + " ")}{u.last_name}",
                    u.address,
                    u.contact,
                    u.created_at
                }).ToList();

                table_customers.DataSource = data;
                UpdatePaginationInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePaginationInfo()
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            lblPageInfo.Text = $"Page {currentPage} of {totalPages} (Total: {totalRecords} records)";

            btnFirst.Enabled = currentPage > 1;
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
            btnLast.Enabled = currentPage < totalPages;
        }

        public void EditCustomer(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= table_customers.Rows.Count) return;

            int userId = (int)table_customers.Rows[rowIndex].Cells["user_id"].Value;
            var customer = userepo.GetUser(userId);

            if (customer == null)
            {
                MessageBox.Show("Customer not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new create_edit_customer();
            form.EditUser(customer);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers(textbox_search.Text.Trim());
            }
        }

        public void DeleteCustomer(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= table_customers.Rows.Count) return;

            int userId = (int)table_customers.Rows[rowIndex].Cells["user_id"].Value;

            var confirm = MessageBox.Show("Are you sure you want to delete this customer?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                userepo.DeleteUser(userId);
                LoadCustomers(textbox_search.Text.Trim());
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

            EditCustomer(table_customers.SelectedRows[0].Index);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (table_customers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteCustomer(table_customers.SelectedRows[0].Index);
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1; // Reset to first page when searching
            LoadCustomers(textbox_search.Text.Trim());
        }

        // Pagination button events
        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadCustomers(textbox_search.Text.Trim());
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadCustomers(textbox_search.Text.Trim());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadCustomers(textbox_search.Text.Trim());
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            currentPage = totalPages;
            LoadCustomers(textbox_search.Text.Trim());
        }

        private void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPageSize.SelectedItem != null)
            {
                pageSize = (int)cmbPageSize.SelectedItem;
                currentPage = 1;
                LoadCustomers(textbox_search.Text.Trim());
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Your existing code
>>>>>>> Stashed changes
        }
    }

    public class DataGridViewActionColumn : DataGridViewButtonColumn
    {
        public DataGridViewActionColumn()
        {
            this.CellTemplate = new DataGridViewActionCell();
            this.Width = 100;
            this.HeaderText = "Actions";
        }
    }

    public class DataGridViewActionCell : DataGridViewButtonCell
    {
        protected override void Paint(Graphics graphics, Rectangle clipBounds,
            Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState,
            object value, object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            // Draw the cell background
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState,
                value, formattedValue, errorText, cellStyle, advancedBorderStyle,
                paintParts & ~DataGridViewPaintParts.ContentForeground);

            // Draw edit icon on left
            Rectangle editRect = new Rectangle(cellBounds.Left + 30, cellBounds.Top + 8, 30, 25);
            TextRenderer.DrawText(graphics, "✏️", new Font("Segoe UI Emoji", 8), editRect, Color.Blue, TextFormatFlags.Left);

            // Draw delete icon on right
            Rectangle deleteRect = new Rectangle(cellBounds.Right - 35, cellBounds.Top + 8, 25, 25);
            TextRenderer.DrawText(graphics, "🗑️", new Font("Segoe UI Emoji", 8), deleteRect, Color.Red, TextFormatFlags.Left);
        }

        protected override void OnClick(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dgv = this.DataGridView;
                if (dgv == null) return;

                Rectangle cellBounds = dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                Point clickPoint = dgv.PointToClient(Cursor.Position);

                // Check if click was on edit icon (left side)
                if (clickPoint.X < cellBounds.Left + cellBounds.Width / 2)
                {
                    // Edit action - call the form's EditCustomer method
                    var form = dgv.FindForm() as Laundry_Attendant_CustomersForm;
                    form?.EditCustomer(e.RowIndex);
                }
                else // Click was on delete icon (right side)
                {
                    // Delete action - call the form's DeleteCustomer method
                    var form = dgv.FindForm() as Laundry_Attendant_CustomersForm;
                    form?.DeleteCustomer(e.RowIndex);
                }
            }
            base.OnClick(e);
        }
    }
}