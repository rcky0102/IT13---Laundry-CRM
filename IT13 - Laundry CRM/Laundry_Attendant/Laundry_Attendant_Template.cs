using IT13___Laundry_CRM.Laundry_Attendant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT13___Laundry_CRM
{
    public partial class Laundry_Attendant_Template : Form
    {
        public Laundry_Attendant_Template()
        {
            InitializeComponent();
        }

        private void button_customers_Click(object sender, EventArgs e)
        {
            Laundry_Attendant_CustomersForm customers = new Laundry_Attendant_CustomersForm();
            customers.Show();

            this.Hide();
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            laundry_attendant_status status = new laundry_attendant_status();
            status.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            laundry_attendant_messages messages = new laundry_attendant_messages();
            messages.Show();

            this.Hide();
        }
    }
}
