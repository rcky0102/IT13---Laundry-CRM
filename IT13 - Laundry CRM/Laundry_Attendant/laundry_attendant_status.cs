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

namespace IT13___Laundry_CRM.Laundry_Attendant
{
    public partial class laundry_attendant_status : Laundry_Attendant_Template
    {
        private readonly StatusRepository statusRepository = new StatusRepository();
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalRecords = 0;
        private List<dynamic> allStatuses = new List<dynamic>();

        public laundry_attendant_status()
        {
            InitializeComponent();
            SetupPaginationControls();
        }

        private void SetupPaginationControls()
        {
            cmbPageSize.Items.AddRange(new object[] { 5, 10, 20, 50 });
            cmbPageSize.SelectedItem = pageSize;
        }

        private void LoadCustomerStatuses()
        {
            try
            {
                var statuses = statusRepository.GetStatusesWithCustomerNames();

                // Transform into a list of anonymous objects for the grid
                allStatuses = statuses.Select(s => new
                {
                    StatusID = s.status_id,
                    CustomerName = $"{s.User.first_name} {(string.IsNullOrEmpty(s.User.middle_name) ? "" : s.User.middle_name + " ")}{s.User.last_name}",
                    Status = s.status,
                    CreatedAt = s.created_at.ToString("yyyy-MM-dd HH:mm:ss")
                }).ToList<dynamic>();

                totalRecords = allStatuses.Count;

                // Apply pagination
                var pagedStatuses = allStatuses
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                table_customers.AutoGenerateColumns = false;
                table_customers.Columns.Clear();

                // Status ID
                table_customers.Columns.Add("StatusID", "Status ID");
                table_customers.Columns["StatusID"].DataPropertyName = "StatusID";

                // Customer Name
                table_customers.Columns.Add("CustomerName", "Customer Name");
                table_customers.Columns["CustomerName"].DataPropertyName = "CustomerName";

                // Status
                table_customers.Columns.Add("Status", "Status");
                table_customers.Columns["Status"].DataPropertyName = "Status";

                // Created At
                table_customers.Columns.Add("CreatedAt", "Created At");
                table_customers.Columns["CreatedAt"].DataPropertyName = "CreatedAt";

                // Action Column with both icons
                DataGridViewActionColumn actionColumn = new DataGridViewActionColumn();
                actionColumn.Name = "actions";
                actionColumn.HeaderText = "Actions";
                table_customers.Columns.Add(actionColumn);

                table_customers.DataSource = pagedStatuses;
                table_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                UpdatePaginationInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statuses: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void EditStatus(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= table_customers.Rows.Count) return;

            int statusId = Convert.ToInt32(table_customers.Rows[rowIndex].Cells["StatusID"].Value);

            // Fetch fresh data from DB
            int userId = statusRepository.GetUserIdByStatusId(statusId);
            string statusText = statusRepository.GetStatusTextById(statusId);

            create_edit_status editForm = new create_edit_status(statusId, userId, statusText);
            editForm.StartPosition = FormStartPosition.CenterParent;

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadCustomerStatuses(textbox_search.Text.Trim());
            }
        }

        public void ArchiveStatus(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= table_customers.Rows.Count) return;

            int statusId = Convert.ToInt32(table_customers.Rows[rowIndex].Cells["StatusID"].Value);

            var confirm = MessageBox.Show("Are you sure you want to archive this status?",
                                          "Confirm Archive",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                statusRepository.ArchiveStatus(statusId);
                MessageBox.Show("Status archived successfully!", "Archived",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomerStatuses(textbox_search.Text.Trim());
            }
        }

        private void laundry_attendant_status_Load(object sender, EventArgs e)
        {
            LoadCustomerStatuses();
        }

