using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Truck
{
    public class IndexViewModel : Base.IndexViewModel
    {
        public string RegistrationNumber { get; set; }
        public string DisplayName { get; set; }
        public DateTime LicenseDiscExpiry { get; set; }
        public DateTime? NextServiceDate { get; set; }
        public virtual IEnumerable<Trip.IndexViewModel> Trips { get; set; }

    }
}
