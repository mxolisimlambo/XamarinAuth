using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Soccer_Country
    {
        [Key]
        public int Soccer_CountryId { get; set; }
        public int Country_Abbr { get; set; }
        public int Country_Name { get; set; }
        //public IEnumerable<Goal_detail> Goal_details { get; set; }

    }
}
