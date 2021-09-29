using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Employee
{
    public class IndexViewModel : Base.IndexViewModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public virtual IEnumerable<Shift.IndexViewModel> Shifts { get; set; }
        
    }
}
