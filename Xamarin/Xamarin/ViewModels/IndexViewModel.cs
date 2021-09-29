using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Base;

namespace Xamarin.ViewModels
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
