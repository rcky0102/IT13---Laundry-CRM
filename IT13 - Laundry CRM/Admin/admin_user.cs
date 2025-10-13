using IT13___Laundry_CRM.Models;
using IT13___Laundry_CRM.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static IT13___Laundry_CRM.Models.User;

namespace IT13___Laundry_CRM.Admin
{
    public partial class admin_user : SIdebarTemplate
    {
        private readonly UserRepository userRepository = new UserRepository();
        private List<User> allUsers = new List<User>();
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalRecords = 0;

        public admin_user()
        {
            InitializeComponent();

            MakeRounded(button_add);
            MakeRounded(panel2);
            MakeRounded(textBox_search);
            MakeRounded(button_archives);
            MakeRounded(cmbRoleFilter);
            MakeRounded(table_users);
            MakeRounded(btnFirst);
            MakeRounded(btnPrevious);
            MakeRounded(cmbPageSize);
            MakeRounded(btnNext);
            MakeRounded(btnLast);
            MakeRounded(panelPagination);

        }

        private void admin_user_Load(object sender, EventArgs e)
        {
            InitializePaginationControls();
            LoadUsers();
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

        private void InitializePaginationControls()
        {
            btnFirst.Click += (s, e) => GoToPage(1);
            btnPrevious.Click += (s, e) => GoToPage(currentPage - 1);
            btnNext.Click += (s, e) => GoToPage(currentPage + 1);
            btnLast.Click += (s, e) => GoToPage(GetTotalPages());
            cmbPageSize.SelectedIndexChanged += (s, e) => ChangePageSize();
            cmbPageSize.SelectedItem = pageSize.ToString();
        }

        private void LoadUsers()
        {
            try
            {
                // Assume you have the currently logged-in user's ID stored globally or in a session-like variable
                int currentUserId = CurrentUser.UserId; // or whatever your variable/property is

                allUsers = userRepository.GetUsers()
                                         .Where(u => !u.is_archived && u.user_id != currentUserId) // ✅ Exclude current admin
                                         .ToList();

                totalRecords = allUsers.Count;
                ApplyFiltersAndPagination();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ApplyFiltersAndPagination()
        {
            string searchQuery = textBox_search.Text.Trim().ToLower();
            string selectedRole = cmbRoleFilter.SelectedItem?.ToString();

            var filteredUsers = allUsers;

            // Search filter
            if (!string.IsNullOrEmpty(searchQuery))
            {
                filteredUsers = filteredUsers.Where(u =>
                    u.user_id.ToString().Contains(searchQuery) ||
                    (!string.IsNullOrEmpty(u.first_name) &&
                     $"{u.first_name} {(string.IsNullOrEmpty(u.middle_name) ? "" : u.middle_name + " ")}{u.last_name}".ToLower().Contains(searchQuery)) ||
                    (!string.IsNullOrEmpty(u.username) && u.username.ToLower().Contains(searchQuery)) ||
                    (!string.IsNullOrEmpty(u.address) && u.address.ToLower().Contains(searchQuery))
                ).ToList();
            }

            // Role filter
            if (!string.IsNullOrEmpty(selectedRole) && selectedRole != "All")
            {
                filteredUsers = filteredUsers.Where(u => u.role.Equals(selectedRole, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            totalRecords = filteredUsers.Count;
            int totalPages = GetTotalPages();

            if (currentPage > totalPages && totalPages > 0)
                currentPage = totalPages;
            else if (currentPage < 1)
                currentPage = 1;

            var pagedUsers = filteredUsers
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            BindDataToGrid(pagedUsers);
            UpdatePaginationInfo();
        }

        private void BindDataToGrid(List<User> users)
        {
            table_users.AutoGenerateColumns = false;
            table_users.Columns.Clear();

            // Data columns
            table_users.Columns.Add("user_id", "ID");
            table_users.Columns["user_id"].DataPropertyName = "user_id";

            table_users.Columns.Add("username", "Username");
            table_users.Columns["username"].DataPropertyName = "username";

            table_users.Columns.Add("role", "Role");
            table_users.Columns["role"].DataPropertyName = "role";

            table_users.Columns.Add("full_name", "Full Name");
            table_users.Columns["full_name"].DataPropertyName = "full_name";

            table_users.Columns.Add("address", "Address");
            table_users.Columns["address"].DataPropertyName = "address";

            table_users.Columns.Add("contact", "Contact");
            table_users.Columns["contact"].DataPropertyName = "contact";

            table_users.Columns.Add("created_at", "Created At");
            table_users.Columns["created_at"].DataPropertyName = "created_at";

            // 🟩 Actions column (combined)
            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            {
                Name = "actions",
                HeaderText = "Actions",
                Text = "", // Text handled in CellPainting
                UseColumnTextForButtonValue = false,
                Width = 80,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            };
            table_users.Columns.Add(actionColumn);

            // Bind data
            table_users.DataSource = users.Select(u => new
            {
                u.user_id,
                u.username,
                u.role,
                full_name = $"{u.first_name} {(string.IsNullOrEmpty(u.middle_name) ? "" : u.middle_name + " ")}{u.last_name}",
                u.address,
                u.contact,
                u.created_at
            }).ToList();

            // Event handlers
            table_users.CellPainting -= table_users_CellPainting;
            table_users.CellPainting += table_users_CellPainting;

            table_users.CellClick -= table_users_CellClick;
            table_users.CellClick += table_users_CellClick;
        }


        private void table_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || table_users.Columns[e.ColumnIndex].Name != "actions") return;

            var cell = table_users[e.ColumnIndex, e.RowIndex];
            var userId = Convert.ToInt32(table_users.Rows[e.RowIndex].Cells["user_id"].Value);

            var clickPos = table_users.PointToClient(Cursor.Position);
            var cellRect = table_users.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            int relativeX = clickPos.X - cellRect.Left;

            // Adjust thresholds to match CellPainting
            int buttonSize = 20;
            int spacing = 10;
            if (relativeX < buttonSize) EditUser(userId); // Clicked Edit
            else if (relativeX < buttonSize * 2 + spacing) ArchiveUser(userId); // Clicked Archive
        }




        private void EditUser(int userId)
        {
            var user = userRepository.GetUser(userId);
            if (user == null) { MessageBox.Show("User not found."); return; }
            var form = new admin_create_edit_user();
            form.EditUser(user);
            if (form.ShowDialog() == DialogResult.OK) LoadUsers();
        }

        private void ArchiveUser(int userId)
        {
            var confirm = MessageBox.Show(
                "Are you sure you want to archive this user?",
                "Confirm Archive",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                userRepository.ArchiveUser(userId);

                MessageBox.Show("User successfully archived.", "Archived",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadUsers(); // Refresh the active user list
            }
        }


        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            ApplyFiltersAndPagination();
        }

        private void cmbRoleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            ApplyFiltersAndPagination();
        }

        #region Pagination Methods
        private void GoToPage(int page)
        {
            int totalPages = GetTotalPages();
            if (page < 1 || page > totalPages) return;
            currentPage = page;
            ApplyFiltersAndPagination();
        }

        private void ChangePageSize()
        {
            if (cmbPageSize.SelectedItem != null && int.TryParse(cmbPageSize.SelectedItem.ToString(), out int newSize))
            {
                pageSize = newSize;
                currentPage = 1;
                ApplyFiltersAndPagination();
            }
        }

        private int GetTotalPages()
        {
            return totalRecords == 0 ? 1 : (int)Math.Ceiling((double)totalRecords / pageSize);
        }

        private void UpdatePaginationInfo()
        {
            int totalPages = GetTotalPages();
            lblPageInfo.Text = $"Page {currentPage} of {totalPages}";
            lblTotalRecords.Text = $"Total Records: {totalRecords}";
            btnFirst.Enabled = currentPage > 1;
            btnPrevious.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
            btnLast.Enabled = currentPage < totalPages;
        }
        #endregion

        private void button_add_Click(object sender, EventArgs e)
        {
            var form = new admin_create_edit_user();
            if (form.ShowDialog() == DialogResult.OK) LoadUsers();
        }

        private void table_users_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == table_users.Columns["actions"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);

                int buttonSize = 20;
                int spacing = 10;
                int xStart = e.CellBounds.Left + 8; // left padding
                int yCenter = e.CellBounds.Top + (e.CellBounds.Height - buttonSize) / 2;

                // Rectangles for hit detection
                Rectangle editRect = new Rectangle(xStart, yCenter, buttonSize, buttonSize);
                Rectangle archiveRect = new Rectangle(xStart + buttonSize + spacing, yCenter, buttonSize, buttonSize);

                // Draw Edit (✔)
                TextRenderer.DrawText(e.Graphics, "✏️", e.CellStyle.Font, editRect, Color.Green,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                // Draw Archive (🗄)
                TextRenderer.DrawText(e.Graphics, "📦", e.CellStyle.Font, archiveRect, Color.IndianRed,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true;
            }
        }

        private void button_archives_Click(object sender, EventArgs e)
        {
            archived_users archive = new archived_users();
            archive.FormClosed += (s, args) =>
            {
                // When the archive window is closed, refresh the main users table
                LoadUsers();
            };
            archive.ShowDialog();
        }
    }
}
