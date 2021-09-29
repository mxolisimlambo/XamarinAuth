using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Referee_mast
    {
        [Key]
        public int Referee_mastId { get; set; }
        public IEnumerable<Referee_Soccer_Country_mast> Referee_Soccer_Country_masts { get; set; }
        public IEnumerable<Match_mast> Match_masts { get; set; }

    }
}
