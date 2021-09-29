using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class Incident : Entity
    {
        public Int16 Severity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual IEnumerable<TripIncident> TripIncidents { get; set; }
        public virtual IEnumerable<IncidentOutcome> IncidentOutcomes { get; set; }
    }

    public class TripIncident : Entity
    {
        public Guid TripId { get; set; }
        public Guid NextAddressId { get; set; }
        public Guid IncidentId { get; set; }


        public virtual Trip Trip { get; set; }
        public virtual Incident Incident { get; set; }
        public virtual Address NextAddress { get; set; }
    }

}
