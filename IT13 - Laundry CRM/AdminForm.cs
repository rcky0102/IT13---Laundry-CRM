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
    public partial class AdminForm : SIdebarTemplate
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_laundry_attendant_Click(object sender, EventArgs e)
        {
            UserForm userform = new UserForm();
            userform.Show();

            this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
