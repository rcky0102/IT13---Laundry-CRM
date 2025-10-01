using IT13___Laundry_CRM.Repositories;
using IT13___Laundry_CRM.Models;
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
    public partial class create_edit_status : Form
    {
        private readonly UserRepository userRepository = new UserRepository();
        private readonly StatusRepository statusRepository = new StatusRepository();

        private int? statusId = null;

        public create_edit_status()
        {
            InitializeComponent();
        }

        public create_edit_status(int statusId, int userId, string status) : this()
        {
            this.statusId = statusId;
            combobox_customer.SelectedValue = userId; // will be set after customers load
            combobox_status.SelectedItem = status;   // will be set after statuses load
        }

        private void create_edit_status_Load(object sender, EventArgs e)
        {
            LoadCustomersToComboBox();
            LoadStatusesToComboBox();

            if (statusId != null)
            {
                // Editing mode → lock customer selection
                combobox_customer.SelectedValue = statusRepository.GetUserIdByStatusId(statusId.Value);
                combobox_status.SelectedItem = statusRepository.GetStatusTextById(statusId.Value);

                combobox_customer.Enabled = false; // 🚀 disable customer selection when editing
            }
            else
            {
                combobox_customer.Enabled = true;  // allow choosing a customer only when adding
            }
        }

        private void LoadCustomersToComboBox()
        {
            try
            {
                // Get all users
                var users = userRepository.GetUsers();

                // Filter customers only
                var customers = users
                    .Where(u => u.role == "customer")
                    .Select(u => new
                    {
                        u.user_id,
                        FullName = $"{u.first_name} {(string.IsNullOrEmpty(u.middle_name) ? "" : u.middle_name + " ")}{u.last_name}"
                    })
                    .ToList();

                // Bind to combobox
                combobox_customer.DataSource = customers;
                combobox_customer.DisplayMember = "FullName"; // what shows in the dropdown
                combobox_customer.ValueMember = "user_id";    // actual value behind each item
                combobox_customer.SelectedIndex = -1;         // no pre-selection
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStatusesToComboBox()
        {
            var statuses = new List<string>
            {
                "Pending",
                "Washing",
                "Drying",
                "Ironing/Folding",
                "Ready for Pickup",
                "Completed/Picked Up",
                "Cancelled",
                "On Hold"
            };

            combobox_status.DataSource = statuses;
            combobox_status.SelectedIndex = -1; // no default selection
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (combobox_customer.SelectedValue == null || combobox_status.SelectedItem == null)
                {
                    MessageBox.Show("Please select both a customer and a status.", "Validation Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (statusId == null)
                {
                    // ADD
                    Status newStatus = new Status
                    {
                        user_id = (int)combobox_customer.SelectedValue,
                        status = combobox_status.SelectedItem.ToString(),
                        created_at = DateTime.Now
                    };

                    statusRepository.AddStatus(newStatus);
                    MessageBox.Show("Status added successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // UPDATE with history tracking
                    Status updatedStatus = new Status
                    {
                        status_id = statusId.Value,
                        user_id = statusRepository.GetUserIdByStatusId(statusId.Value),
                        status = combobox_status.SelectedItem.ToString(),
                        created_at = DateTime.Now
                    };

                    // Use the new method to automatically save previous status to history
                    statusRepository.UpdateStatusWithHistory(updatedStatus);

                    MessageBox.Show("Status updated successfully and previous status saved to history!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving status: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
