using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Incident
{
    public class DetailViewModel : IndexViewModel
    {
        public virtual IEnumerable<Trip.IndexViewModel> Trips { get { return from t in TripIncidents select t.Trip; } }
        public virtual IEnumerable<TripIncident.IndexViewModel> TripIncidents { get; set; }
        public virtual IEnumerable<IncidentOutcome.IndexViewModel> IncidentOutcomes { get; set; }
    }
}
