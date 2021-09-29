using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Team
    {[Key]
        public int TeamId { get; set; }
        //public virtual Soccer_Country Soccer_Country { get; set; }
        public string Name { get; set; }
        public int Address { get; set; }
       

    }
}
