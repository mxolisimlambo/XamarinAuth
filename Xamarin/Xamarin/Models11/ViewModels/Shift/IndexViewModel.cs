using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Shift
{
    public class IndexViewModel: Base.IndexViewModel
    {
        public Guid EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public Guid TimeShiftId { get; set; }
        public virtual TimeShift.IndexViewModel TimeShift { get; set; }
    }
}
