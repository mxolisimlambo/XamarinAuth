using System;
using System.ComponentModel.DataAnnotations;

namespace Xamarin.Models.ViewModels.EndPoint
{
    public class IndexViewModel : Base.IndexViewModel
    {
        public Guid TripId { get; set; }
        public int Order { get; set; }
        public Guid AddressId { get; set; }
       
        public DateTime ETA { get; set; }
    
        public DateTime ATA { get; set; }
        public Status Status { get; set; }
        public Stage Stage { get; set; }

        public virtual Address.IndexViewModel Address { get; set; }
        public virtual Trip.IndexViewModel Trip { get; set; }
    }
}
