using Xamarin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Xamarin.Models
{
    public class Address : Entity
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string ZipCode { get; set; }
        public Guid CityId { get; set; }
        
       
        public virtual IEnumerable<DeliveryItem> Pickups { get; set; }
   
        public virtual IEnumerable<DeliveryItem> Deliveries { get; set; }
  
        public virtual IEnumerable<Trip> TripsStart { get; set; }
  
        public virtual IEnumerable<Trip> TripsEnd { get; set; }

        public virtual IEnumerable<TripIncident> TripIncidents { get; set; }
        public virtual IEnumerable<EndPoint> TripPlans { get; set; }
        public virtual CityTown City { get; set; }
    }

    public class CityTown : Entity
    {
        public string Name { get; set; }
        public Guid RegionId { get; set; }

        public virtual Region Region { get; set; }
        public virtual IEnumerable<Address> Addresses { get; set; }
    }

    public class Region : Entity
    {
        public string Name { get; set; }
        public virtual IEnumerable<CityTown> Cities { get; set; }

    }
}