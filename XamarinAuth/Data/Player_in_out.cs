using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Player_in_out
    {
        [Key]
        public int Player_in_outId { get; set; }
        public DateTime time_in_out { get; set; }
        public string Play_schedule { get; set; }
        public string Play_half { get; set; }
        public virtual Match_mast Match_mast { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public int Player_mastId { get; set; }
        public virtual Player_mast Player_mast { get; set; }
    }
}
