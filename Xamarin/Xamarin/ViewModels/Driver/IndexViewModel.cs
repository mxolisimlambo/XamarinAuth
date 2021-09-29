using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Driver
{
    public class IndexViewModel : Base.IndexViewModel
    {
        public string IdentityNumber { get; set; }
        public string Photo { get; set; }
        public DateTime LicenseExpiryDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
