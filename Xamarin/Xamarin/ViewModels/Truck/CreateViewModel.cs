using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Truck
{
    public class CreateViewModel : Base.CreateViewModel

    {
    
        public Guid Id { get; set; }
        public Guid ModelId { get; set; }
    
        public string RegistrationNumber { get; set; }

        public string DisplayName { get; set; }

        public DateTime LicenseDiscExpiry { get; set; }

        public DateTime? NextServiceDate { get; set; }
    }
}
