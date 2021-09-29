using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Penalty_shootout
    {
        [Key]
        public int Penalty_shootoutId { get; set; }
      
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
