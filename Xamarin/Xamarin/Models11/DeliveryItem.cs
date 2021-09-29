using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Xamarin.Models
{
    public class DeliveryItem : Entity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public Guid PickupAddressId { get; set; }
        public Guid DeliveryAddressId { get; set; }
        public Guid DeliveryNoteId { get; set; }
        public Status Status { get; set; }


        public virtual DeliveryNote DeliveryNote { get; set; }
        public virtual Address PickupAddress { get; set; }
        public virtual Address DeliveryAddress { get; set; }
        public virtual IEnumerable<DeliveryItemScan> DeliveryItemScans { get; set; }
    }
}