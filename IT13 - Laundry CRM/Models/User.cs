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

        public bool is_archived { get; set; } = false;
        public DateTime created_at { get; set; } = DateTime.Now;


        public List<Status> Statuses { get; set; }
        public List<Message> Messages { get; set; }

        public List<Feedback> Feedbacks { get; set; }

        public static class CurrentUser
        {
            public static User User { get; set; }

            public static int UserId => User != null ? User.user_id : 0;
            public static string FullName => User != null
                ? $"{User.first_name} {(string.IsNullOrEmpty(User.middle_name) ? "" : User.middle_name + " ")}{User.last_name}"
                : "";
            public static string Role => User?.role ?? "";
        }

        public class UserComboItem
        {
            public int user_id { get; set; }
            public string FullName { get; set; }
        }

    }
}
