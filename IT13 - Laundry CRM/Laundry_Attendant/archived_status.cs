using IT13___Laundry_CRM.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT13___Laundry_CRM.Laundry_Attendant
{
    public partial class archived_status : Form
    {
        private readonly StatusRepository statusRepository = new StatusRepository();

        public archived_status()
        {
            InitializeComponent();

            MakeRounded(dataGridView_archived);
            MakeRounded(button_unarchive);
            MakeRounded(txtSearch);
        }

        private void archived_status_Load(object sender, EventArgs e)
        {
            LoadArchivedStatuses();
            txtSearch.TextChanged += txtSearch_TextChanged;
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

        private void LoadArchivedStatuses()
        {
            var statuses = statusRepository.GetArchivedStatuses();

            if (statuses.Any())
            {
                var displayList = statuses.Select(s => new
                {
                    s.status_id,
                    Customer = $"{s.User.first_name} {(string.IsNullOrEmpty(s.User.middle_name) ? "" : s.User.middle_name + " ")}{s.User.last_name}",
                    s.status,
                    Date = s.created_at.ToString("g")
                }).ToList();

                dataGridView_archived.DataSource = displayList;
            }
            else
            {
                dataGridView_archived.DataSource = null;
                MessageBox.Show("No archived statuses found.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_unarchive_Click(object sender, EventArgs e)
        {
            if (dataGridView_archived.SelectedRows.Count > 0)
            {
                int statusId = (int)dataGridView_archived.SelectedRows[0].Cells["status_id"].Value;

                statusRepository.UnarchiveStatus(statusId);

                MessageBox.Show("Status successfully unarchived.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadArchivedStatuses(); // Refresh list
            }
            else
            {
                MessageBox.Show("Please select a status to unarchive.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_archived_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchArchivedStatuses(txtSearch.Text.Trim());
        }
        private void SearchArchivedStatuses(string searchText)
        {
            var statuses = statusRepository.GetArchivedStatuses();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                searchText = searchText.ToLower();

                statuses = statuses.Where(s =>
                    s.status_id.ToString().Contains(searchText) ||
                    (!string.IsNullOrEmpty(s.status) && s.status.ToLower().Contains(searchText)) ||
                    (!string.IsNullOrEmpty(s.User.first_name) && s.User.first_name.ToLower().Contains(searchText)) ||
                    (!string.IsNullOrEmpty(s.User.last_name) && s.User.last_name.ToLower().Contains(searchText)) ||
                    (!string.IsNullOrEmpty(s.User.middle_name) && s.User.middle_name.ToLower().Contains(searchText))
                ).ToList();
            }

            if (statuses.Any())
            {
                var displayList = statuses.Select(s => new
                {
                    s.status_id,
                    Customer = $"{s.User.first_name} {(string.IsNullOrEmpty(s.User.middle_name) ? "" : s.User.middle_name + " ")}{s.User.last_name}",
                    s.status,
                    Date = s.created_at.ToString("g")
                }).ToList();

                dataGridView_archived.DataSource = displayList;
            }
            else
            {
                dataGridView_archived.DataSource = null;
            }
        }


    }
}
