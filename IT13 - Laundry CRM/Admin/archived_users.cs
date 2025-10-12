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

namespace IT13___Laundry_CRM.Admin
{
    public partial class archived_users : Form
    {
        private readonly UserRepository userRepository = new UserRepository();

        public archived_users()
        {
            InitializeComponent();
        }

        private void archived_users_Load(object sender, EventArgs e)
        {
            LoadArchivedUsers();
        }

        private void LoadArchivedUsers()
        {
            var archivedUsers = userRepository.GetArchivedUsers();

            if (archivedUsers.Any())
            {
                var displayList = archivedUsers.Select(u => new
                {
                    u.user_id,
                    Username = u.username,
                    Role = u.role,
                    FullName = $"{u.first_name} {(string.IsNullOrEmpty(u.middle_name) ? "" : u.middle_name + " ")}{u.last_name}",
                    u.address,
                    u.contact,
                    CreatedAt = u.created_at.ToString("g")
                }).ToList();

                dataGridView_archived.DataSource = displayList;
            }
            else
            {
                dataGridView_archived.DataSource = null;
                MessageBox.Show("No archived users found.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_unarchive_Click(object sender, EventArgs e)
        {
            if (dataGridView_archived.SelectedRows.Count > 0)
            {
                int userId = (int)dataGridView_archived.SelectedRows[0].Cells["user_id"].Value;

                userRepository.UnarchiveUser(userId);

                MessageBox.Show("User successfully unarchived.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadArchivedUsers(); // refresh the archive table
                                     // 🔽 Add this line so the main table also updates
                Owner?.GetType().GetMethod("LoadUsers")?.Invoke(Owner, null);
            }
            else
            {
                MessageBox.Show("Please select a user to unarchive.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_archived_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional future use (for button columns, etc.)
        }
    
    }
}
