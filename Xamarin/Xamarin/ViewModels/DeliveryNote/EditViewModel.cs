using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Xamarin.Models.ViewModels.DeliveryNote
{
    public class EditViewModel : Base.EditViewModel
    {
        public Guid ClientId { get; set; }

        public string DNNumber { get; set; }
        public Guid TripId { get; set; }
    }
}
