using IT13___Laundry_CRM.Repositories;
using System.Data;

namespace IT13___Laundry_CRM.Laundry_Attendant
{
    public partial class laundry_attendant_status : Laundry_Attendant_Template
    {
        private readonly StatusRepository statusRepository = new StatusRepository();

        public laundry_attendant_status()
        {
            InitializeComponent();


        }

        private void LoadCustomerStatuses()
        {
            try
            {
                var statuses = statusRepository.GetStatusesWithCustomerNames();

                // Transform into a list of anonymous objects for the grid
                var tableData = statuses.Select(s => new
                {
                    StatusID = s.status_id,
                    CustomerName = $"{s.User.first_name} {(string.IsNullOrEmpty(s.User.middle_name) ? "" : s.User.middle_name + " ")}{s.User.last_name}",
                    Status = s.status,
                    CreatedAt = s.created_at.ToString("yyyy-MM-dd HH:mm:ss")
                }).ToList();

                table_customers.DataSource = tableData;

                // optional: auto-size columns
                table_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statuses: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void laundry_attendant_status_Load(object sender, EventArgs e)
        {
            LoadCustomerStatuses();
        }

        private void table_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //using (create_edit_status status = new create_edit_status())
            //{
            //    if (status.ShowDialog() == DialogResult.OK)
            //    {
            //        LoadCustomerStatuses(); // refresh grid after adding
            //    }
            //}
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            //if (table_customers.SelectedRows.Count > 0)
            //{
            //    var row = table_customers.SelectedRows[0];

            //    int statusId = Convert.ToInt32(row.Cells["StatusID"].Value);

            //    // Fetch fresh data from DB
            //    int userId = statusRepository.GetUserIdByStatusId(statusId);
            //    string statusText = statusRepository.GetStatusTextById(statusId);

            //    create_edit_status editForm = new create_edit_status(statusId, userId, statusText);

            //    if (editForm.ShowDialog() == DialogResult.OK)
            //    {
            //        LoadCustomerStatuses(); // refresh grid
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select a status to edit.", "Edit Status",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void button_archive_Click(object sender, EventArgs e)
        {
            //if (table_customers.SelectedRows.Count > 0)
            //{
            //    var row = table_customers.SelectedRows[0];
            //    int statusId = Convert.ToInt32(row.Cells["StatusID"].Value);

            //    var confirm = MessageBox.Show("Are you sure you want to archive this status?",
            //                                  "Confirm Archive",
            //                                  MessageBoxButtons.YesNo,
            //                                  MessageBoxIcon.Question);

            //    if (confirm == DialogResult.Yes)
            //    {
            //        statusRepository.ArchiveStatus(statusId);
            //        MessageBox.Show("Status archived successfully!", "Archived",
            //                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        LoadCustomerStatuses(); // refresh grid
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select a status to archive.", "Archive Status",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

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
                if (status.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomerStatuses(); // refresh grid after adding
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
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

        private void archive_Click(object sender, EventArgs e)
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
    }
}
