using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Xamarin.Models
{
    public class DeliveryNote : Entity
    {
        public Guid ClientId { get; set; }
       
        public string DNNumber { get; set; }
        public Guid TripId { get; set; }

        public virtual IEnumerable<DeliveryItem> DeliveryList { get; set; }
        public virtual Client Client { get; set; }
        public virtual Trip Trip { get; set; }
    }
}
