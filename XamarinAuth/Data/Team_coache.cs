using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Team_coache
    {
        [Key]
        public int Team_coachesId { get; set; }
        public int Coach_mastId { get; set; }
        public virtual Coach_mast Coach_mast { get; set; }
        public int Soccer_TeamId { get; set; }
        public virtual Soccer_Team Soccer_Team { get; set; }
       
    }
}
