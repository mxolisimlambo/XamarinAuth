using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Trip
{
    public class EditViewModel : Base.EditViewModel
    {
        public DateTime PlanDate { get; set; }
        public DateTime PlanEndDate { get; set; }
        public Guid DriverId { get; set; }
        public Guid TruckId { get; set; }
        public Guid StartAddressId { get; set; }
        public Guid EndAddressId { get; set; }
        public Status Status { get; set; }

        public Address.EditViewModel StartAddress { get; set; }
        public Address.EditViewModel EndAddress { get; set; }
    }
}
