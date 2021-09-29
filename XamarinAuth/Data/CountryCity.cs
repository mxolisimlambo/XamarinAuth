using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class CountryCity
    {
        public int CountryCityId { get; set; }
        public int Soccer_CityId { get; set; }
        public virtual Soccer_City Soccer_City { get; set; }
        public int Soccer_CountryId { get; set; }
        public virtual Soccer_Country Soccer_Country { get; set; }
    }
}
