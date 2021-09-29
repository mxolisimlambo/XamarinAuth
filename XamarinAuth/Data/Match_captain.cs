using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Match_captain
    {
        [Key]
        public int Match_captainId { get; set; }
        public int Match_mastId { get; set; }
        public virtual Match_mast Match_mast { get; set; }
        public int Player_mastId { get; set; }
        public virtual Player_mast Player_mast { get; set; }
    }
}
