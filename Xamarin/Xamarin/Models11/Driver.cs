using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class Driver : Employee
    {
        public string IdentityNumber { get; set; }
        public string Photo { get; set; }
        public DateTime LicenseExpiryDate { get; set; }
        public bool IsActive { get; set; }

        public virtual IEnumerable<Trip> Trips { get; set; }
    }
}
