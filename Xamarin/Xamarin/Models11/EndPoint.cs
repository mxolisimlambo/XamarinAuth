using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class EndPoint : Entity
    {
        public Guid TripId { get; set; }
        public int Order { get; set; }
        public Guid AddressId { get; set; }
  
        public DateTime ETA { get; set; }

        public DateTime ATA { get; set; }
        public Status Status { get; set; }
        public Stage Stage { get; set; }

        public virtual Address Address { get; set; }
        public virtual Trip Trip { get; set; }

    }
}
