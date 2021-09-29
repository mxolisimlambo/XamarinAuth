using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class Truck : Entity
    {
        public string RegistrationNumber { get; set; }
        public string DisplayName { get; set; }
        public Guid ModelId { get; set; }
        public DateTime LicenseDiscExpiry { get; set; }
        public DateTime? NextServiceDate { get; set; }

        public virtual IEnumerable<Trip> Trips { get; set; }
        public virtual TruckModel   Model { get; set; }
    }
}
