using System;
using System.ComponentModel.DataAnnotations;
using Xamarin.Models;

namespace Xamarin.ViewModels.DeliveryItem
{
    public class IndexViewModel : Base.IndexViewModel
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid PickupAddressId { get; set; }
        public Guid DeliveryAddressId { get; set; }
        public Guid DeliveryNoteId { get; set; }
        public Status Status { get; set; }

        public virtual DeliveryNote.IndexViewModel DeliveryNote { get; set; }
        public virtual Address.IndexViewModel PickupAddress { get; set; }
        public virtual Address.IndexViewModel DeliveryAddress { get; set; }
    }
}
