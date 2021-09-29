using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Penalty_gk
    {
        [Key]
        public int Penalty_gkId { get; set; }

        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public int Match_mastId { get; set; }
        public virtual Match_mast Match_mast { get; set; }
    }
}
