using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models.ViewModels.Shift
{
    public class EditViewModel : Base.EditViewModel
    {
        public Guid EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public Guid TimeShiftId { get; set; }
    }
}
