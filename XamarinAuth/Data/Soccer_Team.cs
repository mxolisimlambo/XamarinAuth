using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Soccer_Team
    {
        [Key]
        public int Soccer_TeamId { get; set; }
        //public virtual Soccer_Country Soccer_Country { get; set; }
        public string Team_Group { get; set; }
        public int Match_Played { get; set; }
        public int Won { get; set; }
        public int Draw { get; set; }
        public int Lost { get; set; }
        public int Goal_for { get; set; }
        public int Goal_agnst { get; set; }
        public int Goal_diff { get; set; }
        public int Points { get; set; }
        public int Group_position { get; set; }
    }
}
