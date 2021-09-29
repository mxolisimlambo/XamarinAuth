using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Soccer_City
    {
        [Key]
        public int Soccer_CityId { get; set; }
        public string City { get; set; }
        public int Soccer_CountryId { get; set; }
        public virtual Soccer_Country Soccer_Country { get; set; }
        public IEnumerable<Soccer_Venue> Soccer_Venues { get; set; }

    }
}
