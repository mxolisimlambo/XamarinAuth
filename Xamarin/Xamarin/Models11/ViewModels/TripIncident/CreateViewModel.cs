using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.TripIncident
{
    public class CreateViewModel : Base.CreateViewModel
    {
        public Guid TripId { get; set; }
        public Guid NextAddressId { get; set; }
        public Guid IncidentId { get; set; }
    }
}
