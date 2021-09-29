using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Driver
{
    public class CreateViewModel : Employee.CreateViewModel
    {
        public string IdentityNumber { get; set; }
        public string Photo { get; set; }
        public DateTime LicenseExpiryDate { get; set; } = DateTime.Now.AddDays(2);
        public bool IsActive { get; set; } = true;
    }
}
