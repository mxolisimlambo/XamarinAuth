using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Xamarin.Models
{
    public class Shift : Entity
    {
        public Guid EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public Guid TimeShiftId { get; set; }

        public virtual TimeShift TimeShift { get; set; }
        public virtual Employee Employee { get; set; }

    }

    public class TimeShift : Entity
    {
        public string Name { get; set; }
  
        public string StartTime { get; set; }
        public Int16 Duration { get; set; }

        public virtual IEnumerable<Shift> Shifts { get; set; }

    }
}
