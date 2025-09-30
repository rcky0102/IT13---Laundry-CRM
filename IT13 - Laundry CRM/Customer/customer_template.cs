using IT13___Laundry_CRM.Customer;
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
    public partial class customer_template : Form
    {
        public customer_template()
        {
            InitializeComponent();
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            customer_status status = new customer_status();
            status.Show();

            this.Hide();
        }

        private void button_message_Click(object sender, EventArgs e)
        {
            customer_messages message = new customer_messages();
            message.Show();

            this.Hide();
        }

        private void button_feedback_Click(object sender, EventArgs e)
        {
            customer_feedback feedback = new customer_feedback();   
            feedback.Show();

            this.Hide();
        }
    }
}
