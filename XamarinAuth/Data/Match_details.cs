using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Match_details
    {
        [Key]
        public int Match_detailsId { get; set; }
        public string Play_stage { get; set; }
        public string Decided_by { get; set; }
        public string Win_lose { get; set; }
        public string Goal_score { get; set; }
        public string Penalty_score { get; set; }
        public int Player_mastId { get; set; }
        public virtual Player_mast Player_mast { get; set; }
        public int Soccer_TeamiD { get; set; }
        public virtual Soccer_Team Soccer_Team { get; set; }
        public int Match_mastId { get; set; }
        public virtual Match_mast Match_mast { get; set; }
    }
}
