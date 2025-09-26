using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT13___Laundry_CRM.Models
{
    public class User
    {
        public int user_id { get; set; }
        public string username { get; set; } = "";
        public string password { get; set; } = "";
        public string role { get; set; } = "";

        public string first_name { get; set; } = "";

        public string middle_name { get; set; } = "";

        public string last_name { get; set; } = "";

        public string address { get; set; } = "";

        public string contact { get; set; } = "";
        public DateTime created_at { get; set; } = DateTime.Now;


        public List<Status> Statuses { get; set; }
    }
}
