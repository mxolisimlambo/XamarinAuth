using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Referee_Soccer_Country_mast
    {
        public int Referee_Soccer_Country_mastId { get; set; }
        public int Referee_mastId { get; set; }
        public virtual Referee_mast Referee_mast { get; set; }
        public int Soccer_CountryId { get; set; }
        public virtual Soccer_Country Soccer_Country { get; set; }
        public bool IsActive { get; set; }
    }
}
