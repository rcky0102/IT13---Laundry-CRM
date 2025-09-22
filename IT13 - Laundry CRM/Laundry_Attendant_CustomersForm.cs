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

namespace IT13___Laundry_CRM
{
    public partial class Laundry_Attendant_CustomersForm : Laundry_Attendant_Template
    {
        private readonly UserRepository userepo = new UserRepository();

        public Laundry_Attendant_CustomersForm()
        {
            InitializeComponent();
        }

        private void ReadUsers()
        {

        }

        private void Laundry_Attendant_CustomersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
