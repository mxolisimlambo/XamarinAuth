using System;
using System.ComponentModel.DataAnnotations;

namespace Xamarin.Models.ViewModels.EndPoint
{
    public class EditViewModel : Base.EditViewModel
    {
        public Guid TripId { get; set; }
        public int Order { get; set; }
        public Guid AddressId { get; set; }
       
        public DateTime ETA { get; set; }
        
        public DateTime ATA { get; set; }
        public Status Status { get; set; }
        public Stage Stage { get; set; }
    }
}
