using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.DeliveryNote
{
    public class CreateViewModel : Base.CreateViewModel
    {
        public Guid ClientId { get; set; }

        public string DNNumber { get; set; }
        public Guid TripId { get; set; }
    }
}
