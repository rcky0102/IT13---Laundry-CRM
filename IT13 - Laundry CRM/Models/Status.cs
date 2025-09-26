using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT13___Laundry_CRM.Models
{
    public class Status
    {
        public int status_id {  get; set; }
        public int user_id { get; set; }
        public string status { get; set; } = "";
        public DateTime created_at { get; set; } = DateTime.Now;

        public User User { get; set; }


    }
}
