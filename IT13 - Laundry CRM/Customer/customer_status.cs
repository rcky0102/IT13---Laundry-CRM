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

            var statuses = statusRepository.GetStatusesByUserId(currentUserId);

            flowlayoutpanel_status.Controls.Clear();
            foreach (var s in statuses)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Text = $"{s.created_at:g} → {s.status}";
                flowlayoutpanel_status.Controls.Add(lbl);
            }
        }

    }
}
