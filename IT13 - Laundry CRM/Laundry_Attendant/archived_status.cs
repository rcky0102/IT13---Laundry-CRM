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
    public partial class archived_status : Form
    {
        private readonly StatusRepository statusRepository = new StatusRepository();

        public archived_status()
        {
            InitializeComponent();
        }

        private void archived_status_Load(object sender, EventArgs e)
        {
            LoadArchivedStatuses();
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
    }
}
