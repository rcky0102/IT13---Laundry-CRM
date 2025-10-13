using IT13___Laundry_CRM.Repositories;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

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

            MakeRounded(panel3);
            MakeRounded(textbox_search);
            MakeRounded(button_archives);
            MakeRounded(add);
            MakeRounded(table_customers);
            MakeRounded(panelPagination);
            MakeRounded(btnFirst);
            MakeRounded(btnPrevious);
            MakeRounded(cmbPageSize);
            MakeRounded(btnNext);
            MakeRounded(btnLast);

        }

        private void laundry_attendant_status_Load(object sender, EventArgs e)
        {
            LoadCustomerStatuses();
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

        private void LoadCustomerStatuses(string searchText = "", int page = 1)
        {
            try
            {

                // Set font for the entire DataGridView
                table_customers.Font = new Font("Gadugi", 10, FontStyle.Regular); // Change "Gadugi" and size as needed

                // Optional: Set font for column headers separately
                table_customers.ColumnHeadersDefaultCellStyle.Font = new Font("Gadugi", 11, FontStyle.Bold);

                // Optional: Set font for row headers (if used)
                table_customers.RowHeadersDefaultCellStyle.Font = new Font("Gadugi", 10, FontStyle.Regular);


                currentPage = page;
                currentSearch = searchText;

                var statuses = statusRepository.GetStatusesWithCustomerNames();

                // Search filter
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

                // Pagination
                var pagedStatuses = statuses
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                // Transform for DataGridView
                var tableData = pagedStatuses.Select(s => new
                {
                    StatusID = s.status_id,
                    CustomerName = $"{s.User.first_name} {(string.IsNullOrEmpty(s.User.middle_name) ? "" : s.User.middle_name + " ")}{s.User.last_name}",
                    Role = s.User.role,
                    Status = s.status,
                    CreatedAt = s.created_at.ToString("yyyy-MM-dd HH:mm:ss")
                }).ToList();

                table_customers.DataSource = tableData;

                AddActionColumns();
                UpdatePaginationControls();

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
            // Remove existing columns
            if (table_customers.Columns.Contains("EditAction"))
                table_customers.Columns.Remove("EditAction");
            if (table_customers.Columns.Contains("ArchiveAction"))
                table_customers.Columns.Remove("ArchiveAction");

            // Edit Button
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

            // Archive Button
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

        // Pagination buttons
        private void btnFirst_Click(object sender, EventArgs e) => LoadCustomerStatuses(currentSearch, 1);
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1) LoadCustomerStatuses(currentSearch, currentPage - 1);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < GetTotalPages()) LoadCustomerStatuses(currentSearch, currentPage + 1);
        }
        private void btnLast_Click(object sender, EventArgs e) => LoadCustomerStatuses(currentSearch, GetTotalPages());

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

        private void cmbRoleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCustomerStatuses(textbox_search.Text.Trim(), 1);
        }

        private void table_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var statusId = Convert.ToInt32(table_customers.Rows[e.RowIndex].Cells["StatusID"].Value);

                if (table_customers.Columns[e.ColumnIndex].Name == "EditAction")
                    EditStatus(statusId);
                else if (table_customers.Columns[e.ColumnIndex].Name == "ArchiveAction")
                    ArchiveStatus(statusId);
            }
        }

        private void EditStatus(int statusId)
        {
            int userId = statusRepository.GetUserIdByStatusId(statusId);
            string statusText = statusRepository.GetStatusTextById(statusId);

            using (var editForm = new create_edit_status(statusId, userId, statusText))
            {
                editForm.StartPosition = FormStartPosition.CenterParent;
                if (editForm.ShowDialog() == DialogResult.OK)
                    LoadCustomerStatuses(currentSearch, currentPage);
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
                LoadCustomerStatuses(currentSearch, currentPage);
            }
        }

        // Optional buttons
        private void button_archives_Click(object sender, EventArgs e)
        {
            using (var archives = new archived_status())
            {
                archives.FormClosed += (s, args) => LoadCustomerStatuses(currentSearch, currentPage);
                archives.ShowDialog();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (var statusForm = new create_edit_status())
            {
                statusForm.StartPosition = FormStartPosition.CenterParent;
                if (statusForm.ShowDialog() == DialogResult.OK)
                    LoadCustomerStatuses(currentSearch, currentPage);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (table_customers.SelectedRows.Count > 0)
            {
                int statusId = Convert.ToInt32(table_customers.SelectedRows[0].Cells["StatusID"].Value);
                EditStatus(statusId);
            }
            else
            {
                MessageBox.Show("Please select a status to edit.", "Edit Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void archive_Click(object sender, EventArgs e)
        {
            if (table_customers.SelectedRows.Count > 0)
            {
                int statusId = Convert.ToInt32(table_customers.SelectedRows[0].Cells["StatusID"].Value);
                ArchiveStatus(statusId);
            }
            else
            {
                MessageBox.Show("Please select a status to archive.", "Archive Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
