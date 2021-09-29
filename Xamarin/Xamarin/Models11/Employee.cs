using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class Employee : Entity
    {
        public Guid UserAccountId { get; set; }

        public virtual AppUser UserAccount { get; set; }
        public virtual IEnumerable<Shift> Shifts { get; set; }
        
    }
}
