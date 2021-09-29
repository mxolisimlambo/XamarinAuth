using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.TripIncident
{
    public class IndexViewModel : Base.IndexViewModel
    {
        public Guid TripId { get; set; }
        public Guid NextAddressId { get; set; }
        public Guid IncidentId { get; set; }


        public virtual Trip.IndexViewModel Trip { get; set; }
        public virtual Incident.IndexViewModel Incident { get; set; }
        public virtual Address.IndexViewModel NextAddress { get; set; }
    }
}
