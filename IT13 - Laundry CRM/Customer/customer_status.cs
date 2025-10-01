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

namespace IT13___Laundry_CRM.Customer
{
    public partial class customer_status : customer_template
    {

        private readonly StatusRepository statusRepository = new StatusRepository();

        public customer_status()
        {
            InitializeComponent();
        }

        internal void LoadCustomerStatuses()
        {
            throw new NotImplementedException();
        }

        private void customer_status_Load(object sender, EventArgs e)
        {
            LoadMyStatuses();
        }

        private void LoadMyStatuses()
        {
            int currentUserId = User.CurrentUser.UserId;

            if (currentUserId == 0)
            {
                MessageBox.Show("No user logged in.");
                return;
            }

            flowlayoutpanel_status.Controls.Clear();

            // 1️⃣ Get status history
            var history = statusRepository.GetStatusHistoryByUserId(currentUserId);

            // 2️⃣ Get current status
            var currentStatuses = statusRepository.GetStatusesByUserId(currentUserId);

            // 3️⃣ Merge them
            var allStatuses = new List<(DateTime created_at, string status)>();

            allStatuses.AddRange(history.Select(h => (h.created_at, h.status)));
            allStatuses.AddRange(currentStatuses.Select(s => (s.created_at, s.status)));

            // Sort by timestamp ascending (oldest first)
            allStatuses = allStatuses.OrderBy(a => a.created_at).ToList();

            // 4️⃣ Display
            foreach (var s in allStatuses)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Text = $"{s.created_at:g} → {s.status}";
                flowlayoutpanel_status.Controls.Add(lbl);
            }
        }


    }
}
