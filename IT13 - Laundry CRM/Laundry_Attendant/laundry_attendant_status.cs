using IT13___Laundry_CRM.Repositories;
using System.Data;

namespace IT13___Laundry_CRM.Laundry_Attendant
{
    public partial class laundry_attendant_status : Laundry_Attendant_Template
    {
        private readonly StatusRepository statusRepository = new StatusRepository();
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalRecords = 0;
        private string currentSearch = "";

        public laundry_attendant_status()
        {
            InitializeComponent();
        }

        private void LoadCustomerStatuses(string searchText = "", int page = 1)
        {
            try
            {
                currentPage = page;
                currentSearch = searchText;

                var statuses = statusRepository.GetStatusesWithCustomerNames();

                // Apply search filter
                if (!string.IsNullOrEmpty(searchText))
                {
                    statuses = statuses
                        .Where(s =>
                            s.status_id.ToString().Contains(searchText) ||
                            ((s.User.first_name ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase)) ||
                            ((s.User.last_name ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase))
                        )
                        .ToList();
                }

                totalRecords = statuses.Count;

                // Apply pagination
                var pagedStatuses = statuses
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                // Transform into a list of anonymous objects for the grid
                var tableData = pagedStatuses.Select(s => new
                {
                    StatusID = s.status_id,
                    CustomerName = $"{s.User.first_name} {(string.IsNullOrEmpty(s.User.middle_name) ? "" : s.User.middle_name + " ")}{s.User.last_name}",
                    Status = s.status,
                    CreatedAt = s.created_at.ToString("yyyy-MM-dd HH:mm:ss")
                }).ToList();

                table_customers.DataSource = tableData;

                // Add Action columns
                AddActionColumns();

                // Update pagination controls
                UpdatePaginationControls();

                // optional: auto-size columns
                table_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statuses: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddActionColumns()
        {
            // Remove existing action columns if any
            if (table_customers.Columns.Contains("EditAction"))
                table_customers.Columns.Remove("EditAction");
            if (table_customers.Columns.Contains("ArchiveAction"))
                table_customers.Columns.Remove("ArchiveAction");

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

            // Add Archive column
            DataGridViewButtonColumn archiveColumn = new DataGridViewButtonColumn();
            archiveColumn.Name = "ArchiveAction";
            archiveColumn.HeaderText = "Archive";
            archiveColumn.Text = "📦";
            archiveColumn.UseColumnTextForButtonValue = true;
            archiveColumn.Width = 70;
            archiveColumn.DefaultCellStyle.BackColor = Color.Salmon;
            archiveColumn.DefaultCellStyle.ForeColor = Color.White;
            archiveColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table_customers.Columns.Add(archiveColumn);
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

        private void laundry_attendant_status_Load(object sender, EventArgs e)
        {
            cmbPageSize.SelectedIndex = 1; // Select 10 as default
            LoadCustomerStatuses();
        }

        private void table_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var statusId = Convert.ToInt32(table_customers.Rows[e.RowIndex].Cells["StatusID"].Value);

                if (table_customers.Columns[e.ColumnIndex].Name == "EditAction")
                {
                    EditStatus(statusId);
                }
                else if (table_customers.Columns[e.ColumnIndex].Name == "ArchiveAction")
                {
                    ArchiveStatus(statusId);
                }
            }
        }

        private void EditStatus(int statusId)
        {
            // Fetch fresh data from DB
            int userId = statusRepository.GetUserIdByStatusId(statusId);
            string statusText = statusRepository.GetStatusTextById(statusId);

            create_edit_status editForm = new create_edit_status(statusId, userId, statusText);
            editForm.StartPosition = FormStartPosition.CenterParent;

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadCustomerStatuses(currentSearch, currentPage); // refresh grid
            }
        }

        private void ArchiveStatus(int statusId)
        {
            var confirm = MessageBox.Show("Are you sure you want to archive this status?",
                                          "Confirm Archive",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                statusRepository.ArchiveStatus(statusId);
                MessageBox.Show("Status archived successfully!", "Archived",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomerStatuses(currentSearch, currentPage); // refresh grid
            }
        }

        // Pagination button click handlers
        private void btnFirst_Click(object sender, EventArgs e)
        {
            LoadCustomerStatuses(currentSearch, 1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
                LoadCustomerStatuses(currentSearch, currentPage - 1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < GetTotalPages())
                LoadCustomerStatuses(currentSearch, currentPage + 1);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            LoadCustomerStatuses(currentSearch, GetTotalPages());
        }

        private void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPageSize.SelectedItem != null)
            {
                pageSize = Convert.ToInt32(cmbPageSize.SelectedItem);
                LoadCustomerStatuses(currentSearch, 1);
            }
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            LoadCustomerStatuses(textbox_search.Text.Trim(), 1);
        }

        // Existing methods remain the same...
        private void button1_Click(object sender, EventArgs e) { }

        private void button_add_Click(object sender, EventArgs e) { }

        private void button_edit_Click(object sender, EventArgs e) { }

        private void button_archive_Click(object sender, EventArgs e) { }

        private void button_archives_Click(object sender, EventArgs e)
        {
            archived_status archives = new archived_status();
            archives.FormClosed += (s, args) => LoadCustomerStatuses(currentSearch, currentPage);
            archives.ShowDialog();
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (create_edit_status status = new create_edit_status())
            {
                status.StartPosition = FormStartPosition.CenterParent;
                if (status.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomerStatuses(currentSearch, currentPage);
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (table_customers.SelectedRows.Count > 0)
            {
                var row = table_customers.SelectedRows[0];
                int statusId = Convert.ToInt32(row.Cells["StatusID"].Value);
                EditStatus(statusId);
            }
            else
            {
                MessageBox.Show("Please select a status to edit.", "Edit Status",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void archive_Click(object sender, EventArgs e)
        {
            if (table_customers.SelectedRows.Count > 0)
            {
                var row = table_customers.SelectedRows[0];
                int statusId = Convert.ToInt32(row.Cells["StatusID"].Value);
                ArchiveStatus(statusId);
            }
            else
            {
                MessageBox.Show("Please select a status to archive.", "Archive Status",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}