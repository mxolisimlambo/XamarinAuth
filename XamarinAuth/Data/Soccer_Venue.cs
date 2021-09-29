using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinAuth.Data
{
    public class Soccer_Venue
    {
        [Key]
        public int Soccer_VenueId { get; set; }
        public string Venue_Name { get; set; }       
        public int Aud_Capicity { get; set; }
        
    }
}
