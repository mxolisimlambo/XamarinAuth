using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Trip
{
    public class CreateViewModel : Base.CreateViewModel
    {
        public DateTime PlanDate { get; set; }
        public DateTime PlanEndDate { get; set; }
        public Guid DriverId { get; set; }
        public Guid TruckId { get; set; }
        public Address.CreateViewModel StartAddress { get; set; }
        public Address.CreateViewModel EndAddress { get; set; }
        public Status Status { get; set; } = Status.Pending;
    }
}
