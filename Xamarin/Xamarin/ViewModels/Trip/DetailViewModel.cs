using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Trip
{
    public class DetailViewModel : IndexViewModel
    {
        public virtual IEnumerable<TripIncident.IndexViewModel> TripIncidents { get; set; }
        public virtual IEnumerable<Incident.IndexViewModel> Incidents { get { return from x in TripIncidents select x.Incident; } }
        public virtual IEnumerable<EndPoint.IndexViewModel> TripPlan { get; set; }
        public virtual IEnumerable<DeliveryNote.IndexViewModel> DeliveryNotes { get; set; }
    }
}
