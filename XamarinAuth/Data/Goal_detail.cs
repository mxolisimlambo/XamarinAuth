using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Goal_detail
    {
        [Key]
        public int Goal_detailsId { get; set; }
        public string Goal_time { get; set; }
      
        public string Play_stage { get; set; }
      
        public string Goal_schedule { get; set; }
        public string Goal_half { get; set; }
        
        public int Match_mastId { get; set; }
        public virtual Match_mast Match_mast { get; set; }
        public int Player_mastId { get; set; }
        public virtual Player_mast Player_mast { get; set; }
        public int Soccer_CountryId { get; set; }
        public virtual Soccer_Country Soccer_Country { get; set; }
    }
}
