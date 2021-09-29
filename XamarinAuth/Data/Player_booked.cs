using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Player_booked
    {
        [Key]
        public int Player_bookedId { get; set; }
        public DateTime Booking_time { get; set; }
        public string Sent_off { get; set; }
        public string Play_schedule { get; set; }
        public string Play_half { get; set; }
 
        public string Score_goal { get; set; }
        public int Kick_no { get; set; }
          public int Match_mastId { get; set; }
        public virtual Match_mast Match_mast { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public int Player_mastId { get; set; }
        public virtual Player_mast Player_mast { get; set; }
    }
}