        private void table_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

<<<<<<< Updated upstream
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            using (create_edit_status status = new create_edit_status())
            {
=======
        private void button_archives_Click(object sender, EventArgs e)
        {
            archived_status archives = new archived_status();
            archives.FormClosed += (s, args) => LoadCustomerStatuses();
            archives.ShowDialog();
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (create_edit_status status = new create_edit_status())
            {
                status.StartPosition = FormStartPosition.CenterParent;

>>>>>>> Stashed changes
                if (status.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomerStatuses();
                }
            }
        }

<<<<<<< Updated upstream
        private void button_edit_Click(object sender, EventArgs e)
        {
            if (table_customers.SelectedRows.Count > 0)
            {
                var row = table_customers.SelectedRows[0];

                int statusId = Convert.ToInt32(row.Cells["StatusID"].Value);

                // Fetch fresh data from DB
                int userId = statusRepository.GetUserIdByStatusId(statusId);
                string statusText = statusRepository.GetStatusTextById(statusId);

                create_edit_status editForm = new create_edit_status(statusId, userId, statusText);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomerStatuses(); // refresh grid
                }
            }
            else
            {
                MessageBox.Show("Please select a status to edit.", "Edit Status",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_archive_Click(object sender, EventArgs e)
        {
            if (table_customers.SelectedRows.Count > 0)
            {
                var row = table_customers.SelectedRows[0];
                int statusId = Convert.ToInt32(row.Cells["StatusID"].Value);

                var confirm = MessageBox.Show("Are you sure you want to archive this status?",
                                              "Confirm Archive",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    statusRepository.ArchiveStatus(statusId);
                    MessageBox.Show("Status archived successfully!", "Archived",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomerStatuses(); // refresh grid
                }
            }
            else
            {
                MessageBox.Show("Please select a status to archive.", "Archive Status",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
=======
        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadCustomerStatuses(textbox_search.Text.Trim());
        }

        // Pagination button events
        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadCustomerStatuses(textbox_search.Text.Trim());
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadCustomerStatuses(textbox_search.Text.Trim());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadCustomerStatuses(textbox_search.Text.Trim());
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            currentPage = totalPages;
            LoadCustomerStatuses(textbox_search.Text.Trim());
        }

        private void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPageSize.SelectedItem != null)
            {
                pageSize = (int)cmbPageSize.SelectedItem;
                currentPage = 1;
                LoadCustomerStatuses(textbox_search.Text.Trim());
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
>>>>>>> Stashed changes
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

            // ADJUST THESE VALUES FOR SPACING:
            int leftIconMargin = 30;    // Distance from left edge to edit icon
            int rightIconMargin = 45;   // Distance from right edge to archive icon
            int topMargin = 8;          // Distance from top edge
            int iconSize = 25;          // Size of the icon area

            // Draw edit icon on left
            Rectangle editRect = new Rectangle(cellBounds.Left + leftIconMargin,
                                             cellBounds.Top + topMargin,
                                             iconSize, iconSize);
            TextRenderer.DrawText(graphics, "✏️", new Font("Segoe UI Emoji", 8),
                                editRect, Color.Blue, TextFormatFlags.Left);

            // Draw archive icon on right
            Rectangle archiveRect = new Rectangle(cellBounds.Right - rightIconMargin,
                                                cellBounds.Top + topMargin,
                                                iconSize, iconSize);
            TextRenderer.DrawText(graphics, "📦", new Font("Segoe UI Emoji", 8),
                                archiveRect, Color.Orange, TextFormatFlags.Left);
        }

        protected override void OnClick(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dgv = this.DataGridView;
                if (dgv == null) return;

                Rectangle cellBounds = dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                Point clickPoint = dgv.PointToClient(Cursor.Position);

                // ADJUST CLICK DETECTION AREA:
                int clickDetectionSplit = cellBounds.Width / 2; // Currently splits at 50%

                // Check if click was on edit icon (left side)
                if (clickPoint.X < cellBounds.Left + clickDetectionSplit)
                {
                    // Edit action
                    var form = dgv.FindForm() as laundry_attendant_status;
                    form?.EditStatus(e.RowIndex);
                }
                else // Click was on archive icon (right side)
                {
                    // Archive action
                    var form = dgv.FindForm() as laundry_attendant_status;
                    form?.ArchiveStatus(e.RowIndex);
                }
            }
            base.OnClick(e);
        }
    }
}