using System;
using System.Collections.Generic;

namespace Xamarin.Models
{
    public class Trip : Entity
    {
        public DateTime PlanDate { get; set; }
        public DateTime PlanEndDate { get; set; }
        public Guid DriverId { get; set; }
        public Guid TruckId { get; set; }
        public Guid StartAddressId { get; set; }
        public Guid EndAddressId { get; set; }
        public Status Status { get; set; }

        public virtual Address StartAddress { get; set; }
        public virtual Address EndAddress { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual Truck Truck { get; set; }
        public virtual IEnumerable<TripIncident> Incidents { get; set; }
        public virtual IEnumerable<EndPoint> TripPlans { get; set; }
        public virtual IEnumerable<DeliveryNote> DeliveryNotes { get; set; }
    }
}