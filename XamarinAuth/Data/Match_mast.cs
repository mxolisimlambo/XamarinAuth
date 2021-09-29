using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Match_mast
    {
        [Key]
        public int Match_mastId { get; set; }
        public string Play_stage { get; set; }
        public DateTime Play_date { get; set; }
        public int Results { get; set; }
        public string Decided_by { get; set; }
        public string Goal_score { get; set; }
        public int Audence { get; set; }
       
        public int Stop1_sec { get; set; }
        public int Stop2_sec { get; set; }
        public int Soccer_VenueId { get; set; }
        public virtual Soccer_Venue Soccer_Venue { get; set; }
        public int Referee_mastId { get; set; }
        public virtual Referee_mast Referee_mast { get; set; }
        //public int Player_mastId { get; set; }
        //public virtual Player_mast Player_mast { get; set; }
        public IEnumerable<Goal_detail> Goal_details { get; set; }



    }
}
