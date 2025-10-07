using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT13___Laundry_CRM.Models
{
    public class Message
    {
        public int message_id {  get; set; }

        public int sender_id { get; set; }
        public int receiver_id { get; set; }
        public string message { get; set; } = "";

        public DateTime created_at { get; set; } = DateTime.Now;

        public User User { get; set; }
        public User Sender { get; set; }   // <-- Add this
        public User Receiver { get; set; } // <-- Add this
    }
}
