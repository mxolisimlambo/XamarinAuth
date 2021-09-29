using System;
using System.ComponentModel.DataAnnotations;

namespace Xamarin.Models.ViewModels.DeliveryItem
{
    public class CreateViewModel : Base.CreateViewModel
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public Guid PickupAddressId { get; set; }
        public Guid DeliveryAddressId { get; set; }
        public Guid DeliveryNoteId { get; set; }
        public Status Status { get; set; }
    }
}
