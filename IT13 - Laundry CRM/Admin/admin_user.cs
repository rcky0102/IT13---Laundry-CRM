using IT13___Laundry_CRM.Repositories;
using IT13___Laundry_CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
        }

        private void admin_user_Load(object sender, EventArgs e)
        {
            InitializePaginationControls();
            LoadUsers();
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
                allUsers = userRepository.GetUsers();
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

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "edit";
            editColumn.HeaderText = "Action";
            editColumn.Text = "✔";
            editColumn.UseColumnTextForButtonValue = true;
            editColumn.Width = 60;
            table_users.Columns.Add(editColumn);

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "delete";
            deleteColumn.HeaderText = "Action";
            deleteColumn.Text = "🗑";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Width = 60;
            table_users.Columns.Add(deleteColumn);

            var data = users.Select(u => new
            {
                u.user_id,
                u.username,
                u.role,
                full_name = $"{u.first_name} {(string.IsNullOrEmpty(u.middle_name) ? "" : u.middle_name + " ")}{u.last_name}",
                u.address,
                u.contact,
                u.created_at
            }).ToList();

            table_users.DataSource = data;
        }

        private void table_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var userIdVal = table_users.Rows[e.RowIndex].Cells["user_id"].Value?.ToString();
            if (string.IsNullOrEmpty(userIdVal)) return;

            int userId = int.Parse(userIdVal);

            if (e.ColumnIndex == table_users.Columns["edit"].Index)
            {
                EditUser(userId);
            }
            else if (e.ColumnIndex == table_users.Columns["delete"].Index)
            {
                DeleteUser(userId);
            }
        }

        private void EditUser(int userId)
        {
            var user = userRepository.GetUser(userId);
            if (user == null) { MessageBox.Show("User not found."); return; }
            var form = new admin_create_edit_user();
            form.EditUser(user);
            if (form.ShowDialog() == DialogResult.OK) LoadUsers();
        }

        private void DeleteUser(int userId)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                userRepository.DeleteUser(userId);
                LoadUsers();
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
    }
}
