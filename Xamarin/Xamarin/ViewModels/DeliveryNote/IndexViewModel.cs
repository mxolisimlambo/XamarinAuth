using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.DeliveryNote
{
    public class IndexViewModel : Base.IndexViewModel
    {
        public Guid ClientId { get; set; }
  
        public string DNNumber { get; set; }
        public Guid TripId { get; set; }

        public virtual Client.IndexViewModel Client { get; set; }
        public virtual Trip.IndexViewModel Trip { get; set; }
    }
}
